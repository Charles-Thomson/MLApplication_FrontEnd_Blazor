﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MachineLearningApplication_Build_2.Components.Cards.IconAndDescriptionCard
{
    public partial class IconAndDescriptionHorizontal : IconAndDescriptionComponentBase
    {

        [Parameter] required public string IconType { get; set; }

        [Parameter] required public string IconColor { get; set; }

        [Parameter] required public string IconSize { get; set; }

        [Parameter] required public string Description { get; set; }

        [Parameter] required public Action OnClickCallBack { get; set; }

        public void HandleOnClickCallBack() {
            OnClickCallBack.Invoke();
        }



    }
}
