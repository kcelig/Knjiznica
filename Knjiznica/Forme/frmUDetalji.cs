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
    public partial class UDetalji : Form
    {
        public UDetalji()
        {
            InitializeComponent();
        }

        public Ucenik U;

        private void frmUDetalji_Load(object sender, EventArgs e)
        {
            // Ako se ne radi o novom učeniku, prikazujem postojećeg
            if (this.U != null) {
                txtOIB.Text = this.U.OIB;
                txtIme.Text = this.U.Ime;
                txtPrezime.Text = this.U.Prezime;
                txtAdresa.Text = this.U.Adresa;
                txtTelefon.Text = this.U.Telefon;
                cbRazred.Text = this.U.Razred.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Provjerimo jesu li upisani svi obavezni podaci uzimamo da su obavezni npr. OIB, ime, prezime i razred
            if (txtOIB.Text == "" || txtIme.Text == "" || txtPrezime.Text == "" || cbRazred.Text == "")
            {
                MessageBox.Show("OIB, ime i prezime te razred su obvezni!");
                this.DialogResult = DialogResult.None;

            }
            else {
                // Ako je svojstvo U null, tada se radi o novom učeniku
                if (this.U == null) {
                    this.U = new Ucenik();
                }

                // Spremamo vrijednosti iz kontrola u objekt U
                this.U.OIB = txtOIB.Text;
                this.U.Ime = txtIme.Text;
                this.U.Prezime = txtPrezime.Text;
                this.U.Adresa = txtAdresa.Text;
                this.U.Telefon = txtTelefon.Text;
                this.U.Razred = int.Parse(cbRazred.Text);

                // Vraćamo pozitivan rezultat dijaloga
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
