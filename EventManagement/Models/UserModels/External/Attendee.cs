namespace EventManagement.Models.UserModels
{
    public class Attendee : BaseUser
    {
        public string TicketNumber { get; set; } = "";
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
