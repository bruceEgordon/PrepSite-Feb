using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PrepSite.Models.Pages
{
    [ContentType(DisplayName = "StartPage", 
        GUID = "78bd1f67-8b95-46df-bc98-9fe0b918e00f", Description = "For creating a Start Page",
        GroupName = "Specialized")]
    public class StartPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Heading", Description = "If the Heading is not set, the page falls back to showing the Name.", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

    }
}