using HotelSync.Domain.Interfaces;

namespace HotelSync.Domain.Entities;

public class Hotel : IEntityId<int>
{
    public int Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string Address { get; set; } = string.Empty;
    
    public List<Room> Rooms { get; set; } = new List<Room>();
}