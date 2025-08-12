using HotelSync.Domain.Interfaces;

namespace HotelSync.Domain.Entities;

public class Booking : IAuditable, IEntityId<int>
{
    public int Id { get; set; }
    
    public int RoomId { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public string ClientName { get; set; } = string.Empty;
    
    public decimal TotalPrice { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public Room Room { get; set; } = null!;
}