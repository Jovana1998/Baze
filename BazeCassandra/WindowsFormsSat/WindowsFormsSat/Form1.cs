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
            DataProvider.DodajSat("1");
            MessageBox.Show("Dodat je sat");
        }

        private void Ucitaj_Sat_Click(object sender, EventArgs e)
        {
            Sat s = DataProvider.VratiSat(1);

            MessageBox.Show(s.brend);
        }

        private void Azuriraj_Sat_Click(object sender, EventArgs e)
        {
            DataProvider.AzurirajSat(1);
            MessageBox.Show("Azuriran je sat");
        }

        private void Izbrisi_Sat_Click(object sender, EventArgs e)
        {
            DataProvider.ObrisiSat(1);
            MessageBox.Show("Sat je izbrisan");
        }

        private void Ucitaj_Sve_Satove_Click(object sender, EventArgs e)
        {
            List<Sat> satovi = DataProvider.SviSatovi();

            foreach (Sat s in satovi)
                MessageBox.Show(s.brend);
        }

        private void Prikazi_Satove_Brenda_Click(object sender, EventArgs e)
        {
            List<Sat_Brend> satovi = DataProvider.SatoviBrenda("rolex");
            foreach (Sat_Brend s in satovi)
                MessageBox.Show(s.idsata.ToString());
        }

        private void Prikazi_Cena_Od_Do_Click(object sender, EventArgs e)
        {
            List<Sat_Cena> satovi = DataProvider.SatoviCena(2000,3000);
            foreach (Sat_Cena s in satovi)
                MessageBox.Show(s.idsata.ToString());
        }

        private void Prikazi_Sve_Satove_Odredjenog_Korisnika_Click(object sender, EventArgs e)
        {
            List<Korisnik> satovi = DataProvider.SatoviJednogKorisnika(1);
            foreach (Korisnik s in satovi)
                MessageBox.Show(s.idsata.ToString());
        }

        private void Prikazi_Listu_Omiljenih_Click(object sender, EventArgs e)
        {
            List<ListaOmiljenih> satovi = DataProvider.ListaOmiljenih(1);
            foreach (ListaOmiljenih s in satovi)
                MessageBox.Show(s.satid.ToString());
        }
    }
}
