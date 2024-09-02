using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
using MachineLearningApplication_Build_2.Components.Cards.ComponentListCard;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MachineLearningApplication_Build_2.Enums.EnvironmentNodeEnums;


namespace MachineLearningApplication_Build_2.Components.SubPages.SideBarMenuGroupSubPages.ReinforcementLearning
{
    public partial class EnvironmentSubPage
    {
        [Parameter] required public string PageTitle { get; set; }

        private IconButtonStateClass GenerateIconButtonStateClass(string Title, string Icon, string IconColor, Action? OnClickCallBack = null)
        {
            return new IconButtonStateClass(
                    ButtonTitle: Title,
                    ButtonIcon: Icon,
                    ButtonIconColor: IconColor,
                    OnClickCallBack: OnClickCallBack
                );
        }


        public EnvironmentSubPage() {


            ButtonBuildData = new List<IconButtonStateClass>() {
                GenerateIconButtonStateClass("Start","bi bi-caret-right","green",() =>  UpdateNodeSelectionValue(NodeStateEnums.Start)),
                GenerateIconButtonStateClass("Goal","bi bi-trophy","green",() =>  UpdateNodeSelectionValue(NodeStateEnums.Goal)),
                GenerateIconButtonStateClass("Obstical","i bi-radioactive","green",() =>  UpdateNodeSelectionValue(NodeStateEnums.Obstical)),
                GenerateIconButtonStateClass("Empty","bi bi-square","green",() =>  UpdateNodeSelectionValue(NodeStateEnums.Empty)),


            };
        }

        public List<IconButtonStateClass> ButtonBuildData { get; set; }




    public void UpdateNodeSelectionValue(NodeStateEnums newNodeStateValue) {
            Console.WriteLine($"Updating the node statre value : {newNodeStateValue}");
            stateContainer.NodeSelectionValue = newNodeStateValue;
        }

        public List<string> EmvironmentDimensionOptions = new List<string>
        {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"
        };
    }
}
