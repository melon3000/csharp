using KaloridApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static c_1.UL5;

namespace c_1
{
    internal class StarClass
    {
        static double[] arvud;
        public static void Main(string[] args)
        {
            Tekstist_arvud();

            ArvudeStatistika stat = new ArvudeStatistika(arvud);
            stat.VäljastaStatistika();  
        }
        static void Tekstist_arvud()
        {
            Console.WriteLine("Sisesta arvud tühikuga eraldatult:");
            string sisend = Console.ReadLine();

            string[] osad = sisend.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            arvud = new double[osad.Length];

            bool vigane = false; 

            for (int i = 0; i < osad.Length; i++)
            {
                if (!double.TryParse(osad[i], out arvud[i]))
                {
                    Console.WriteLine($"Vigane sisend: {osad[i]} ei ole arv. Palun sisesta uuesti.");
                    vigane = true;
                    break;
                }
            }

            if (vigane)
            {
                Tekstist_arvud();
            }
        
    

       



    //Console.WriteLine("=== Kalorite kalkulaator ===");

    //Console.Write("Sisesta oma nimi: ");
    //string nimi = Console.ReadLine();

    //Console.Write("Sisesta oma vanus (aastates): ");
    //int vanus = int.Parse(Console.ReadLine());

    //Console.Write("Sisesta sugu (mees/naine): ");
    //string sugu = Console.ReadLine();

    //Console.Write("Sisesta pikkus (cm): ");
    //double pikkus = double.Parse(Console.ReadLine());

    //Console.Write("Sisesta kaal (kg): ");
    //double kaal = double.Parse(Console.ReadLine());

    //Console.WriteLine("\nVali aktiivsustase:");
    //Console.WriteLine("1. Väheaktiivne (1.2)");
    //Console.WriteLine("2. Mõõdukalt aktiivne (1.55)");
    //Console.WriteLine("3. Väga aktiivne (1.9)");
    //Console.Write("Sisesta valik (1/2/3): ");
    //string valik = Console.ReadLine();

    //double aktiivsus = 1.2;
    //if (valik == "2") aktiivsus = 1.55;
    //else if (valik == "3") aktiivsus = 1.9;

    //double kalorid = Kalorid.ArvutaKalorivajadus(sugu, vanus, pikkus, kaal, aktiivsus);

    //Console.WriteLine($"\n{nimi} päevane energiavajadus: {kalorid:F0} kcal");




    //    // Пример массива с 4 цифрами
    //    int[] arvud = { 1, 5, 7, 7 };

    //    // Вызов функции из файла Funktsioonid.cs
    //    int suurimArv = Funktsioonid.SuurimNeljarv(arvud);

    //    // Выводим результат
    //    if (suurimArv == -1)
    //        Console.WriteLine("Sisend on vigane!");
    //    else
    //        Console.WriteLine($"Suurim võimalik neljakohaline arv on: {suurimArv}");

    //    Funktsioonid.KusiMarksona("elevant", "Osta elevant ära!");

    //    Arvutaja.Arvumäng();
    //    Console.OutputEncoding = Encoding.UTF8;

    //    double[] arvud = AnalüüsiArve.teksti_arvud();
    //    var tulemus = AnalüüsiArve.AnalüüsiArved(arvud);
    //    Console.WriteLine($"Summa: {tulemus.Item1:F2}, Keskmine: {tulemus.Item2:F2}, Korrutis: {tulemus.Item3:F2}");

    //    ArvuTöötlus arvutaja = new ArvuTöötlus();
    //    int[] ruudud = arvutaja.GenereeriRuudud(-100, 100);

    //    // List processing section (for names)
    //    List<string> nimed = new List<string>();

    //    for (int i = 0; i < 10; i++)
    //    {
    //        Console.WriteLine($"{i + 1} Nimi: ");
    //        nimed.Add(Console.ReadLine());
    //    }

    //    foreach (string nimi in nimed)
    //    {
    //        Console.WriteLine(nimi);
    //    }

    //    Console.WriteLine("---");

    //    // Using a do-while loop to collect person data
    //    List<Isik> isikud = new List<Isik>();
    //    int g = 0;
    //    do
    //    {
    //        Console.WriteLine(g + 1);
    //        Isik isik = new Isik();
    //        Console.WriteLine("Esnimi: ");
    //        isik.eesnimi = Console.ReadLine();
    //        isikud.Add(isik);
    //        g++;
    //    } while (g < 10);

    //    isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));

    //    foreach (Isik isik in isikud)
    //    {
    //        Console.WriteLine($"Kokku on {isikud.Count} isikut.");
    //        isik.Prindi();
    //    }

    //    // Start of task 2 - Collecting names and ages for statistics
    //    var inimesed = new List<string>();
    //    var vanused = new List<int>();

    //    // Collect data
    //    for (int i = 0; i < 5; i++)
    //    {
    //        Console.Write($"{i + 1}. Sisesta nimi: ");
    //        string nimi = Console.ReadLine();
    //        inimesed.Add(nimi);

    //        int vanus;
    //        while (true)
    //        {
    //            Console.Write($"{i + 1}. Sisesta vanus: ");
    //            if (int.TryParse(Console.ReadLine(), out vanus) && vanus >= 0)
    //                break;
    //            else
    //                Console.WriteLine("Palun sisesta kehtiv positiivne number.");
    //        }
    //        vanused.Add(vanus);
    //    }

    //    // Call statistics function
    //    var (sum, avg, youngestPerson, oldestPerson, minAge, maxAge) = Statistika(inimesed, vanused);

    //    // Output results
    //    Console.WriteLine($"\nVanuste summa: {sum}");
    //    Console.WriteLine($"Vanuste keskmine: {avg:F2}");
    //    Console.WriteLine($"Kõige vanem inimene: {oldestPerson}, Vanus: {maxAge}");
    //    Console.WriteLine($"Kõige noorem inimene: {youngestPerson}, Vanus: {minAge}");


    //// Statistics function
    //static (int sum, double avg, string youngestPerson, string oldestPerson, int minAge, int maxAge)
    //    Statistika(List<string> inimesed, List<int> vanused)
    //{
    //    int sum = 0;
    //    int minAge = int.MaxValue;
    //    int maxAge = int.MinValue;
    //    string youngestPerson = null;
    //    string oldestPerson = null;

    //    for (int i = 0; i < vanused.Count; i++)
    //    {
    //        int age = vanused[i];
    //        sum += age;

    //        if (age < minAge)
    //        {
    //            minAge = age;
    //            youngestPerson = inimesed[i];
    //        }

    //        if (age > maxAge)
    //        {
    //            maxAge = age;
    //            oldestPerson = inimesed[i];
    //        }
    //    }

    //    double avg = vanused.Count > 0 ? sum / (double)vanused.Count : 0;

    //    return (sum, avg, youngestPerson, oldestPerson, minAge, maxAge);
}
    }
}
