using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;

namespace Debugger
{
    public class DOrganizationServiceFactory : IOrganizationServiceFactory
    {
        private readonly DSettings _settings;

        public DOrganizationServiceFactory(DSettings settings)
        {
            _settings = settings;
        }

        public IOrganizationService CreateOrganizationService(Guid? userId)
        {
            if (_settings?.Environment == null)
            {
                throw new ArgumentNullException("Environment");
            }

            return new CrmServiceClient(_settings.Environment.Instance, _settings.Environment.ClientId, _settings.Environment.ClientSecret, _settings.Environment.UseUniqueInstance, _settings.Environment.TokenCachePath);
        }
    }
}