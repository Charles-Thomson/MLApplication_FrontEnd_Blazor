namespace MachineLearningApplication_Build_2.Components.Cards.IconAndDescriptionCard
{
    public class IconAndDescriptionStateClass
    {
        public string IconAndDescriptionCardType { get; set; }
        public string IconType { get; set; }
        public string IconColor { get; set; }
        public string IconSize { get; set; }
        public string Description { get; set; }

        public IconAndDescriptionStateClass(string IconAndDescriptionCardType, string IconType, string IconColor, string IconSize, string Description)
        {
            this.IconAndDescriptionCardType = IconAndDescriptionCardType;
            this.IconType = IconType;
            this.IconColor = IconColor;
            this.IconSize = IconSize;
            this.Description = Description;
        }
    }
}
