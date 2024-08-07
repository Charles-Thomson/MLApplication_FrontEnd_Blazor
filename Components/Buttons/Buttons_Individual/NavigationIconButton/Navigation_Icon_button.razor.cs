using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.NavigationIconButton
{
    public partial class Navigation_Icon_button
    {
        [Parameter] public string? Button_Title { get; set; }

        [Parameter] public string? Button_Icon { get; set; }

        [Parameter] public string? Button_Icon_Color { get; set; }
        public Navigation_Icon_button(string button_Title, string button_Icon, string button_Icon_Color)
        {
            Button_Title = button_Title;
            Button_Icon = button_Icon;
            Button_Icon_Color = button_Icon_Color;
        }
    }
}
