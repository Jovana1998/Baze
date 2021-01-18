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
    public class AdminModel : PageModel
    {
        private readonly ILogger<AdminModel> _logger;
        BoltGraphClient client;
        public AdminModel(ILogger<AdminModel> logger)
        {
            client = Manager.GetClient();
            _logger = logger;
        }
        public async Task<IActionResult> OnGetAsync()
        {
           
            return Page();
        }
    }
}
