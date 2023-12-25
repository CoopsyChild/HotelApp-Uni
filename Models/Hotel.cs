namespace HotelApp.Models;

public class Hotel
{
    private readonly ReservationBook _reservationBook;
    
    public String Id { get; }
    
    public String OwnerId { get; }
    public String Name { get; }
    
    public double Rating { get; }
    
    public Hotel(string name)
    {
        Name = name;
        _reservationBook = new ReservationBook();
    }
    
    public IEnumerable<Reservation> GetReservationsForUSer(String userId)
    {
        return _reservationBook.GetReservationsForUSer(userId);
    }

    public void MakeReservation(Reservation reservation)
    {
        _reservationBook.AddReservation(reservation);
    }
}