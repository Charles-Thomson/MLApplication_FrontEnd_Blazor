using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual
{
    public partial class NavigationIconButton
    {
        [Parameter] public string? ButtonTitle { get; set; }

        [Parameter] public string? ButtonIcon { get; set; }

        [Parameter] public string? ButtonIconColor { get; set; }
        [Parameter] public Action OnClickCallBack { get; set; }

        private void Handle_OnClickCallBack()
        {
            OnClickCallBack.Invoke();


        }


    }
}
