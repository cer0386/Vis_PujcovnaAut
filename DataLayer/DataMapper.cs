﻿using DomainLayer;
using DomainLayer.DomainModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    //autoIncrement id u novych zams and zaks
    //selects
    public class DataMapper
    {
        public List<Zakaznik> FindZak()
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

        public Zakaznik FindZak(int id)
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

        public Zakaznik FindZak(string jmeno, string prijmeni, string ridicak)
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
        

        public int SaveZak(Zakaznik zakaznik)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("INSERT INTO vis.zakaznik (id_zakaznika,jmeno,prijmeni,mesto, ulice, cislo_popisne, psc, email, cislo_ridicskeho_prukazu)");
                sb.Append("VALUES (@id_zakaznika, @jmeno, @prijmeni, @mesto, @ulice,@cislo_popisne,@psc,@email,@cislo_ridicskeho_prukazu);");
                //sb.Append("SELECT CAST(scope_identity() AS int)");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_zakaznika", zakaznik.ID);
                    command.Parameters.AddWithValue("@jmeno", zakaznik.Jmeno);
                    command.Parameters.AddWithValue("@prijmeni", zakaznik.Prijmeni);
                    command.Parameters.AddWithValue("@mesto", zakaznik.Mesto);
                    command.Parameters.AddWithValue("@ulice", zakaznik.Ulice);
                    command.Parameters.AddWithValue("@cislo_popisne", zakaznik.CisloPopisne);
                    command.Parameters.AddWithValue("@psc", zakaznik.PSC);
                    command.Parameters.AddWithValue("@email", zakaznik.Email);
                    command.Parameters.AddWithValue("@cislo_ridicskeho_prukazu", zakaznik.cisloRidicskehoPrukazu);
                }
            }
            return 0;
        }
        public int DeleteZak(Zakaznik zakaznik)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("DELETE FROM vis.zakaznik where id_zakaznika = @id");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", zakaznik.ID);

                }
            }

            return 0;
        }
        public int SaveZam(Zamestnanec zamestnanec)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("INSERT INTO vis.zamestnanec (id_zamestnance,jmeno,prijmeni,email, pozice)");
                sb.Append("VALUES (@id, @jmeno, @prijmeni,@email,@pozice);");
                //sb.Append("SELECT CAST(scope_identity() AS int)");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", zamestnanec.ID);
                    command.Parameters.AddWithValue("@jmeno", zamestnanec.Jmeno);
                    command.Parameters.AddWithValue("@prijmeni", zamestnanec.Prijmeni);
                    command.Parameters.AddWithValue("@email", zamestnanec.Email);
                    command.Parameters.AddWithValue("@pozice", zamestnanec.Pozice);
                }
            }

            return 0;
        }
        public int DeleteZam(Zamestnanec zamestnanec)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("DELETE FROM vis.zamestnanec where id_zamestnance = @id");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", zamestnanec.ID);

                }
            }
            return 0;
        }
        public int SaveAuto(Auto auto)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("INSERT INTO vis.auto (spz,zakoupeno,stk,typ, znacka, pocet_nehod, cena_za_den, vyrazeno  )");
                sb.Append("VALUES (@spz, @zakoupeno, @stk, @typ, @znacka,@pocet_nehod,@cena_za_den,@vyrazeno);");
                //sb.Append("SELECT CAST(scope_identity() AS int)");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@spz", auto.SPZ);
                    command.Parameters.AddWithValue("@zakoupeno", auto.datumZakoupeni);
                    command.Parameters.AddWithValue("@stk", auto.STK);
                    command.Parameters.AddWithValue("@typ", auto.typ);
                    command.Parameters.AddWithValue("@znacka", auto.znacka);
                    command.Parameters.AddWithValue("@pocet_nehod", auto.pocetNehod);
                    command.Parameters.AddWithValue("@cena_za_den", auto.cenaZaDen);
                    command.Parameters.AddWithValue("@vyrazeno", auto.vyrazeno);
                }
            }
            return 0;
        }
        public int DeleteAuto(Auto auto)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("DELETE FROM vis.auto where SPZ = @spz");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@spz", auto.SPZ);

                }
            }
            return 0;
        }
        public int SaveFak(Faktura faktura)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("INSERT INTO vis.faktura (cislo_faktury,cislo_rezervace,vytvoreno,potvrzeno, zaplaceno)");
                sb.Append("VALUES (@cisloF, @cisloR, @vytvoreno, @potvrzeno, @zaplaceno);");
                //sb.Append("SELECT CAST(scope_identity() AS int)");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@cisloF", faktura.cisloFaktury);
                    command.Parameters.AddWithValue("@cisloR", faktura.cisloRezervace);
                    command.Parameters.AddWithValue("@vytvoreno", faktura.vytvorena);
                    command.Parameters.AddWithValue("@potvrzeno", faktura.potvrzena);
                    command.Parameters.AddWithValue("@zaplaceno", faktura.zaplacena);
                }
            }


            return 0;
        }
        public int DeleteFak(Faktura faktura)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("DELETE FROM vis.faktura where cislo_faktury = @id");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", faktura.cisloFaktury);

                }
            }
            return 0;
        }
        public int SavePlat(Platba platba)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("INSERT INTO vis.platba (id_platba,cislo_faktury,typ_platby,castka)");
                sb.Append("VALUES (@id, @cisloF, @typ_platby, @castka);");
                //sb.Append("SELECT CAST(scope_identity() AS int)");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", platba.id_platby);
                    command.Parameters.AddWithValue("@cisloF", platba.cisloFaktury);
                    command.Parameters.AddWithValue("@typ_platby", platba.typ_platby);
                    command.Parameters.AddWithValue("@castka", platba.castka);
                }
            }


            return 0;
        }
        public int DeletePlat(Platba platba)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("DELETE FROM vis.platba where id_platba = @id");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", platba.id_platby);

                }
            }
            return 0;
        }
        public int SaveRez(Rezervace rezervace)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("INSERT INTO vis.rezervace (cislo_rezervace,id_zakaznika,vyzvednuti,vraceni)");
                sb.Append("VALUES (@id_rezervace, @idZ, @vyzvednuti, @vraceni);");
                //sb.Append("SELECT CAST(scope_identity() AS int)");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_rezervace", rezervace.cisloRezervace);
                    command.Parameters.AddWithValue("@idZ", rezervace.idZakaznika);
                    command.Parameters.AddWithValue("@vyzvednuti", rezervace.zacatekRezervace);
                    command.Parameters.AddWithValue("@vraceni", rezervace.konecRezervace);
                }
            }


            return 0;
        }
        public int DeleteRez(Rezervace rezervace)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("DELETE FROM vis.rezervace where cislo_rezervace = @id");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", rezervace.cisloRezervace);

                }
            }
            return 0;
        }
        public int SaveRezervovano(Rezervovano rezervovano)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("INSERT INTO vis.rezervovano (cislo_rezervace,auto_spz)");
                sb.Append("VALUES (@cisloR, @spz);");
                //sb.Append("SELECT CAST(scope_identity() AS int)");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@cisloR", rezervovano.cisloRezervace);
                    command.Parameters.AddWithValue("@spz", rezervovano.SPZ);
                }
            }


            return 0;
        }
        public int DeleteRezervovano(Rezervovano rezervovano)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("DELETE FROM vis.rezervovano where auto_spz = @spz");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@spz", rezervovano.SPZ);

                }
            }
            return 0;
        }
        public int SaveUprav(Upravuje upravuje)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("INSERT INTO vis.upravuje (ID_zamestnance,Cislo_Rezervace,)");
                sb.Append("VALUES (@idZam, @cisloR);");
                //sb.Append("SELECT CAST(scope_identity() AS int)");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@idZam", upravuje.IDzamestnance);
                    command.Parameters.AddWithValue("@cisloR", upravuje.cisloRezervace);
                }
            }


            return 0;
        }
        public int DeleteUprav(Upravuje upravuje)
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("DELETE FROM vis.upravuje where ID_zamestnance = @id");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", upravuje.IDzamestnance);

                }
            }
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
            faktura.cisloFaktury = reader.GetInt32(0);
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
            rezervace.cisloRezervace = reader.GetInt32(0);
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