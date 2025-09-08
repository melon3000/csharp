using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace c_1
{
    internal class ArvuTöötlus
    {
        Random rnd = new Random();

        public int[] GenereeriRuudud(int min, int max)
        {
            // Genereerime 2 juhuslikku täisarvu vahemikus [-100, 100]
            int N = rnd.Next(-100, 101);
            int M = rnd.Next(-100, 101);

            // Leiame väiksema ja suurema väärtuse, et teha vahemik
            int start = Math.Min(N, M);
            int end = Math.Max(N, M);

            int length = end - start + 1; //Max - Min arv
            int[] ruudud = new int[length]; //Loome uus masiiv ruudud

            Console.WriteLine($"Min_Number = {start}, Max_number = {end}, Vahemik = {length} arvud");
            Console.WriteLine("-----------");

            // Täidame massiivi ruutudega
            for (int i = 0; i < length; i++)
            {
                int number = start + i;
                ruudud[i] = number * number;
            }

            // Prindime tulemused koos algväärtustega
            for (int i = 0; i < length; i++)
            {
                int number = start + i;
                Console.WriteLine($"{number} → {ruudud[i]}");
            }

            return ruudud;
        }
    }
}
