using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Admin : User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool isSuperAdmin, string Section, string username, string password) : base(username, password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = Section;
        }

        public void ShowData()
        {
            UsernameL();
            Console.WriteLine(" ");
            Console.WriteLine($" {IsSuperAdmin}: {Section} Username: {_username},  Password: {_password}");
        }
    }
}
