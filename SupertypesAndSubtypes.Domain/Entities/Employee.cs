using System;

namespace SupertypesAndSubtypes.Domain.Entities
{
    public class Employee
    {
        public Employee(Guid employeeId, string employeeName)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
        }

        public Guid EmployeeId { get; }
        public string EmployeeName { get; }
    }
}
