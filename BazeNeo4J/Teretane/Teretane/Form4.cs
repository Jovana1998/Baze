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

        public Form4()
        {
            InitializeComponent();
        }

        private void Uclani_se_k_Click(object sender, EventArgs e)
        {

        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
