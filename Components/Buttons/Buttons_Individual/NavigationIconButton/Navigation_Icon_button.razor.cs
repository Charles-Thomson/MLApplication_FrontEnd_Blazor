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
        [Parameter] public Action OnClickCallBack { get; set; }

        private void Handle_OnClickCallBack() {
            OnClickCallBack.Invoke();
            Console.WriteLine("Button Pressed Inside Card");

        }


    }
}
