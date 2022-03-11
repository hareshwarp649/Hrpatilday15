using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class UserFirstName

    {

      public  string pattern ="^[A-Z]{1}[a-zA-Z]{2}$";
            //"^[A - Za - z]{3,}$";
            //(@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
        public void FirstName()
        {
            Console.WriteLine("Validating the First Name");
            Regex atom = new Regex(pattern);
            Console.WriteLine("Enter the First Name");
            string input = Console.ReadLine();
            bool result = atom.IsMatch(input);
            if (result)
            {

                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }


          
        public void LastName()
        {
            Console.WriteLine("Validating the Last Name");
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter the Last Name");
            string input = Console.ReadLine();
            bool result = regex.IsMatch(input);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
