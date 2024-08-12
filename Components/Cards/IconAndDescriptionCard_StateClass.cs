using Microsoft.AspNetCore.Components;

namespace MachineLearningApplication_Build_2.Components.Cards
{
    public class IconAndDescriptionCard_StateClass
    {
        public string IconType { get; set; }
        public string IconColor { get; set; }
        public string IconSize { get; set; }
        public string Description { get; set; }

        public IconAndDescriptionCard_StateClass(string IconType, string IconColor, string IconSize, string Description) 
        {
            this.IconType = IconType;
            this.IconColor = IconColor;
            this.IconSize = IconSize;
            this.Description = Description;
        }

    }
}
