using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //PhoneBookExample();
            WordCount();

            Console.ReadLine();
        }

        static void PhoneBookExample()
        {
            var phonebook = new Dictionary<string, string>();
            phonebook["John Smith"] = "+1-555-8976";

            phonebook["Lisa Smith"] = "+1-555-1234";

            phonebook["Aaron Doe"] = "+1-555-5030";

            phonebook["Ivan"] = "+359-899-555-592";
            phonebook["Ivan"] = "+359-2-981-9819";

            phonebook.Remove("John Smith");
            foreach (var pair in phonebook)
            {
                Console.WriteLine($"{pair.Key} --> {pair.Value}");
            }
        }

        static void WordCount()
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split();

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 1;
                }
                else
                {
                    wordCount[word]++;
                }
            }

            foreach (var pair in wordCount)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }

    }
}
