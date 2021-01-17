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
    public partial class Form5 : Form
    {
        public static BoltGraphClient client;

        public Form5()
        {
            InitializeComponent();
        }

        private void Dodaj_teretanu_Click(object sender, EventArgs e)
        {

        }

        private void Vrati_se_na_pocetak_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
