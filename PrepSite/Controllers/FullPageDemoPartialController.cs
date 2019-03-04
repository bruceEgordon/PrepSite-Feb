using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using PrepSite.Models.Pages;
using PrepSite.Models.ViewModels;

namespace PrepSite.Controllers
{
    public class FullRefreshDemoPartialController : PartialContentController<FullRefreshDemo>
    {
        public override ActionResult Index(FullRefreshDemo currentPage)
        {
            return PartialView(PageViewModel.Create(currentPage));
        }
    }

}