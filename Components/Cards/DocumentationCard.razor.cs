using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.Cards
{
    public partial class DocumentationCard
    {

        [Parameter] public string? Card_Title { get; set; }

        [Parameter] public string? Card_Body_Text { get; set; }
        public DocumentationCard()
        {

        }
    }
}
