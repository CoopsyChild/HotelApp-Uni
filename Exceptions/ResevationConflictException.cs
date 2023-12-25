using System.Runtime.Serialization;
using HotelApp.Models;

namespace HotelApp.Exceptions;

public class ResevationConflictException : Exception
{
    public Reservation ExistingReservation { get; }
    public Reservation IncomingReservation { get; }
    
    public ResevationConflictException(Reservation existingReservation, Reservation incomingReservation)
    {
        ExistingReservation = existingReservation;
        IncomingReservation = incomingReservation;
    }

    protected ResevationConflictException(SerializationInfo info, StreamingContext context, Reservation existingReservation, Reservation incomingReservation) : base(info, context)
    {
        ExistingReservation = existingReservation;
        IncomingReservation = incomingReservation;
    }

    public ResevationConflictException(string? message, Reservation existingReservation, Reservation incomingReservation) : base(message)
    {
        ExistingReservation = existingReservation;
        IncomingReservation = incomingReservation;
    }

    public ResevationConflictException(string? message, Exception? innerException, Reservation existingReservation, Reservation incomingReservation) : base(message, innerException)
    {
        ExistingReservation = existingReservation;
        IncomingReservation = incomingReservation;
    }
}