using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Components;
using System.Security.Principal;

namespace MachineLearningApplication_Build_2.Components.Buttons.Button_SVGs
{
    public class TopBarButton_SVGs
    {
        private string NavigationMenuDropDownSVG_String = "";


     
        private RenderFragment GetSVGRenderFragment(string svgString) => builder =>
        {
            builder.AddMarkupContent(0, svgString);
        };



        public RenderFragment NavigationMenuDropDownSVG => GetSVGRenderFragment(GetNavigationMenuDropDownSVG_string());


        private string GetNavigationMenuDropDownSVG_string() {
            return "<svg width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-list\" viewBox=\"0 0 16 16\">\r\n  <path fill-rule=\"evenodd\" d=\"M2.5 12a.5.5 0 0 1 .5-.5h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5m0-4a.5.5 0 0 1 .5-.5h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5m0-4a.5.5 0 0 1 .5-.5h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5\"/>\r\n</svg>";


        }


    }
}
