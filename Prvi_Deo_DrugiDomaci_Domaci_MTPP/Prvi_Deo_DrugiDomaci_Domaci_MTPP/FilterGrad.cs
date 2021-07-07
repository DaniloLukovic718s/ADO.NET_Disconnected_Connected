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
    public partial class FilterGrad : Form
    {
        LinqSqlDataContext dc = new LinqSqlDataContext();
        public FilterGrad()
        {
            InitializeComponent();
        }
        private void FilterGrad_Load(object sender, EventArgs e)
        {
            var suppliers = from s in dc.Suppliers
                            select s;
            gridCityList.DataSource = suppliers;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCityList.Text != "")
                {
                    var city = from s in dc.Suppliers
                               where s.city == txtCityList.Text
                               orderby s.companyname ascending
                               select new
                               {
                                   s.supplierid,
                                   s.companyname,
                                   s.contactname,
                                   s.contacttitle,
                                   s.address,
                                   s.city,
                                   s.region,
                                   s.postalcode,
                                   s.country,
                                   s.phone,
                                   s.fax
                               };
                    gridCityList.DataSource = city;
                }
                else
                {
                    var suppliers = from s in dc.Suppliers
                                    select s;
                    gridCityList.DataSource = suppliers;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            var suppliers = from s in dc.Suppliers
                            select s;
            gridCityList.DataSource = suppliers;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 GlavnaForma = new Form1();
            GlavnaForma.ShowDialog();
        }
    }
}
