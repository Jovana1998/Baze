using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace Baze_Teretane.Pages
{
    public class UclaniSeModel : PageModel
    {
        private readonly ILogger<UclaniSeModel> _logger;
        BoltGraphClient client;

        public Korisnik NoviKorisnik { get; set; }
        public UclaniSeModel(ILogger<UclaniSeModel> logger)
        {
            client = Manager.GetClient();
            _logger = logger;
        }
        public async Task<IActionResult> OnGetAsync()
        {

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            //nalazimo teretanu da bi napravili vezu od korisnika ka teretani 
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Teretana) where n.id='" + id + "' return n", queryDict, CypherResultMode.Set);
            Teretana ter = ((IRawGraphClient)client).ExecuteGetCypherResults<Teretana>(query).FirstOrDefault();
            //trazimo poslednji upisan id za ovu labelu
            var queryMax = new Neo4jClient.Cypher.CypherQuery("match (n:Korisnik) return MAX(n.id)",
                                              new Dictionary<string, object>(), CypherResultMode.Set);
            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(queryMax).ToList().FirstOrDefault();
            //povecavamo za jedan i dodeljujemo novom korisniku 
            int pom = Int32.Parse(maxId);
            pom++;
            NoviKorisnik.id = pom.ToString();
            //Pravimo vezu 
            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: Korisnik), (b: Teretana) WHERE a.id = '"+NoviKorisnik.id+"' AND b.id = '"+id+"' CREATE(a) -[r: CLAN]->(b) RETURN a", queryDict1, CypherResultMode.Set);
            Korisnik k = ((IRawGraphClient)client).ExecuteGetCypherResults<Korisnik>(query1).FirstOrDefault();
            return Page();
        }
    }
}