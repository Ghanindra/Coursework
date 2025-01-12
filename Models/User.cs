using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class User

    {

        //public int Id { get; set; } // Unique identifier for the user

        //public string Name { get; set; } // Name of the user

        //public string Email { get; set; } // Email address

        //public string Phone { get; set; } // Contact number

        //public string Address { get; set; } // Address (optional)
        //public string Password { get; set; } // This will store the hashed password

        public string Username { get; set; }  // This is required for the registration logic
        public string Password { get; set; }  // This will store the hashed password
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now; // Date the user was added

    }
}
