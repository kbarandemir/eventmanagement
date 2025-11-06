using EventManagement.Models.Common;

namespace EventManagement.Models.UserModels
{
    public abstract class BaseUser : BaseEntity
    {
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Role { get; set; } = "";
        public int? UserGroupId { get; set; }
        public UserGroup? UserGroup { get; set; }
    }
}
