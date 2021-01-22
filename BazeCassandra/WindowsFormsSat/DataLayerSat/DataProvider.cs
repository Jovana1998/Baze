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
        public static void DodajSat(int idsata,int idkorisnika, string brend, double cena, string materijal)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet SatData = session.Execute("insert into \"Sat\" (idsata, idkorisnika, brend, cena, materijal)  values (" + idsata + " , "+idkorisnika+" , '"+brend+"' , "+cena+", '"+materijal+"')");
            RowSet SatBrend = session.Execute("insert into \"Sat_Brend\" (brend, idsata) values ('"+brend+"'," + idsata+")");
            RowSet SatCena = session.Execute("insert into \"Sat_Cena\" (cena, idsata) values ("+cena+", " + idsata + ")");
            RowSet SatKorinik = session.Execute("insert into \"Korisnik_Sat\" (idkorisnika, idsata) values (" + idkorisnika + ", " + idsata + ")");
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

            Row cenaData = session.Execute("select * from  \"Sat\" where idsata =" + idsata).FirstOrDefault();

            double trazenaCena = (double)cenaData["cena"];
            RowSet SatData = session.Execute("update \"Sat\" set cena=" + cena + " where idsata =" + idsata);
            RowSet Sat_CenaDeleteData = session.Execute("delete from \"Sat_Cena\" where cena =" + trazenaCena + " and idsata= " + idsata);
            RowSet InsertData = session.Execute("insert into \"Sat_Cena\" (cena, idsata) values(" + cena + ", " + idsata + ")");
        }
        public static void ObrisiSat(int idsata)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            Row readData = session.Execute("select * from \"Sat\" where \"idsata\" = " + idsata + "").FirstOrDefault();
            Sat sat = new Sat();
            if (readData != null)
            {

                sat.idsata = readData["idsata"] != null ? (int)readData["idsata"] : 0;
                sat.idkorisnika = readData["idkorisnika"] != null ? (int)readData["idkorisnika"] : 0;
                sat.brend = readData["brend"] != null ? readData["brend"].ToString() : string.Empty;
                sat.cena = readData["cena"] != null ? (double)readData["cena"] : 0;
                sat.materijal = readData["materijal"] != null ? readData["materijal"].ToString() : string.Empty;
            }
            RowSet satData = session.Execute("delete from \"Sat\" where \"idsata\" = " + idsata + "");
            RowSet SatBrend = session.Execute("delete from \"Sat_Brend\" where brend = '" + sat.brend + "' and idsata= " + idsata);
            RowSet SatCena = session.Execute("delete from \"Sat_Cena\" where cena = " + sat.cena + " and idsata=  " + idsata);
            RowSet SatKorinik = session.Execute("delete from \"Korisnik_Sat\" where idkorisnika = " + sat.idkorisnika + " and idsata = " + idsata);

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
        public static List<Korisnik_Sat> SatoviJednogKorisnika(int idkorisnika)
        {
            ISession session = SessionManager.GetSession();
            List<Korisnik_Sat> satovi = new List<Korisnik_Sat>();


            if (session == null)
                return null;

            var satoviData = session.Execute("select * from \"Korisnik_Sat\" where idkorisnika = "+idkorisnika);


            foreach (var satData in satoviData)
            {
                Korisnik_Sat sat = new Korisnik_Sat();
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

            RowSet narData = session.Execute("insert into \"ListaOmiljenih\" (korisnikid, satid) values ("+korisnikid+", "+satid+")");

        }
        public static void IzbrisiIzListeOmiljenih(int idkorisnika, int idsata)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet narudzbinaData = session.Execute("delete from \"ListaOmiljenih2\" where korisnikid = " + idkorisnika + " and satid= "+idsata);
        }
        public static void DodajKorisnika(string idkorisnika)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikData = session.Execute("insert into \"Korisnik\"(\"idkorisnika\", ime, lokacija, prezime) values (" + idkorisnika + ", 'Katarina', 'Paracin', 'Lukic')");
           
        }
        public static Korisnik VratiKorisnika(int idkorisnika)
        {
            ISession session = SessionManager.GetSession();
            Korisnik korisnik = new Korisnik();

            if (session == null)
                return null;

            Row korisnikData = session.Execute("select * from \"Korisnik\" where \"idkorisnika\"=1").FirstOrDefault();

            if (korisnikData != null)
            {
                korisnik.idkorisnika = korisnikData["idkorisnika"] != null ? (int)korisnikData["idkorisnika"] : 0;
                korisnik.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                korisnik.lokacija = korisnikData["lokacija"] != null ? korisnikData["lokacija"].ToString() : string.Empty;
                korisnik.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;

            }

            return korisnik;
        }
        public static void ObrisiKorisnika(int idkorisnika)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikData = session.Execute("delete from \"Korisnik\" where \"idkorisnika\" = " + idkorisnika + "");
        }
        public static void AzurirajKorisnika(int idkorisnika)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikData = session.Execute("update \"Korisnik\" set lokacija= 'Nis' where idkorisnika =" + idkorisnika);
        }
        public static List<Korisnik> VratiSveKorisnika()
        {
            ISession session = SessionManager.GetSession();
            List<Korisnik> korisnici = new List<Korisnik>();

            if (session == null)
                return null;

            var korisnikData = session.Execute("select * from \"Korisnik\"");

            foreach (var row in korisnikData)
            {
                Korisnik k = new Korisnik();
                k.idkorisnika = row["idkorisnika"] != null ? (int)row["idkorisnika"] : 0;
                k.ime = row["ime"] != null ? row["ime"].ToString() : string.Empty;
                k.lokacija = row["lokacija"] != null ? row["lokacija"].ToString() : string.Empty;
                k.prezime = row["prezime"] != null ? row["prezime"].ToString() : string.Empty;


                korisnici.Add(k);
            }

            return korisnici;
        }
    }
}
