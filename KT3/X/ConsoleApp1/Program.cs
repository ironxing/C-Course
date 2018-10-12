using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            bool finished = false;
            string[] array;

            while (!finished)
            {
                Console.WriteLine("Lägg till en rad:");
                string aString = Console.ReadLine();

                if (aString == "q" || aString == "quit")
                {
                    finished = true;
                }
                else
                {
                    //addElement(aString, list);

                    if (aString.Contains(","))
                    {
                        array = aString.Split(',');
                        foreach (string element in array){
                            list.Add(element.Trim());
                        }
                    }
                    else
                    {
                        list.Add(aString.Trim());
                    }
                }
            }

            list.Sort();
            Console.WriteLine("Filter:");
            string filter = Console.ReadLine();

            foreach (string element in list)
            {
                if (element.StartsWith(filter))
                {
                    Console.WriteLine(element);
                }
            }
            
            Console.ReadKey();


        }

        public void addElement(string aString, List<string> aList)
        {
            if (aString.Contains(","))
            {
                string[] array;
                array = aString.Split(',');
                foreach (string element in array)
                {
                    aList.Add(element.Trim());
                }
            }
            else
            {
                aList.Add(aString.Trim());
            }
        }
    }
}
