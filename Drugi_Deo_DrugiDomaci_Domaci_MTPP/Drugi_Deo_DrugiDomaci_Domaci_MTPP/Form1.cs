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
    public partial class Form1 : Form
    {
        EntityDataModel edm = new EntityDataModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            gridKlijentList.DataSource = edm.klijent.ToList<Klijent>();
            gridServisList.DataSource = edm.servis.ToList<Servis>();

            foreach (Control c in gbKlijentUpdate.Controls)
            {
                c.DataBindings.Clear();
            }

            foreach (Control s in gbServisUpdate.Controls)
            {
                s.DataBindings.Clear();
            }

            //Combo za delete klijenta

            cboKlijentDelete.DataSource = gridKlijentList.DataSource;
            cboKlijentDelete.DisplayMember = "klijentID";
            cboKlijentDelete.ValueMember = "klijentID";

            //Combo za delete servisa

            cboServisDelete.DataSource = gridServisList.DataSource;
            cboServisDelete.DisplayMember = "servisID";
            cboServisDelete.ValueMember = "servisID";

            //Klijent update
            cboKlijentID.DataSource = gridKlijentList.DataSource;
            cboKlijentID.DisplayMember = "klijentID";
            cboKlijentID.ValueMember = "klijentID";

            //Servis update

            cboServisId.DataSource = gridServisList.DataSource;
            cboServisId.DisplayMember = "servisID";
            cboServisId.ValueMember = "servisID";

            txtUpdateNazivKlijenta.DataBindings.Add("Text", gridKlijentList.DataSource, "nazivKlijenta");
            txtUpdateRegBroj.DataBindings.Add("Text", gridKlijentList.DataSource, "registarskiBroj");
            txtUpdateKontakt.DataBindings.Add("Text", gridKlijentList.DataSource, "Kontakt");
            txtUpdateKomentar.DataBindings.Add("Text", gridKlijentList.DataSource, "dodatniKomentar");



            dtUpdateDate.DataBindings.Add("Text", gridServisList.DataSource, "datumServisa");
            txtUpdateOpis.DataBindings.Add("Text", gridServisList.DataSource, "opisUsluge");


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertForm iForm = new InsertForm();
            iForm.Show();
            this.Hide();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(cboKlijentDelete.SelectedValue);
                Klijent klijent = edm.klijent.SingleOrDefault(k => k.klijentID == id);
                Servis servis = edm.servis.SingleOrDefault(s => s.klijentID == klijent.klijentID);

                if (servis == null)
                {
                    edm.klijent.Remove(klijent);
                    edm.SaveChanges();
                    edm.Dispose();

                    edm = new EntityDataModel();
                    btnRead_Click(null, null);

                    MessageBox.Show("Uspesno ste obrisali klijenta", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Klijent " + klijent.nazivKlijenta + " ne moze biti obrisan!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteServis_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cboServisDelete.SelectedValue);
                Servis ser = edm.servis.SingleOrDefault(x => x.servisID == id);

                edm.servis.Remove(ser);
                edm.SaveChanges();
                edm.Dispose();
                edm = new EntityDataModel();

                btnRead_Click(null, null);

                MessageBox.Show("Uspesno ste obrisali servis", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cboKlijentID.SelectedValue);
                Klijent updateKlijenta = edm.klijent.SingleOrDefault(k => k.klijentID == id);
                updateKlijenta.klijentID = id;
                updateKlijenta.nazivKlijenta = txtUpdateNazivKlijenta.Text;
                updateKlijenta.registarskiBroj = txtUpdateRegBroj.Text;
                updateKlijenta.Kontakt = txtUpdateKontakt.Text;
                updateKlijenta.dodatniKomentar = txtUpdateKomentar.Text;

                edm.SaveChanges();
                btnRead_Click(null, null);

                MessageBox.Show("Uspesno ste napravili izmene nad klijentom!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                edm.Dispose(); // brisanje reference na objekat
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
                edm.Dispose();
                edm = new EntityDataModel();
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cboServisId.SelectedValue);
                Servis updateServisa = edm.servis.SingleOrDefault(s => s.servisID == id);

                updateServisa.servisID = id;
                updateServisa.datumServisa = dtUpdateDate.Value;
                updateServisa.opisUsluge = txtUpdateOpis.Text;

                edm.SaveChanges();
                btnRead_Click(null, null);

                MessageBox.Show("Uspesno ste napravili izmene nad servisom!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                edm.Dispose();
                edm = new EntityDataModel();
            }
        }
    }
}
