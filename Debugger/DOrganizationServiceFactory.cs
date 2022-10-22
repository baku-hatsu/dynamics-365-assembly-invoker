using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;

namespace Debugger
{
    public class DOrganizationServiceFactory : IOrganizationServiceFactory
    {
        public IOrganizationService CreateOrganizationService(Guid? userId)
        {
            return new CrmServiceClient("");
        }
    }
}