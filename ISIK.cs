using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1
{
    internal class Isik
    {
        public string eesnimi;
        public string perenimi;
        public int synniaasta;

        public Isik() { }
        public Isik(string eesnimi, string perenimi, int synniaasta)
        {   
            this.eesnimi = eesnimi;
            this.perenimi = "tundmatu";
            this.synniaasta = 2022;
        }

        public void Prindi()
        {
            Console.WriteLine($"{eesnimi}, {perenimi}, {synniaasta}");
        }

    }
}
