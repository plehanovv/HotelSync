namespace HotelSync.Domain.Interfaces;

public interface IAuditable
{
    public DateTime CreatedAt { get; set; }
}