using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.Cards
{
    public partial class DefaultCard
    {
        [Parameter] required public string IconType { get; set; }
        [Parameter] required public string IconColor { get; set; }
        [Parameter] required public string IconSize { get; set; }
        [Parameter] required public string Description { get; set; }
    }
}
