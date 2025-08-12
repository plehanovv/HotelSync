using HotelSync.Domain.Interfaces;

namespace HotelSync.Domain.Entities;

public class Room : IAuditable, IEntityId<int>
{
    public int Id { get; set; }
    
    public int HotelId { get; set; }
    
    public string RoomNumber { get; set; } = string.Empty;
    
    public string Type { get; set; } = string.Empty; // Например, "Standard", "Deluxe"
    
    public decimal PricePerNight { get; set; }
    
    public Hotel Hotel { get; set; } = null!;
    
    public List<Booking> Bookings { get; set; } = new List<Booking>();
    
    public DateTime CreatedAt { get; set; }
}