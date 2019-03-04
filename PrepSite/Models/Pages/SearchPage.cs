using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PrepSite.Models.Pages
{
    [ContentType(DisplayName = "Search Page", GUID = "9d5080b6-155a-432f-8f35-380ba70e40e0",
        Description = "Used for creating a search page.", GroupName = "Specialized")]
    [ImageUrl("~/Static/contenticons/epi-edu-icon-search.jpg")]
    public class SearchPage : PageData
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