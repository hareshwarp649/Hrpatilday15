using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to validating User Registration using Regex");
            Console.WriteLine("Enter Option " + "\n 1. Validating First Name" + "\n 2. Validating  Last Name");

            UserFirstName name = new UserFirstName();
            int atom= Convert.ToInt32(Console.ReadLine());
           switch (atom)
            {
                case 1:
                    name.FirstName();
                    break;
              case 2:
                    name.LastName();
                   break;
           }
        }
    }
}
