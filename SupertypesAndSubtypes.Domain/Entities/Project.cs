using System;

namespace SupertypesAndSubtypes.Domain.Entities
{
    public class Project
    {
        public Project(Guid projectId, string projectName, Guid customerId, DateTime startDate, string customerName, decimal totalTimeSpent)
        {
            ProjectId = projectId;
            ProjectName = projectName;
            CustomerId = customerId;
            StartDate = startDate;
            CustomerName = customerName;
            TotalTimeSpent = totalTimeSpent;
        }

        public Guid ProjectId { get; }
        public string ProjectName { get; }
        public Guid CustomerId { get; }
        public DateTime StartDate { get; }
        public string CustomerName { get; }
        public decimal TotalTimeSpent { get; }
    }
}
