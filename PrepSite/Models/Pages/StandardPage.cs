using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PrepSite.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", 
        GUID = "f3bf48bf-aa0a-4625-ac51-de25336f300e", 
        Description = "Simple standard page type.")]
    [ImageUrl("~/Static/contenticons/epi-edu-icon-page.jpg")]
    public class StandardPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}