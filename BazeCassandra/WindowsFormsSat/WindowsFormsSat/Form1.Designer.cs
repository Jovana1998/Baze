
namespace WindowsFormsSat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dodaj_Sat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IzbrisiIzListeOmiljenihbtn = new System.Windows.Forms.Button();
            this.dodajUListuOmiljenihbtn = new System.Windows.Forms.Button();
            this.Prikazi_Listu_Omiljenih = new System.Windows.Forms.Button();
            this.Ucitaj_Sve_Satove = new System.Windows.Forms.Button();
            this.Prikazi_Sve_Satove_Odredjenog_Korisnika = new System.Windows.Forms.Button();
            this.Prikazi_Cena_Od_Do = new System.Windows.Forms.Button();
            this.Prikazi_Satove_Brenda = new System.Windows.Forms.Button();
            this.Ucitaj_Sat = new System.Windows.Forms.Button();
            this.Izbrisi_Sat = new System.Windows.Forms.Button();
            this.Azuriraj_Sat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Prikazi_Sve_Narudzbine = new System.Windows.Forms.Button();
            this.Ucitaj_Narudzbinu = new System.Windows.Forms.Button();
            this.Izbrisi_Narudzbinu = new System.Windows.Forms.Button();
            this.Azuriraj_Narudzbinu = new System.Windows.Forms.Button();
            this.Dodaj_Narudzbinu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Prikazi_Sve_Komentare = new System.Windows.Forms.Button();
            this.Ucitaj_Komentar = new System.Windows.Forms.Button();
            this.Azuriraj_Komentar = new System.Windows.Forms.Button();
            this.Izbrisi_Komentar = new System.Windows.Forms.Button();
            this.Dodaj_Komentar = new System.Windows.Forms.Button();
            this.Korisnik = new System.Windows.Forms.GroupBox();
            this.Prikazi_sve_korisnike = new System.Windows.Forms.Button();
            this.Azuriraj_korisnika = new System.Windows.Forms.Button();
            this.Ucitaj_korisnika = new System.Windows.Forms.Button();
            this.Izbrisi_korisnika = new System.Windows.Forms.Button();
            this.Dodaj_korisnika = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Korisnik.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dodaj_Sat
            // 
            this.Dodaj_Sat.Location = new System.Drawing.Point(6, 48);
            this.Dodaj_Sat.Name = "Dodaj_Sat";
            this.Dodaj_Sat.Size = new System.Drawing.Size(176, 23);
            this.Dodaj_Sat.TabIndex = 0;
            this.Dodaj_Sat.Text = "Dodaj sat";
            this.Dodaj_Sat.UseVisualStyleBackColor = true;
            this.Dodaj_Sat.Click += new System.EventHandler(this.Dodaj_Sat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IzbrisiIzListeOmiljenihbtn);
            this.groupBox1.Controls.Add(this.dodajUListuOmiljenihbtn);
            this.groupBox1.Controls.Add(this.Prikazi_Listu_Omiljenih);
            this.groupBox1.Controls.Add(this.Ucitaj_Sve_Satove);
            this.groupBox1.Controls.Add(this.Prikazi_Sve_Satove_Odredjenog_Korisnika);
            this.groupBox1.Controls.Add(this.Prikazi_Cena_Od_Do);
            this.groupBox1.Controls.Add(this.Prikazi_Satove_Brenda);
            this.groupBox1.Controls.Add(this.Ucitaj_Sat);
            this.groupBox1.Controls.Add(this.Izbrisi_Sat);
            this.groupBox1.Controls.Add(this.Azuriraj_Sat);
            this.groupBox1.Controls.Add(this.Dodaj_Sat);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 487);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sat";
            // 
            // IzbrisiIzListeOmiljenihbtn
            // 
            this.IzbrisiIzListeOmiljenihbtn.Location = new System.Drawing.Point(7, 417);
            this.IzbrisiIzListeOmiljenihbtn.Name = "IzbrisiIzListeOmiljenihbtn";
            this.IzbrisiIzListeOmiljenihbtn.Size = new System.Drawing.Size(175, 23);
            this.IzbrisiIzListeOmiljenihbtn.TabIndex = 10;
            this.IzbrisiIzListeOmiljenihbtn.Text = "Izbrisi iz liste omiljenih";
            this.IzbrisiIzListeOmiljenihbtn.UseVisualStyleBackColor = true;
            this.IzbrisiIzListeOmiljenihbtn.Click += new System.EventHandler(this.IzbrisiIzListeOmiljenihbtn_Click);
            // 
            // dodajUListuOmiljenihbtn
            // 
            this.dodajUListuOmiljenihbtn.Location = new System.Drawing.Point(7, 388);
            this.dodajUListuOmiljenihbtn.Name = "dodajUListuOmiljenihbtn";
            this.dodajUListuOmiljenihbtn.Size = new System.Drawing.Size(175, 23);
            this.dodajUListuOmiljenihbtn.TabIndex = 9;
            this.dodajUListuOmiljenihbtn.Text = "Dodaj u listu omiljenih";
            this.dodajUListuOmiljenihbtn.UseVisualStyleBackColor = true;
            this.dodajUListuOmiljenihbtn.Click += new System.EventHandler(this.DodajUListuOmiljenihbtn_Click);
            // 
            // Prikazi_Listu_Omiljenih
            // 
            this.Prikazi_Listu_Omiljenih.Location = new System.Drawing.Point(7, 359);
            this.Prikazi_Listu_Omiljenih.Name = "Prikazi_Listu_Omiljenih";
            this.Prikazi_Listu_Omiljenih.Size = new System.Drawing.Size(175, 23);
            this.Prikazi_Listu_Omiljenih.TabIndex = 8;
            this.Prikazi_Listu_Omiljenih.Text = "Prikazi listu omiljenih";
            this.Prikazi_Listu_Omiljenih.UseVisualStyleBackColor = true;
            this.Prikazi_Listu_Omiljenih.Click += new System.EventHandler(this.Prikazi_Listu_Omiljenih_Click);
            // 
            // Ucitaj_Sve_Satove
            // 
            this.Ucitaj_Sve_Satove.Location = new System.Drawing.Point(7, 329);
            this.Ucitaj_Sve_Satove.Name = "Ucitaj_Sve_Satove";
            this.Ucitaj_Sve_Satove.Size = new System.Drawing.Size(175, 23);
            this.Ucitaj_Sve_Satove.TabIndex = 7;
            this.Ucitaj_Sve_Satove.Text = "Ucitaj sve satove";
            this.Ucitaj_Sve_Satove.UseVisualStyleBackColor = true;
            this.Ucitaj_Sve_Satove.Click += new System.EventHandler(this.Ucitaj_Sve_Satove_Click);
            // 
            // Prikazi_Sve_Satove_Odredjenog_Korisnika
            // 
            this.Prikazi_Sve_Satove_Odredjenog_Korisnika.Location = new System.Drawing.Point(7, 277);
            this.Prikazi_Sve_Satove_Odredjenog_Korisnika.Name = "Prikazi_Sve_Satove_Odredjenog_Korisnika";
            this.Prikazi_Sve_Satove_Odredjenog_Korisnika.Size = new System.Drawing.Size(249, 45);
            this.Prikazi_Sve_Satove_Odredjenog_Korisnika.TabIndex = 6;
            this.Prikazi_Sve_Satove_Odredjenog_Korisnika.Text = "Prikazi sve satove odredjenog korisnika";
            this.Prikazi_Sve_Satove_Odredjenog_Korisnika.UseVisualStyleBackColor = true;
            this.Prikazi_Sve_Satove_Odredjenog_Korisnika.Click += new System.EventHandler(this.Prikazi_Sve_Satove_Odredjenog_Korisnika_Click);
            // 
            // Prikazi_Cena_Od_Do
            // 
            this.Prikazi_Cena_Od_Do.Location = new System.Drawing.Point(6, 248);
            this.Prikazi_Cena_Od_Do.Name = "Prikazi_Cena_Od_Do";
            this.Prikazi_Cena_Od_Do.Size = new System.Drawing.Size(250, 23);
            this.Prikazi_Cena_Od_Do.TabIndex = 5;
            this.Prikazi_Cena_Od_Do.Text = "Prikazi sve satove sa cenom od-do";
            this.Prikazi_Cena_Od_Do.UseVisualStyleBackColor = true;
            this.Prikazi_Cena_Od_Do.Click += new System.EventHandler(this.Prikazi_Cena_Od_Do_Click);
            // 
            // Prikazi_Satove_Brenda
            // 
            this.Prikazi_Satove_Brenda.Location = new System.Drawing.Point(6, 193);
            this.Prikazi_Satove_Brenda.Name = "Prikazi_Satove_Brenda";
            this.Prikazi_Satove_Brenda.Size = new System.Drawing.Size(250, 49);
            this.Prikazi_Satove_Brenda.TabIndex = 4;
            this.Prikazi_Satove_Brenda.Text = "Prikazi sve satove odredjenog brenda";
            this.Prikazi_Satove_Brenda.UseVisualStyleBackColor = true;
            this.Prikazi_Satove_Brenda.Click += new System.EventHandler(this.Prikazi_Satove_Brenda_Click);
            // 
            // Ucitaj_Sat
            // 
            this.Ucitaj_Sat.Location = new System.Drawing.Point(7, 134);
            this.Ucitaj_Sat.Name = "Ucitaj_Sat";
            this.Ucitaj_Sat.Size = new System.Drawing.Size(175, 23);
            this.Ucitaj_Sat.TabIndex = 3;
            this.Ucitaj_Sat.Text = "Ucitaj sat";
            this.Ucitaj_Sat.UseVisualStyleBackColor = true;
            this.Ucitaj_Sat.Click += new System.EventHandler(this.Ucitaj_Sat_Click);
            // 
            // Izbrisi_Sat
            // 
            this.Izbrisi_Sat.Location = new System.Drawing.Point(7, 105);
            this.Izbrisi_Sat.Name = "Izbrisi_Sat";
            this.Izbrisi_Sat.Size = new System.Drawing.Size(175, 23);
            this.Izbrisi_Sat.TabIndex = 2;
            this.Izbrisi_Sat.Text = "Izbrisi sat";
            this.Izbrisi_Sat.UseVisualStyleBackColor = true;
            this.Izbrisi_Sat.Click += new System.EventHandler(this.Izbrisi_Sat_Click);
            // 
            // Azuriraj_Sat
            // 
            this.Azuriraj_Sat.Location = new System.Drawing.Point(7, 76);
            this.Azuriraj_Sat.Name = "Azuriraj_Sat";
            this.Azuriraj_Sat.Size = new System.Drawing.Size(175, 23);
            this.Azuriraj_Sat.TabIndex = 1;
            this.Azuriraj_Sat.Text = "Azuriraj sat";
            this.Azuriraj_Sat.UseVisualStyleBackColor = true;
            this.Azuriraj_Sat.Click += new System.EventHandler(this.Azuriraj_Sat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Prikazi_Sve_Narudzbine);
            this.groupBox2.Controls.Add(this.Ucitaj_Narudzbinu);
            this.groupBox2.Controls.Add(this.Izbrisi_Narudzbinu);
            this.groupBox2.Controls.Add(this.Azuriraj_Narudzbinu);
            this.groupBox2.Controls.Add(this.Dodaj_Narudzbinu);
            this.groupBox2.Location = new System.Drawing.Point(549, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 222);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Narudzbina";
            // 
            // Prikazi_Sve_Narudzbine
            // 
            this.Prikazi_Sve_Narudzbine.Location = new System.Drawing.Point(7, 179);
            this.Prikazi_Sve_Narudzbine.Name = "Prikazi_Sve_Narudzbine";
            this.Prikazi_Sve_Narudzbine.Size = new System.Drawing.Size(187, 23);
            this.Prikazi_Sve_Narudzbine.TabIndex = 4;
            this.Prikazi_Sve_Narudzbine.Text = "Prikazi sve narudzbine";
            this.Prikazi_Sve_Narudzbine.UseVisualStyleBackColor = true;
            this.Prikazi_Sve_Narudzbine.Click += new System.EventHandler(this.Prikazi_Sve_Narudzbine_Click);
            // 
            // Ucitaj_Narudzbinu
            // 
            this.Ucitaj_Narudzbinu.Location = new System.Drawing.Point(7, 143);
            this.Ucitaj_Narudzbinu.Name = "Ucitaj_Narudzbinu";
            this.Ucitaj_Narudzbinu.Size = new System.Drawing.Size(186, 23);
            this.Ucitaj_Narudzbinu.TabIndex = 3;
            this.Ucitaj_Narudzbinu.Text = "Ucitaj narudzbinu";
            this.Ucitaj_Narudzbinu.UseVisualStyleBackColor = true;
            this.Ucitaj_Narudzbinu.Click += new System.EventHandler(this.Ucitaj_Narudzbinu_Click);
            // 
            // Izbrisi_Narudzbinu
            // 
            this.Izbrisi_Narudzbinu.Location = new System.Drawing.Point(7, 101);
            this.Izbrisi_Narudzbinu.Name = "Izbrisi_Narudzbinu";
            this.Izbrisi_Narudzbinu.Size = new System.Drawing.Size(186, 23);
            this.Izbrisi_Narudzbinu.TabIndex = 2;
            this.Izbrisi_Narudzbinu.Text = "Izbrisi narudzbinu";
            this.Izbrisi_Narudzbinu.UseVisualStyleBackColor = true;
            this.Izbrisi_Narudzbinu.Click += new System.EventHandler(this.Izbrisi_Narudzbinu_Click);
            // 
            // Azuriraj_Narudzbinu
            // 
            this.Azuriraj_Narudzbinu.Location = new System.Drawing.Point(6, 61);
            this.Azuriraj_Narudzbinu.Name = "Azuriraj_Narudzbinu";
            this.Azuriraj_Narudzbinu.Size = new System.Drawing.Size(187, 23);
            this.Azuriraj_Narudzbinu.TabIndex = 1;
            this.Azuriraj_Narudzbinu.Text = "Azuriraj narudzbinu";
            this.Azuriraj_Narudzbinu.UseVisualStyleBackColor = true;
            this.Azuriraj_Narudzbinu.Click += new System.EventHandler(this.Azuriraj_Narudzbinu_Click);
            // 
            // Dodaj_Narudzbinu
            // 
            this.Dodaj_Narudzbinu.Location = new System.Drawing.Point(7, 22);
            this.Dodaj_Narudzbinu.Name = "Dodaj_Narudzbinu";
            this.Dodaj_Narudzbinu.Size = new System.Drawing.Size(187, 23);
            this.Dodaj_Narudzbinu.TabIndex = 0;
            this.Dodaj_Narudzbinu.Text = "Dodaj narudzbinu";
            this.Dodaj_Narudzbinu.UseVisualStyleBackColor = true;
            this.Dodaj_Narudzbinu.Click += new System.EventHandler(this.Dodaj_Narudzbinu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Prikazi_Sve_Komentare);
            this.groupBox3.Controls.Add(this.Ucitaj_Komentar);
            this.groupBox3.Controls.Add(this.Azuriraj_Komentar);
            this.groupBox3.Controls.Add(this.Izbrisi_Komentar);
            this.groupBox3.Controls.Add(this.Dodaj_Komentar);
            this.groupBox3.Location = new System.Drawing.Point(329, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 222);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Korisnik";
            // 
            // Prikazi_Sve_Komentare
            // 
            this.Prikazi_Sve_Komentare.Location = new System.Drawing.Point(7, 179);
            this.Prikazi_Sve_Komentare.Name = "Prikazi_Sve_Komentare";
            this.Prikazi_Sve_Komentare.Size = new System.Drawing.Size(163, 23);
            this.Prikazi_Sve_Komentare.TabIndex = 4;
            this.Prikazi_Sve_Komentare.Text = "Prikazi sve komentare";
            this.Prikazi_Sve_Komentare.UseVisualStyleBackColor = true;
            this.Prikazi_Sve_Komentare.Click += new System.EventHandler(this.Prikazi_Sve_Komentare_Click);
            // 
            // Ucitaj_Komentar
            // 
            this.Ucitaj_Komentar.Location = new System.Drawing.Point(7, 143);
            this.Ucitaj_Komentar.Name = "Ucitaj_Komentar";
            this.Ucitaj_Komentar.Size = new System.Drawing.Size(163, 23);
            this.Ucitaj_Komentar.TabIndex = 3;
            this.Ucitaj_Komentar.Text = "Ucitaj komentar";
            this.Ucitaj_Komentar.UseVisualStyleBackColor = true;
            this.Ucitaj_Komentar.Click += new System.EventHandler(this.Ucitaj_Komentar_Click);
            // 
            // Azuriraj_Komentar
            // 
            this.Azuriraj_Komentar.Location = new System.Drawing.Point(7, 101);
            this.Azuriraj_Komentar.Name = "Azuriraj_Komentar";
            this.Azuriraj_Komentar.Size = new System.Drawing.Size(163, 23);
            this.Azuriraj_Komentar.TabIndex = 2;
            this.Azuriraj_Komentar.Text = "Azuriraj komentar";
            this.Azuriraj_Komentar.UseVisualStyleBackColor = true;
            this.Azuriraj_Komentar.Click += new System.EventHandler(this.Azuriraj_Komentar_Click);
            // 
            // Izbrisi_Komentar
            // 
            this.Izbrisi_Komentar.Location = new System.Drawing.Point(7, 61);
            this.Izbrisi_Komentar.Name = "Izbrisi_Komentar";
            this.Izbrisi_Komentar.Size = new System.Drawing.Size(163, 23);
            this.Izbrisi_Komentar.TabIndex = 1;
            this.Izbrisi_Komentar.Text = "Izbrisi komentar";
            this.Izbrisi_Komentar.UseVisualStyleBackColor = true;
            this.Izbrisi_Komentar.Click += new System.EventHandler(this.Izbrisi_Komentar_Click);
            // 
            // Dodaj_Komentar
            // 
            this.Dodaj_Komentar.Location = new System.Drawing.Point(7, 22);
            this.Dodaj_Komentar.Name = "Dodaj_Komentar";
            this.Dodaj_Komentar.Size = new System.Drawing.Size(163, 23);
            this.Dodaj_Komentar.TabIndex = 0;
            this.Dodaj_Komentar.Text = "Dodaj komentar";
            this.Dodaj_Komentar.UseVisualStyleBackColor = true;
            this.Dodaj_Komentar.Click += new System.EventHandler(this.Dodaj_Komentar_Click);
            // 
            // Korisnik
            // 
            this.Korisnik.Controls.Add(this.Prikazi_sve_korisnike);
            this.Korisnik.Controls.Add(this.Azuriraj_korisnika);
            this.Korisnik.Controls.Add(this.Ucitaj_korisnika);
            this.Korisnik.Controls.Add(this.Izbrisi_korisnika);
            this.Korisnik.Controls.Add(this.Dodaj_korisnika);
            this.Korisnik.Location = new System.Drawing.Point(329, 266);
            this.Korisnik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Korisnik.Size = new System.Drawing.Size(178, 254);
            this.Korisnik.TabIndex = 4;
            this.Korisnik.TabStop = false;
            this.Korisnik.Text = "Korisnik";
            this.Korisnik.Enter += new System.EventHandler(this.Korisnik_Enter);
            // 
            // Prikazi_sve_korisnike
            // 
            this.Prikazi_sve_korisnike.Location = new System.Drawing.Point(7, 184);
            this.Prikazi_sve_korisnike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prikazi_sve_korisnike.Name = "Prikazi_sve_korisnike";
            this.Prikazi_sve_korisnike.Size = new System.Drawing.Size(163, 30);
            this.Prikazi_sve_korisnike.TabIndex = 6;
            this.Prikazi_sve_korisnike.Text = "Prikazi sve korisnike";
            this.Prikazi_sve_korisnike.UseVisualStyleBackColor = true;
            this.Prikazi_sve_korisnike.Click += new System.EventHandler(this.Prikazi_sve_korisnike_Click);
            // 
            // Azuriraj_korisnika
            // 
            this.Azuriraj_korisnika.Location = new System.Drawing.Point(7, 109);
            this.Azuriraj_korisnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Azuriraj_korisnika.Name = "Azuriraj_korisnika";
            this.Azuriraj_korisnika.Size = new System.Drawing.Size(163, 26);
            this.Azuriraj_korisnika.TabIndex = 2;
            this.Azuriraj_korisnika.Text = "Azuriraj korisnika";
            this.Azuriraj_korisnika.UseVisualStyleBackColor = true;
            this.Azuriraj_korisnika.Click += new System.EventHandler(this.Azuriraj_korisnika_Click);
            // 
            // Ucitaj_korisnika
            // 
            this.Ucitaj_korisnika.Location = new System.Drawing.Point(7, 146);
            this.Ucitaj_korisnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ucitaj_korisnika.Name = "Ucitaj_korisnika";
            this.Ucitaj_korisnika.Size = new System.Drawing.Size(163, 25);
            this.Ucitaj_korisnika.TabIndex = 5;
            this.Ucitaj_korisnika.Text = "Ucitaj korisnika";
            this.Ucitaj_korisnika.UseVisualStyleBackColor = true;
            this.Ucitaj_korisnika.Click += new System.EventHandler(this.Ucitaj_korisnika_Click);
            // 
            // Izbrisi_korisnika
            // 
            this.Izbrisi_korisnika.Location = new System.Drawing.Point(7, 67);
            this.Izbrisi_korisnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Izbrisi_korisnika.Name = "Izbrisi_korisnika";
            this.Izbrisi_korisnika.Size = new System.Drawing.Size(163, 29);
            this.Izbrisi_korisnika.TabIndex = 1;
            this.Izbrisi_korisnika.Text = "Izbrisi korisnika";
            this.Izbrisi_korisnika.UseVisualStyleBackColor = true;
            this.Izbrisi_korisnika.Click += new System.EventHandler(this.Izbrisi_korisnika_Click);
            // 
            // Dodaj_korisnika
            // 
            this.Dodaj_korisnika.Location = new System.Drawing.Point(7, 29);
            this.Dodaj_korisnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dodaj_korisnika.Name = "Dodaj_korisnika";
            this.Dodaj_korisnika.Size = new System.Drawing.Size(163, 26);
            this.Dodaj_korisnika.TabIndex = 0;
            this.Dodaj_korisnika.Text = "Dodaj korisnika";
            this.Dodaj_korisnika.UseVisualStyleBackColor = true;
            this.Dodaj_korisnika.Click += new System.EventHandler(this.Dodaj_korisnika_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.Korisnik);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.Korisnik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dodaj_Sat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Prikazi_Sve_Satove_Odredjenog_Korisnika;
        private System.Windows.Forms.Button Prikazi_Cena_Od_Do;
        private System.Windows.Forms.Button Prikazi_Satove_Brenda;
        private System.Windows.Forms.Button Ucitaj_Sat;
        private System.Windows.Forms.Button Izbrisi_Sat;
        private System.Windows.Forms.Button Azuriraj_Sat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Ucitaj_Komentar;
        private System.Windows.Forms.Button Azuriraj_Komentar;
        private System.Windows.Forms.Button Izbrisi_Komentar;
        private System.Windows.Forms.Button Dodaj_Komentar;
        private System.Windows.Forms.Button Ucitaj_Narudzbinu;
        private System.Windows.Forms.Button Izbrisi_Narudzbinu;
        private System.Windows.Forms.Button Azuriraj_Narudzbinu;
        private System.Windows.Forms.Button Dodaj_Narudzbinu;
        private System.Windows.Forms.Button Ucitaj_Sve_Satove;
        private System.Windows.Forms.Button Prikazi_Listu_Omiljenih;
        private System.Windows.Forms.Button Prikazi_Sve_Narudzbine;
        private System.Windows.Forms.Button Prikazi_Sve_Komentare;
        private System.Windows.Forms.Button IzbrisiIzListeOmiljenihbtn;
        private System.Windows.Forms.Button dodajUListuOmiljenihbtn;
        private System.Windows.Forms.GroupBox Korisnik;
        private System.Windows.Forms.Button Prikazi_sve_korisnike;
        private System.Windows.Forms.Button Azuriraj_korisnika;
        private System.Windows.Forms.Button Ucitaj_korisnika;
        private System.Windows.Forms.Button Izbrisi_korisnika;
        private System.Windows.Forms.Button Dodaj_korisnika;
    }
}

