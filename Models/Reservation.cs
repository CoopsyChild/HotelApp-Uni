namespace HotelApp.Models;

public class Reservation
{
    public RoomId RoomId { get; }
    public String UserId;
    public DateTime StartTime;
    public DateTime EndTime;
    public TimeSpan Length => EndTime.Subtract(StartTime);

    public Reservation(DateTime startTime, DateTime endTime, RoomId roomId, String userId)
    {
        StartTime = startTime;
        EndTime = endTime;
        RoomId = roomId;
        UserId = userId;
    }

    public bool Conflicts(Reservation reservation)
    {
        if (!reservation.RoomId.Equals(RoomId))
        {
            return false;
        }

        return (reservation.StartTime < EndTime && reservation.EndTime > StartTime);
    }
}