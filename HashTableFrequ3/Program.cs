using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableFrequ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable Program");
            int key = 0;
            string sampleParagraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paragraph = sampleParagraph.Split();
            MyNodeFrequency<int, string> hash = new MyNodeFrequency<int, string>(paragraph.Length);
            foreach (string word in paragraph)
            {
                hash.Add(key, word);
                key++;
            }
            hash.Remove(14);
            for (key = 0; key < paragraph.Length; key++)
            {
                string value = hash.Get(key);
                Console.WriteLine($"frequency of word '{value}' is {key}");
            }
        }
    }
}
