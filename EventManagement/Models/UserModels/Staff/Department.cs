using EventManagement.Models.Common;
using System.Collections.Generic;

namespace EventManagement.Models.UserModels.Staff
{
    public class Department : BaseEntity
    {
        public string Name { get; set; } = "";

        public string? Description { get; set; } = "";

        public ICollection<Position>? Positions { get; set; } = new List<Position>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
