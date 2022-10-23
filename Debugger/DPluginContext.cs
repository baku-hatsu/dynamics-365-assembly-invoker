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

        public int Stage { get; set; }

        [NotImplemented]
        public IPluginExecutionContext ParentContext => throw new NotImplementedException();

        public int Mode { get; set; }

        public int IsolationMode { get; set; }

        public int Depth { get; set; }

        public Guid? RequestId { get; set; }

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

        public Guid CorrelationId { get; set; }

        public bool IsExecutingOffline { get; set; }

        public bool IsOfflinePlayback { get; set; }

        public bool IsInTransaction { get; set; }

        public Guid OperationId { get; set; }

        public DateTime OperationCreatedOn { get; set; }
    }
}