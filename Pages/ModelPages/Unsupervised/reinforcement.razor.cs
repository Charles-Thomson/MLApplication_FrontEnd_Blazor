
using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.ResourceIconButton;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Pages.ModelPages.Unsupervised
{
    public partial class Reinforcement
    {

        public List<ResourceIconButton_StateClass> SideNavigationBuildData { get; set; }

        
        public Reinforcement()
        {
            
            SideNavigationBuildData = CreateIconButtonBuildData();

        }

        /// <summary>
        /// Helper function of the creation of NavigationIconButton_StateClass
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Icon"></param>
        /// <param name="IconColor"></param>
        /// <param name="OnClickCallBack"></param>
        /// <returns> NavigationIconButton_StateClass </returns>
        private ResourceIconButton_StateClass GenerateIconButtonStateClass(string Title, string Icon, string IconColor, Action OnClickCallBack)
        {
            return new ResourceIconButton_StateClass(
                    ButtonTitle: Title,
                    ButtonIcon: Icon,
                    ButtonIconColor: IconColor,
                    OnClickCallBack: OnClickCallBack
                );
        }

        private List<ResourceIconButton_StateClass> CreateIconButtonBuildData() {
            List<ResourceIconButton_StateClass> NewIconbuttonBuildData = new() {
                GenerateIconButtonStateClass("", "bi bi-person-check", "primary-color", CallBackPlaceHolder),
                GenerateIconButtonStateClass("", "bi bi-person-x",  "primary-color", CallBackPlaceHolder),
                GenerateIconButtonStateClass("", "bi bi-bar-chart-line", "primary-color", CallBackPlaceHolder),
                GenerateIconButtonStateClass("", "bi bi-collection", "primary-color", CallBackPlaceHolder),
            };

            return NewIconbuttonBuildData;

        }

        public void CallBackPlaceHolder() {
            Console.WriteLine($"Call back recived : Value: ");
        }
    }
}
