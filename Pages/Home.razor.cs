using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.NavigationIconButton;
using MachineLearningApplication_Build_2.Components.Cards;
using MachineLearningApplication_Build_2.Services;
using Microsoft.AspNetCore.Components;
using Serilog;
using MachineLearningApplication_Build_2.wwwroot.TextContent;
using MachineLearningApplication_Build_2.Components.Cards.IconAndDescriptionCard;
using MachineLearningApplication_Build_2.Components.Cards.ComponentListCard;
using MachineLearningApplication_Build_2.Structs;



namespace MachineLearningApplication_Build_2.Pages
{
    public partial class Home
    {

        [Inject]
        NavigationManager? NavigationManager { get; set; } 
        public string Supervised_Learning_Card_Content { get; private set; } = "Supervised Learning (SL) takes a defined input set and desiered output to train a model ...";
        public string Unsupervised_Learning_Card_Content { get; private set; } = "Unsupervised Learnming (ML) takes a unlabeled data to train a model to deisearn patterns and insights ...";
        public string Regression_Card_Content { get; private set; } = "Regression takes a set of input data and known outpus to train a model to determain the outcome of future input sets ...";
        public string Classification_Learning_Card_Content { get; private set; } = "Classification trains a model to desearn input data into a numebr of pre defined clasifications ...";

        public List<NavigationIconButton_StateClass> ResourceIconbutton_BuildData { get; set; }
        
        public List<ComponentListCardStateClass> ComponentListCardStateClasses { get; set; }

        public ComponentListCardStateClass SelectedComponentListCardStateClasses { get; set; }

        public HomePageTextContent HomePage_TextContent { get; set; }
        private JSONUnpackingService JSONUnpackingService { get; set; } = new();

        private readonly string TextContentFilePath = "wwwroot/TextContent/HomePage_TextContent.json";

        public Home() {
            ResourceIconbutton_BuildData = Generate_ResourceIconbutton_BuildData();

            ComponentListCardStateClasses = CreateComponentListCardStateClass();
            SelectedComponentListCardStateClasses = CreateComponentListCardDefaultCard();

            //HomePage_TextContent = JSONUnpackingService.UnpackTextContent<HomePageTextContent>(TextContentFilePath);
  
        }

        /// <summary>
        /// Update the displayed Card 
        /// </summary>
        /// <param name="NewCardId">ID of the new Card to be displayed</param>
        public void UpdateSelectedCard(string NewCardId)
        {
            Log.Information($"CALLBACK : Updating selected card -> ID: {NewCardId}");
            SelectedComponentListCardStateClasses = ComponentListCardStateClasses.FirstOrDefault(p => p.CardId == NewCardId); 
            StateHasChanged();
        }

        public void NavigateTo(string url) => NavigationManager?.NavigateTo(url);

        /// <summary>
        /// Helper function of the creation of NavigationIconButton_StateClass
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Icon"></param>
        /// <param name="IconColor"></param>
        /// <param name="OnClickCallBack"></param>
        /// <returns> NavigationIconButton_StateClass </returns>
        private NavigationIconButton_StateClass GenerateIconButtonStateClass(string Title, string Icon, string IconColor, Action OnClickCallBack) {
            return new NavigationIconButton_StateClass(
                    ButtonTitle: Title,
                    ButtonIcon: Icon,
                    ButtonIconColor: IconColor,
                    OnClickCallBack: OnClickCallBack
                );
        }


        /// <summary>
        /// Generate the State Classes to store Icon Button data
        /// </summary>
        /// <returns>List of new Icon Button State objects</returns>
        public List<NavigationIconButton_StateClass> Generate_ResourceIconbutton_BuildData() {

            List<NavigationIconButton_StateClass> New_ResourceIconbutton_BuildData = new() {
                GenerateIconButtonStateClass("Supervised", "bi bi-person-check", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                GenerateIconButtonStateClass("Unsupervised", "bi bi-person-x",  "primary-color", () => UpdateSelectedCard("Unsupervised_Card")),
                GenerateIconButtonStateClass("Regression", "bi bi-bar-chart-line", "primary-color", () => UpdateSelectedCard("Regression_Card")),
                GenerateIconButtonStateClass("Classification", "bi bi-collection", "primary-color", () => UpdateSelectedCard("Classification_Card")),
            };

            return New_ResourceIconbutton_BuildData;
        }


        /// <summary>
        /// Create the ComponentListCardStateClass with nested IconAndDescriptionStateClass
        /// </summary>
        /// <returns> List<ComponentListCardStateClass> </returns>
        private List<ComponentListCardStateClass> CreateComponentListCardStateClass()
        {
            List<IconAndDescriptionStateClass> Supervised_List = new List<IconAndDescriptionStateClass> {
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal", IconType: "bi bi-cpu" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Working Example" ),
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-share-fill" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Neural Network" ),
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-database-fill" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Data sets & Application" )
            };
            List<IconAndDescriptionStateClass> Unsupervised_List = new List<IconAndDescriptionStateClass> {
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-cpu" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Working Example" ),
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-share-fill" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Neural Network" ),
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-database-fill" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Data sets & Application" )
            };
            List<IconAndDescriptionStateClass> Regression_List = new List<IconAndDescriptionStateClass> {
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-cpu" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Working Example" ),
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-share-fill" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Neural Network" ),
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-database-fill" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Data sets & Application" )
            };
            List<IconAndDescriptionStateClass> Classification_List = new List<IconAndDescriptionStateClass> {
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-cpu" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Working Example" ),
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-share-fill" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Neural Network" ),
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Horizontal",IconType: "bi bi-database-fill" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Data sets & Application" )
            };

          
        List<ComponentListCardStateClass> newCardData = new List<ComponentListCardStateClass>
            {
                new ComponentListCardStateClass(cardId: "Supervised_Card", cardTitle:"Supervised Learning (SL)" , stateClass:Supervised_List ),
                new ComponentListCardStateClass(cardId: "Unsupervised_Card", cardTitle:"Unsupervised Learning (UL)", stateClass:Unsupervised_List ),
                new ComponentListCardStateClass(cardId: "Regression_Card", cardTitle:"Regression", stateClass:Regression_List ),
                new ComponentListCardStateClass(cardId: "Classification_Card", cardTitle:"Classification", stateClass:Classification_List)
            };
            return newCardData;
        }


        /// <summary>
        ///  Create the default (Shown on page load) ComponentListCardStateClass 
        /// </summary>
        /// <returns>ComponentListCardStateClass</returns>
        private ComponentListCardStateClass CreateComponentListCardDefaultCard() {
            List<IconAndDescriptionStateClass> Default_List = new List<IconAndDescriptionStateClass> {
                new IconAndDescriptionStateClass(IconAndDescriptionCardType: "Centered", IconType: "bi bi-arrow-up-square", IconColor: "secondary-color", IconSize: "icon-size-Xlarge", Description: "SELECT FROM OPTIONS ABOVE")
            };

            ComponentListCardStateClass newDefault = new ComponentListCardStateClass(cardId: "Default_Card", cardTitle: "", stateClass: Default_List);

            return newDefault;
        }
    }
}
