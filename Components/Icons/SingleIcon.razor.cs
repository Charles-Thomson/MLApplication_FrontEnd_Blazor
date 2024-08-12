using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.Icons
{
    public partial class SingleIcon
    {
        [Parameter] public string Icon { get; set; }
        [Parameter] public string IconColor { get; set; }
        [Parameter] public string IconSize { get; set; }


    }
}
