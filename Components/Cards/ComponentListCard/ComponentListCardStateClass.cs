using MachineLearningApplication_Build_2.Components.Cards.IconAndDescriptionCard;
using Microsoft.AspNetCore.Components;

namespace MachineLearningApplication_Build_2.Components.Cards.ComponentListCard
{
    public class ComponentListCardStateClass
    {
        [Parameter] public  string CardId { get; set; }

        [Parameter] public  string CardTitle { get; set; }

        [Parameter] public  List<IconAndDescriptionStateClass> StateClass { get; set; }


        public ComponentListCardStateClass(string cardId, string cardTitle, List<IconAndDescriptionStateClass> stateClass) 
        { 
            CardId = cardId;
            CardTitle = cardTitle;
            StateClass = stateClass;
        }


    }
}
