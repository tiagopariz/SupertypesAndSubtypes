using System;

namespace SupertypesAndSubtypes.Domain.Entities
{
    public class ServiceType
    {
        public ServiceType(Guid serviceTypeId, string serviceTypeName)
        {
            ServiceTypeId = serviceTypeId;
            ServiceTypeName = serviceTypeName;
        }

        public Guid ServiceTypeId { get; }
        public string ServiceTypeName { get; }
    }
}
