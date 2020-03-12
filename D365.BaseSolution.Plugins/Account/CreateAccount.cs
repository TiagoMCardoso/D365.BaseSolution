using System;
using D365.BaseSolution.Base.Entities;
using D365.BaseSolution.Base.Plugins;
using Microsoft.Xrm.Sdk;
using System.Linq;

namespace D365.BaseSolution.Plugins
{
    public class CreateAccount : BaseClass
    {
        public override void ExecutePlugin()
        {
            tracingService.Trace("Starting plugin {0}", className);

            try
            {
                if (entity != null)
                {
                    // Obtain the target entity from the input parameters.  
                    Account account = entity.ToEntity<Account>();

                    // *** Samples ***

                    // *** Create

                    Contact c = new Contact()
                    {
                        FirstName = "Test",
                        LastName = "123",
                        ParentCustomerId = entity.ToEntityReference()
                    };

                    service.Create(c);

                    //// *** Update

                    //Contact contact = new Contact()
                    //{
                    //    Id = new Guid("00000000-0000-0000-0000-000000000000"), // Inform a valid GUID
                    //    FirstName = "Test",
                    //    LastName = "123"
                    //};

                    //service.Update(contact);

                    //// *** Delete

                    //service.Delete(Contact.EntityLogicalName, new Guid("00000000-0000-0000-0000-000000000000")); // Inform a valid GUID

                    //// *** Retrieve

                    //var accounts = (from e in svcContext.AccountSet
                    //                where e.Id == new Guid("00000000-0000-0000-0000-000000000000") // Inform a valid GUID
                    //                select e);

                    // *** End Samples ***
                }
            }
            catch (Exception ex)
            {
                tracingService.Trace("Exception: {0}", ex.Message);

                throw new InvalidPluginExecutionException(ex.Message);
            }
            finally
            {
                tracingService.Trace("Finished plugin {0}", className);
            }
        }
    }
}