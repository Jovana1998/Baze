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
    public partial class Form1 : Form
    {

        public static BoltGraphClient client;

        public Form1()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Form5 Admin = new Form5();
            //Admin.client = client;
            Admin.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetClient();
        }

        private void Trener_Click(object sender, EventArgs e)
        {
            Form2 Trener = new Form2();
            //Trener.client; = client;
            Trener.ShowDialog();
        }

        private void Korisnik_Click(object sender, EventArgs e)
        {
            Form3 Korisnik = new Form3();
            //Korisnik.client = client;
            Korisnik.ShowDialog();
        }
    }
}
