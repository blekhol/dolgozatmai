namespace dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis szornyAdatbazis = new SzornyAdatbazis();
            List<Szorny> szornyek = szornyAdatbazis.Feltolt();

            
        }
    }
}
