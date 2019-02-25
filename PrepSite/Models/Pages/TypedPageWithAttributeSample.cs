using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PrepSite.Models.Pages
{
    [ContentType(DisplayName = "TypedPageWithAttributeSample", GUID = "f0073174-1547-4415-89ef-7486afd1b894", 
        Description = "Testing access permissions", GroupName = "My Group", Order = 1024)]
    [Access(Users = "Bubba", Roles = "CmsEditors")]
    [ImageUrl("~/Static/contenticons/epi-edu-icon-page.jpg")]
    public class TypedPageWithAttributeSample : PageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}