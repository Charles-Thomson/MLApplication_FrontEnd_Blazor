using Microsoft.AspNetCore.Components;

namespace MachineLearningApplication_Build_2.Components.Cards.ComponentListCard
{
    public class ComponentListCardStateClass
    {
        [Parameter] public required string CardId { get; set; }

        [Parameter] public required string CardTitle { get; set; }

        [Parameter] public required List<RenderFragment> RenderfragmentList { get; set; }


    }
}
