using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugi_Deo_DrugiDomaci_Domaci_MTPP
{
  
    public partial class InsertForm : Form
    {
        EntityDataModel edm = new EntityDataModel();
        public InsertForm()
        {
            InitializeComponent();
        }

        private void btnInsertKlijenti_Click(object sender, EventArgs e)
        {
            try
            {
                Klijent newKlijent = new Klijent {nazivKlijenta = txtNazivKlijenta.Text, registarskiBroj = txtRegBroj.Text, Kontakt = txtKontakt.Text, dodatniKomentar = txtKomentar.Text};
                edm.klijent.Add(newKlijent);
                edm.SaveChanges();
                MessageBox.Show("Uspesno ste dodali novog klijenta!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbKlijentId.DataSource = edm.klijent.ToList<Klijent>();
                cmbKlijentId.DisplayMember = "klijentID";
                cmbKlijentId.ValueMember = "klijentID";

                edm.Dispose();
                edm = new EntityDataModel();

            }
            catch (DbEntityValidationException efex)
            {
                foreach (DbEntityValidationResult s in efex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }

                }
                edm.Dispose(); // brisanje reference na objekat
                edm = new EntityDataModel();
            }
        }

        private void btnInsertServis_Click(object sender, EventArgs e)
        {
            try
            {
                Servis newServis = new Servis { klijentID = Convert.ToInt32(cmbKlijentId.Text), datumServisa = dtServis.Value, opisUsluge = txtOpis.Text };
                edm.servis.Add(newServis);
                edm.SaveChanges();

                MessageBox.Show("Uspesno ste dodali novi servis!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                edm.Dispose();
                edm = new EntityDataModel();
            }
            catch (DbEntityValidationException efex)
            {
                foreach (DbEntityValidationResult s in efex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }

                }
                edm.Dispose(); // brisanje reference na objekat
                edm = new EntityDataModel();
            }
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            cmbKlijentId.DataSource = edm.klijent.ToList<Klijent>();
            cmbKlijentId.DisplayMember = "klijentID";
            cmbKlijentId.ValueMember = "klijentID";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 GlavnaForma = new Form1();
            GlavnaForma.Show();
            this.Close();
        }
    }
}
