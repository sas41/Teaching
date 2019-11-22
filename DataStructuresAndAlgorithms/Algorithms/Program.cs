using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //URLs();
            //ParenthesesTracking();

            Console.ReadLine();
        }

        static void ParenthesesTracking()
        {
            string input = Console.ReadLine();

            Stack<int> openers = new Stack<int>();

            for (int index = 0; index < input.Length; index++)
            {
                char current = input[index];
                if (current == '(')
                {
                    openers.Push(index);
                }
                else if (current == ')')
                {
                    int startIndex = openers.Pop();
                    string substring = input.Substring(startIndex, index - startIndex + 1);
                    Console.WriteLine(substring);
                }
            }
        }

        static void URLs()
        {
            Stack<string> urls = new Stack<string>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    // End program
                    break;
                }
                else if (input.ToLower() == "back")
                {
                    // Go back
                    if (urls.Count > 0)
                    {
                        urls.Pop();
                        if (urls.Count > 0)
                        {
                            Console.WriteLine(urls.Peek());
                        }
                    }
                }
                else
                {
                    urls.Push(input);
                    // URL
                }
            }
        }

        static void ExampleCommandLoop()
        {
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input.ToLower() == "exit")
                {
                    break;
                }
                else if (input.ToLower() == "test")
                {
                    Console.WriteLine("This is a Test!");
                }
                else 
                {
                    Console.WriteLine("Unknown Command.");
                }
            }

        }
    }
}