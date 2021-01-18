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
    public class PrikazTeretaneModel : PageModel
    {
        private readonly ILogger<PrikazTeretaneModel> _logger;
        BoltGraphClient client;
        public Teretana ter;
        public List<Trener> SviTreneri { get; set; }
        public List<Usluga> SveUsluge { get; set; }

        public PrikazTeretaneModel(ILogger<PrikazTeretaneModel> logger)
        {
            client = Manager.GetClient();
            _logger = logger;
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Teretana) where n.id='" + id + "' return n", queryDict, CypherResultMode.Set);
            ter = ((IRawGraphClient)client).ExecuteGetCypherResults<Teretana>(query).FirstOrDefault();

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH p=(n)-[r:RADI_U]->(m) where m.id= '" + ter.id + "' RETURN n", queryDict1, CypherResultMode.Set);
            SviTreneri = ((IRawGraphClient)client).ExecuteGetCypherResults<Trener>(query1).ToList();

            Dictionary<string, object> queryDict2 = new Dictionary<string, object>();
            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH p=(n)-[r:NUDI_USLUGU]->(m) where n.id= '" + ter.id + "' RETURN m", queryDict2, CypherResultMode.Set);
            SveUsluge = ((IRawGraphClient)client).ExecuteGetCypherResults<Usluga>(query2).ToList();

            return Page();
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Teretana) where n.id='" + id + "' return n", queryDict, CypherResultMode.Set);
            ter = ((IRawGraphClient)client).ExecuteGetCypherResults<Teretana>(query).FirstOrDefault();

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH p=(n)-[r:RADI_U]->(m) where m.id= '" + ter.id + "' RETURN n", queryDict1, CypherResultMode.Set);
            SviTreneri = ((IRawGraphClient)client).ExecuteGetCypherResults<Trener>(query1).ToList();

            Dictionary<string, object> queryDict2 = new Dictionary<string, object>();
            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH p=(n)-[r:NUDI_USLUGU]->(m) where n.id= '" + ter.id + "' RETURN m", queryDict2, CypherResultMode.Set);
            SveUsluge = ((IRawGraphClient)client).ExecuteGetCypherResults<Usluga>(query2).ToList();

            return Page();
        }
    }
}
