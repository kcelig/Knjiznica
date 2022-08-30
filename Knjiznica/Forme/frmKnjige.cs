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
    public partial class Knjige : Form
    {
        public Knjige(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private PodatkovniKontekst kontekst;

        private void PrikaziKnjige()
        {
            Forme.Pomocna.PrikaziListuUListBoxu<Knjiga>(
            this.kontekst.Knjige, lbKnjige);
        }
        private void frmKnjige_Load(object sender, EventArgs e)
        {
            // Na učitavanju forme prikazujemo knjige
            PrikaziKnjige();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KDetalji frmKDetalji = new KDetalji();
            // Prikazujemo formu za detalje nove knjige
            if (frmKDetalji.ShowDialog() == DialogResult.OK)
            {
                // Ako je dijalog poz., dodajemo novu knjigu nalistu
                this.kontekst.DodajKnjigu(frmKDetalji.K);
                PrikaziKnjige();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (lbKnjige.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali knjigu!");
            }
            else
            {
                KDetalji frmKDetalji = new KDetalji();
                // Prikazujemo formu za detalje odabranu knjigu
                frmKDetalji.K = (Knjiga)lbKnjige.SelectedItem;
                if (frmKDetalji.ShowDialog() == DialogResult.OK)
                {
                // Spremamo promjene i osvježavamo listu
                    this.kontekst.SpremiKnjige();
                    PrikaziKnjige();
                }
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (lbKnjige.SelectedIndex < 0)
            {
                 MessageBox.Show("Niste odabrali knjigu!");
            }
            else
            {
                // Uklanjamo knjigu s liste i osvježavamo listu
                this.kontekst.BrisiKnjigu((Knjiga)lbKnjige.SelectedItem);
                PrikaziKnjige();
            }
        }

       






    }

}
