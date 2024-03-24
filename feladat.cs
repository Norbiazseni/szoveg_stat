using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoveg_stat
{
    class Program
    {
        static int Hany_szo(string s)
        {
            int db = 0;
            bool szokoz = true;  

            foreach (char c in s)
            {
                if (c == ' ' || c == '\t' || c == '\n' || c == '\r')
                {
                    szokoz = true;  
                }
                else
                {
                    if (szokoz)  
                    {
                        db++;
                        szokoz = false;  
                    }
                }
            }
            return db;
        }
        static string Visszafele(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static string[] SzavakTombbe(string s)
        {
            return s.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        }


        static void Kiir(int a, string s, string g)
        {
            Console.WriteLine($"{a} db szó van ebben a szövegben");
            Console.WriteLine($"A szavak visszafelé: {s}");
            Console.WriteLine($"{g} a leghosszabb szó");
        }

        static string Leghosszabb(string s)
        {
            string[] szavak = s.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string leghosszabbSzo = "";

            foreach (string szo in szavak)
            {
                if (szo.Length > leghosszabbSzo.Length)
                {
                    leghosszabbSzo = szo;
                }
            }

            return leghosszabbSzo;
        }

        static void Main(string[] args)
        {
            Console.Write("Kérem a szöveget: ");
            string text = Console.ReadLine();

            int szo_db = Hany_szo(text);
            string vissza_text = Visszafele(text);
            string[] szavak = SzavakTombbe(text);
            string leghosszabb = Leghosszabb(text);
            foreach (string s in szavak)
            {
                Console.WriteLine(s);
            }

            Kiir(szo_db, vissza_text, leghosszabb);
            Console.WriteLine("Nyomj egy billt");
            Console.ReadKey();
        }
    }
}
