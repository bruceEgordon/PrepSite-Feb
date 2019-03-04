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
    [TemplateDescriptor(Inherited = true,
    Tags = new[] { SiteTags.Full }, AvailableWithoutTag = true)]
    public class StandardPagesFullPartialController : PartialContentController<StandardPage>
    {
        public override ActionResult Index(StandardPage currentPage)
        {
            return PartialView(viewName: SiteTags.Full,
                model: PageViewModel.Create(currentPage));
        }
    }

    [TemplateDescriptor(Inherited = true,
    Tags = new[] { SiteTags.Wide }, AvailableWithoutTag = false)]
    public class StandardPagesWidePartialController : PartialContentController<StandardPage>
    {
        public override ActionResult Index(StandardPage currentPage)
        {
            return PartialView(viewName: SiteTags.Wide,
                model: PageViewModel.Create(currentPage));
        }
    }

    [TemplateDescriptor(Inherited = true,
    Tags = new[] { SiteTags.Narrow }, AvailableWithoutTag = false)]
    public class StandardPagesNarrowPartialController : PartialContentController<StandardPage>
    {
        public override ActionResult Index(StandardPage currentPage)
        {
            return PartialView(viewName: SiteTags.Narrow,
                model: PageViewModel.Create(currentPage));
        }
    }

}