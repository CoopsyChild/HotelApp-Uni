using HotelApp.Exceptions;

namespace HotelApp.Models;

public class ReservationBook
{
    private IReadOnlyList<Reservation> _reservations;

    public ReservationBook()
    {
        _reservations = new List<Reservation>();
    }

    public IEnumerable<Reservation> GetReservationsForUSer(String userId)
    {
        return _reservations.Where(r => r.UserId == userId).ToList();
    }

    public void AddReservation(Reservation reservation)
    {
        foreach (var existingReservation in _reservations)
        {
            if (existingReservation.Conflicts(reservation))
            {
                throw new ResevationConflictException(existingReservation, reservation);
            }
        }
        
        _reservations.Append(reservation);
    }
}