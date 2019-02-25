using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using PrepSite.Models.ViewModels;

namespace PrepSite.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : PageData
    {
        protected readonly IContentLoader loader;
        public PageControllerBase(IContentLoader loader)
        {
            this.loader = loader;
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(TPage currentPage) where TPage : PageData
        {
            var viewmodel = PageViewModel.Create(currentPage);
            viewmodel.MenuPages = FilterForVisitor.Filter(
              loader.GetChildren<PageData>(ContentReference.StartPage))
              .Cast<PageData>().Where(page => page.VisibleInMenu);
            return viewmodel;
        }

    }

}