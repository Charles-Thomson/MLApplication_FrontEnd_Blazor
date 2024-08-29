using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.SubPages.SideBarMenuGroupSubPages.ReinforcementLearning
{
    public partial class EnvironmentSubPage
    {
        [Parameter] required public string PageTitle { get; set; }

        public List<string> EmvironmentDimensionOptions = new List<string>
        {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"
        };
    }
}
