using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerSat.QueryEntities
{
   public class KorisnikKomentar
    {
        public int idprodavca { get; set; }
        public int idkupca { get; set; }
        public int idkomentara { get; set; }
        public string komentar { get; set; }
    }
}
