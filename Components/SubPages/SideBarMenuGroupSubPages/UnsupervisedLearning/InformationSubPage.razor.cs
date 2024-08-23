using Microsoft.AspNetCore.Components;
using MachineLearningApplication_Build_2.wwwroot.TextContent;

namespace MachineLearningApplication_Build_2.Components.SubPages.SideBarMenuGroupSubPages.UnsupervisedLearning
{
    public partial class InformationSubPage
    {
        [Parameter] public string? PageTitle { get; set; }

        public InfomartionPageTextContent TextContent { get; set; }

        public InformationSubPage() {
            
        
        }
    }
}

