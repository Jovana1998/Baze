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
    }
}
