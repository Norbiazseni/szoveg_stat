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
            int db = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    db += 1;
                }
            }
            return db;
        }
        static void Kiir(int a)
        {
            Console.WriteLine($"{a} db szó van ebben a szövegben");
        }
        static void Main(string[] args)
        {
            Console.Write("Kérem a szöveget: ");
            string text = Console.ReadLine();

            int szo_db = Hany_szo(text);
            Kiir(szo_db);
            Console.WriteLine("Nyomj egy billt");
            Console.ReadKey();
        }
    }
}
