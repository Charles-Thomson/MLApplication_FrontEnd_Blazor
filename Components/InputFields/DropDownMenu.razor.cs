using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.InputFields
{
    public partial class DropDownMenu
    {
        [Parameter] required public List<string> DropDownOptions { get; set; }

        [Parameter] public string? LabelText { get; set; }
        [Parameter] public string? BindValue { get; set; }

        [Parameter] public EventCallback<string> ValueChangedCallBack { get; set; }


        private async Task OnValueChanged(ChangeEventArgs e)
        {
            BindValue = e.Value?.ToString();
            await ValueChangedCallBack.InvokeAsync(BindValue);
        }
    }
}
