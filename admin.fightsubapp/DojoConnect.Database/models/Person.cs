using System.ComponentModel.DataAnnotations;

namespace DojoConnect.Database.models;

public class Person
{
    public Guid Id { get; set; }
    public Gym Gym { get; set; }
    public Guid GymId { get; set; }

    [MaxLength(100)]
    public string FirstName { get; set; }
    
    [MaxLength(100)]
    public string LastName { get; set; }

    public string Email { get; set; }
    public string Password { get; set; }
}