namespace MachineLearningApplication_Build_2.Layouts
{
    public partial class MainLayout
    {
        private bool IsNavMenuVisable { get; set; } = false;
        string NavMenuVisableStyle => IsNavMenuVisable ? "" : "display: none";

        public void ToggelNavMenuVisbaility() => IsNavMenuVisable = !IsNavMenuVisable;

        /*<div class="nav-menu @(isNavMenuOpen ? "open" : "closed")">*/

    }
}
