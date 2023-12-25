
namespace HotelApp.Models;

public class Review
{
    public Review(string id, string hotelId, string userId, string reservationId, int rating, string comment)
    {
        Id = id;
        HotelId = hotelId;
        UserId = userId;
        ReservationId = reservationId;
        Rating = rating;
        Comment = comment;
    }

    public Review(string reservationId, int rating, string comment)
    {
        ReservationId = reservationId;
        Rating = rating;
        Comment = comment;
    }

    public String? Id { get; }
    public String? HotelId { get; }
    public String? UserId { get; }
    public String ReservationId { get; }
    public int Rating { get; }
    public String Comment { get; }
}