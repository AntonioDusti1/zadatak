using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO
{
    internal class klasaDirectory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();

            //provjera da li direktorij postoji
            if (Directory.Exists(putanja))
            {
                //ako direktorij postoji, ispisujemo sve datoteke u njemu
                Console.WriteLine("Datoteke: ");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }

            //putanja za poddirektorij Test
            string putanjaPoddirektorija = "\\Test";
            // spajanje putanja u jednu
            string novaPutanja = putanja + putanjaPoddirektorija;

            //ako direktorij ne postoji, kreirat ćemo ga
            if (!Directory.Exists(novaPutanja))
            {
                Directory.CreateDirectory(novaPutanja);
            }
            //ako direktorij postoji, ispisujemo poruku
            else
            {
                Console.WriteLine("Direktorij već postoji!");
            }

            //ispis svih poddirektorija
            Console.WriteLine("Poddirektoriji: ");
            foreach (string poddirektorij
                in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(poddirektorij);
            }

            Directory.Delete(novaPutanja);

            Console.WriteLine("Nakon brisanja: ");
            foreach (string poddirektorij
                in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(poddirektorij);
            }
            Console.ReadKey();
        }
    }
}
