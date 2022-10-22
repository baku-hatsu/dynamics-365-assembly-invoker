using Microsoft.Xrm.Sdk;
using System;

namespace Debugger
{
    public class DPluginContext : IPluginExecutionContext
    {
        public string MessageName { get; set; }

        public string PrimaryEntityName { get; set; }

        public Guid UserId { get; set; }

        public Guid InitiatingUserId { get; set; }

        public Guid BusinessUnitId { get; set; }

        public Guid OrganizationId { get; set; }

        public string OrganizationName { get; set; }

        public Guid PrimaryEntityId { get; set; }

        public string SecondaryEntityName { get; set; }

        [NotImplemented]
        public int Stage => throw new NotImplementedException();

        [NotImplemented]
        public IPluginExecutionContext ParentContext => throw new NotImplementedException();

        [NotImplemented]
        public int Mode => throw new NotImplementedException();

        [NotImplemented]
        public int IsolationMode => throw new NotImplementedException();

        [NotImplemented]
        public int Depth => throw new NotImplementedException();

        [NotImplemented]
        public Guid? RequestId => throw new NotImplementedException();

        [NotImplemented]
        public ParameterCollection InputParameters => throw new NotImplementedException();

        [NotImplemented]
        public ParameterCollection OutputParameters => throw new NotImplementedException();

        [NotImplemented]
        public ParameterCollection SharedVariables => throw new NotImplementedException();

        [NotImplemented]
        public EntityImageCollection PreEntityImages => throw new NotImplementedException();

        [NotImplemented]
        public EntityImageCollection PostEntityImages => throw new NotImplementedException();

        [NotImplemented]
        public EntityReference OwningExtension => throw new NotImplementedException();

        [NotImplemented]
        public Guid CorrelationId => throw new NotImplementedException();

        [NotImplemented]
        public bool IsExecutingOffline => throw new NotImplementedException();

        [NotImplemented]
        public bool IsOfflinePlayback => throw new NotImplementedException();

        [NotImplemented]
        public bool IsInTransaction => throw new NotImplementedException();

        [NotImplemented]
        public Guid OperationId => throw new NotImplementedException();

        [NotImplemented]
        public DateTime OperationCreatedOn => throw new NotImplementedException();
    }
}