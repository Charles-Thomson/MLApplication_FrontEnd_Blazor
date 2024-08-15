using MachineLearningApplication_Build_2.Components.Buttons.ButtonStateClasses;
using Microsoft.AspNetCore.Components;



namespace MachineLearningApplication_Build_2.Components.Buttons.Button_Groups.SideNavigationGroup
{
    public partial class SideNaviagationButtonGroup
    {
        [Parameter] public required List<IconButtonStateClass> BuildData { get; set; }   
    }
}
