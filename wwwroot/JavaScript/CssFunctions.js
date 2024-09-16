function hoverEffect_Opacity_subPageContent(triggerElementId, targetElementId) {
    var triggerElement = document.getElementById(triggerElementId);
    var targetElement = document.getElementById(targetElementId);

    if (triggerElement && targetElement) {
        triggerElement.addEventListener('mouseover', function () {
            targetElement.style.opacity = '0.5';
            targetElement.style.transition = 'opacity 4s';

            
        });

        triggerElement.addEventListener('mouseout', function () {
            targetElement.style.opacity = '1';
            targetElement.style.background = 'opacity 4s';
            
        });
    }
}

function hoverEffect_Opacity_toolTipText(triggerElementId, targetElementId) {
    var triggerElement = document.getElementById(triggerElementId);
    var targetElement = document.getElementById(targetElementId);

    if (triggerElement && targetElement) {
        triggerElement.addEventListener('mouseover', function () {
            targetElement.style.opacity = '1';
            targetElement.style.transition = 'opacity 6s';


        });

        triggerElement.addEventListener('mouseout', function () {
            targetElement.style.opacity = '0';
            targetElement.style.transition = 'opacity 1s';

        });
    }
}


function hoverEffect_BackgroundGradient(triggerElementId, targetElementId) {
    var triggerElement = document.getElementById(triggerElementId);
    var targetElement = document.getElementById(targetElementId);

    if (triggerElement && targetElement) {

        targetElement.style.transition = 'background 4s';
        targetElement.style.transition = 'boxShadow 2s';
        triggerElement.addEventListener('mouseover', function () {
            targetElement.style.background = 'linear-gradient(to right, whitesmoke, white)';
            targetElement.style.boxShadow = '0px 8px 30px rgba(0, 0, 0, 0.15)'; 
        });

        triggerElement.addEventListener('mouseout', function () {
            targetElement.style.background = 'white';
            targetElement.style.boxShadow = '0px 0px 0px rgba(0, 0, 0, 0.1)'; 
        });
    }
}

function hoverEffect_WidthTransition(triggerElementId, targetElementId) {
    var triggerElement = document.getElementById(triggerElementId);
    var targetElement = document.getElementById(targetElementId);

    if (triggerElement && targetElement) {
        triggerElement.addEventListener('mouseover', function () {


            targetElement.style.width = '12rem';
            targetElement.style.transition = 'width 2s';
        });

        triggerElement.addEventListener('mouseout', function () {
            targetElement.style.width = '3rem';
            targetElement.style.transition = 'width 2s';
        });
    }
}