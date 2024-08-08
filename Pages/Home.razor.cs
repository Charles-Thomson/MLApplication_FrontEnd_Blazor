using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.NavigationIconButton;
using MachineLearningApplication_Build_2.Components.Cards;
using MachineLearningApplication_Build_2.Services;
using Microsoft.AspNetCore.Components;
using Serilog;
using System.CodeDom.Compiler;
using System.Collections.Generic;

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

        public Card_State_Class DefaultCard { get; set; }
        public Card_State_Class SelectedCard { get; set; }
        public List<Card_State_Class> CardBuildData { get; set; }

        public Home() {
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
            Card_State_Class NewCard = CardBuildData.FirstOrDefault(p => p.CardId == NewCardId);

            if (NewCard == null)
            {
                SelectedCard = DefaultCard;
                return;
            }
            SelectedCard = NewCard;
            StateHasChanged();
        }

        public void NavigateTo(string url) {
            NavigationManager.NavigateTo(url);
        }

        
        public void CallBackTest()
        {
            Console.WriteLine("CallBack recieved");

        }

        /// <summary>
        /// Generate the State Classes to store Icon Button data
        /// </summary>
        /// <returns>List of new Icon Button State objects</returns>
        public List<Navigation_Icon_Button_StateClass> Generate_ResourceIconbutton_BuildData() {

            List<Navigation_Icon_Button_StateClass> New_ResourceIconbutton_BuildData = new() {
                new Navigation_Icon_Button_StateClass(button_Title:"Supervised",     button_Icon:"bi bi-person-check",   button_Icon_Color:"primary-color", onClickCallBack: () => UpdateSelectedCard("Supervised_Card")),
                new Navigation_Icon_Button_StateClass(button_Title:"Unsupervised",   button_Icon:"bi bi-person-x",       button_Icon_Color:"primary-color", onClickCallBack: () => UpdateSelectedCard("Unsupervised_Card")),
                new Navigation_Icon_Button_StateClass(button_Title:"Regression",     button_Icon:"bi bi-bar-chart-line", button_Icon_Color:"primary-color", onClickCallBack: () => UpdateSelectedCard("Regression_Card")),
                new Navigation_Icon_Button_StateClass(button_Title:"Classification", button_Icon:"bi bi-collection",     button_Icon_Color:"primary-color", onClickCallBack: () => UpdateSelectedCard("Classification_Card"))
            };

            return New_ResourceIconbutton_BuildData;
        }


        /// <summary>
        /// Generate State Classes to store Card data
        /// </summary>
        /// <returns>List of new Card State Objects</returns>
        public List<Card_State_Class> Generate_Card_BuildData()
        {

            List<Card_State_Class> NewCardBuildData = new() {
                new(CardId: "Supervised_Card",
                    CardTitle: "Supervised Learning (SL)",
                    CardDescriptionText: "Description text",
                    CardIconButton_BuildData: new() {
                        new Navigation_Icon_Button_StateClass(button_Title: "Supervised", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Supervised", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Supervised", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Supervised", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest)
                        }
                    ),

                new(CardId: "Unsupervised_Card",
                    CardTitle: "Unsupervised Learning (UL)",
                    CardDescriptionText: "Description text",
                    CardIconButton_BuildData: new() {
                        new Navigation_Icon_Button_StateClass(button_Title: "Unsupervised", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Unsupervised", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Unsupervised", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Unsupervised", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest)
                        }
                    ),
                new(CardId: "Regression_Card",
                    CardTitle: "Regression",
                    CardDescriptionText: "Description text",
                    CardIconButton_BuildData: new() {
                        new Navigation_Icon_Button_StateClass(button_Title: "Regression", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Regression", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Regression", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Regression", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest)
                        }
                    ),
                new(CardId: "Classification_Card",
                    CardTitle: "Classification",
                    CardDescriptionText: "Description text",
                    CardIconButton_BuildData: new() {
                        new Navigation_Icon_Button_StateClass(button_Title: "Classification", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Classification", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Classification", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest),
                        new Navigation_Icon_Button_StateClass(button_Title: "Classification", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color", onClickCallBack: CallBackTest)
                        }
                    ),
            }; 
            return NewCardBuildData;
        }

        /// <summary>
        /// Generate default card
        /// </summary>
        /// <returns>Deafult card State Class</returns>
        public Card_State_Class Generate_DefaultCard()
        {
            return new(
                    CardId: "Card_Default",
                    CardTitle: "Default Card",
                    CardDescriptionText: "Description text",
                    CardIconButton_BuildData: new() {}
                );
        }
    }
}
