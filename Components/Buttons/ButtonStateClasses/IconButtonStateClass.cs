using Microsoft.AspNetCore.Components;
using System.Security;

namespace MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses
{
    public class IconButtonStateClass
    {
        public string? ButtonTitle { get; set; }
        public string? ButtonIcon { get; set; }
        public string? ButtonIconColor { get; set; }
        public Action? OnClickCallBack { get; set; }

        

        public IconButtonStateClass(string ButtonTitle, string ButtonIcon, string ButtonIconColor, Action? OnClickCallBack = null)
        {
            this.ButtonTitle = ButtonTitle;
            this.ButtonIcon = ButtonIcon;
            this.ButtonIconColor = ButtonIconColor;
            this.OnClickCallBack = OnClickCallBack;
            
        }
    }
}
