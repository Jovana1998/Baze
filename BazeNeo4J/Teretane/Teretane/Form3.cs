using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient;
using Teretane.DomainModel;
using Neo4jClient.Cypher;
using Neo4j.Driver.V1;

namespace Teretane
{
    public partial class Form3 : Form
    {
        public static BoltGraphClient client;

        public static BoltGraphClient GetClient()
        {
            if (client == null)
            {
                IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "12345"), Config.Builder.WithEncryptionLevel(EncryptionLevel.None).ToConfig());
                client = new BoltGraphClient(driver: driver);
                client.Connect();
            }

            return client;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Prikazi_sve_teretane_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Teretana) return n",
                                                                      new Dictionary<string, object>(), CypherResultMode.Set);

            List<Teretana> teretane = ((IRawGraphClient)client).ExecuteGetCypherResults<Teretana>(query).ToList();

            foreach (Teretana u in teretane)
            {
                MessageBox.Show(u.naziv);
            }
        }

        private void Vrati_se_na_pocetak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Uclani_se_Click(object sender, EventArgs e)
        {
            Form4 clan = new Form4();
            //clan.client = client;
            clan.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetClient();
        }
    }
}
