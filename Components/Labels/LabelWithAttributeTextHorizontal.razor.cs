﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.Labels
{
    public partial class LabelWithAttributeTextHorizontal
    {
        [Parameter] public string? LabelText { get; set; }
         
        [Parameter] public string? ContentText { get; set; }
    }
}
