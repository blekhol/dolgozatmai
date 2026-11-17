namespace dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis db = new SzornyAdatbazis();
            List<Szorny> szornyek = db.Feltolt();
            Szornyelemzo elemzo = new Szornyelemzo(szornyek);


            Console.WriteLine("1. =============================");
            Console.WriteLine($"A Listában lévő szörnyek száma: {elemzo.OsszesSzornySzama()}");

            Console.WriteLine("\n2. =============================");
            Console.WriteLine("Veszélyes szörnyek nevei: \n");
            foreach(string nev in elemzo.VeszelyesSzornyekNevei())
            {
                Console.WriteLine(nev);
            }

            Console.WriteLine("\n3. =============================");
            Console.WriteLine("Élőhelyek: \n");
            foreach (string elohely in elemzo.EgyediElohelyek())
            {
                Console.WriteLine(elohely);
            }

            Console.WriteLine("\n4. =============================");
            Console.WriteLine($"Átlagos veszélyesség: {elemzo.AtlagosVeszelyesseg()}");            

            Console.WriteLine("\n5. =============================");
            Console.WriteLine("Legveszélyesebb szörny(ek): \n");
            foreach (Szorny szorny in elemzo.LegveszelyesebbSzornyek())
            {
                Console.WriteLine($"{szorny.Nev}, szintje: {szorny.VeszelyessegiSzint}");
            }

            Console.WriteLine("\n6. =============================");
            Console.WriteLine("Fekete mocsári veszélyes szörnyek(szint >= 5):\n");
            foreach (Szorny szorny in elemzo.MocsariVeszelyesSzornyek())
            {
                Console.WriteLine($"{szorny.Nev}, szintje: {szorny.VeszelyessegiSzint}");
            }

            Console.WriteLine("\n7. =============================");
            string vanE = elemzo.VanExtremTuzGyengeSzorny() ? "Van":"Nincs";
            Console.WriteLine($"Van-e tűz gyenge 9-nél nagyobb szintű? {vanE}");

            Console.WriteLine("\n8. =============================");
            Console.WriteLine("Szörnyek száma élőhelyenként: \n");
            foreach (string szamok in elemzo.SzornyekSzamaElohelyenkent())
            {
                Console.WriteLine(szamok);
            }
        }
    }
}
