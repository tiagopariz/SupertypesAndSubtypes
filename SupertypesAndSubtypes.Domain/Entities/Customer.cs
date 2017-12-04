using System;

namespace SupertypesAndSubtypes.Domain.Entities
{
    public class Customer
    {
        public Customer(Guid customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
        }

        public Guid CustomerId { get; }
        public string CustomerName { get; }
    }
}
