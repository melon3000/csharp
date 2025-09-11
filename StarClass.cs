<<<<<<< HEAD
﻿using osa3funktsioonid;
using System;
using System.Collections.Generic;
using System.Linq;
=======
﻿using System;
using System.Collections;
>>>>>>> 69d6f596efe5f994d01161709d9e6c128a7577b2
using System.Text;

namespace c_1
{
    internal class StarClass
    {
        public static void Main(string[] args)
        {
<<<<<<< HEAD

            // Пример массива с 4 цифрами
            int[] arvud = { 1, 5, 7, 7 };

            // Вызов функции из файла Funktsioonid.cs
            int suurimArv = Funktsioonid.SuurimNeljarv(arvud);

            // Выводим результат
            if (suurimArv == -1)
                Console.WriteLine("Sisend on vigane!");
            else
                Console.WriteLine($"Suurim võimalik neljakohaline arv on: {suurimArv}");


            Funktsioonid.KusiMarksona("elevant", "Osta elevant ära!");

            Arvutaja.Arvumäng();
=======
            Console.OutputEncoding = Encoding.UTF8;

            double[] arvud = AnalüüsiArve.teksti_arvud();
            var tulemus = AnalüüsiArve.AnalüüsiArved(arvud);
            Console.WriteLine($"Summa: {tulemus.Item1:F2}, Keskmine: {tulemus.Item2:F2}, Korrutis: {tulemus.Item3:F2}");

            ArvuTöötlus arvutaja = new ArvuTöötlus();
            int[] ruudud = arvutaja.GenereeriRuudud(-100, 100);

            //            Console.OutputEncoding = Encoding.UTF8;
            //            Random rnd = new Random();

            //            Console.WriteLine("LLLLLLLLLLLLLLLLLLLLLLLLL");


            //            int[] arvud = new int[10];
            //            int j = 0;
            //            while (j<10)
            //            {
            //                Console.WriteLine(j + 1);
            //                arvud[j] = rnd.Next(1,101);
            //                j++;
            //            }
            //            foreach (int arv in arvud)
            //            {
            //                Console.WriteLine(arv);
            //            }
            //;
            //            Console.WriteLine("LLLLLLLLLLLLLLLLLLLLLLLLL");

            //            //OSA 3 MASSIIVID, LIST, KORDUSED

            //            List<string> nimed = new List<string>();

            //            for (int i = 0; i < 10; i++)
            //            {
            //                Console.WriteLine($"{i+1} Nimi: ");
            //                nimed.Add(Console.ReadLine());
            //            }

            //            foreach (string nimi in nimed)
            //            {
            //                Console.WriteLine(nimi);
            //            }

            //            Console.WriteLine("---");

            //            while (true)
            //            {
            //                if (j < 10)
            //                {
            //                    Console.WriteLine(j+1);
            //                    j ++;
            //                }
            //                else
            //                {
            //                    break;
            //                }
            //            }

            //            Console.WriteLine("---");

            //            List<Isik> isikud = new List<Isik>();
            //            int g = 0;
            //            do
            //            {
            //                Console.WriteLine(g + 1);
            //                Isik isik = new Isik();
            //                Console.WriteLine("Esnimi: ");
            //                isik.eesnimi = Console.ReadLine();
            //                isikud.Add(isik);
            //                g++;
            //            } while (g < 10);
            //            isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
            //            foreach (Isik isik in isikud)
            //            {
            //                Console.WriteLine("Kokku on", isikud.Count, "isikud");
            //                isik.Prindi();
            //                Console.WriteLine("Kolmandal kohal on", isikud[2], "isik");
            //            }
>>>>>>> 69d6f596efe5f994d01161709d9e6c128a7577b2







<<<<<<< HEAD


            //2. Osa - Valikud


            //3. Имена и возрасты Задача: Создайте класс Человек { string Имя; int Возраст; }.
            //Создайте метод Статистика(Список люди), который: вычисляет сумму всех возрастов и средний возраст,
            //находит самого старшего и самого молодого человека, возвращает эти значения в Tuple.
            //Пользователь вводит 5 человек (имя и возраст отдельно).


            //    Console.OutputEncoding = Encoding.UTF8;

            //    var inimesed = new List<string>();
            //    var vanused = new List<int>();

            //    // Сбор данных
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

            //    // Вызов статистической функции
            //    var (sum, avg, youngestPerson, oldestPerson, minAge, maxAge) = Statistika(inimesed, vanused);

            //    // Вывод результатов
            //    Console.WriteLine($"\nVanuste summa: {sum}");
            //    Console.WriteLine($"Vanuste keskmine: {avg:F2}");
            //    Console.WriteLine($"Kõige vanem inimene: {oldestPerson}, Vanus: {maxAge}");
            //    Console.WriteLine($"Kõige noorem inimene: {youngestPerson}, Vanus: {minAge}");
            //}

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




            //Console.OutputEncoding = Encoding.UTF8;
            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.Write("Tere tulemast!, \nInput Text: ");
            //string tekst = Console.ReadLine();
            //Console.WriteLine($"{tekst}, Rõõm Näha");
            //int a = 1000;
            //char taht = 'A';
            //Console.Write($"Esimene arv on {a}, Sisesta b = ... ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Summa = {a+b}");
            //Console.WriteLine("Ujukomaarv");
            //double d=double.Parse(Console.ReadLine());
            //Console.WriteLine(d);
            //float f=float.Parse(Console.ReadLine());
            //Console.WriteLine(f);
            //bool t = true;

            //Random rnd = new Random();
            //a = rnd.Next(-10, 10);
            //Console.WriteLine(a);
            //float vastus = funktsioonid.kalkulaator(f, a);
            //Console.Write($"vastus: {vastus}");
            Console.ReadKey();
=======
            //// ÜLESANNE 1
            //Console.WriteLine("=== ÜLESANNE 1 ===");
            //try
            //{
            //    Console.Write("Mis on sinu nimi? ");
            //    string Nimi = Console.ReadLine();

            //    // Убрана проверка IsValidName

            //    if (Nimi.ToLower() == "juku")
            //    {
            //        Console.WriteLine("Tere tulemast tagasi, Juku! Kui vana sa oled?");
            //        string vanusSisend = Console.ReadLine();
            //        if (!int.TryParse(vanusSisend, out int vanus))
            //        {
            //            Console.WriteLine("Viga: vanus peab olema täisarv.");
            //        }
            //        else
            //        {
            //            string hind = Funktsioonid.Hind(vanus);
            //            Console.WriteLine($"Sinu piletihind on: {hind}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Tere tulemast, {Nimi}!");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Viga: {e.Message}");
            //}

            //// ÜLESANNE 2
            //Console.WriteLine("=== ÜLESANNE 2 ===");
            //try
            //{
            //    Console.Write("Sisesta esimese inimese nimi: ");
            //    string nimi1 = Console.ReadLine();
            //    Console.Write("Sisesta teise inimese nimi: ");
            //    string nimi2 = Console.ReadLine();

            //    // Убрана проверка IsValidName

            //    Console.WriteLine($"{nimi1} ja {nimi2} on täna pinginaabrid.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Viga: {e.Message}");
            //}

            //// ÜLESANNE 3
            //Console.WriteLine("=== ÜLESANNE 3 ===");
            //try
            //{
            //    Console.Write("Sisesta toa pikkus (m): ");
            //    string pikkusSisend = Console.ReadLine();
            //    Console.Write("Sisesta toa laius (m): ");
            //    string laiusSisend = Console.ReadLine();

            //    if (!double.TryParse(pikkusSisend, out double pikkus) || pikkus <= 0)
            //    {
            //        Console.WriteLine("Viga: toa pikkus peab olema positiivne number.");
            //    }
            //    else if (!double.TryParse(laiusSisend, out double laius) || laius <= 0)
            //    {
            //        Console.WriteLine("Viga: toa laius peab olema positiivne number.");
            //    }
            //    else
            //    {
            //        double pindala = pikkus * laius;
            //        Console.WriteLine($"Põranda pindala on: {pindala} ruutmeetrit.");

            //        Console.Write("Kas soovid teha remonti? (jah/ei): ");
            //        string remontVastus = Console.ReadLine().ToLower();

            //        if (remontVastus == "jah")
            //        {
            //            Console.Write("Kui palju maksab ruutmeeter? ");
            //            string ruutmeeterHindSisend = Console.ReadLine();

            //            if (!double.TryParse(ruutmeeterHindSisend, out double ruutmeeterHind) || ruutmeeterHind < 0)
            //            {
            //                Console.WriteLine("Viga: ruutmeetri hind peab olema positiivne number.");
            //            }
            //            else
            //            {
            //                double remontHind = ruutmeeterHind * pindala;
            //                Console.WriteLine($"Põranda vahetamise hind on: {remontHind}.");
            //            }
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Viga: {e.Message}");
            //}

            //// ÜLESANNE 4
            //Console.WriteLine("=== ÜLESANNE 4 ===");
            //try
            //{
            //    Console.Write("Sisesta hind 30% allahindlusega: ");
            //    string hindSisend = Console.ReadLine();

            //    if (!double.TryParse(hindSisend, out double allahindlusHind) || allahindlusHind < 0)
            //    {
            //        Console.WriteLine("Viga: hind peab olema positiivne number.");
            //    }
            //    else
            //    {
            //        double algHind = allahindlusHind / 0.7;
            //        Console.WriteLine($"Algne hind oli: {algHind:F2}");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Viga: {e.Message}");
            //}

            //// ÜLESANNE 5
            //Console.WriteLine("=== ÜLESANNE 5 ===");
            //try
            //{
            //    Console.Write("Sisesta temperatuur (°C): ");
            //    string tempSisend = Console.ReadLine();

            //    if (!double.TryParse(tempSisend, out double temperatuur))
            //    {
            //        Console.WriteLine("Viga: temperatuur peab olema arv.");
            //    }
            //    else
            //    {
            //        if (temperatuur > 18)
            //            Console.WriteLine("Temperatuur on üle 18 kraadi, soovitav toasoojus talvel.");
            //        else
            //            Console.WriteLine("Temperatuur on alla 18 kraadi.");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Viga: {e.Message}");
            //}

            //// ÜLESANNE 6
            //Console.WriteLine("=== ÜLESANNE 6 ===");
            //try
            //{
            //    Console.Write("Sisesta inimese pikkus (cm): ");
            //    string pikkusSisend = Console.ReadLine();

            //    if (!int.TryParse(pikkusSisend, out int pikkusInimene) || pikkusInimene <= 0)
            //    {
            //        Console.WriteLine("Viga: pikkus peab olema positiivne täisarv.");
            //    }
            //    else
            //    {
            //        if (pikkusInimene < 150)
            //            Console.WriteLine("Sa oled lühike.");
            //        else if (pikkusInimene <= 180)
            //            Console.WriteLine("Sa oled keskmise pikkusega.");
            //        else
            //            Console.WriteLine("Sa oled pikk.");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Viga: {e.Message}");
            //}

            //// ÜLESANNE 7
            //Console.WriteLine("=== ÜLESANNE 7 ===");
            //try
            //{
            //    Console.Write("Sisesta inimese pikkus (cm): ");
            //    string pikkus2Sisend = Console.ReadLine();
            //    Console.Write("Sisesta inimese sugu (M/N): ");
            //    string sugu = Console.ReadLine().ToUpper();

            //    if (!int.TryParse(pikkus2Sisend, out int pikkus2) || pikkus2 <= 0)
            //    {
            //        Console.WriteLine("Viga: pikkus peab olema positiivne täisarv.");
            //    }
            //    else
            //    {
            //        if (sugu == "M")
            //        {
            //            if (pikkus2 < 160)
            //                Console.WriteLine("Mees on lühike.");
            //            else if (pikkus2 <= 190)
            //                Console.WriteLine("Mees on keskmise pikkusega.");
            //            else
            //                Console.WriteLine("Mees on pikk.");
            //        }
            //        else if (sugu == "N")
            //        {
            //            if (pikkus2 < 150)
            //                Console.WriteLine("Naine on lühike.");
            //            else if (pikkus2 <= 175)
            //                Console.WriteLine("Naine on keskmise pikkusega.");
            //            else
            //                Console.WriteLine("Naine on pikk.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sugu sisestati valesti.");
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Viga: {e.Message}");
            //}

            //// ÜLESANNE 8
            //Console.WriteLine("=== ÜLESANNE 8 ===");
            //try
            //{
            //    Console.WriteLine("Kas soovid osta piima? (jah/ei)");
            //    string piim = Console.ReadLine().ToLower();
            //    Console.WriteLine("Kas soovid osta saia? (jah/ei)");
            //    string sai = Console.ReadLine().ToLower();
            //    Console.WriteLine("Kas soovid osta leiba? (jah/ei)");
            //    string leib = Console.ReadLine().ToLower();

            //    double hindKokku = 0;
            //    if (piim == "jah") hindKokku += 1.20;
            //    if (sai == "jah") hindKokku += 0.80;
            //    if (leib == "jah") hindKokku += 1.00;

            //    Console.WriteLine($"Sinu ostukorvi hind kokku on: {hindKokku:F2} eurot.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Viga: {e.Message}");
            //}
>>>>>>> 69d6f596efe5f994d01161709d9e6c128a7577b2
        }
    }
}
