using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableFrequ2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("<--------Welcome to Hash Table Program-------->");
            Console.WriteLine("-----------------------------------------------");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split();
            MyServ2Node<int, string> hash = new MyServ2Node<int, string>(para.Length);
            int key = 0;
            foreach (string word in para)
            {
                hash.Add(key, word);
                key++;
            }
            //FrequencyWard frequency = new FrequencyWard();
            //frequency.Frequency(hash);
            for (key = 0; key < paragraph.Length; key++)
            {
                string value = hash.Get(key);
                Console.WriteLine($"frequency of word '{value}' is {key}");
            }
        }
    }
}
