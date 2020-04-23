using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalAndLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 15;
            int d = 5;

            bool alpha = true;
            bool beta = false;

            bool gamma;

            gamma = (a < b);

            //////////////////////////////////////////////
            //////////////////////////////////////////////
            //////////////////////////////////////////////
            
            // TRUE, FALSE

            if (true)
            {
                Console.WriteLine("This is Always Displayed");
            }

            if (false)
            {
                Console.WriteLine("This is Never Displayed");
            }

            if (alpha)
            {
                Console.WriteLine("Alpha is true, so it Displays!");
            }

            if (beta)
            {
                Console.WriteLine("Beta is false, so it won't Display.");
            }

            //////////////////////////////////////////////
            //////////////////////////////////////////////
            //////////////////////////////////////////////

            // SMALLER THAN, LARGER THAN

            if (a < b)
            {
                Console.WriteLine("Is A, smaller than B");
            }

            if (a > b)
            {
                Console.WriteLine("Is A, larger than B");
            }

            //////////////////////////////////////////////
            //////////////////////////////////////////////
            //////////////////////////////////////////////

            // SMALLER OR EQUAL TO, LARGER OR EQUAL TO

            if (a <= b)
            {
                Console.WriteLine("Is A, smaller or equal to B");
            }

            if (a >= b)
            {
                Console.WriteLine("Is A, larger or equal to B");
            }

            //////////////////////////////////////////////
            //////////////////////////////////////////////
            //////////////////////////////////////////////

            // EQUAL TO, DIFFERENT THAN

            if (a == b)
            {
                Console.WriteLine("Is A equal to B");
            }

            if (a != b)
            {
                Console.WriteLine("Is A different than B");
            }

            //////////////////////////////////////////////
            //////////////////////////////////////////////
            //////////////////////////////////////////////

            // Logical AND, Logical OR

            if ( (a<b) && (a==d) )
            {
                Console.WriteLine("Is A smaller than B, AND is A equal to D");
            }

            if ( (c > b) || (d == b) )
            {
                Console.WriteLine("Is C larger than B, OR is d equal to B");
            }

            //////////////////////////////////////////////
            //////////////////////////////////////////////
            //////////////////////////////////////////////

            // ELSE statement, ELSE IF statement

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("A is the largest");
                }
                else
                {
                    Console.WriteLine("C is the largest");
                }
            }
            else if (b > c)
            {
                Console.WriteLine("B is the largest");
            }
        }
    }
}
