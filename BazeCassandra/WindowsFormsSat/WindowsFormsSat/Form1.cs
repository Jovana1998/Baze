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
            DataProvider.DodajSat(1, 1,"rolex",1000,"srebro");
            DataProvider.DodajSat(2, 1, "casio", 2000, "srebro");
            MessageBox.Show("Dodat je sat");
        }

        private void Ucitaj_Sat_Click(object sender, EventArgs e)
        {
            Sat s = DataProvider.VratiSat(1);

            MessageBox.Show( s.idsata+s.brend + s.cena+ s.materijal);
        }

        private void Azuriraj_Sat_Click(object sender, EventArgs e)
        {
            DataProvider.AzurirajSat(1, 5000);
            MessageBox.Show("Azuriran je sat 1");
        }

        private void Izbrisi_Sat_Click(object sender, EventArgs e)
        {
            DataProvider.ObrisiSat(1);
            MessageBox.Show("Sat 1 je izbrisan");
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
            List<Korisnik_Sat> satovi = DataProvider.SatoviJednogKorisnika(1);
            foreach (Korisnik_Sat s in satovi)
                MessageBox.Show(s.idsata.ToString());
        }

        private void Prikazi_Listu_Omiljenih_Click(object sender, EventArgs e)
        {
            List<ListaOmiljenih> satovi = DataProvider.ListaOmiljenih(1);
            foreach (ListaOmiljenih s in satovi)
                MessageBox.Show("ID sata: "+s.satid.ToString()+", ID korisnika: "+s.korisnikid);
        }

        private void Dodaj_Komentar_Click(object sender, EventArgs e)
        {
            DataProvider.DodajKomentar("2");
            MessageBox.Show("Komentar dodat!");
        }

        private void Izbrisi_Komentar_Click(object sender, EventArgs e)
        {
            DataProvider.ObrisiKomentar(1, 1);
            MessageBox.Show("Komentar 1 je obrisan!"); 
        }

        private void Azuriraj_Komentar_Click(object sender, EventArgs e)
        {
            DataProvider.AzurirajKomentar(1, 1);
            MessageBox.Show("Komentar 1 je azuriran!");
        }

        private void Ucitaj_Komentar_Click(object sender, EventArgs e)
        {
            Komentar k = DataProvider.VratiKomentar1(1);
            MessageBox.Show(k.tekstkomentara);
        }

        private void Prikazi_Sve_Komentare_Click(object sender, EventArgs e)
        {
            List<Komentar> kom = DataProvider.VratiSveKomentare();

            foreach (Komentar k in kom)
                MessageBox.Show("Id komentara: " k.idkomentara+", komentar: "+k.tekstkomentara);
        }

        private void Dodaj_Narudzbinu_Click(object sender, EventArgs e)
        {
            DataProvider.DodajNarudzbinu("2", "1", "2");
            MessageBox.Show("Narudzbina je dodata!");
        }

        private void Azuriraj_Narudzbinu_Click(object sender, EventArgs e)
        {
            DataProvider.AzurirajNarudzbinu(1);
            MessageBox.Show("Narudzbina 1 azurirana!");
        }

        private void Izbrisi_Narudzbinu_Click(object sender, EventArgs e)
        {
            DataProvider.ObrisiNarudzbinu(1);
            MessageBox.Show("Narudzbina je obrisana!");
        }

        private void Ucitaj_Narudzbinu_Click(object sender, EventArgs e)
        {
            Narudzbina n = DataProvider.VratiNarudzbinu(1);
            MessageBox.Show("Narudzbina: " + n.idnarudzbine);
        }

        private void Prikazi_Sve_Narudzbine_Click(object sender, EventArgs e)
        {
            List<Narudzbina> nar = DataProvider.VratiSveNarudzbine();

            foreach (Narudzbina n in nar)
                MessageBox.Show("Narudzbina: " + n.idnarudzbine);
        }

        private void DodajUListuOmiljenihbtn_Click(object sender, EventArgs e)
        {
            DataProvider.DodajUListuOmiljenih(1,1);
            MessageBox.Show("Dodat je sat u listu omiljenih");
        }

        private void IzbrisiIzListeOmiljenihbtn_Click(object sender, EventArgs e)
        {
            DataProvider.IzbrisiIzListeOmiljenih(1,1);
            MessageBox.Show("izbrisan je sat iz liste omiljenih");
        }

        private void Dodaj_korisnika_Click(object sender, EventArgs e)
        {
            DataProvider.DodajKorisnika("1");
            MessageBox.Show("Korisnik je dodat!");
        }

        private void Ucitaj_korisnika_Click(object sender, EventArgs e)
        {
            Korisnik k = DataProvider.VratiKorisnika(1);
            MessageBox.Show(k.ime + " " + k.prezime);
        }

        private void Izbrisi_korisnika_Click(object sender, EventArgs e)
        {
            DataProvider.ObrisiKorisnika(1);
            MessageBox.Show("Korisnik je obrisan!");
        }

        private void Azuriraj_korisnika_Click(object sender, EventArgs e)
        {
            DataProvider.AzurirajKorisnika(1);
            MessageBox.Show("Korisnik azuriran!");
        }

        private void Prikazi_sve_korisnike_Click(object sender, EventArgs e)
        {
            List<Korisnik> nar = DataProvider.VratiSveKorisnika();

            foreach (Korisnik k in nar)
                MessageBox.Show(k.ime + " " + k.prezime);
        }

        private void Korisnik_Enter(object sender, EventArgs e)
        {

        }
    }
}
