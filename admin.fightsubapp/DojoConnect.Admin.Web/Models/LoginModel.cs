using System.ComponentModel.DataAnnotations;

namespace DojoConnect.Admin.Web.Models;

public class LoginModel
{
    [Required, EmailAddress, DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    
    [Required, DataType(DataType.Password)]
    public string Password { get; set; }
}