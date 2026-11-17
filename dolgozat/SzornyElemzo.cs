using System;
using System.Collections.Generic;
using System.Text;

namespace dolgozat
{
    internal class Szornyelemzo
    {
        private List<Szorny> szornyek = [];

        public Szornyelemzo(List<Szorny> szornyek)
        {
            this.szornyek = szornyek;
        }

        public int OsszesSzornySzama()
        {
            return szornyek.Count();
        }

        public IEnumerable<string> VeszelyesSzornyekNevei()
        {
            return szornyek.Where(sz => sz.VeszelyesE == true).Select(sz => sz.Nev);
        }

        public IEnumerable<string> EgyediElohelyek()
        {
            return szornyek.Select(sz => sz.Elohely).Distinct().OrderBy(e => e);
        }

        public double AtlagosVeszelyesseg()
        {
            return szornyek.Average(sz => sz.VeszelyessegiSzint);
        }
    }
}
