using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1
{
    internal class StarClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Tere tulemast!, \nInput Text: ");
            string tekst = Console.ReadLine();
            Console.WriteLine($"{tekst}, Rõõm Näha");
            int a = 1000;
            char taht = 'A';
            Console.Write($"Esimene arv on {a}, Sisesta b = ... ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Summa = {a+b}");
            Console.WriteLine("Ujukomaarv");
            double d=double.Parse(Console.ReadLine());
            Console.WriteLine(d);
            float f=float.Parse(Console.ReadLine());
            Console.WriteLine(f);
            bool t = true;

            Random rnd = new Random();
            a = rnd.Next(-10, 10);
            Console.WriteLine(a);
            float vastus = funktsioonid.kalkulaator(f, a);
            Console.Write($"vastus: {vastus}");
        }
    }
}
