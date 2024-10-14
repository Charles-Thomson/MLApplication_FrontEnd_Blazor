using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual;
using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineLearningApplication_Build_2.Components.ComponentGroups
{
    public partial class SideNavigationGroup
    {
        [Inject] protected IJSRuntime JSRuntime { get; set; }

        
        [Parameter]
        public List<IconButtonDropDownStateClass>? SideNavigationGroupBuildData { get; set; }
        

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JS.InvokeVoidAsync("hoverEffect_Opacity_subPageContent", "sidebar-menu-button-group-container", "opacity-filter");
                await JS.InvokeVoidAsync("hoverEffect_Opacity_toolTipText", "sidebar-menu-button-group-container", "sidebar-menu-tool-tips-group");
                await JS.InvokeVoidAsync("hoverEffect_BackgroundGradient", "sidebar-menu-button-group-container", "sidebar-menu-button-group-container");
                await JS.InvokeVoidAsync("hoverEffect_WidthTransition", "sidebar-menu-button-group-container", "sidebar-menu-button-group-container");
            }
        }





     


        
    }
}
