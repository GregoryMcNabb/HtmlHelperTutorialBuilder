class Tutorial {
    constructor(selector, steps) {
        this.steps = steps;
        this.currentStep = 0;
        self = this;
        $(selector).on('click', function () {
            self.Next(self);
        });
    }

    Next(self) {
        if (self.currentStep > 0) {
            $(self.steps[self.currentStep - 1].Selector).popover('dispose');
        }
        var step = self.steps[self.currentStep];
        if (!step)
            return;
        
        self.currentStep++;
        var htmlText = "<p>" + step.Text + "</p>";
        htmlText += '<button id="endTutorialButton" class="btn btn-secondary float-left">End</button>';
        if (self.steps[self.currentStep])
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
        $('#nextTutorialStepButton').on('click', function(){ self.Next(self);});
        $('#endTutorialButton').on('click', function () { self.End(self); });
    }
    End(self) {
        if (self.currentStep > 0) {
            $(self.steps[self.currentStep - 1].Selector).popover('dispose');
        }
        self.currentStep = 0;
    }
}