using Microsoft.AspNetCore.Components;
using System.Security;

namespace MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.NavigationIconButton
{
    public class NavigationIconButton_StateClass
    {
        public string? ButtonTitle { get; set; }
        public string? ButtonIcon { get; set; }
        public string? ButtonIconColor { get; set; }   
        public Action OnClickCallBack { get; set; }

        public NavigationIconButton_StateClass(string ButtonTitle, string ButtonIcon, string ButtonIconColor, Action OnClickCallBack)
        {
            this.ButtonTitle = ButtonTitle;
            this.ButtonIcon = ButtonIcon;
            this.ButtonIconColor = ButtonIconColor;
            this.OnClickCallBack = OnClickCallBack;
        }
    }
}
