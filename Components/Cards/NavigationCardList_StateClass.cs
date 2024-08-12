namespace MachineLearningApplication_Build_2.Components.Cards
{
    public class NavigationCardList_StateClass
    {
        public string CardId { get; set; }

        public string CardTitle { get; set; }
        public  List<IconAndDescriptionCard_StateClass> IconAndDescriptionCard_StateClasses { get; set; }

        public NavigationCardList_StateClass(List<IconAndDescriptionCard_StateClass> iconAndDescriptionCard_StateClasses, string cardId, string cardTitle = null)
        {
            CardId = cardId;
            IconAndDescriptionCard_StateClasses = iconAndDescriptionCard_StateClasses;
            CardTitle = cardTitle;
        }


    }
}
