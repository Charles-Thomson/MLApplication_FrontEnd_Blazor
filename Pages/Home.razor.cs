using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.NavigationIconButton;
using MachineLearningApplication_Build_2.Components.Cards;
using MachineLearningApplication_Build_2.Services;
using Microsoft.AspNetCore.Components;
using Serilog;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json;
using MachineLearningApplication_Build_2.wwwroot.TextContent;


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

        public List<Navigation_Icon_Button_StateClass> ResourceIconbutton_BuildData { get; set; }
        public Card_State_Class<HomePage_TextContentUnpackingClass> DefaultCard { get; set; }
        public Card_State_Class<HomePage_TextContentUnpackingClass> SelectedCard { get; set; }
        public List<Card_State_Class<HomePage_TextContentUnpackingClass>> CardBuildData { get; set; }


        public Dictionary<string, string>? TextBlocks { get; set; }

        public HomePageTextContent? HomePage_TextContent { get; set; }

        
        public Home() {

            var jsonString = File.ReadAllText("wwwroot/TextContent/HomePage_TextContent.json");
            HomePage_TextContent = JsonSerializer.Deserialize<HomePageTextContent>(jsonString);

            DefaultCard = Generate_DefaultCard();
            CardBuildData = Generate_Card_BuildData();
            ResourceIconbutton_BuildData = Generate_ResourceIconbutton_BuildData();

            SelectedCard = DefaultCard;            
        }

        /// <summary>
        /// Update the displayed Card 
        /// </summary>
        /// <param name="NewCardId">ID of the new Card to be displayed</param>
        public void UpdateSelectedCard(string NewCardId)
        {
            Console.WriteLine($"CallBack recieved with {NewCardId}");
           
            SelectedCard = CardBuildData.FirstOrDefault(p => p.CardId == NewCardId) ?? DefaultCard; ;
            StateHasChanged();
        }

        public void NavigateTo(string url) => NavigationManager?.NavigateTo(url);
        

        private Navigation_Icon_Button_StateClass GenerateIconButtonStateClass(string Title, string Icon, string IconColor, Action OnClickCallBack) {
            return new Navigation_Icon_Button_StateClass(
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
        public List<Navigation_Icon_Button_StateClass> Generate_ResourceIconbutton_BuildData() {

            List<Navigation_Icon_Button_StateClass> New_ResourceIconbutton_BuildData = new() {
                GenerateIconButtonStateClass("Supervised", "bi bi-person-check", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                GenerateIconButtonStateClass("Unsupervised", "bi bi-person-x",  "primary-color", () => UpdateSelectedCard("Unsupervised_Card")),
                GenerateIconButtonStateClass("Regression", "bi bi-bar-chart-line", "primary-color", () => UpdateSelectedCard("Regression_Card")),
                GenerateIconButtonStateClass("Classification", "bi bi-collection", "primary-color", () => UpdateSelectedCard("Classification_Card")),
            };

            return New_ResourceIconbutton_BuildData;
        }


        /// <summary>
        /// Generate State Classes to store Card data
        /// </summary>
        /// <returns>List of new Card State Objects</returns>
        public List<Card_State_Class<HomePage_TextContentUnpackingClass>> Generate_Card_BuildData()
        {

            List<Card_State_Class<HomePage_TextContentUnpackingClass>> NewCardBuildData = new() {
                new(cardId: "Supervised_Card",
                    cardTitle: "Supervised Learning (SL)",
                    cardDescriptionText: "Holder",
                    textContent: HomePage_TextContent.Unsupervised_Machine_Learning,
                    cardIconButton_BuildData: new() {
                        GenerateIconButtonStateClass("Supervised", "bi bi-person-check", "primary-color", () => UpdateSelectedCard("Supervised_Card") ),
                        GenerateIconButtonStateClass("Unsupervised", "bi bi-person-x",  "primary-color", () => UpdateSelectedCard("Supervised_Card") ),
                        GenerateIconButtonStateClass("Regression", "bi bi-bar-chart-line", "primary-color", () => UpdateSelectedCard("Supervised_Card") ),
                        GenerateIconButtonStateClass("Classification", "bi bi-collection", "primary-color", () => UpdateSelectedCard("Supervised_Card") )
                        }
                    ),

                new(cardId: "Unsupervised_Card",
                    cardTitle: "Unsupervised Learning (UL)",
                    cardDescriptionText: "Description text",
                    textContent: HomePage_TextContent.Unsupervised_Machine_Learning,
                    cardIconButton_BuildData: new() {
                        GenerateIconButtonStateClass("Supervised", "bi bi-person-check", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                        GenerateIconButtonStateClass("Unsupervised", "bi bi-person-x",  "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                        GenerateIconButtonStateClass("Regression", "bi bi-bar-chart-line", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                        GenerateIconButtonStateClass("Classification", "bi bi-collection", "primary-color", () => UpdateSelectedCard("Supervised_Card"))
                        }
                    ),
                new(cardId: "Regression_Card",
                    cardTitle: "Regression",
                    cardDescriptionText: "Description text",
                    textContent: HomePage_TextContent.Unsupervised_Machine_Learning,
                    cardIconButton_BuildData: new() {
                        GenerateIconButtonStateClass("Supervised", "bi bi-person-check", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                        GenerateIconButtonStateClass("Unsupervised", "bi bi-person-x",  "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                        GenerateIconButtonStateClass("Regression", "bi bi-bar-chart-line", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                        GenerateIconButtonStateClass("Classification", "bi bi-collection", "primary-color", () => UpdateSelectedCard("Supervised_Card"))
                        }
                    ),
                new(cardId: "Classification_Card",
                    cardTitle: "Classification",
                    cardDescriptionText: "Description text",
                    textContent: HomePage_TextContent.Unsupervised_Machine_Learning,
                    cardIconButton_BuildData: new() {
                        GenerateIconButtonStateClass("Supervised", "bi bi-person-check", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                        GenerateIconButtonStateClass("Unsupervised", "bi bi-person-x",  "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                        GenerateIconButtonStateClass("Regression", "bi bi-bar-chart-line", "primary-color", () => UpdateSelectedCard("Supervised_Card")),
                        GenerateIconButtonStateClass("Classification", "bi bi-collection", "primary-color", () => UpdateSelectedCard("Supervised_Card"))
                        }
                    ),
            }; 
            return NewCardBuildData;
        }

        /// <summary>
        /// Generate default card
        /// </summary>
        /// <returns>Deafult card State Class</returns>
        public Card_State_Class<HomePage_TextContentUnpackingClass> Generate_DefaultCard()
        {
            return new(
                    cardId: "Card_Default",
                    cardTitle: "Default Card Title",
                    cardDescriptionText: "Default",
                    textContent: HomePage_TextContent.Unsupervised_Machine_Learning,
                    cardIconButton_BuildData: new() 
                );
        }
    }
}
