using System.ComponentModel.DataAnnotations;

namespace database.fightsubapp.models;

public class Gym
{
    public Guid GymId { get; set; }
    
    [MaxLength(250)]
    public string Name { get; set; }
}