using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parProgrammering
{
    enum Mode
    {
        Multiply = 0,
        Percentage,
        Divide
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mode mode;

            bool xValid = false;
            bool yValid = false;
            decimal xDecimal = 0;
            decimal yDecimal = 0;

            Console.WriteLine("Mode:");
            var inputMode = Console.ReadLine();

            if(inputMode == "divide")
            {
                mode = Mode.Divide;
            } else if (inputMode == "Multiply")
            {
                mode = Mode.Multiply;
            }
            else
            {
                mode = Mode.Percentage;
            }


            while (!xValid) { 
                Console.WriteLine("Please write an number");
                string x = Console.ReadLine();
                if (decimal.TryParse(x, out xDecimal)) { 
                    xValid = true;
                }
                else
                {
                    Console.WriteLine("The number is not valid");
                }
            }

            while (!yValid)
            {
                Console.WriteLine("Please write another number");
                string y = Console.ReadLine();
                if (decimal.TryParse(y, out yDecimal))
                {
                    yValid = true;
                }
                else
                {
                    Console.WriteLine("The number is not valid");
                }
            }

            decimal outcomeDecimal=0;
            var format = mode == Mode.Percentage ? "P2" : "N3";
            switch (mode)
            {
                case Mode.Divide:
                case Mode.Percentage:
                    outcomeDecimal = xDecimal / yDecimal;
                    break;
                case Mode.Multiply:
                    outcomeDecimal = xDecimal * yDecimal;
                    break;
            }

            //string outcome = String.Format("{0:f3}",outcomeDecimal);
            Console.WriteLine(outcomeDecimal.ToString(format));
            Console.ReadKey(); 
    }
    }
}
