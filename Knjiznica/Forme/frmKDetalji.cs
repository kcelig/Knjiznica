using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Knjiznica.Model;

namespace Knjiznica.Forme
{
    public partial class KDetalji : Form
    {
        public KDetalji()
        {
            InitializeComponent();
        }

        public Knjiga K;


        private void frmKDetalji_Load(object sender, EventArgs e)
        {
            // Na početku postavljam Maximum svojstvo
            // za NumericUpDown kontrolu na tekuću godinu
            nudGodinaIzdanja.Maximum = DateTime.Now.Year;
            nudGodinaIzdanja.Value = DateTime.Now.Year;
            // Ako se ne radi o novoj knjizi, prikazujem postojeću
            if (this.K != null)
            {
                txtISBN.Text = this.K.ISBN;
                txtAutor.Text = this.K.Autor;
                txtNaslov.Text = this.K.Naslov;
                nudGodinaIzdanja.Value = (decimal)this.K.GodinaIzdanja;
                cbBrojPrimjeraka.Text = this.K.BrojPrimjeraka.ToString();
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            // Provjerimo jesu li upisani svi obavezni podaci
            // uzimamo da su obavezni svi
            if (txtISBN.Text == "" || txtAutor.Text == ""
            || txtNaslov.Text == "" || cbBrojPrimjeraka.Text == "")
            {
                MessageBox.Show("Sve podatke morate unijeti!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                // Ako je svojstvo U null, tada se radi o novoj knjizi
                if (this.K == null)
                {
                    this.K = new Knjiga();
                }
                // Spremamo vrijednosti iz kontrola u objekt K
                this.K.ISBN = txtISBN.Text;
                this.K.Autor = txtAutor.Text;
                this.K.Naslov = txtNaslov.Text;
                this.K.GodinaIzdanja = (int)nudGodinaIzdanja.Value;
                this.K.BrojPrimjeraka = int.Parse(cbBrojPrimjeraka.Text);

                this.DialogResult = DialogResult.OK;
            }


        }

    }
}
