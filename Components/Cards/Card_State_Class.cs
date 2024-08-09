using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.NavigationIconButton;

namespace MachineLearningApplication_Build_2.Components.Cards
{
    public class Card_State_Class<T> 
    {
        public string CardId { get; set; }
        public string CardTitle { get; set; } 

        public string? CardDescriptionText { get; set; }

        public T? TextContent { get; set; } 

        public List<Navigation_Icon_Button_StateClass>? CardIconButton_BuildData { get; set; } 


        public Card_State_Class(
                            string cardId,
                            string cardTitle,
                            string cardDescriptionText,
                            T textContent,
                            List<Navigation_Icon_Button_StateClass> cardIconButton_BuildData)
        {

            CardId = cardId;
            CardTitle = cardTitle;
            CardDescriptionText = cardDescriptionText;
            TextContent = textContent;
            CardIconButton_BuildData = cardIconButton_BuildData;



        }
    }
}
