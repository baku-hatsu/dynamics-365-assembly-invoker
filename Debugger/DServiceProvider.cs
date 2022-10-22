using Microsoft.Xrm.Sdk;
using System;

namespace Debugger
{
    public class DServiceProvider : IServiceProvider
    {
        private readonly DSettings _settings;
        private readonly DPluginContext _context;

        public DServiceProvider(DSettings settings, DPluginContext context)
        {
            _settings = settings;
            _context = context;
        }

        public object GetService(Type serviceType)
        {
            switch (serviceType.Name)
            {
                case nameof(IPluginExecutionContext):
                    return _context;

                case nameof(IOrganizationServiceFactory):
                    return new DOrganizationServiceFactory(_settings);

                case nameof(ITracingService):
                    return new DTracingService();

                default:
                    return new NotImplementedException();
            }
        }
    }
}