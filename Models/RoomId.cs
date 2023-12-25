namespace HotelApp.Models;

public class RoomId
{
    public RoomId(String hotelId, int floorNumber, int roomNumber)
    {
        FloorNumber = floorNumber;
        RoomNumber = roomNumber;
        HotelId = hotelId;
    }
    public int FloorNumber { get; }
    public int RoomNumber { get; }
    public String HotelId { get; }

    public override bool Equals(object? obj)
    {
        return obj is RoomId roomId &&
               roomId.FloorNumber == FloorNumber &&
               roomId.RoomNumber == RoomNumber &&
               roomId.HotelId == HotelId;
    }

    public override string ToString()
    {
        return $"{HotelId}{FloorNumber}{RoomNumber}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(HotelId, FloorNumber, RoomNumber);
    }
}