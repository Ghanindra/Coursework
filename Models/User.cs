using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class User

    {


        public string Username { get; set; }  // This is required for the registration logic
        public string Password { get; set; }  // This will store the hashed password
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now; // Date the user was added

    }
}
