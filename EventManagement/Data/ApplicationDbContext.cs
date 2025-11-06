using Microsoft.EntityFrameworkCore;
using EventManagement.Models.UserModels;
using EventManagement.Models;

namespace EventManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 🔹 Kullanıcılar
        public DbSet<BaseUser> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }

        // // 🔹 Etkinlikler
        // public DbSet<Event> Events { get; set; }
        // public DbSet<Ticket> Tickets { get; set; }
        // public DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 🔹 BaseUser soyut olduğu için tabloya doğrudan yazılmaz
            modelBuilder.Entity<BaseUser>().HasDiscriminator<string>("Role")
                .HasValue<Admin>("Admin")
                .HasValue<Organizer>("Organizer")
                .HasValue<Attendee>("Attendee");
        }
    }
}
