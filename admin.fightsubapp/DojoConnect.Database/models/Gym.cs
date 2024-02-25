using System.ComponentModel.DataAnnotations;

namespace DojoConnect.Database.models;

public class Gym
{
    public Guid Id { get; set; }
    
    [MaxLength(250)]
    public string Name { get; set; }

    public ICollection<Person> Persons { get; set; }
}