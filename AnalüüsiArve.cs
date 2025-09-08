using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1
{
    internal class AnalüüsiArve
    {
        public static double[] teksti_arvud()
        {
            Console.WriteLine("Siseta arvud koma või tühikuga earaldatuld: ");
            string sisend = Console.ReadLine();
            char[] eraldajad = new char[] {' '}; // ';'

            string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);
            double[] arvud = new double[osad.Length];
            for(int i = 0; i < osad.Length; i++)
            {
                arvud[i] = Convert.ToDouble(osad[i]);
            }
            return arvud;
        }
        public static Tuple<double, double, double> AnalüüsiArved(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;

            foreach (double arv in arvud)
            {
                korrutis *= (double)arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }
    }
}
