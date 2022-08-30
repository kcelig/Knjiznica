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
    public partial class PDetalji : Form
    {
        public PDetalji(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        public Posudba P;

        // Varijabla članica u kojoj čuvamo podatkovni kontekst
        private PodatkovniKontekst kontekst;

        private void PrikaziUcenike()
        {
            Forme.Pomocna.PrikaziListuUListBoxu<Ucenik>(
            this.kontekst.Ucenici, lbUcenici);
        }
        private void PrikaziKnjige()
        {
            Forme.Pomocna.PrikaziListuUListBoxu<Knjiga>(
            this.kontekst.Knjige, lbKnjige);
        }

        private void PDetalji_Load(object sender, EventArgs e)
        {
            // Prikazujemo učenike i knjige na formi
            PrikaziUcenike();
            PrikaziKnjige();
            // Ako se ne radi o novoj posudbi, prikazujem postojeću
            if (this.P != null)
            {
                lbUcenici.SelectedItem = this.P.Ucenik;
                lbKnjige.SelectedItem = this.P.Knjiga;
                dtpDatumPosudbe.Value = this.P.DatumPosudbe;
                nudBrojDana.Value = this.P.BrojDana;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Provjerimo jesu li odabrani učenik i knjiga
            if (lbUcenici.SelectedIndex < 0 || lbKnjige.SelectedIndex < 0)
            {
                MessageBox.Show("Učenika i knjigu morate odabrati!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                // Ako je svojstvo P null, tada se radi o novoj posudbi
                if (this.P == null)
                {
                    this.P = new Posudba();
                }
                // Spremamo vrijednosti iz kontrola u objekt P
                this.P.Ucenik = (Ucenik)lbUcenici.SelectedItem;
                this.P.Knjiga = (Knjiga)lbKnjige.SelectedItem;
                this.P.DatumPosudbe = dtpDatumPosudbe.Value;
                this.P.BrojDana = (int)nudBrojDana.Value;

                this.DialogResult = DialogResult.OK;
            }


        }



    }
}
