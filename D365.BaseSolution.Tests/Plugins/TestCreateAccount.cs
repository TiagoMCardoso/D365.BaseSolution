extern alias d365plugins;
using System;
using System.Linq;

using Xunit;
using FakeXrmEasy;

using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using d365plugins.D365.BaseSolution.Plugins;
using d365plugins::D365.BaseSolution.Base.Entities;

namespace D365.BaseSolution.Tests
{
    public class TestCreateAccount : Common.BaseClass
    {
        private Account account;
        XrmFakedPluginExecutionContext pluginContext;

        private Guid accountId = new Guid("5125f555-8111-ea11-a811-000d3a795fd4");

        private void CreateTestContext()
        {
            account = new Account
            {
                Id = accountId,
                Name = "Account ABC"
            };
        }

        private void CreatePluginContext()
        {
            ParameterCollection inputParameters = new ParameterCollection();
            inputParameters.Add("Target", account);

            pluginContext = fakedContext.GetDefaultPluginContext();
            pluginContext.MessageName = "Create";
            pluginContext.InputParameters = inputParameters;

            // Initialize data that are required for the plugin execution, we need to have it into the context in order to create the contact record inside the plugin
            fakedContext.Initialize(new List<Entity> { account });
        }

        [Fact]
        private void Success()
        {
            CreateTestContext();
            CreatePluginContext();

            fakedContext.ExecutePluginWith<CreateAccount>(pluginContext);

            var contact = (from c in fakedContext.CreateQuery<Contact>()
                           where c.ParentCustomerId != null && c.ParentCustomerId.Id == accountId
                           select c).FirstOrDefault();

            // if contact contains data, it means that plugin has ran successfuly
            Assert.True(contact != null);
        }

        //[Fact]
        //private void Error()
        //{
        //    CreateTestContext();

        //    //Break the code to get an error
        //    account.Id = new Guid("00000000-8111-ea11-a811-000d3a795fd4");

        //    CreatePluginContext();

        //    fakedContext.ExecutePluginWith<CreateAccount>(pluginContext);

        //    var contact = (from c in fakedContext.CreateQuery<Contact>()
        //                   where c.ParentCustomerId != null && c.ParentCustomerId.Id == accountId
        //                   select c).FirstOrDefault();

        //    // if contact DOESN'T contains data, it means that plugin HASN'T ran successfully, but that's what you are looking for here
        //    Assert.True(contact != null);

        //    //Assert.Throws<InvalidPluginExecutionException>(() => fakedContext.ExecutePluginWith<CreateAccount>(pluginContext));
        //}
    }
}