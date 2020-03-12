using System;
using System.Activities;
using Microsoft.Xrm.Sdk.Workflow;
using D365.BaseSolution.Base.Workflows;

namespace D365.BaseSolution.Workflows
{
    public class SumNumbers : BaseClass
    {
        [Input("Number1")]
        [RequiredArgument]
        public InArgument<Decimal> Number1 { get; set; }

        [Input("Number2")]
        [RequiredArgument]
        public InArgument<Decimal> Number2 { get; set; }

        [Output("Result")]
        public OutArgument<Decimal> Result { get; set; }

        public override void ExecuteWorkflow()
        {
            tracingService.Trace("Starting custom workflow {0}", className);

            try
            {
                // TO DO: Add your business logic here

                // *** Sample ***

                var num1 = this.Number1.Get(context);
                var num2 = this.Number2.Get(context);

                Result.Set(context, (num1 + num2));

                // *** End Sample ***
            }
            catch (Exception ex)
            {
                tracingService.Trace("Exception: {0}", ex.Message);

                throw new InvalidWorkflowException(ex.Message);
            }

            tracingService.Trace("Finished custom workflow {0}", className);
        }

    }
}
