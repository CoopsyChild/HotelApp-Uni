namespace HotelApp.Models;

public class Reservation
{
    public Reservation(string userId, DateTime startTime, DateTime endTime, string id, string hotelId, RoomId roomId)
    {
        UserId = userId;
        StartTime = startTime;
        EndTime = endTime;
        Id = id;
        HotelId = hotelId;
        RoomId = roomId;
    }

    public Reservation(string userId, DateTime startTime, DateTime endTime, string hotelId, RoomId roomId)
    {
        UserId = userId;
        StartTime = startTime;
        EndTime = endTime;
        HotelId = hotelId;
        RoomId = roomId;
    }

    public String? Id { get; }
    public String HotelId { get; }
    public RoomId RoomId { get; }
    public String UserId;
    public DateTime StartTime;
    public DateTime EndTime;
    public TimeSpan Length => EndTime.Subtract(StartTime);
    public bool Conflicts(Reservation reservation)
    {
        if (!reservation.RoomId.Equals(RoomId))
        {
            return false;
        }

        return (reservation.StartTime < EndTime && reservation.EndTime > StartTime);
    }
}