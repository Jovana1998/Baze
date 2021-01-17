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
    public partial class Proba : Form
    {
        public static BoltGraphClient client;
        public Proba()
        {
            InitializeComponent();
        }
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
        private void Form1_Load(object sender, EventArgs e)
        {
            GetClient();
        }

        private void Vrati_Sve_Teretane_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Teretana) return n",
                                                                      new Dictionary<string, object>(), CypherResultMode.Set);

            List<Teretana> teretane = ((IRawGraphClient)client).ExecuteGetCypherResults<Teretana>(query).ToList();

            foreach (Teretana u in teretane)
            {
                MessageBox.Show(u.naziv);
            }
        }

        private void Vrati_Sve_Korisnike_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Korisnik) return n",
                                                                      new Dictionary<string, object>(), CypherResultMode.Set);

            List<Korisnik> korisnici = ((IRawGraphClient)client).ExecuteGetCypherResults<Korisnik>(query).ToList();

            foreach (Korisnik u in korisnici)
            {
                MessageBox.Show(u.ime);
            }
        }

        private void Prikazi_Korisnike_Unete_Teretane_Click(object sender, EventArgs e)
        {
           
            string unetNazivTeretane =  nazivTeretane.Text ;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("unetNazivTeretane", unetNazivTeretane);

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH p=(n)-[r:CLAN_JE]->(m) where m.naziv= '"+nazivTeretane.Text+"' RETURN n",
                                                            queryDict, CypherResultMode.Set);

            List<Korisnik> korisniciTeretane = ((IRawGraphClient)client).ExecuteGetCypherResults<Korisnik>(query).ToList();

            foreach (Korisnik a in korisniciTeretane)
            {
                //DateTime bday = a.getBirthday();
                MessageBox.Show(a.ime);
            }
        }

        private void Prikazi_Usluge_Svih_Teretana_Click(object sender, EventArgs e)
        {

            var query = new Neo4jClient.Cypher.CypherQuery(" match (n:Usluga) return n",
                                                                          new Dictionary<string, object>(), CypherResultMode.Set);

            List<Usluga> sveusluge = ((IRawGraphClient)client).ExecuteGetCypherResults<Usluga>(query).ToList();

            foreach (Usluga u in sveusluge)
            {
                MessageBox.Show(u.nazivusluge);
            }
        }

        private void Prikazi_Usluge_Unete_Teretane_Click(object sender, EventArgs e)
        {
            string unetNazivTeretane = ".*" + unetnazivteretane.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("unetNazivTeretane", unetNazivTeretane);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Teretana) and n.naziv =~ {unetNazivTeretane} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Usluga> usluge = ((IRawGraphClient)client).ExecuteGetCypherResults<Usluga>(query).ToList();

            foreach (Usluga a in usluge)
            {
                //DateTime bday = a.getBirthday();
                MessageBox.Show(a.nazivusluge);
            }

        }

        private void Dodaj_Korisnika_Click(object sender, EventArgs e)
        {

        }
    }
}
