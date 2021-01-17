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
    public partial class Form2 : Form
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

        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unetNazivTeretane = textTeretanaK.Text;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("unetNazivTeretane", unetNazivTeretane);

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH p=(n)-[r:VEZBA_U]->(m) where m.naziv= '" + textTeretanaK.Text + "' RETURN n",
                                                            queryDict, CypherResultMode.Set);

            List<Korisnik> korisniciTeretane = ((IRawGraphClient)client).ExecuteGetCypherResults<Korisnik>(query).ToList();

            foreach (Korisnik a in korisniciTeretane)
            {
                //DateTime bday = a.getBirthday();
                MessageBox.Show(a.ime);
            }
        }

        private void Vrati_se_na_pocetak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetClient();
        }

        private void Nadji_korisnika_Click(object sender, EventArgs e)
        {
            string unetNazivKorisnika = textIme.Text;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("unetNazivKorisnika", unetNazivKorisnika);

            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Korisnik) where n.ime= '"+ textIme.Text +"' return n",
                                                            queryDict, CypherResultMode.Set);



            List<Korisnik> korisniciTeretane = ((IRawGraphClient)client).ExecuteGetCypherResults<Korisnik>(query).ToList();

            foreach (Korisnik a in korisniciTeretane)
            {
                MessageBox.Show(a.ime+" "+a.prezime);
            }
        }

        private void Nadji_plan_Click(object sender, EventArgs e)
        {
            string unetiOpis = textOpis.Text;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("unetiOpis", unetiOpis);

            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Plan) where n.opisplana= '"+ textOpis.Text +"' return n",
                                                            queryDict, CypherResultMode.Set);



            List<Plan> planovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Plan>(query).ToList();

            foreach (Plan a in planovi)
            {
                MessageBox.Show(a.opisplana);
            }
        }

        private void Nadji_uslugu_Click(object sender, EventArgs e)
        {
            string unetaUsluga = textNaziv.Text;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("unetaUsluga", unetaUsluga);

            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Usluga) where n.nazivusluge= '" + textNaziv.Text + "' return n",
                                                            queryDict, CypherResultMode.Set);



            List<Usluga> usluge = ((IRawGraphClient)client).ExecuteGetCypherResults<Usluga>(query).ToList();

            foreach (Usluga a in usluge)
            {
                MessageBox.Show(a.nazivusluge);
            }
        }
    }
}
