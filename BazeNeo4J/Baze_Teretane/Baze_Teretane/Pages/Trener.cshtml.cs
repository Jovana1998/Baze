using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Neo4jClient;
using Neo4jClient.Cypher;


namespace Baze_Teretane.Pages
{
    public class TrenerModel : PageModel
    {
        private readonly ILogger<TrenerModel> _logger;
        BoltGraphClient client;
        [BindProperty]
        public Trener trener { get; set; }
        [BindProperty]
        public string IDTrenera { get; set; }
        [BindProperty]
        public String preporuka { get; set; }
        [BindProperty]
        public int idKorisnika { get; set; }
        [BindProperty]
        public List<Korisnik> RadiSaKorisnicima { get; set; }
        public TrenerModel(ILogger<TrenerModel> logger)
        {
            client = Manager.GetClient();
            _logger = logger;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new Neo4jClient.Cypher.CypherQuery("match(n: Trener) where n.id = '" + IDTrenera + "' return n", queryDict, CypherResultMode.Set);
            trener = ((IRawGraphClient)client).ExecuteGetCypherResults<Trener>(query).FirstOrDefault();

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH p=(n)-[r:VEZBA_SA]->(m) where m.id= '" + IDTrenera + "' RETURN n", queryDict1, CypherResultMode.Set);
            RadiSaKorisnicima = ((IRawGraphClient)client).ExecuteGetCypherResults<Korisnik>(query1).ToList();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()  
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new Neo4jClient.Cypher.CypherQuery("match(n: Trener) where n.id = '"+ IDTrenera+"' return n", queryDict, CypherResultMode.Set);
            trener = ((IRawGraphClient)client).ExecuteGetCypherResults<Trener>(query).FirstOrDefault();

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH p=(n)-[r:VEZBA_SA]->(m) where m.id= '" + IDTrenera + "' RETURN n", queryDict1, CypherResultMode.Set);
            RadiSaKorisnicima = ((IRawGraphClient)client).ExecuteGetCypherResults<Korisnik>(query1).ToList();

            return Page();
        }
        public async Task<IActionResult> OnPostPreporuciAsync(int idk)
        {
            int a = idk;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH( t: Trener { id: '"+IDTrenera+"'}), (k:Korisnik {id: '"+idk+"'}) WITH t, k CREATE(t)-[:PREPORUCUJE_PLAN {opisplana:'"+preporuka+"'}]->(k) return t", queryDict, CypherResultMode.Set);
           Trener trener1 = ((IRawGraphClient)client).ExecuteGetCypherResults<Trener>(query).FirstOrDefault();

            return Page();
        }
        public async Task<IActionResult> OnPostObrisiPlanAsync(int idKorisnika)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH p=(t:Trener{id:'"+trener.id+"'})-[r:PREPORUCUJE_PLAN]->(k:Korisnik{id:'"+idKorisnika+"'}) DELETE r", queryDict, CypherResultMode.Set);
            Trener trener1 = ((IRawGraphClient)client).ExecuteGetCypherResults<Trener>(query).FirstOrDefault();

            return Page();
        }
    }
}
