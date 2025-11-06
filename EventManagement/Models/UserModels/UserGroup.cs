using EventManagement.Models.Common;
using System.Collections.Generic;

namespace EventManagement.Models.UserModels
{
    public class UserGroup : BaseEntity
    {
        public string GroupName { get; set; } = "";
        public ICollection<BaseUser> Users { get; set; } = new List<BaseUser>();
    }
}
