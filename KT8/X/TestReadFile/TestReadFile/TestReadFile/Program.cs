using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\Xing\Google Drive\My Documents\ORU\Termin 3\Del2 Objektorienterad programmering med C#\KT8\X\aTextFile.txt";
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                var sr = new StreamReader(fs);
                var filecontent = sr.ReadToEnd();
                Console.Write(filecontent);
                sr.Close();
            }
            Console.ReadKey();
        }
    }
}
