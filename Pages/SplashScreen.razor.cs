using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Pages
{
    public partial class SplashScreen
    {
        [Inject]
        public required NavigationManager NavigationManager { get; set; }

        //public SplashScreen()
        //{
        //    SplashScreenDelayHandler();
        //}

        //protected override async Task OnInitializedAsync()
        //{
        //    await SplashScreenDelayHandler();
        //}

        protected override async void OnAfterRender(bool firstRender)
        {
            
            await SplashScreenDelayHandler();
            

        }

        private async Task SplashScreenDelayHandler()
        {
            await Task.Delay(3000);
            NavigationManager.NavigateTo("/home");
        }

    }
}
