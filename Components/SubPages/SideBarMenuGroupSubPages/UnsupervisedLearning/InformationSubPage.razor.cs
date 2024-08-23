using Microsoft.AspNetCore.Components;
using MachineLearningApplication_Build_2.wwwroot.TextContent;
using MachineLearningApplication_Build_2.Services;

namespace MachineLearningApplication_Build_2.Components.SubPages.SideBarMenuGroupSubPages.UnsupervisedLearning
{
    public partial class InformationSubPage
    {
        [Parameter] public string? PageTitle { get; set; }

        public InformationSubPageTextContent? TextContent { get; set; }

        private JSONUnpackingService JSONUnpackingService { get; set; } = new();

        private readonly string TextContentFilePath = "wwwroot/TextContent/InformationSubPageContent.json";

        public InformationSubPage()
        {
            TextContent = JSONUnpackingService.UnpackTextContent<InformationSubPageTextContent>(TextContentFilePath);
        }
    }
}
