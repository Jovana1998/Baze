﻿using Cassandra;
using DataLayerSat.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayerSat
{
    public class DataProvider
    {
        public static void DodajSat(int idsata,int idkorisnika, string brend, double cena, string materijal)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet SatData = session.Execute("insert into \"Sat\" (\"idsata\", idkorisnika, brend, cena, materijal)  values (" + idsata + " , "+idkorisnika+", "+brend+", "+cena+", "+materijal+")");
            RowSet SatBrend = session.Execute("insert into \"Sat_Brend\" (brend, idsata) values ("+brend+"," + idsata+")");
            RowSet SatCena = session.Execute("insert into \"Sat_Cena\" (cena, idsata) values ("+cena+", " + idsata + ")");
            RowSet SatKorinik = session.Execute("insert into \"Korisnik\" (idkorisnika, idsata) values (" + idkorisnika + ", " + idsata + ")");
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
        public static void AzurirajSat(int idsata, double cena)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet SatData = session.Execute("update \"Sat\" set cena="+cena+" where idsata =" + idsata);
        }
        public static void ObrisiSat(int idsata)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet satData = session.Execute("delete from \"Sat\" where \"idsata\" = " + idsata + "");

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

            var satoviData = session.Execute("select * from \"ListaOmiljenih\" where korisnikid = " + idkorisnika);


            foreach (var satData in satoviData)
            {
                ListaOmiljenih sat = new ListaOmiljenih();
                sat.satid = satData["satid"] != null ? (int)satData["satid"] : 0;
                sat.korisnikid = satData["korisnikid"] != null ? (int)satData["korisnikid"] : 0;
                satovi.Add(sat);
            }



            return satovi;
        }
        public static void DodajKomentar(string idkomentara)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet komentarData1 = session.Execute("insert into \"Komentar\"(\"idkomentara\", tekstkomentara) values (" + idkomentara + ", 'Komentar2')");
            RowSet komentarData2 = session.Execute("insert into \"KorisnikKomentar\"(idprodavca, \"idkomentara\", idkupca, komentar) values (1, " + idkomentara + ", 2, 'Komentar2')");
        }
        public static KorisnikKomentar VratiKomentar(int idprodavca)
        {
            ISession session = SessionManager.GetSession();
            KorisnikKomentar kom = new KorisnikKomentar();

            if (session == null)
                return null;

            Row komentarData = session.Execute("select * from \"KorisnikKomentar\" where \"idprodavca\"=1").FirstOrDefault();

            if (komentarData != null)
            {
                kom.idprodavca = komentarData["idprodavca"] != null ? (int)komentarData["idprodavca"] : 0;
                kom.idkomentara = komentarData["idkomentara"] != null ? (int)komentarData["idkomentara"] : 0;
                kom.idkupca = komentarData["brend"] != null ? (int)komentarData["idkupca"] : 0;
                kom.komentar = komentarData["komentar"] != null ? komentarData["komentar"].ToString() : string.Empty;
            }

            return kom;
        }
        public static Komentar VratiKomentar1(int idkomentara)
        {
            ISession session = SessionManager.GetSession();
            Komentar kom = new Komentar();

            if (session == null)
                return null;

            Row komentarData = session.Execute("select * from \"Komentar\" where \"idkomentara\"=1").FirstOrDefault();

            if (komentarData != null)
            {
                // kom.idprodavca = komentarData["idprodavca"] != null ? (int)komentarData["idprodavca"] : 0;
                kom.idkomentara = komentarData["idkomentara"] != null ? (int)komentarData["idkomentara"] : 0;
                // kom.idkupca = komentarData["brend"] != null ? (int)komentarData["idkupca"] : 0;
                kom.tekstkomentara = komentarData["tekstkomentara"] != null ? komentarData["tekstkomentara"].ToString() : string.Empty;
            }

            return kom;
        }
        public static void ObrisiKomentar(int idprodavca, int idkomentara)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet komentarData1 = session.Execute("delete from \"Komentar\" where \"idkomentara\" = " + idkomentara + "");
            RowSet komentarData2 = session.Execute("delete from \"KorisnikKomentar\" where \"idprodavca\" = " + idprodavca + " and \"idkomentara\" = " + idkomentara + "");
        }
        public static void AzurirajKomentar(int idprodavca, int idkomentara)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet komData1 = session.Execute("update \"Komentar\" set tekstkomentara= 'Azurirani komentar' where idkomentara =" + idkomentara);
            RowSet komData2 = session.Execute("update \"KorisnikKomentar\" set komentar= 'Azurirani komentar' where idprodavca =" + idprodavca + " and idkomentara=" + idkomentara);

        }
        public static List<Komentar> VratiSveKomentare()
        {
            ISession session = SessionManager.GetSession();
            List<Komentar> kom = new List<Komentar>();

            if (session == null)
                return null;

            var komData = session.Execute("select * from \"Komentar\"");

            foreach (var row in komData)
            {
                Komentar komentar = new Komentar();
                komentar.idkomentara = row["idkomentara"] != null ? (int)row["idkomentara"] : 0;
                komentar.tekstkomentara = row["tekstkomentara"] != null ? row["tekstkomentara"].ToString() : string.Empty;


                kom.Add(komentar);
            }

            return kom;
        }
        public static void DodajNarudzbinu(string idnarudzbine, string idkorisnika, string idsata)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet narudzbinaData = session.Execute("insert into \"Narudzbina\"(\"idnarudzbine\", \"idkorisnika\", \"idsata\") values (" + idnarudzbine + "," + idkorisnika + "," + idsata + ")");
        }
        public static Narudzbina VratiNarudzbinu(int idnarudzbine)
        {
            ISession session = SessionManager.GetSession();
            Narudzbina nar = new Narudzbina();

            if (session == null)
                return null;

            Row narudzbinaData = session.Execute("select * from \"Narudzbina\" where \"idnarudzbine\"=1").FirstOrDefault();

            if (narudzbinaData != null)
            {
                nar.idnarudzbine = narudzbinaData["idnarudzbine"] != null ? (int)narudzbinaData["idnarudzbine"] : 0;
                nar.idkorisnika = narudzbinaData["idkorisnika"] != null ? (int)narudzbinaData["idkorisnika"] : 0;
                nar.idsata = narudzbinaData["idsata"] != null ? (int)narudzbinaData["idsata"] : 0;
            }

            return nar;
        }
        public static void ObrisiNarudzbinu(int idnarudzbine)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet narudzbinaData = session.Execute("delete from \"Narudzbina\" where \"idnarudzbine\" = " + idnarudzbine + "");
        }
        public static List<Narudzbina> VratiSveNarudzbine()
        {
            ISession session = SessionManager.GetSession();
            List<Narudzbina> nar = new List<Narudzbina>();

            if (session == null)
                return null;

            var narData = session.Execute("select * from \"Narudzbina\"");

            foreach (var row in narData)
            {
                Narudzbina narudzbina = new Narudzbina();
                narudzbina.idnarudzbine = row["idnarudzbine"] != null ? (int)row["idnarudzbine"] : 0;
                narudzbina.idkorisnika = row["idkorisnika"] != null ? (int)row["idkorisnika"] : 0;
                narudzbina.idsata = row["idsata"] != null ? (int)row["idsata"] : 0;

                nar.Add(narudzbina);
            }

            return nar;
        }
        public static void AzurirajNarudzbinu(int idnarudzbine)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet narData = session.Execute("update \"Narudzbina\" set idsata= 2 where idnarudzbine =" + idnarudzbine);

        }
        public static void DodajUListuOmiljenih(int korisnikid, int satid)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet narData = session.Execute("insert into \"ListaOmiljenih2\" (korisnikid, satid) values ("+korisnikid+", "+satid+")");

        }
        public static void IzbrisiIzListeOmiljenih(int idkorisnika, int idsata)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet narudzbinaData = session.Execute("delete from \"ListaOmiljenih2\" where korisnikid = " + idkorisnika + " and satid= "+idsata);
        }
    }
}
