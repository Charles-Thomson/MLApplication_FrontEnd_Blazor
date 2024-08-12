using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineLearningApplication_Build_2.wwwroot.TextContent;


namespace MachineLearningApplication_Build_2.Components.Cards
{
    public partial class NavigationCardList
    {
        [Parameter] public required NavigationCardList_StateClass CardBuildData { get; set; }
    }
}

