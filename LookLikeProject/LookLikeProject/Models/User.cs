using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LookLikeProject.Models
{
    public class User
    {
        public string Vnev { get; set; }
        public string Kernev { get; set; }
        public DateTime Szuldatum { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Passw { get; set; }

        public User(string vnev, string knev, DateTime szuldatum, string email, string username, string passw)
        {
            Vnev = vnev;
            Kernev = knev;
            Szuldatum = szuldatum;
            Email = email;
            UserName = username;
            Passw = passw;

        }

        public User()
        { 
            Vnev=string.Empty;
            Kernev=string.Empty;
            Szuldatum=new DateTime();
            Email=string.Empty;
            UserName=string.Empty;
            Passw=string.Empty;
        }
    }
}
