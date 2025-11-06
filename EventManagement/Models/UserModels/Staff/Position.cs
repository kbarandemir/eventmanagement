using EventManagement.Models.Common;
using System.Collections.Generic;

namespace EventManagement.Models.UserModels.Staff
{
    public class Position : BaseEntity
    {
        public string Title { get; set; } = "";

        public string? Description { get; set; } = "";

        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<Employee>? Employees { get; set; } = new List<Employee>();
    }
}
