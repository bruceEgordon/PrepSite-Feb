using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrepSite.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : PageData
    {
        public T CurrentPage { get; set; }

        public IEnumerable<PageData> MenuPages { get; set; }

        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }
    }
    //This static class with its static Create<T> method is a
    //convenience for creating PageViewModel instances without
    //having to specify the type because generic methods can use
    //type inference while constructors cannot.
    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T currentPage)
            where T : PageData
        {
            return new PageViewModel<T>(currentPage);
        }
    }

}