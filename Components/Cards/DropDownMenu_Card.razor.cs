using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineLearningApplication_Build_2.wwwroot.TextContent;


namespace MachineLearningApplication_Build_2.Components.Cards
{
    public partial class DropDownMenu_Card<T>
    {
        [Parameter] public required Card_State_Class<T> CardBuildData { get; set; }

        private HomePage_TextContentUnpackingClass? TextContentAsHomePageTextContentUnpackingClass
        {
            get
            {
                if (CardBuildData.TextContent is object textContent)
                {
                    return (HomePage_TextContentUnpackingClass?)textContent;
                }
                return null;
            }
        }

    }
}
