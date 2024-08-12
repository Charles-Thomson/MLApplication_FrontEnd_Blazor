using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.NavigationIconButton;

namespace MachineLearningApplication_Build_2.Components.Cards
{
    public class Card_State_Class<T> 
    {
        public string CardId { get; set; }
        public string CardTitle { get; set; } 
        public T? TextContent { get; set; } 

        public List<NavigationIconButton_StateClass>? CardIconButton_BuildData { get; set; } 


        public Card_State_Class(
                            string cardId,
                            string cardTitle,
                            
                            T? textContent,
                            List<NavigationIconButton_StateClass> cardIconButton_BuildData)
        {
            CardId = cardId;
            CardTitle = cardTitle;
            
            TextContent = textContent;
            CardIconButton_BuildData = cardIconButton_BuildData;
        }
    }
}
