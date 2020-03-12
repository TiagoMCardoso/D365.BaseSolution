using FakeXrmEasy;

namespace D365.BaseSolution.Tests.Common
{
    public abstract class BaseClass
    {
        public XrmFakedContext fakedContext { get; private set; }

        protected BaseClass()
        {
            fakedContext = new XrmFakedContext();
        }
    }
}
