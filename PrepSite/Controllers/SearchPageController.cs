using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Search;
using EPiServer.Search.Queries.Lucene;
using EPiServer.Security;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using PrepSite.Business.ExtensionMethods;
using PrepSite.Models.Pages;
using PrepSite.Models.ViewModels;

namespace PrepSite.Controllers
{
    public class SearchPageController : PageControllerBase<SearchPage>
    {
        private SearchHandler searchHandler;

        public SearchPageController(IContentLoader loader, SearchHandler srchHandler) : base(loader)
        {
            searchHandler = srchHandler;
        }

        public ActionResult Index(SearchPage currentPage, string q)
        {
            var viewmodel = new SearchPageViewModel(currentPage);
            if (!string.IsNullOrWhiteSpace(q))
            {
                // 1. only pages
                var onlyPages = new ContentQuery<PageData>();

                // 2. free-text query
                var freeText = new FieldQuery(q);

                // 3. only what the current user can read
                var readAccess = new AccessControlListQuery();
                readAccess.AddAclForUser(PrincipalInfo.Current, HttpContext);

                // 4. only under the Start page (to exclude Wastebasket, for example)
                var underStart = new VirtualPathQuery();
                underStart.AddContentNodes(ContentReference.StartPage);

                // build the query from the expressions
                var query = new GroupQuery(LuceneOperator.AND);
                query.QueryExpressions.Add(freeText);
                query.QueryExpressions.Add(onlyPages);
                query.QueryExpressions.Add(readAccess);
                query.QueryExpressions.Add(underStart);

                // get the first page of ten results
                SearchResults results = searchHandler.GetSearchResults(query, 1, 10);

                viewmodel.SearchText = q;

                viewmodel.SearchResults = results.IndexResponseItems
                    .Select(x => new Result
                    {
                        Title = x.Title,
                        Description = x.DisplayText.TruncateAtWord(20),
                        Url = GetExternalUrl(x).ToString()
                    }).ToList();
            }

            //Not using the base controller CreateViewModel so we need to set the menu
            viewmodel.MenuPages = FilterForVisitor.Filter(
                loader.GetChildren<PageData>(ContentReference.StartPage))
                .Cast<PageData>().Where(page => page.VisibleInMenu);

            return View(viewmodel);
        }


        private Uri GetExternalUrl(IndexResponseItem item)
        {
            try
            {
                UrlBuilder url = new UrlBuilder(item.Uri);
                Global.UrlRewriteProvider.ConvertToExternal(url, item, Encoding.UTF8);
                return url.Uri;
            }
            catch
            {
                return default(Uri);
            }
        }

    }
}