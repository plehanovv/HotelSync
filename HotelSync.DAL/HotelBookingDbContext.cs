using HotelSync.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelSync.DAL;

public class HotelBookingDbContext : DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Hotel> Hotels { get; set; }

    public HotelBookingDbContext(DbContextOptions<HotelBookingDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HotelBookingDbContext).Assembly);
    }
}