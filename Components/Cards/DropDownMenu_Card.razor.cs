using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.Cards
{
    public partial class DropDownMenu_Card
    {
        

        [Parameter] public Card_State_Class? CardBuildData { get; set; }
        public DropDownMenu_Card()
        {

        }
    }
}
