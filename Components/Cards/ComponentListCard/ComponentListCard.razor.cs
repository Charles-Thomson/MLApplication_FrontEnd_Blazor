using MachineLearningApplication_Build_2.Components.Cards.IconAndDescriptionCard;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.Cards.ComponentListCard
{
    public partial class ComponentListCard
    {

        [Parameter] required public string CardId { get; set; }

        [Parameter] required public string CardTitle { get; set; }

        [Parameter] required public List<IconAndDescriptionStateClass> StateClass { get; set; }
        
    }
}
