using Microsoft.AspNetCore.Components;

namespace MachineLearningApplication_Build_2.Components.Buttons.Buttons_Individual
{
    public class IconButtonDropDownStateClass
    {
        /// <summary>
        /// Button Data
        /// </summary>
        public string? Icon { get; set; }
        public string? IconColor { get; set; }
        public string? IconSize { get; set; }
        public string? ButtonText {get; set;}

        /// <summary>
        /// DropDown Content Data
        /// </summary>

        public RenderFragment DropDownContent { get; set; } /// Whill be changed to a build element


    }
}
