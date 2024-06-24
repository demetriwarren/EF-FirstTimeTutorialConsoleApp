using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FirstTimeTutorial
{
    public class User
    {
        public int Id { get; set; } = 0;
        public string Username { get; set; } = string.Empty;        //all types need to match the types in the Db
        public string Password { get; set; } = string.Empty;
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Email { get; set; }                          //is allowed to be null. is set to default null with the "?"
        public bool IsReviewer { get; set; } 
        public bool IsAdmin { get; set; }

    }
}
