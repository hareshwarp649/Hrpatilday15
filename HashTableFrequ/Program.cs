using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableFrequ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<--------Welcome to Hash Table Program-------->");
            Console.WriteLine("-----------------------------------------------");
            MyServNode<string, string> hash = new MyServNode<string, string>(5);
            hash.Add("0", "to");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            hash.Add("6", "to");

            Console.WriteLine("Frequency of to  : " + hash.WordOfFrequency("to"));
            Console.WriteLine("Frequency of be  : " + hash.WordOfFrequency("be"));
            Console.WriteLine("Frequency of or  : " + hash.WordOfFrequency("or"));
            Console.WriteLine("Frequency of not : " + hash.WordOfFrequency("not"));




        }
    }
    
}
