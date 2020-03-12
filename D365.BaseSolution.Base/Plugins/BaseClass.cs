using System;
using D365.BaseSolution.Base.Entities;
using Microsoft.Xrm.Sdk;

namespace D365.BaseSolution.Base.Plugins
{
    public abstract class BaseClass : IPlugin
    {
        private const string preImageName = "preImage";
        private const string postImageName = "postImage";

        public IOrganizationService service { get; private set; }
        public IPluginExecutionContext context { get; private set; }
        public IOrganizationServiceFactory serviceFactory { get; private set; }
        public CrmServiceContext svcContext { get; private set; }
        public ITracingService tracingService { get; private set; }
        public Entity entity { get; private set; }
        public Entity preEntityImage { get; private set; }
        public bool preEntityImageAvailable { get; private set; }
        public Entity postEntityImage { get; private set; }
        public bool postEntityImageAvailable { get; private set; }
        public string className { get; private set; }

        public void Execute(IServiceProvider serviceProvider)
        {
            className = GetType().Name;

            tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            service = serviceFactory.CreateOrganizationService(context.UserId);
            svcContext = new CrmServiceContext(service);

            preEntityImageAvailable = false;
            postEntityImageAvailable = false;

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                entity = (Entity)context.InputParameters["Target"];
            }

            if (context.PreEntityImages.Contains(preImageName) && context.PreEntityImages[preImageName] is Entity)
            {
                preEntityImage = context.PreEntityImages[preImageName];
                preEntityImageAvailable = true;
            }

            if (context.PostEntityImages.Contains(postImageName) && context.PostEntityImages[postImageName] is Entity)
            {
                postEntityImage = context.PostEntityImages[postImageName];
                postEntityImageAvailable = true;
            }

            ExecutePlugin();
        }

        public abstract void ExecutePlugin();
    }
}