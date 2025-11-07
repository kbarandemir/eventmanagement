using EventManagement.Models.Common;
using EventManagement.Models.UserModels;
using System.Collections.Generic;

namespace EventManagement.Models.EventModels
{
    public class Event : BaseEntity
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; } = "";
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;
        public int CategoryId { get; set; }
        public EventCategory Category { get; set; } = null!;
        // public ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();
        public string? PosterUrl { get; set; } = "/images/default.js";


        // 🔹 Katılımcı kayıtları (Attendee ↔ Event)
        // public ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

        // 🔹 Etkinliğin kategorileri (Event ↔ Category)
        // public ICollection<EventCategoryAssignment> EventCategoryAssignments { get; set; } = new List<EventCategoryAssignment>();
        public int Capacity { get; set; } = 0;
        public decimal? TicketPrice { get; set; }
        public string Status { get; set; } = "Draft";
    }
}
