var BaseSolution = window.BaseSolution || {};
(function () {
    this.preferredcontactmethodcodeOnChange = function (executionContext) {
        var formContext = executionContext.getFormContext();

        var preferredcontactmethodcode = formContext.getAttribute("preferredcontactmethodcode");
        var telephone1 = formContext.getAttribute("telephone1");

        if (telephone1 != null) {
            // Set Business Phone optional
            telephone1.setRequiredLevel("none");

            if (preferredcontactmethodcode != null && preferredcontactmethodcode.getValue() == 3) {
                // Set Business Phone required
                telephone1.setRequiredLevel("required");
            }
        }
    }
}).call(BaseSolution);