using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.ToolTips
{
    public partial class SideNavigationButtonGroupToolTips
    {
        [Parameter] public List<string>? BuildData { get; set; }
    }
}
