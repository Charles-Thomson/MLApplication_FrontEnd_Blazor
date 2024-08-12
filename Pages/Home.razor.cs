using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.NavigationIconButton;
using MachineLearningApplication_Build_2.Components.Cards;
using MachineLearningApplication_Build_2.Services;
using Microsoft.AspNetCore.Components;
using Serilog;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json;
using MachineLearningApplication_Build_2.wwwroot.TextContent;
using Blazorise;


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
        //public Card_State_Class<HomePage_TextContentUnpackingClass> DefaultCard { get; set; }
        //public Card_State_Class<HomePage_TextContentUnpackingClass> SelectedCard { get; set; }
        //public List<Card_State_Class<HomePage_TextContentUnpackingClass>> CardBuildData { get; set; }

        public List<NavigationCardList_StateClass> NavigationCardData { get; set; }

        public NavigationCardList_StateClass Selected_NavigationCardData { get; set; }

        public NavigationCardList_StateClass NavigationCard_Default { get; set; }


        public HomePageTextContent HomePage_TextContent { get; set; }
        private JSONUnpackingService JSONUnpackingService { get; set; } = new();

        private readonly string TextContentFilePath = "wwwroot/TextContent/HomePage_TextContent.json";

        public Home() {
            NavigationCardData = CreateNavigationCardListData();
            
            ResourceIconbutton_BuildData = Generate_ResourceIconbutton_BuildData();
            NavigationCard_Default = CreateNavigationCardListData_Deafult();
            Selected_NavigationCardData = NavigationCard_Default;

            //HomePage_TextContent = JSONUnpackingService.UnpackTextContent<HomePageTextContent>(TextContentFilePath);

            //DefaultCard = Generate_DefaultCard();
            //CardBuildData = Generate_Card_BuildData();


            //SelectedCard = DefaultCard;            
        }

        /// <summary>
        /// Update the displayed Card 
        /// </summary>
        /// <param name="NewCardId">ID of the new Card to be displayed</param>
        public void UpdateSelectedCard(string NewCardId)
        {
            

            Log.Information($"CALLBACK : Updating selected card -> ID: {NewCardId}");

            Selected_NavigationCardData = NavigationCardData.FirstOrDefault(p => p.CardId == NewCardId); ;
            StateHasChanged();
        }

        public void NavigateTo(string url) => NavigationManager?.NavigateTo(url);
        

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

       

        

        private List<NavigationCardList_StateClass> CreateNavigationCardListData() 
        {

            /// Need to build lists of the icons on each card
            List<IconAndDescriptionCard_StateClass> Supervised_List = new List<IconAndDescriptionCard_StateClass> {
                new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "1" ),
                new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "2" ),
                new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "3" )
            };
            List<IconAndDescriptionCard_StateClass> Unsupervised_List = new List<IconAndDescriptionCard_StateClass> {
                 new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "4" ),
                new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "5" ),
                new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "6" )
            };
            List<IconAndDescriptionCard_StateClass> Regression_List = new List<IconAndDescriptionCard_StateClass> {
                 new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "7" ),
                new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "8" ),
                new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "9" )
            };
            List<IconAndDescriptionCard_StateClass> Classification_List = new List<IconAndDescriptionCard_StateClass> {
                 new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "10" ),
                new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "11" ),
                new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "12" )
            };

            /// Need to build a list of the cards 
            List<NavigationCardList_StateClass> newCardData = new List<NavigationCardList_StateClass>
            {
                new NavigationCardList_StateClass(cardId: "Supervised_Card", cardTitle:"Supervised Learning (SL)" , iconAndDescriptionCard_StateClasses:Supervised_List ),
                new NavigationCardList_StateClass(cardId: "Unsupervised_Card", cardTitle:"Unsupervised Learning (UL)", iconAndDescriptionCard_StateClasses:Unsupervised_List ),
                new NavigationCardList_StateClass(cardId: "Regression_Card", cardTitle:"Regression", iconAndDescriptionCard_StateClasses:Regression_List ),
                new NavigationCardList_StateClass(cardId: "Classification_Card", cardTitle:"Classification", iconAndDescriptionCard_StateClasses:Classification_List )

            };
            return newCardData;

        }

        /// <summary>
        /// Genertae the Default Card - to be shown on page load
        /// </summary>
        /// <returns> NavigationCardList_StateClass: Default Card </returns>
        private NavigationCardList_StateClass CreateNavigationCardListData_Deafult() {
            List<IconAndDescriptionCard_StateClass> Default_List = new List<IconAndDescriptionCard_StateClass> {
                 new IconAndDescriptionCard_StateClass(IconType: "bi bi-person-check" , IconColor: "primary-color", IconSize: "icon-size-medium", Description: "Default" ),
                
            };

            return new NavigationCardList_StateClass(cardId: "Default_Card", cardTitle: string.Empty, iconAndDescriptionCard_StateClasses: Default_List);

        }






        /// <summary>
        /// Generate State Classes to store Card data
        /// </summary>
        /// <returns>List of new Card State Objects</returns>
        //public List<Card_State_Class<HomePage_TextContentUnpackingClass>> Generate_Card_BuildData()
        //{
        //    List<Card_State_Class<HomePage_TextContentUnpackingClass>> NewCardBuildData = new() {
        //        new(cardId: "Supervised_Card",
        //            cardTitle: "Supervised Learning (SL)",                   
        //            textContent: HomePage_TextContent.Supervised_Machine_Learning,
        //            cardIconButton_BuildData: new() {
        //                GenerateIconButtonStateClass("Supervised", "bi bi-person-check", "primary-color", () => UpdateSelectedCard("Supervised_Card") ),
        //                GenerateIconButtonStateClass("Unsupervised", "bi bi-person-x",  "primary-color", () => UpdateSelectedCard("Supervised_Card") ),
        //                GenerateIconButtonStateClass("Regression", "bi bi-bar-chart-line", "primary-color", () => UpdateSelectedCard("Supervised_Card") ),
        //                GenerateIconButtonStateClass("Classification", "bi bi-collection", "primary-color", () => UpdateSelectedCard("Supervised_Card") )
        //                }
        //            ),

        //        new(cardId: "Unsupervised_Card",
        //            cardTitle: "Unsupervised Learning (UL)",                   
        //            textContent: HomePage_TextContent.Unsupervised_Machine_Learning,
        //            cardIconButton_BuildData: new() {
        //                GenerateIconButtonStateClass("Supervised", "bi bi-person-check", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
        //                GenerateIconButtonStateClass("Unsupervised", "bi bi-person-x",  "primary-color", () => UpdateSelectedCard("Supervised_Card")),
        //                GenerateIconButtonStateClass("Regression", "bi bi-bar-chart-line", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
        //                GenerateIconButtonStateClass("Classification", "bi bi-collection", "primary-color", () => UpdateSelectedCard("Supervised_Card"))
        //                }
        //            ),
        //        new(cardId: "Regression_Card",
        //            cardTitle: "Regression",
        //            textContent: HomePage_TextContent.Regression_Machine_Learning,
        //            cardIconButton_BuildData: new() {
        //                GenerateIconButtonStateClass("Supervised", "bi bi-person-check", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
        //                GenerateIconButtonStateClass("Unsupervised", "bi bi-person-x",  "primary-color", () => UpdateSelectedCard("Supervised_Card")),
        //                GenerateIconButtonStateClass("Regression", "bi bi-bar-chart-line", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
        //                GenerateIconButtonStateClass("Classification", "bi bi-collection", "primary-color", () => UpdateSelectedCard("Supervised_Card"))
        //                }
        //            ),
        //        new(cardId: "Classification_Card",
        //            cardTitle: "Classification",
        //            textContent: HomePage_TextContent.Classification_Machine_Learning,
        //            cardIconButton_BuildData: new() {
        //                GenerateIconButtonStateClass("Supervised", "bi bi-person-check", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
        //                GenerateIconButtonStateClass("Unsupervised", "bi bi-person-x",  "primary-color", () => UpdateSelectedCard("Supervised_Card")),
        //                GenerateIconButtonStateClass("Regression", "bi bi-bar-chart-line", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
        //                GenerateIconButtonStateClass("Classification", "bi bi-collection", "primary-color", () => UpdateSelectedCard("Supervised_Card"))
        //                }
        //            ),
        //    }; 
        //    return NewCardBuildData;
        //}

        /// <summary>
        /// Generate default card
        /// </summary>
        /// <returns>Deafult card State Class</returns>
        //public Card_State_Class<HomePage_TextContentUnpackingClass> Generate_DefaultCard()
        //{
        //    return new(
        //            cardId: "Card_Default",
        //            cardTitle: "Default Card Title",
        //            textContent: HomePage_TextContent.Default_Card,
        //            cardIconButton_BuildData: new() 
        //        );
        //}
    }
}
