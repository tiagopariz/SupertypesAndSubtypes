using System;

namespace SupertypesAndSubtypes.Domain.Entities
{
    public class ServiceDetail
    {
        public ServiceDetail(Guid serviceDetailId, Guid serviceId, Guid itemId, Guid activityId, Guid employeeId, DateTime workDate, decimal timeSpent)
        {
            ServiceDetailId = serviceDetailId;
            ServiceId = serviceId;
            ItemId = itemId;
            ActivityId = activityId;
            EmployeeId = employeeId;
            WorkDate = workDate;
            TimeSpent = timeSpent;
        }

        public Guid ServiceDetailId { get; }
        public Guid ServiceId { get; }
        public Guid ItemId { get; }
        public Guid ActivityId { get; }
        public Guid EmployeeId { get; }
        public DateTime WorkDate { get; }
        public decimal TimeSpent { get; }
    }
}
