using Microsoft.AspNetCore.Components;
using System.Security;

namespace MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.NavigationIconButton
{
    public class Navigation_Icon_Button_StateClass
    {
        

        public string? button_Title { get; set; }
        public string? button_Icon { get; set; }
        public string? button_Icon_Color { get; set; }   
        
        public Action OnClickCallBack { get; set; }

        public Navigation_Icon_Button_StateClass(string button_Title, string button_Icon, string button_Icon_Color, Action onClickCallBack)
        {
            this.button_Title = button_Title;
            this.button_Icon = button_Icon;
            this.button_Icon_Color = button_Icon_Color;
            this.OnClickCallBack = onClickCallBack;
        }
    }
}
