using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerSat.QueryEntities
{
    public class Korisnik
    {
        public int idkorisnika { get; set; }
        public int idsata { get; set; }
        public string ime { get; set; }
        public string lokacija { get; set; }
    }
}
