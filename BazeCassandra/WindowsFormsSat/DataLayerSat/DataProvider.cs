using Cassandra;
using DataLayerSat.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayerSat
{
    public class DataProvider
    {
        public static void DodajSat(string idsata)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet SatData = session.Execute("insert into \"Sat\" (\"idsata\", idkorisnika, brend, cena, materijal)  values (" + idsata + ", 1, 'rolex', 1000, 'zlato')");
            RowSet SatBrend = session.Execute("insert into \"Sat_Brend\" (brend, idsata) values ('rolex'," + idsata+")");
            RowSet SatCena = session.Execute("insert into \"Sat_Cena\" (cena, idsata) values (5000," + idsata + ")");
        }
        public static Sat VratiSat (int idsata)
        {
            ISession session = SessionManager.GetSession();
            Sat sat = new Sat();

            if (session == null)
                return null;

            Row satData = session.Execute("select * from \"Sat\" where \"idsata\"=1").FirstOrDefault();

            if (satData != null)
            {
                sat.idsata = satData["idsata"] != null ? (int)satData["idsata"] : 0 ;
                sat.idkorisnika = satData["idkorisnika"] != null ? (int)satData["idkorisnika"] : 0;
                sat.brend = satData["brend"] != null ? satData["brend"].ToString() : string.Empty;
                sat.cena = satData["cena"] != null ? (double)satData["cena"] : 0;
                sat.materijal = satData["materijal"] != null ? satData["materijal"].ToString() : string.Empty;
            }

            return sat;
        }
        public static void AzurirajSat(int idsata)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet SatData = session.Execute("update \"Sat\" set cena= 2000 where idsata =" + idsata);
        }
        public static void ObrisiSat(int idsata)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet roomData = session.Execute("delete from \"Sat\" where \"idsata\" = " + idsata + "");

        }
        public static List<Sat> SviSatovi()
        {
            ISession session = SessionManager.GetSession();
            List<Sat> satovi = new List<Sat>();


            if (session == null)
                return null;

            var satoviData = session.Execute("select * from \"Sat\"");


            foreach (var satData in satoviData)
            {
                Sat sat = new Sat();
                sat.idsata = satData["idsata"] != null ? (int)satData["idsata"] : 0;
                sat.brend = satData["brend"] != null ? satData["brend"].ToString() : string.Empty;
                sat.cena = satData["cena"] != null ? (double)satData["cena"] : 0;
                sat.idkorisnika = satData["idkorisnika"] != null ? (int)satData["idkorisnika"] : 0;
                sat.materijal = satData["materijal"] != null ? satData["materijal"].ToString() : string.Empty;
                satovi.Add(sat);
            }



            return satovi;
        }
        public static List<Sat_Brend> SatoviBrenda(string brend)
        {
            ISession session = SessionManager.GetSession();
            List<Sat_Brend> satovi = new List<Sat_Brend>();


            if (session == null)
                return null;

            var satoviData = session.Execute("select * from \"Sat_Brend\" where brend = '" +brend +"'");


            foreach (var satData in satoviData)
            {
                Sat_Brend sat = new Sat_Brend();
                sat.idsata = satData["idsata"] != null ? (int)satData["idsata"] : 0;
                sat.brend = satData["brend"] != null ? satData["brend"].ToString() : string.Empty;
                satovi.Add(sat);
            }



            return satovi;
        }
        public static List<Sat_Cena> SatoviCena(int odcena, int docena)
        {
            ISession session = SessionManager.GetSession();
            List<Sat_Cena> satovi = new List<Sat_Cena>();


            if (session == null)
                return null;

            var satoviData = session.Execute("select * from \"Sat_Cena\" where cena > " + odcena+ " and cena <"+docena+ " allow filtering");


            foreach (var satData in satoviData)
            {
                Sat_Cena sat = new Sat_Cena();
                sat.idsata = satData["idsata"] != null ? (int)satData["idsata"] : 0;
                sat.cena = satData["cena"] != null ? (double)satData["cena"] : 0;
                satovi.Add(sat);
            }



            return satovi;
        }
        public static List<Korisnik> SatoviJednogKorisnika(int idkorisnika)
        {
            ISession session = SessionManager.GetSession();
            List<Korisnik> satovi = new List<Korisnik>();


            if (session == null)
                return null;

            var satoviData = session.Execute("select * from \"Korisnik\" where idkorisnika = "+idkorisnika);


            foreach (var satData in satoviData)
            {
                Korisnik sat = new Korisnik();
                sat.idsata = satData["idsata"] != null ? (int)satData["idsata"] : 0;
                sat.idkorisnika = satData["idkorisnika"] != null ? (int)satData["idkorisnika"] : 0;
                satovi.Add(sat);
            }



            return satovi;
        }
        public static List<ListaOmiljenih> ListaOmiljenih(int idkorisnika)
        {
            ISession session = SessionManager.GetSession();
            List<ListaOmiljenih> satovi = new List<ListaOmiljenih>();


            if (session == null)
                return null;

            var satoviData = session.Execute("select * from \"ListaOmiljenih2\" where korisnikid = " + idkorisnika);


            foreach (var satData in satoviData)
            {
                ListaOmiljenih sat = new ListaOmiljenih();
                sat.satid = satData["satid"] != null ? (int)satData["satid"] : 0;
                sat.korisnikid = satData["korisnikid"] != null ? (int)satData["korisnikid"] : 0;
                satovi.Add(sat);
            }



            return satovi;
        }
    }
}
