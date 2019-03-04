using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrepSite.Models.Blocks
{
    [ContentType(DisplayName = "Editorial", GUID = "b070780d-ad17-408f-8049-b41bdf28b25e",
        Description = "Reusable rich editorial text.")]
    [ImageUrl("~/Static/contenticons/epi-edu-icon-block.jpg")]
    public class EditorialBlock : BlockData
    {

        [CultureSpecific]
        [Display(Name = "Main body", Description = "Main body with rich XHTML-editor",
            GroupName = SystemTabNames.Content, Order = 10)]
        public virtual XhtmlString MainBody { get; set; }

    }
}