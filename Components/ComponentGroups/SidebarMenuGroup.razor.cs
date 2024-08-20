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


        private List<SideBarMenuStateClass>? _buildData;
        [Parameter]
        required public List<SideBarMenuStateClass> BuildData
        {
            get { return _buildData; }
            set {  
                _buildData = value;
                ParseBuildData();
            }
        }

        public List<IconButtonStateClass>? ButtonBuildData { get; set; }
        public List<string>? ToolTipBuildData { get; set; }
        public RenderFragment? CurrentDisplayedSubPage { get; set; }

        public string CurrentlyDisplayedSubPageID { get; set; } = "";

        public string SubPageVisability { get; set; }


        /// <summary>
        /// Set the call back function of IconButtonStateClass
        /// </summary>
        protected void SetCallBackFunctions() {
            if (ButtonBuildData == null) return;

            foreach (IconButtonStateClass elm in ButtonBuildData) {
                if (elm.ButtonTitle == null) continue;
                elm.OnClickCallBack = () => UpdateDisplayedSubPage(elm.ButtonTitle);
            }
        }

        /// <summary>
        /// Update the currently displayed SubPage render fragment
        /// </summary>
        /// <param name="newPageId">ID of the new page to be displayed</param>
        public void UpdateDisplayedSubPage(string newPageId) {
           
            if (ButtonBuildData == null || newPageId == null) return;

            SetSubPageVisability(true);

            if (newPageId == CurrentlyDisplayedSubPageID)
            {
                CurrentlyDisplayedSubPageID = string.Empty;
                SetSubPageVisability(false);
                return;
            }

            CurrentDisplayedSubPage = BuildData
                .FirstOrDefault(page => page.ClassId == newPageId)?
                .SubPageContent;

            CurrentlyDisplayedSubPageID = newPageId;

            StateHasChanged();
        }


        /// <summary>
        /// Set the visability of the SubPage container
        /// </summary>
        /// <param name="isVisable"></param>
        private void SetSubPageVisability(bool isVisable) {
            SubPageVisability = isVisable ? "side-bar-menu-content-group" : "side-bar-menu-content-group-hidden";
            StateHasChanged();
        }

        /// <summary>
        /// Break out the elements of the build data 
        /// </summary>
        protected void ParseBuildData() {

            SubPageVisability = "side-bar-menu-content-group-hidden";
            if (BuildData == null) return;


            ButtonBuildData = BuildData
                .Select(ButtonData => ButtonData.ButtonBuildData)
                .ToList();

            ToolTipBuildData = BuildData
                .Select(ToolTipData => ToolTipData.ToolTipText)
                .ToList();

            SetCallBackFunctions();
        }
    }
}

