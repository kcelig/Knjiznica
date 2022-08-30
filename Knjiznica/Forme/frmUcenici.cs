using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Knjiznica.Model; //uključiti Knjiznica.Model

namespace Knjiznica.Forme
{
    public partial class Ucenici : Form //preimenovati u Ucenici
    {
        public Ucenici(PodatkovniKontekst kontekst) //preimenovati u Ucenici
        {
            InitializeComponent();
            // U konstruktoru kao parametar dobivamo podatkovni kontekst s glavne forme i spremamo ga u varijablu članicu
            this.kontekst = kontekst;       
        }

        // Varijabla članica u kojoj čuvamo podatkovni kontekst
        private PodatkovniKontekst kontekst;  

        private void Ucenici_Load(object sender, EventArgs e)
        {
            //na učitavanju forme prikazujemo učenike
            PrikaziUcenike();
        }

    

        private void PrikaziUcenike() {
            Forme.Pomocna.PrikaziListuUListBoxu<Ucenik>(this.kontekst.Ucenici, lbUcenici);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UDetalji frmUDetalji = new UDetalji();

            // Prikazujemo formu za detalje novog učenika
            if (frmUDetalji.ShowDialog() == DialogResult.OK) {
                // Ako je dijalog pozitivan, dodajemo novog učenika na listu
                this.kontekst.DodajUcenika(frmUDetalji.U);
                PrikaziUcenike();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (lbUcenici.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali učenika");
            }
            else {
                // Prikazujemo formu za detalje odabranog učenika
                UDetalji frmUDetalji = new UDetalji();
                frmUDetalji.U = (Ucenik)lbUcenici.SelectedItem;

                if (frmUDetalji.ShowDialog() == DialogResult.OK) {
                    // Spremamo promjene i osvježavamo listu
                    this.kontekst.SpremiUcenike();
                    PrikaziUcenike();
                }
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (lbUcenici.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali učenika");
            }
            else {
                // Uklanjamo učenika s liste i osvježavamo listu
                this.kontekst.BrisiUcenika((Ucenik)lbUcenici.SelectedItem);
                PrikaziUcenike();
            }
        }
    }
}
