using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerSat.QueryEntities
{
   public class Sat
    {
        public int idsata { get; set; }
        public int idkorisnika { get; set; }
        public string brend { get; set; }
        public double cena { get; set; }
        public string materijal { get; set; }

    }
}
