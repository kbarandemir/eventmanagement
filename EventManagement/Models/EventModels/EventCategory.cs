using EventManagement.Models.Common;
using System.Collections.Generic;

namespace EventManagement.Models.EventModels
{
    public class EventCategory : BaseEntity
    {
        public string Name { get; set; } = "";
        public string? Description { get; set; }

        public ICollection<Event> Events { get; set; } = new List<Event>();
        // 🔹 Bu kategoriye ait etkinlikler
        // public ICollection<EventCategoryAssignment> EventCategoryAssignments { get; set; } = new List<EventCategoryAssignment>();
    }
}
