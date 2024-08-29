using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.TwoDimensionalMazeEnvironment
{
    public partial class MazeNode
    {
        [Parameter] required public int NodeID { get; set; }
        [Parameter] required public string BackgroundColor { get; set; }

        [Parameter] public EventCallback<string> OnClickCallBack { get; set; }
    }
}
