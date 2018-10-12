using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal xDecimal;
            decimal yDecimal;

            bool xValid = false;
            bool yValid = false;

            while (!xValid)
            {
                Console.WriteLine("Please write an integer number");
                string x = Console.ReadLine();

                if (decimal.TryParse(x, out xDecimal))
                {
                    xDecimal = decimal.Parse(x);
                    xValid = true;
                }
                else
                {
                    Console.WriteLine("The number is not valid");
                }
            }

            while (!yValid)
            {
                Console.WriteLine("Please write the second integer number");
                string y = Console.ReadLine();

                if (decimal.TryParse(y, out yDecimal))
                {
                    yDecimal = decimal.Parse(y);
                    yValid = true;
                }
                else
                {
                    Console.WriteLine("The number is not valid");
                }
            }

            decimal outcomeDecimal = xDecimal * yDecimal;
            string outcome = String.Format("{0:f3}", outcomeDecimal);
            Console.WriteLine("Result: " + outcome);

            Console.ReadKey();
        }
    }
}
