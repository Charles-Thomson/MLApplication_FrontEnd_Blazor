using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
using MachineLearningApplication_Build_2.Components.ComponentGroups;
using MachineLearningApplication_Build_2.Components.SubPages.SideBarMenuGroupSubPages.UnsupervisedLearning;
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

        public List<SideBarMenuStateClass> NewSideNavBuildData { get; set; }


        public Reinforcement()
        {
            
            SideNavigationBuildData = CreateIconButtonBuildData();
            NewSideNavBuildData = GenerateSideBarMenuStateClass();

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
                    ButtonIconColor: IconColor
                    //OnClickCallBack: OnClickCallBack
                );
        }


        private List<SideBarMenuStateClass> GenerateSideBarMenuStateClass()
        {
            RenderFragment InformationPageRnderFragment = builder => {
                builder.OpenComponent(0, typeof(InformationSubPage));
                builder.AddAttribute(1, "PageTitle", "Information");
                builder.CloseComponent();
            };

            RenderFragment HyperperametersPageRnderFragment = builder => {
                builder.OpenComponent(0, typeof(InformationSubPage));
                builder.AddAttribute(1, "PageTitle", "Hyperperameters");
                builder.CloseComponent();
            };

            RenderFragment EnvironmentPageRnderFragment = builder => {
                builder.OpenComponent(0, typeof(InformationSubPage));
                builder.AddAttribute(1, "PageTitle", "Environment");
                builder.CloseComponent();
            };

            RenderFragment NeuralNetworkPageRnderFragment = builder => {
                builder.OpenComponent(0, typeof(InformationSubPage));
                builder.AddAttribute(1, "PageTitle", "Neural Network");
                builder.CloseComponent();
            };

            RenderFragment SubmitPageRnderFragment = builder => {
                builder.OpenComponent(0, typeof(InformationSubPage));
                builder.AddAttribute(1, "PageTitle", "Submit");
                builder.CloseComponent();
            };




            IconButtonStateClass ButtonStateData_Information = GenerateIconButtonStateClass("Information", "bi bi-info-square", "primary-color", () => CallBackPlaceHolder("Info"));
            IconButtonStateClass ButtonStateData_Hyperperameters = GenerateIconButtonStateClass("Hyperperameters", "bi bi bi-gear-fill", "primary-color", () => CallBackPlaceHolder("Hyperparameters"));
            IconButtonStateClass ButtonStateData_Environment = GenerateIconButtonStateClass("Environment", "bi bi-globe-americas", "primary-color", () => CallBackPlaceHolder("Environment"));
            IconButtonStateClass ButtonStateData_Neural_Network = GenerateIconButtonStateClass("Neural Network", "bi bi-share-fill", "primary-color", () => CallBackPlaceHolder("NeuralNetwork"));
            IconButtonStateClass ButtonStateData_Submit = GenerateIconButtonStateClass("Submit", "bi bi-send-fill", "primary-color", () => CallBackPlaceHolder("Submit"));

            List<SideBarMenuStateClass> newBuildData = new List<SideBarMenuStateClass> {
                new SideBarMenuStateClass(ClassId: "Information", ToolTipText: "Information", ButtonBuildData: ButtonStateData_Information, SubPageContent: InformationPageRnderFragment),
                new SideBarMenuStateClass(ClassId: "Hyperperameters", ToolTipText: "Hyperperameters",ButtonBuildData: ButtonStateData_Hyperperameters, SubPageContent: HyperperametersPageRnderFragment),
                new SideBarMenuStateClass(ClassId: "Environment", ToolTipText: "Environment",ButtonBuildData: ButtonStateData_Environment, SubPageContent: EnvironmentPageRnderFragment),
                new SideBarMenuStateClass(ClassId: "Neural Network", ToolTipText: "Neural Network",ButtonBuildData: ButtonStateData_Neural_Network, SubPageContent: NeuralNetworkPageRnderFragment),
                new SideBarMenuStateClass(ClassId: "Submit", ToolTipText: "Submit",ButtonBuildData: ButtonStateData_Submit, SubPageContent: SubmitPageRnderFragment)
            };


            return newBuildData;
        }



        /// <summary>
        ///  Add the Render Fragmets into this state class build

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
