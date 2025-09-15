using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1
{
    internal class UL5
    {
        public class ArvudeStatistika
        {
            private double[] arvud;

            public ArvudeStatistika(double[] arvud)
            {
                this.arvud = arvud;  
            }

            public double Maksimum()
            {
                return arvud.Max();
            }

            public double Minimum()
            {
                return arvud.Min();
            }

            public double Kogusumma()
            {
                return arvud.Sum();
            }

            public double Keskmine()
            {
                return arvud.Average();
            }

            public int LoendaSuuremadKuiKeskmine()
            {
                double keskmine = Keskmine();
                return arvud.Count(x => x > keskmine);
            }

            public void VäljastaStatistika()
            {
                Console.WriteLine($"Maksimaalne: {Maksimum()}");
                Console.WriteLine($"Minimaalne: {Minimum()}");
                Console.WriteLine($"Kogusumma: {Kogusumma()}");
                Console.WriteLine($"Keskmine: {Keskmine()}");
                Console.WriteLine($"Arvud, mis on suuremad kui keskmine: {LoendaSuuremadKuiKeskmine()}");

                Array.Sort(arvud);  
                Console.WriteLine("Arvud järjestatuna:");
                foreach (var arv in arvud)
                {
                    Console.Write(arv + " ");  
                }
                Console.WriteLine();
            }
        }

    }
}
