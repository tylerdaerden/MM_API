using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Command;

namespace MM_Models.Api.Command
{ 
#nullable disable
    public class RegisterCommand : ICommandDefinition
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public DateTime Birthdate { get; set; }
    public string Password { get; set; }

    public RegisterCommand(string firstName, string lastName, string userName, string email, DateTime birthdate, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        Email = email;
        Birthdate = birthdate;
        Password = password;
    }


}
}
