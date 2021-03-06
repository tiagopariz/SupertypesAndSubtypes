﻿using System;

namespace SupertypesAndSubtypes.Domain.Entities
{
    public class Service
    {
        public Service(Guid serviceId, string serviceName, Guid parentServiceId, Guid customerId, DateTime startDate, string customerName, decimal totalTimeSpent)
        {
            ServiceId = serviceId;
            ServiceName = serviceName;
            ParentServiceId = parentServiceId;
            CustomerId = customerId;
            StartDate = startDate;
            CustomerName = customerName;
            TotalTimeSpent = totalTimeSpent;
        }

        public Guid ServiceId { get; }
        public string ServiceName { get; }
        public Guid ParentServiceId { get; }
        public Guid CustomerId { get; }
        public DateTime StartDate { get; }
        public string CustomerName { get; }
        public decimal TotalTimeSpent { get; }
    }
}
