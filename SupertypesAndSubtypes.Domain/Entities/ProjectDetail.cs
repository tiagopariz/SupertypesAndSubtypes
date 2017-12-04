using System;

namespace SupertypesAndSubtypes.Domain.Entities
{
    public class ProjectDetail
    {
        public ProjectDetail(Guid projectDetailId, Guid projectId, Guid itemId, Guid activityId, Guid employeeId, DateTime workDate, decimal timeSpent)
        {
            ProjectDetailId = projectDetailId;
            ProjectId = projectId;
            ItemId = itemId;
            ActivityId = activityId;
            EmployeeId = employeeId;
            WorkDate = workDate;
            TimeSpent = timeSpent;
        }

        public Guid ProjectDetailId { get; }
        public Guid ProjectId { get; }
        public Guid ItemId { get; }
        public Guid ActivityId { get; }
        public Guid EmployeeId { get; }
        public DateTime WorkDate { get; }
        public decimal TimeSpent { get; }
    }
}
