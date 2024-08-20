using Blazorise;
using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
using MachineLearningApplication_Build_2.Components.SubPages.SideBarMenuGroupSubPages.UnsupervisedLearning;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.ComponentGroups
{
    public partial class SidebarMenuGroup
    {
        //[Parameter] required public List<IconButtonStateClass> BuildData { get; set; }


        public List<SideBarMenuStateClass>? _buildData;
        [Parameter]
        required public List<SideBarMenuStateClass>? BuildData
        {

            get { return _buildData; }

            set {  
                _buildData = value;
                GenerateBuildData();
            }
             
        }

        public List<IconButtonStateClass> ButtonBuildData { get; set; }

        public List<string> ToolTipBuildData { get; set; }

        public RenderFragment? CurrentDisplayedSubPage { get; set; }

        public RenderFragment CurretPage = builder =>
        {
            builder.OpenComponent(0,typeof(InformationSubPage));
            builder.CloseComponent();
        };

        public void SetButtonCallBackFunctions() {
            foreach (IconButtonStateClass elm in ButtonBuildData) {
                elm.OnClickCallBack = () => TestCallBack(elm.ButtonTitle);
            }
        }

        public void TestCallBack(string TestStr) {
            Console.WriteLine($"CallBack Recieved: {TestStr}");

            CurrentDisplayedSubPage = BuildData
                .Where(page => page.ClassId == TestStr)
                .Select(sc => sc.SubPageContent)
                .FirstOrDefault();
            StateHasChanged();
        }


        public void GenerateBuildData() {

            ButtonBuildData = BuildData.Select(ButtonData => ButtonData.ButtonBuildData).ToList();
            ToolTipBuildData = BuildData.Select(ToolTipData => ToolTipData.ToolTipText).ToList();
            //CurrentDisplayedSubPage = BuildData
            //    .Where(page => page.ClassId == "Information")
            //    .Select(sc => sc.SubPageContent)
            //    .FirstOrDefault();

            SetButtonCallBackFunctions();



            StateHasChanged();
        }

        


    }
}

