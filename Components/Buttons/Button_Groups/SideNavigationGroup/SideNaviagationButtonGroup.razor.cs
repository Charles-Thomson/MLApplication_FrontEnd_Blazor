
using MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual.ResourceIconButton;
using Microsoft.AspNetCore.Components;



namespace MachineLearningApplication_Build_2.Components.Buttons.Button_Groups.SideNavigationGroup
{
    public partial class SideNaviagationButtonGroup
    {
        [Parameter] public required List<ResourceIconButton_StateClass> BuildData { get; set; }   
    }
}
