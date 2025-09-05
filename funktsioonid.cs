using System;

namespace c_1
{
    internal class Funktsioonid
    {
        public static string Hind(int vanus)
        {
            if (vanus < 0 || vanus > 100)
                return $"Viga! Sisestatud vanus {vanus} on vale!";
            else if (vanus < 6)
                return "Tasuta";
            else if (vanus < 15)
                return "Lastepilet";
            else if (vanus < 66)
                return "Täispilet";
            else
                return "Sooduspilet";
        }

        public static float kalkulaator(float arv1, float arv2)
        {
            return arv1 * arv2;
        }

        public static string KuuNimetus(int kuu_nr)
        {
            switch (kuu_nr)
            {
                case 1: return "Jaanuar";
                case 2: return "Veebruar";
                case 3: return "Märts";
                case 4: return "Aprill";
                case 5: return "Mai";
                case 6: return "Juuni";
                case 7: return "Juuli";
                case 8: return "August";
                case 9: return "September";
                case 10: return "Oktoober";
                case 11: return "November";
                case 12: return "Detsember";
                default: return "Viga!";
            }
        }

        public static string Hooaeg(int kuu_nr)
        {
            if (kuu_nr == 12 || kuu_nr == 1 || kuu_nr == 2) return "Talv";
            else if (kuu_nr >= 3 && kuu_nr <= 5) return "Kevad";
            else if (kuu_nr >= 6 && kuu_nr <= 8) return "Suvi";
            else if (kuu_nr >= 9 && kuu_nr <= 11) return "Sügis";
            else return "Viga!";
        }
    }
}
