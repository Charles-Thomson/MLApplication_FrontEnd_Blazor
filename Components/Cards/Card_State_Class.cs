using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.NavigationIconButton;

namespace MachineLearningApplication_Build_2.Components.Cards
{
    public class Card_State_Class
    {
        public string? CardId { get; set; }
        public string? CardTitle { get; set; }

        public string? CardDescriptionText { get; set;}

        public List<Navigation_Icon_Button_StateClass>? CardIconButton_BuildData { get; set; }

    }
}
