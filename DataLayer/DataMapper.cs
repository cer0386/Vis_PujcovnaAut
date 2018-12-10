using ClassLibrary1;
using ClassLibrary1.DomainModel;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataMapper
    {
        public List<Zakaznik> Find()
        {
            string sql = ("Select * from vis.Zakaznik");
            List<Zakaznik> zakaznici = new List<Zakaznik>();
            using (SqlConnection connection = new SqlConnection(DBConnector.GetBuilder().ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            zakaznici.Add(MapZakToObj(reader));
                        }
                    }
                }
            }
            return zakaznici;
        }

        public Zakaznik Find(int id)
        {
            string sql = ("Select * from vis.Zakaznik where id = @id");
            Zakaznik zakaznik = null;
            using(SqlConnection connection = new SqlConnection(DBConnector.GetBuilder().ConnectionString))
            {
                connection.Open();
                using(SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            zakaznik = MapZakToObj(reader);
                        }
                    }
                }
            }
            return zakaznik;
        }

        public Zakaznik Find(string jmeno, string prijmeni, string ridicak)
        {
            string sql = ("Select * from vis.Zakaznik where");
            Zakaznik zakaznik = null;
            if (jmeno != null && prijmeni != null)
                sql += " jmeno = \'" + jmeno + "\' and prijmeni = \'" + prijmeni + "\'";
            else if (ridicak != null && jmeno != null)
                sql += " and cislo_ridickeho_prukazu = \'" + ridicak + "\'";
            else
                sql += " cislo_ridickeho_prukazu = \'" + ridicak + "\'";
            using (SqlConnection connection = new SqlConnection(DBConnector.GetBuilder().ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            zakaznik = MapZakToObj(reader);
                        }
                    }
                }
            }
            return zakaznik;
        }
        

        public int Save()
        {
            return 0;
        }

        public int Delete()
        {
            return 0;
        }

        private static Zakaznik MapZakToObj(SqlDataReader reader)
        {
            Zakaznik zakaznik = new Zakaznik();
            zakaznik.ID = reader.GetInt32(0);
            zakaznik.Jmeno = reader.GetString(1);
            zakaznik.Prijmeni = reader.GetString(2);
            zakaznik.Mesto = reader.GetString(3);
            zakaznik.Ulice = reader.GetString(4);
            zakaznik.CisloPopisne = reader.GetInt32(5);
            zakaznik.PSC = reader.GetInt32(6);
            zakaznik.Email = reader.GetString(7);
            zakaznik.cisloRidicskehoPrukazu = reader.GetString(8);

            return zakaznik;
        }

        
        private static Zamestnanec MapZamToObj(SqlDataReader reader)
        {
            Zamestnanec zamestnanec = new Zamestnanec();
            zamestnanec.ID = reader.GetInt32(0);
            zamestnanec.Jmeno = reader.GetString(1);
            zamestnanec.Prijmeni = reader.GetString(2);
            zamestnanec.Email = reader.GetString(3);
            return zamestnanec;
        }

        private static Faktura MapFakToObj(SqlDataReader reader)
        {
            Faktura faktura = new Faktura();
            faktura.id_faktury = reader.GetInt32(0);
            faktura.vytvorena = reader.GetDateTime(1);
            faktura.potvrzena = reader.GetDateTime(2);
            faktura.zaplacena = reader.GetDateTime(3);
            return faktura;
        }

        private static Platba MapPlaToObj(SqlDataReader reader)
        {
            Platba platba = new Platba();
            platba.id_platby = reader.GetInt32(0);
            platba.typ_platby = reader.GetString(1);
            platba.castka = reader.GetDouble(2);
            return platba;
        }

        private static Rezervace MapRezToObj(SqlDataReader reader)
        {
            Rezervace rezervace = new Rezervace();
            rezervace.id_rezervace = reader.GetInt32(0);
            rezervace.zacatekRezervace = reader.GetDateTime(1);
            rezervace.konecRezervace = reader.GetDateTime(2);
            
            return rezervace;
        }

        private static Auto MapAutToObj(SqlDataReader reader)
        {
            Auto auto = new Auto();
            auto.SPZ = reader.GetString(0);
            auto.datumZakoupeni = reader.GetDateTime(1);
            auto.STK = reader.GetDateTime(2);
            auto.typ = reader.GetString(3);
            auto.znacka = reader.GetString(4);
            auto.pocetNehod = reader.GetInt32(5);
            auto.cenaZaDen = reader.GetDouble(6);
            auto.vyrazeno = reader.GetBoolean(7);

            return auto;
        }
        
        private static Rezervovano MapRezervToObj(SqlDataReader reader)
        {
            Rezervovano rezervovano = new Rezervovano();
            rezervovano.cisloRezervace = reader.GetInt32(0);
            rezervovano.SPZ = reader.GetString(1);
            return rezervovano;
        }

        private static Upravuje MapUpravToObj(SqlDataReader reader)
        {
            Upravuje upravuje = new Upravuje();
            upravuje.IDzamestnance = reader.GetInt32(0);
            upravuje.cisloRezervace = reader.GetInt32(1);
            return upravuje;
        }



    }
}
