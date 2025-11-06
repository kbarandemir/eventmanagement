using EventManagement.Models.UserModels;

namespace EventManagement.Services.Interfaces
{
    public interface IUserService
    {
        Task<BaseUser?> GetUserByEmailAsync(string email);
        Task<IEnumerable<BaseUser>> GetAllUsersAsync();
        Task AddUserAsync(BaseUser user);
        Task DeleteUserAsync(int id);
        Task<bool> ValidateCredentialsAsync(string email, string password);

        Task<BaseUser?> LoginAsync(string email, string password);

        // Login and Register methods for specific user roles
        Task<Admin> RegisterAdminAsync(string fullName, string email, string password, string department);
        Task<Organizer> RegisterOrganizerAsync( string email, string password, string organizationName, string contactNumber);
        Task<Attendee> RegisterAttendeeAsync(string fullName, string email, string password, DateTime registrationDate);

    }
}
