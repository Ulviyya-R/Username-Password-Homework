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
                Console.WriteLine("Yeniden Daxil Edin");
                UsernameL();
            }
        }
        public void Passwword()
        {
            Console.Write("Password: ");
            string pass = Console.ReadLine();
            Password = pass;

            char[] chars = pass.ToCharArray();
            string ust = pass.ToUpper();
            char[] karakter = ust.ToCharArray();
            int count = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == karakter[i])
                {
                    count++;
                }
            }
            if (count > 0)
            {
                _password = pass;
            }
            else
            {
                Console.WriteLine("Yeniden daxil edin");
                Passwword();
            }
        }

    }
}

        

      



        
    
