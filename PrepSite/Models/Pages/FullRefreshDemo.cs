using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PrepSite.Models.Pages
{
    [ContentType(DisplayName = "FullRefreshDemo", GUID = "acfcd597-8cfa-4c91-8b50-7254750ec1ca",
        Description = "Testing full refresh")]
    [ImageUrl("~/Static/contenticons/epi-edu-icon-page.jpg")]
    public class FullRefreshDemo : PageData
    {
        [CultureSpecific]
        [Display(
        Name = "Main body",
        Description = "The main body will be shown in the main " +
        "content area of the page, using the XHTML-editor you can " +
        "insert for example text, images and tables.",
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(Name = "Show Banner",
            Description = "Use to set display of banner property.",
            GroupName = SystemTabNames.Content, Order = 20)]
        public virtual bool ShowBanner { get; set; }

        [Display(Name = "Banner Text",
            Description = "Text to show in banner.",
            GroupName = SystemTabNames.Content, Order = 30)]
        public virtual string BannerText { get; set; }

    }
}