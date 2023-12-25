namespace HotelApp.Models;

public class RoomId
{
    public RoomId(int floorNumber, int roomNumber)
    {
        FloorNumber = floorNumber;
        RoomNumber = roomNumber;
    }
    public int FloorNumber { get; }
    public int RoomNumber { get; }

    public override bool Equals(object? obj)
    {
        return obj is RoomId roomId &&
               roomId.FloorNumber == FloorNumber &&
               roomId.RoomNumber == RoomNumber;
    }

    public override string ToString()
    {
        return $"{FloorNumber}{RoomNumber}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FloorNumber, RoomNumber);
    }
}