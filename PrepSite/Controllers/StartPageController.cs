using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using PrepSite.Models.Pages;

namespace PrepSite.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        
        public StartPageController(IContentLoader contentLoader) : base(contentLoader)
        {
            
        }
        public ActionResult Index(StartPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(CreatePageViewModel(currentPage));
        }
    }
}