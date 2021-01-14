using DataLayerSat;
using DataLayerSat.QueryEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsSat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dodaj_Sat_Click(object sender, EventArgs e)
        {
            DataLayerSat.DataProvider.DodajSat("1");
        }

        private void Ucitaj_Sat_Click(object sender, EventArgs e)
        {
            Sat s = DataProvider.VratiSat(1);

            MessageBox.Show(s.brend);
        }
    }
}
