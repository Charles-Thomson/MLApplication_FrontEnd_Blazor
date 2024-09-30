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
        [Parameter] public string? Icon { get; set; }

        public string HeightCSS { get; set; }
        public string CloseButtonCSS { get; set; }

        public string Open = "300%";
        public string Closed = "2rem";

        public string Visable = "visible";
        public string NotVisable = "hidden";

        public string OnClickHight() {
            if (HeightCSS == Open)
            {
                return Closed;
            }
            else {
                return Open;

            }
        }

        public string CloseButtonVisibility() {
            if (HeightCSS == Open)
            {
                return Visable;
            }
            else
            {
                return NotVisable;
            }
        }
        

        public void HandleOnclick() {

            HeightCSS = OnClickHight();
            CloseButtonCSS = CloseButtonVisibility();
        }

        public IconButtonWithDropDown() {
            HeightCSS = Closed;
            CloseButtonCSS = NotVisable;


        }

    }
}
