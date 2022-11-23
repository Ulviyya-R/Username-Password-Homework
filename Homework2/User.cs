using Homework2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class User
    {
        private protected string _username;
        private protected string Username;
        private  protected string _password;
        private protected string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;

        }

        public void UsernameL()
        {
            Console.Write("Username: ");
            string userr = Console.ReadLine();
            Username = userr;
            if (userr.Length > 6)
            {
                Passwword();
                _username = userr;
            }
            else
            {
                Console.WriteLine("Error! Usename 6 herfli olmalidir!");
                UsernameL();
            }
        }
        public void Passwword()
        {
            Console.Write("Password: ");
            string pass = Console.ReadLine();
            Password = pass;

            if (pass == pass.ToLower())
            {
                Console.WriteLine("Set again Password");
                Passwword();
            }
            else
            {
                _password = pass;
            }
        }

    }
}

        

      



        
    
