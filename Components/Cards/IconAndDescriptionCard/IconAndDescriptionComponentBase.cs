using Microsoft.AspNetCore.Components;

namespace MachineLearningApplication_Build_2.Components.Cards.IconAndDescriptionCard
{
    public interface IconAndDescriptionComponentBase {
        string IconType { get; set; }

        string IconColor { get; set; }

        string IconSize { get; set; }

        string Description { get; set; }
    }
}
