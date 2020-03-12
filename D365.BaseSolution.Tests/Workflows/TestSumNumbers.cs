extern alias d365workflows;
using System;

using Xunit;
using FakeXrmEasy;

using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using d365workflows.D365.BaseSolution.Workflows;
using d365workflows::D365.BaseSolution.Base.Entities;

namespace D365.BaseSolution.Tests.Workflows
{
    public class TestSumNumbers : Common.BaseClass
    {
        private decimal num1;
        private decimal num2;

        [Fact]
        private void Success()
        {
            num1 = new Decimal(5);
            num2 = new Decimal(7);

            var inputsParams = new Dictionary<string, object>() {
                      { "Number1", num1 },
                      { "Number2", num2 }
                };

            var results = fakedContext.ExecuteCodeActivity<SumNumbers>(inputsParams);

            Assert.Equal("12", results["Result"].ToString());
        }

        //[Fact]
        //private void Error()
        //{
        //    num1 = new Decimal(5);
        //    num2 = new Decimal(7);

        //    var inputsParams = new Dictionary<string, object>() {
        //              { "Number1", num1 },
        //              { "Number2", num2 }
        //        };

        //    var results = fakedContext.ExecuteCodeActivity<SumNumbers>(inputsParams);

        //    Assert.Equal("99", results["Result"].ToString());
        //}
    }
}
