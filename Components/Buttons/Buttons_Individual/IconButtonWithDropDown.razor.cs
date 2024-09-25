using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual
{
    public partial class IconButtonWithDropDown
    { 
        [Parameter] public string? ButtonText { get; set; }

        public string HeightCSS { get; set; } 

        public string Open = "300%";
        public string Closed = "2rem";

        public void OnClickHight() {
            if (HeightCSS == Open)
            {
                HeightCSS = Closed;
            }
            else {
                HeightCSS = Open;

            }
        }

        public IconButtonWithDropDown() {
            HeightCSS = Closed;
        }

    }
}
