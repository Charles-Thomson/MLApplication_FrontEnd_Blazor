using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
using MachineLearningApplication_Build_2.Components.ComponentGroups;
using MachineLearningApplication_Build_2.Components.SubPages.SideBarMenuGroupSubPages.ReinforcementLearning;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Pages.ModelPages.ReinforcmentLearning
{
    public partial class Reinforcement
    {

        public int environmentDimension_X { get; set; } = 2;
        public int environmentDimension_Y { get; set; } = 2;


        public List<SideBarMenuStateClass> SideNavigationBuildData { get; set; }


        public Reinforcement()
        {
            SideNavigationBuildData = GenerateSideBarMenuStateClass();
        }

        
        /// <summary>
        /// Helper function of the creation of NavigationIconButton_StateClass
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Icon"></param>
        /// <param name="IconColor"></param>
        /// <param name="OnClickCallBack"></param>
        /// <returns> NavigationIconButton_StateClass </returns>
        private IconButtonStateClass GenerateIconButtonStateClass(string Title, string Icon, string IconColor, Action? OnClickCallBack = null)
        {
            return new IconButtonStateClass(
                    ButtonTitle: Title,
                    ButtonIcon: Icon,
                    ButtonIconColor: IconColor,
                    OnClickCallBack: OnClickCallBack
                );
        }
        /// <summary>
        /// Generate build data (State classes) for the SideBarMenu
        /// </summary>
        /// <returns> List<SideBarMenuStateClass> </returns>
        private List<SideBarMenuStateClass> GenerateSideBarMenuStateClass()
        {
            RenderFragment InformationPageRnderFragment = builder => {
                builder.OpenComponent(0, typeof(InformationSubPage));
                builder.AddAttribute(1, "PageTitle", "Information");
                builder.CloseComponent();
            };

            RenderFragment HyperparametersPageRnderFragment = builder => {
                builder.OpenComponent(0, typeof(HyperparametersSubPage));
                builder.AddAttribute(1, "PageTitle", "Hyperparameters");
                builder.CloseComponent();
            };

            RenderFragment EnvironmentPageRnderFragment = builder => {
                builder.OpenComponent(0, typeof(EnvironmentSubPage));
                builder.AddAttribute(1, "PageTitle", "Environment");
                builder.CloseComponent();
            };

            RenderFragment NeuralNetworkPageRnderFragment = builder => {
                builder.OpenComponent(0, typeof(NeuralNetworkSubPage));
                builder.AddAttribute(1, "PageTitle", "Neural Network");
                builder.CloseComponent();
            };

            RenderFragment SubmitPageRnderFragment = builder => {
                builder.OpenComponent(0, typeof(SubmissionSubPage));
                builder.AddAttribute(1, "PageTitle", "Submit");
                builder.CloseComponent();
            };

            IconButtonStateClass ButtonStateData_Information = GenerateIconButtonStateClass("Information", "bi bi-info-square", "primary-color");
            IconButtonStateClass ButtonStateData_Hyperparameters = GenerateIconButtonStateClass("Hyperparameters", "bi bi bi-gear-fill", "primary-color");
            IconButtonStateClass ButtonStateData_Environment = GenerateIconButtonStateClass("Environment", "bi bi-globe-americas", "primary-color");
            IconButtonStateClass ButtonStateData_Neural_Network = GenerateIconButtonStateClass("Neural Network", "bi bi-share-fill", "primary-color");
            IconButtonStateClass ButtonStateData_Submit = GenerateIconButtonStateClass("Submit", "bi bi-send-fill", "primary-color");

            List<SideBarMenuStateClass> newBuildData = new List<SideBarMenuStateClass> {
                new SideBarMenuStateClass(ClassId: "Information", ToolTipText: "Information", ButtonBuildData: ButtonStateData_Information, SubPageContent: InformationPageRnderFragment),
                new SideBarMenuStateClass(ClassId: "Hyperparameters", ToolTipText: "Hyperparameters",ButtonBuildData: ButtonStateData_Hyperparameters, SubPageContent: HyperparametersPageRnderFragment),
                new SideBarMenuStateClass(ClassId: "Environment", ToolTipText: "Environment",ButtonBuildData: ButtonStateData_Environment, SubPageContent: EnvironmentPageRnderFragment),
                new SideBarMenuStateClass(ClassId: "Neural Network", ToolTipText: "Neural Network",ButtonBuildData: ButtonStateData_Neural_Network, SubPageContent: NeuralNetworkPageRnderFragment),
                new SideBarMenuStateClass(ClassId: "Submit", ToolTipText: "Submit",ButtonBuildData: ButtonStateData_Submit, SubPageContent: SubmitPageRnderFragment)
            };

            return newBuildData;
        }
    }
}
