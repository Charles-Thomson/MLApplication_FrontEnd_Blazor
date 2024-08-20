using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
using Microsoft.AspNetCore.Components;

namespace MachineLearningApplication_Build_2.Components.ComponentGroups
{
    public class SideBarMenuStateClass
    {

        public string ClassId { get; set; }

        public IconButtonStateClass ButtonBuildData { get; set; }
        public string ToolTipText { get; set; }

        public RenderFragment SubPageContent { get; set; }

        public SideBarMenuStateClass(string ClassId, string ToolTipText, IconButtonStateClass ButtonBuildData, RenderFragment SubPageContent) {
            this.ClassId = ClassId;
            this.ToolTipText = ToolTipText;
            this.ButtonBuildData = ButtonBuildData; 
            this.SubPageContent = SubPageContent;
        
        }
    }
}
