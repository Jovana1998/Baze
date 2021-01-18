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
    public partial class Form4 : Form
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

        public Form4()
        {
            InitializeComponent();
        }

        private void Uclani_se_k_Click(object sender, EventArgs e)
        {
            var queryMax = new Neo4jClient.Cypher.CypherQuery("match (n:Korisnik) return MAX(n.id)",
                                                         new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(queryMax).ToList().FirstOrDefault();

            Korisnik korisnik = new Korisnik();
            int pom = Int32.Parse(maxId);
            pom++;
            korisnik.id = pom.ToString();
            korisnik.ime = txtIme.ToString();
            korisnik.prezime = txtPrezime.ToString();
            korisnik.kilogram = txtKg.ToString();
            korisnik.pol = txtPol.ToString();
            korisnik.nivo = comboBox1.SelectedIndex.ToString();
            korisnik.bolesti = txtBolesti.ToString();

        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            GetClient();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
