using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrepSite.Business.SelectionFactories
{
    public class WorkStatusSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new List<ISelectItem>
            {
               new SelectItem { Value = "FT", Text = "Full-time"},
               new SelectItem { Value = "PT", Text = "Part-time"},
               new SelectItem { Value = "ST", Text = "Student"},
               new SelectItem { Value = "UN", Text = "Unemployed"}
            };
        }
    }
}