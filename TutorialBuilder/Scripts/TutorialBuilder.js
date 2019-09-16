class Tutorial {
    constructor(selector, steps) {
        this.steps = steps;
        this.currentStep = 0;
        $(selector).on('click', function () { this.Next(); });
    }
    Next() {
        if (currentStep > 0) {
            $(steps[currentStep - 1].Selector).popover('dispose');
        }
        var step = steps[currentStep];
        if (!step)
            return;

        currentStep++;
        var htmlText = "<p>" + step.Text + "</p>";
        htmlText += '<button id="endTutorialButton" class="btn btn-secondary float-left" onclick="EndTutorial()">End</button>';
        if (steps[currentStep])
            htmlText += '<button id="nextTutorialStepButton" class="btn btn-primary float-right">Next</button>';
        var titleText = '';
        if (step.Title)
            titleText = step.Title;
        var options = {
            content: htmlText,
            placement: 'auto',
            title: titleText,
            trigger: 'manual',
            html: true,
            sanitize: false
        }
        var target = $(step.Selector);
        target.popover(options);
        target.popover('show');
        target.focus();
        $('#nextTutorialStepButton').on('click', function () { this.Next(); });
        $('#endTutorialButton').on('click', function () { this.End(); });
    }
    End() {
        if (stepCount > 0)
            $(stepTargets[stepCount - 1].selector).popover('dispose');
        stepCount = 0;
    }
}