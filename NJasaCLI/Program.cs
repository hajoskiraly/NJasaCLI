using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Linq;

namespace NJasaCLI
{
    internal class Program
    {
        static List<beolvasas> beolvasasok = new List<beolvasas>();

        static void Main(string[] args)
        {
            using (var sr = new StreamReader("NASAmissions.txt"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    beolvasasok.Add(new beolvasas(sr.ReadLine()));
                }
                sr.Close();
            }
            //feladat 3
            int kuldetesekszama = beolvasasok.Count;
            Console.WriteLine("{0} kuldetes talalhato az allomanyban.", kuldetesekszama);

            // feladat 4
            Console.Write("adjon meg egy kuldetest: ");
            string bekeres = Console.ReadLine();
            var matches = beolvasasok.Where(x => x.nev != null && x.nev.IndexOf(bekeres, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            if (matches.Count > 0)
            {
                foreach (var m in matches)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Nev: {0}", m.nev);
                    Console.WriteLine("Ev: {0}", m.ev);
                    Console.WriteLine("Celpont: {0}", m.celpont);
                    Console.WriteLine("Legenyseg: {0}", m.legenyseg);
                    Console.WriteLine("Sikeres: {0}", m.sikeres);
                    Console.WriteLine("Leiras: {0}", m.leiras);
                    Console.WriteLine("Koltseg: {0}", m.koltseg);
                    Console.WriteLine("Hasznosteher: {0}", m.hasznosteher);
                }
            }
            else
            {
                Console.WriteLine("Nincs talalat.");
            }
            // feladat 5 


        }
        
     }
}


