using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prvi_Deo_DrugiDomaci_Domaci_MTPP
{
    public partial class Form1 : Form
    {
        LinqSqlDataContext dc = new LinqSqlDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                gridRead.DataSource = dc.SelectSuppliers();

                foreach (Control c in gbUpdate.Controls)
                {
                    c.DataBindings.Clear();
                }

                txtUpSuplierID.DataBindings.Add("Text", gridRead.DataSource, "supplierid");
                txtUpCompanyName.DataBindings.Add("Text", gridRead.DataSource, "companyname");
                txtUpContactName.DataBindings.Add("Text", gridRead.DataSource, "contactname");
                txtUpContactTitle.DataBindings.Add("Text", gridRead.DataSource, "contacttitle");
                txtUpAddress.DataBindings.Add("Text", gridRead.DataSource, "address");
                txtUpCity.DataBindings.Add("Text", gridRead.DataSource, "city");
                txtUpRegion.DataBindings.Add("Text", gridRead.DataSource, "region");
                txtUpPostalCode.DataBindings.Add("Text", gridRead.DataSource, "postalcode");
                txtUpCountry.DataBindings.Add("Text", gridRead.DataSource, "country");
                txtUpPhone.DataBindings.Add("Text", gridRead.DataSource, "phone");
                txtUpFax.DataBindings.Add("Text", gridRead.DataSource, "fax");

                cboDelete.DataSource = dc.SelectSuppliers();
                cboDelete.DisplayMember = "supplierid";
                cboDelete.ValueMember = "supplierid";
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int Ret = 0;
                dc = new LinqSqlDataContext();

                if (txtCompanyName.Text == "" || txtContactName.Text == "" || txtContactTitle.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtRegion.Text == "" ||
                    txtPostalCode.Text == "" || txtCountry.Text == "" || txtPhone.Text == "" || txtFax.Text == "")
                {
                    MessageBox.Show("Polja ne smeju biti prazna, molimo vas popunite sva polja!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    Ret = dc.InsertSuppliers
                        (
                            txtCompanyName.Text, txtContactName.Text, txtContactTitle.Text, txtAddress.Text, txtCity.Text, txtRegion.Text, txtPostalCode.Text, txtCountry.Text, txtPhone.Text, txtFax.Text
                        );
                    if (Ret > 0)
                    {
                        throw new Exception("Proverite ponovo podatke koje ste uneli");
                    }
                    MessageBox.Show("Uspesno ste uneli podatke!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnRead_Click(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int Ret = 0;
                int supplierid = Convert.ToInt32(cboDelete.SelectedValue);
                Ret = dc.DeleteSuppliers(supplierid);
                if (Ret > 0)
                {
                    throw new Exception("Ne mozete izbrisati red iz tabele");
                }

                btnRead_Click(null, null);
                MessageBox.Show("Uspesno ste obrisali podatke!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int Ret = 0;
                int supplierid = Convert.ToInt32(txtUpSuplierID.Text);
                Ret = dc.UpdateSuppliers(supplierid, txtUpCompanyName.Text, txtUpContactName.Text, txtUpContactTitle.Text, txtUpAddress.Text, txtUpCity.Text, txtUpRegion.Text, txtUpPostalCode.Text, txtUpCountry.Text, txtUpPhone.Text, txtUpFax.Text);
                MessageBox.Show("Uspesno ste promenili podatke!");
                btnRead_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilterForm_Click(object sender, EventArgs e)
        {
            FilterGrad fGrad = new FilterGrad();
            fGrad.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
