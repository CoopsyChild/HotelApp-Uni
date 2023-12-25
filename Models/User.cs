namespace HotelApp.Models;

public class User
{
    public User(string lastName, string firstName, string username, string email, string phone, bool isAdmin, bool isHotelOwner, string userId)
    {
        LastName = lastName;
        FirstName = firstName;
        Username = username;
        Email = email;
        Phone = phone;
        IsAdmin = isAdmin;
        UserId = userId;
        IsHotelOwner = isHotelOwner;
    }
    public String LastName { get; set; }
    public String FirstName { get; set; }
    public String Username { get; }
    public String Email { get; set; }
    public String Phone { get; set; }
    public bool IsAdmin { get; }
    public bool IsHotelOwner { get; }
    public String UserId { get; }
}
