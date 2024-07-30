using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.ToolTips
{
    public partial class ToolTip
    {

        [Parameter]
        public string ToolTipText { get; set; } = "Test";

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

    }
}
