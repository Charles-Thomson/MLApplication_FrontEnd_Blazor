function addHoverEffect(triggerElementId, targetElementId) {
    var triggerElement = document.getElementById(triggerElementId);
    var targetElement = document.getElementById(targetElementId);

    if (triggerElement && targetElement) {
        triggerElement.addEventListener('mouseover', function () {
            targetElement.style.opacity = '0.5';
            targetElement.style.transition = 'opacity 4s';
        });

        triggerElement.addEventListener('mouseout', function () {
            targetElement.style.opacity = '1';
        });
    }
}