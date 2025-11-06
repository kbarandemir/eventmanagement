using EventManagement.Models.EventModels;
namespace EventManagement.Models.UserModels
{
    public class Organizer : BaseUser
    {
        public string OrganizationName { get; set; } = "";
        public string ContactNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public string? WebsiteUrl { get; set; } = "";
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
