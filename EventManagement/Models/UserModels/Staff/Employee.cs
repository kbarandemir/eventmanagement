using EventManagement.Models.UserModels.Staff;

namespace EventManagement.Models.UserModels
{
    public class Employee : BaseUser
    {
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int? PositionId { get; set; }
        public Position? Position { get; set; }
    }
}
