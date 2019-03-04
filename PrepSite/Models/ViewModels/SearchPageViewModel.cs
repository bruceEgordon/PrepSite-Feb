using PrepSite.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrepSite.Models.ViewModels
{
    public class SearchPageViewModel : PageViewModel<SearchPage>
    {
        public SearchPageViewModel(SearchPage currentPage) : base(currentPage) { }

        public string SearchText { get; set; }
        public List<Result> SearchResults { get; set; }
    }
    public class Result
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }

}