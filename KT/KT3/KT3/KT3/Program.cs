using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            var array = new string[10]; //?
            var aString = "";
            bool running = true;

            while (running)
            {
                Console.WriteLine("Lägg till en rad:");
                aString = Console.ReadLine();

                if (aString == "q" || aString == "quit")
                {
                    running = false;
                }
                else
                {
                    if (aString.Contains(","))
                    {
                        array = aString.Split(',');
                        foreach (var element in array)
                        {
                            list.Add(element);
                        }
                    }
                }
            }

            Console.WriteLine("Filter:");
            var filter = Console.ReadLine();

            foreach (var element in list)
            {
                if (element.StartsWith(filter)) {
                    Console.WriteLine(element);
                }
                
            }

            Console.ReadKey();

            
        }
    }
}
