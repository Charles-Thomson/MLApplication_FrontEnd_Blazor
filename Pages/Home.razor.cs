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
        public string Supervised_Learning_Card_Content { get; private set; } = "Supervised Learning (SL) takes a defined input set and desiered output to train a model ...";
        public string Unsupervised_Learning_Card_Content { get; private set; } = "Unsupervised Learnming (ML) takes a unlabeled data to train a model to deisearn patterns and insights ...";
        public string Regression_Card_Content { get; private set; } = "Regression takes a set of input data and known outpus to train a model to determain the outcome of future input sets ...";
        public string Classification_Learning_Card_Content { get; private set; } = "Classification trains a model to desearn input data into a numebr of pre defined clasifications ...";

        public Card_State_Class ExampleCard { get; set; }


        public Home() {
            ExampleCard = GenerateCards();
        }

        public Card_State_Class GenerateCards() {
            Card_State_Class new_card_state_class = new();
            new_card_state_class.CardId = "Card_1";
            new_card_state_class.CardTitle = "Supervised Learning (SL)";
            new_card_state_class.CardDescriptionText = "Description text";

            List<Navigation_Icon_Button_StateClass> IconButtons_BuildData = new() {
                new Navigation_Icon_Button_StateClass(button_Title: "Classification", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color"),
                new Navigation_Icon_Button_StateClass(button_Title: "Classification", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color"),
                new Navigation_Icon_Button_StateClass(button_Title: "Classification", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color"),
                new Navigation_Icon_Button_StateClass(button_Title: "Classification", button_Icon: "bi bi-collection", button_Icon_Color: "primary-color")


            };

            new_card_state_class.CardIconButton_BuildData = IconButtons_BuildData;

            return new_card_state_class;


        }
    }
}
