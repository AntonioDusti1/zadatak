using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SystemIO
{
    internal class streamPisac
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Upišite prezime: ");
            string prezime = Console.ReadLine();

            StreamWriter sw = new StreamWriter(
                @"c:\prviDir\mojaDatoteka.txt");

            sw.WriteLine("Ime: {0}", ime);
            sw.WriteLine("Prezime: {0}", prezime);
            sw.Close();


            StreamReader sr = new StreamReader(
                @"c:\prviDir\mojaDatoteka.txt");

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();

            Console.ReadKey();
        }
    }
}