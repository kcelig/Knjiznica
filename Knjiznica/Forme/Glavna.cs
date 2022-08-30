using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Knjiznica.Model;    //moramo uključiti da bi public PodatkovniKontekst Kontekst; bio vidlljiv

namespace Knjiznica.Forme
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        // PodatkovniKontekst objekt čuvat će sve podatke o učenicima, knjigama i posudbama
        public PodatkovniKontekst Kontekst;

        private void Glavna_Load(object sender, EventArgs e)
        {
            // Na prikazivanju forme instanciramo kontekstni objekt koji čita sve podatke iz datoteka
            try {
                this.Kontekst = new PodatkovniKontekst();
                PrikaziPosudbe();
            }
            catch (Exception ex) {
                // U slučaju greške, samo ju ispisujemo
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucenici_Click(object sender, EventArgs e)
        {
            // Instanciramo novu formu Ucenici i prikazujemo je
            // U konstruktor prosljeđujemo kontekstni objekt
            Ucenici frmUcenici = new Ucenici(this.Kontekst);
            frmUcenici.ShowDialog();

        }

        private void knjige_Click(object sender, EventArgs e)
        {
            Knjige frmKnjige = new Knjige(this.Kontekst);
            frmKnjige.ShowDialog();
        }

        public void PrikaziPosudbe() {
            Forme.Pomocna.PrikaziListuUListBoxu<Posudba>(this.Kontekst.Posudbe, lbPosudbe);
        
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            PDetalji frmPDetalji = new PDetalji(this.Kontekst);
            // Prikazujemo formu za detalje novog učenika
            if (frmPDetalji.ShowDialog() == DialogResult.OK)
            {
                // Ako je dijalog pozitivan, dodajemo novu posudbu
                this.Kontekst.DodajPosudbu(frmPDetalji.P);
                PrikaziPosudbe();
            }
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (lbPosudbe.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali posudbu!");
            }
            else
            {
                PDetalji frmPDetalji = new PDetalji(this.Kontekst);
                // Prikazujemo formu za detalje odabrane posudbe
                frmPDetalji.P = (Posudba)lbPosudbe.SelectedItem;
                if (frmPDetalji.ShowDialog() == DialogResult.OK)
                {
                    // Spremamo promjene i osvježavamo listu
                    this.Kontekst.SpremiPosudbe();
                    PrikaziPosudbe();
                }
            }
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            if (lbPosudbe.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali posudbu!");
            }
            else
            {
                // Uklanjamo posudbu s liste i osvježavamo listu
                this.Kontekst.BrisiPosudbu((Posudba)lbPosudbe.
                SelectedItem);
                PrikaziPosudbe();
            }
        }


    }
}
