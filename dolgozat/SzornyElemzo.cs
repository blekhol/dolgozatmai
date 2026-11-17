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

        public IEnumerable<Szorny> LegveszelyesebbSzornyek()
        {
            return szornyek.Where(sz => sz.VeszelyessegiSzint == szornyek.Select(sz => sz.VeszelyessegiSzint).Max());
        }

        public IEnumerable<Szorny> MocsariVeszelyesSzornyek()
        {
            return szornyek.Where(sz => sz.Elohely == "Fekete Mocsár" && sz.VeszelyessegiSzint >= 5).OrderByDescending(sz => sz.VeszelyessegiSzint);
        }


    }
}
