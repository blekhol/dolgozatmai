using System;
using System.Collections.Generic;
using System.Text;

namespace dolgozat
{
    internal class SzornyAdatbazis
    {
        private readonly string connectionString = "server=localhost;database=valamibest;uid=root;pwd=";

        public List<Szorny> Feltolt()
        {
            var szornyek = new List<Szorny>();

            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM szornyek";
                using (var command = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("Id");
                            string nev = reader.GetString("Nev");
                            int veszelyessegiSzint = reader.GetInt32("VeszelyessegiSzint");
                            string elohely = reader.GetString("Elohely");
                            string foGyengeseg = reader.GetString("FoGyengeseg");
                            string leggyakoribbZsakmany = reader.GetString("LeggyakoribbZsakmany");
                            bool veszelyesE = reader.GetBoolean("VeszelyesE");
                            var szorny = new Szorny(id, nev, veszelyessegiSzint, elohely, foGyengeseg, leggyakoribbZsakmany, veszelyesE);
                            szornyek.Add(szorny);
                        }
                    }
                }
            }

            return szornyek;
        }
    }
}
