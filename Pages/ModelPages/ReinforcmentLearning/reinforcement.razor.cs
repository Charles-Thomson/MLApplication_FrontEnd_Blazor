using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual;
using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
using MachineLearningApplication_Build_2.Components.ComponentGroups;
using MachineLearningApplication_Build_2.Components.SubPages.SideBarMenuGroupSubPages.ReinforcementLearning;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.VisualBasic;
using System;
using System.CodeDom.Compiler;
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
            //SideNavigationBuildData = GenerateSideBarMenuStateClass();
            SideNavigationGroupBuildData = GeneratedSideNavigationGroupBuildData();
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

        /// Generate a function to prduce the buidl data like below

        private List<IconButtonDropDownStateClass>? SideNavigationGroupBuildData { get; set; }

        private List<IconButtonDropDownStateClass>? GeneratedSideNavigationGroupBuildData() {


            List<IconButtonDropDownStateClass>? BuildDataList = new();
            IconButtonDropDownStateClass Button1 = new IconButtonDropDownStateClass();
            Button1.Icon = "bi bi-info-square";
            Button1.IconSize = "icon-size-small";
            Button1.IconColor = "grey";
            Button1.ButtonText = "Information";
            Button1.DropDownContent = GenerateSideNavigationRenderFragment(component: typeof(InformationSubPage), "Information");

            
            IconButtonDropDownStateClass Button2 = new IconButtonDropDownStateClass();
            Button2.Icon = "bi bi bi-gear-fill";
            Button2.IconSize = "icon-size-small";
            Button2.IconColor = "grey";
            Button2.ButtonText = "Hyperparameters";
            Button2.DropDownContent = GenerateSideNavigationRenderFragment(component: typeof(HyperparametersSubPage), "Hyperparameter");

            
            IconButtonDropDownStateClass Button3 = new IconButtonDropDownStateClass();
            Button3.Icon = "bi bi-globe-americas";
            Button3.IconSize = "icon-size-small";
            Button3.IconColor = "grey";
            Button3.ButtonText = "Environment";
            Button3.DropDownContent = GenerateSideNavigationRenderFragment(component: typeof(EnvironmentSubPage), "Environment");

            IconButtonDropDownStateClass Button4 = new IconButtonDropDownStateClass();
            Button4.Icon = "bi bi-share-fill";
            Button4.IconSize = "icon-size-small";
            Button4.IconColor = "grey";
            Button4.ButtonText = "NeuralNetwork";
            Button4.DropDownContent = GenerateSideNavigationRenderFragment(component: typeof(NeuralNetworkSubPage), "NeuralNetwork");

            IconButtonDropDownStateClass Button5 = new IconButtonDropDownStateClass();
            Button5.Icon = "bi bi-send-fill";
            Button5.IconSize = "icon-size-small";
            Button5.IconColor = "grey";
            Button5.ButtonText = "Submission";
            Button5.DropDownContent = GenerateSideNavigationRenderFragment(component: typeof(SubmissionSubPage), "Submission");


            BuildDataList.Add(Button1);
            BuildDataList.Add(Button2);
            BuildDataList.Add(Button3);
            BuildDataList.Add(Button4);
            BuildDataList.Add(Button5);


            return BuildDataList;

        }

        /// <summary>
        /// Genertae a rnder fragment of the given type
        /// </summary>
        /// <param name="type">Componenet Type </param> 
        /// <param name="PageTitle">Title of the componenet -- redundent ?</param>
        /// <returns></returns>
        private RenderFragment GenerateSideNavigationRenderFragment(Type component, string PageTitle) {
            RenderFragment newRenderFragment = builder =>
            {
                builder.OpenComponent(0, component);
                builder.AddAttribute(1, "PageTitle", "PageTitle");
                builder.CloseComponent();
            };

            return newRenderFragment;


        }







        ///// <summary>
        ///// Generate build data (State classes) for the SideBarMenu
        ///// </summary>
        ///// <returns> List<SideBarMenuStateClass> </returns>
        //private List<SideBarMenuStateClass> GenerateSideBarMenuStateClass()
        //{
        //    RenderFragment InformationPageRnderFragment = builder => {
        //        builder.OpenComponent(0, typeof(InformationSubPage));
        //        builder.AddAttribute(1, "PageTitle", "Information");
        //        builder.CloseComponent();
        //    };

        //    RenderFragment HyperparametersPageRnderFragment = builder => {
        //        builder.OpenComponent(0, typeof(HyperparametersSubPage));
        //        builder.AddAttribute(1, "PageTitle", "Hyperparameters");
        //        builder.CloseComponent();
        //    };

        //    RenderFragment EnvironmentPageRnderFragment = builder => {
        //        builder.OpenComponent(0, typeof(EnvironmentSubPage));
        //        builder.AddAttribute(1, "PageTitle", "Environment");
        //        builder.CloseComponent();
        //    };

        //    RenderFragment NeuralNetworkPageRnderFragment = builder => {
        //        builder.OpenComponent(0, typeof(NeuralNetworkSubPage));
        //        builder.AddAttribute(1, "PageTitle", "Neural Network");
        //        builder.CloseComponent();
        //    };

        //    RenderFragment SubmitPageRnderFragment = builder => {
        //        builder.OpenComponent(0, typeof(SubmissionSubPage));
        //        builder.AddAttribute(1, "PageTitle", "Submit");
        //        builder.CloseComponent();
        //    };

        //    IconButtonStateClass ButtonStateData_Information = GenerateIconButtonStateClass("Information", "bi bi-info-square", "secondary-color");
        //    IconButtonStateClass ButtonStateData_Hyperparameters = GenerateIconButtonStateClass("Hyperparameters", "bi bi bi-gear-fill", "secondary-color");
        //    IconButtonStateClass ButtonStateData_Environment = GenerateIconButtonStateClass("Environment", "bi bi-globe-americas", "secondary-color");
        //    IconButtonStateClass ButtonStateData_Neural_Network = GenerateIconButtonStateClass("Neural Network", "bi bi-share-fill", "secondary-color");
        //    IconButtonStateClass ButtonStateData_Submit = GenerateIconButtonStateClass("Submit", "bi bi-send-fill", "secondary-color");

        //    List<SideBarMenuStateClass> newBuildData = new List<SideBarMenuStateClass> {
        //        new SideBarMenuStateClass(ClassId: "Information", ToolTipText: "Information", ButtonBuildData: ButtonStateData_Information, SubPageContent: InformationPageRnderFragment),
        //        new SideBarMenuStateClass(ClassId: "Hyperparameters", ToolTipText: "Hyperparameters",ButtonBuildData: ButtonStateData_Hyperparameters, SubPageContent: HyperparametersPageRnderFragment),
        //        new SideBarMenuStateClass(ClassId: "Environment", ToolTipText: "Environment",ButtonBuildData: ButtonStateData_Environment, SubPageContent: EnvironmentPageRnderFragment),
        //        new SideBarMenuStateClass(ClassId: "Neural Network", ToolTipText: "Neural Network",ButtonBuildData: ButtonStateData_Neural_Network, SubPageContent: NeuralNetworkPageRnderFragment),
        //        new SideBarMenuStateClass(ClassId: "Submit", ToolTipText: "Submit",ButtonBuildData: ButtonStateData_Submit, SubPageContent: SubmitPageRnderFragment)
        //    };

        //    return newBuildData;
        //}
    }
}
