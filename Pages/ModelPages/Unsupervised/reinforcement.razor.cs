using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
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

        public List<IconButtonStateClass> SideNavigationBuildData { get; set; }

        
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
        private IconButtonStateClass GenerateIconButtonStateClass(string Title, string Icon, string IconColor, Action OnClickCallBack)
        {
            return new IconButtonStateClass(
                    ButtonTitle: Title,
                    ButtonIcon: Icon,
                    ButtonIconColor: IconColor,
                    OnClickCallBack: OnClickCallBack
                );
        }

        private List<IconButtonStateClass> CreateIconButtonBuildData() {
            List<IconButtonStateClass> NewIconbuttonBuildData = new() {
                GenerateIconButtonStateClass("Information", "bi bi-info-square", "primary-color", () => CallBackPlaceHolder("Info")),
                GenerateIconButtonStateClass("Hyperperameters", "bi bi bi-gear-fill", "primary-color", () => CallBackPlaceHolder("Hyperparameters")),
                GenerateIconButtonStateClass("Environment", "bi bi-globe-americas",  "primary-color", () => CallBackPlaceHolder("Environment")),
                GenerateIconButtonStateClass("Neural Network", "bi bi-share-fill", "primary-color", () => CallBackPlaceHolder("NeuralNetwork")),
                GenerateIconButtonStateClass("Submit", "bi bi-send-fill", "primary-color", () => CallBackPlaceHolder("Submit")),
            };

            return NewIconbuttonBuildData;

        }

        public void CallBackPlaceHolder(string val) {
            Console.WriteLine($"Call back recived : Value: {val}");
        }
    }
}
