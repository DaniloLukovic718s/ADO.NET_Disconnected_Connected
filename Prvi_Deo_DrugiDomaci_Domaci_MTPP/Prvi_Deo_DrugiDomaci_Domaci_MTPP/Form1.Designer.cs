
namespace Prvi_Deo_DrugiDomaci_Domaci_MTPP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRead = new System.Windows.Forms.Button();
            this.btnFilterForm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.cboDelete = new System.Windows.Forms.ComboBox();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtUpCompanyName = new System.Windows.Forms.TextBox();
            this.txtUpSuplierID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpFax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpCountry = new System.Windows.Forms.TextBox();
            this.txtUpPostalCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUpRegion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUpCity = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUpAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUpContactTitle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUpContactName = new System.Windows.Forms.TextBox();
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridRead = new System.Windows.Forms.DataGridView();
            this.gbUpdate.SuspendLayout();
            this.gbInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRead)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(1575, 313);
            this.btnRead.Margin = new System.Windows.Forms.Padding(6);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(160, 92);
            this.btnRead.TabIndex = 23;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnFilterForm
            // 
            this.btnFilterForm.Location = new System.Drawing.Point(1575, 168);
            this.btnFilterForm.Margin = new System.Windows.Forms.Padding(6);
            this.btnFilterForm.Name = "btnFilterForm";
            this.btnFilterForm.Size = new System.Drawing.Size(160, 92);
            this.btnFilterForm.TabIndex = 22;
            this.btnFilterForm.Text = "FILTER";
            this.btnFilterForm.UseVisualStyleBackColor = true;
            this.btnFilterForm.Click += new System.EventHandler(this.btnFilterForm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1869, 269);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 71);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1903, 180);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 25);
            this.label21.TabIndex = 20;
            this.label21.Text = "SupplierId ";
            // 
            // cboDelete
            // 
            this.cboDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDelete.FormattingEnabled = true;
            this.cboDelete.Location = new System.Drawing.Point(1845, 211);
            this.cboDelete.Margin = new System.Windows.Forms.Padding(6);
            this.cboDelete.Name = "cboDelete";
            this.cboDelete.Size = new System.Drawing.Size(238, 33);
            this.cboDelete.TabIndex = 19;
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.label22);
            this.gbUpdate.Controls.Add(this.txtUpCompanyName);
            this.gbUpdate.Controls.Add(this.txtUpSuplierID);
            this.gbUpdate.Controls.Add(this.label20);
            this.gbUpdate.Controls.Add(this.btnUpdate);
            this.gbUpdate.Controls.Add(this.label11);
            this.gbUpdate.Controls.Add(this.txtUpFax);
            this.gbUpdate.Controls.Add(this.label12);
            this.gbUpdate.Controls.Add(this.txtUpPhone);
            this.gbUpdate.Controls.Add(this.label13);
            this.gbUpdate.Controls.Add(this.txtUpCountry);
            this.gbUpdate.Controls.Add(this.txtUpPostalCode);
            this.gbUpdate.Controls.Add(this.label14);
            this.gbUpdate.Controls.Add(this.label15);
            this.gbUpdate.Controls.Add(this.txtUpRegion);
            this.gbUpdate.Controls.Add(this.label16);
            this.gbUpdate.Controls.Add(this.txtUpCity);
            this.gbUpdate.Controls.Add(this.label17);
            this.gbUpdate.Controls.Add(this.txtUpAddress);
            this.gbUpdate.Controls.Add(this.label18);
            this.gbUpdate.Controls.Add(this.txtUpContactTitle);
            this.gbUpdate.Controls.Add(this.label19);
            this.gbUpdate.Controls.Add(this.txtUpContactName);
            this.gbUpdate.Location = new System.Drawing.Point(825, 539);
            this.gbUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Padding = new System.Windows.Forms.Padding(6);
            this.gbUpdate.Size = new System.Drawing.Size(658, 731);
            this.gbUpdate.TabIndex = 18;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "UPDATE";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 100);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(165, 25);
            this.label22.TabIndex = 24;
            this.label22.Text = "Company Name";
            // 
            // txtUpCompanyName
            // 
            this.txtUpCompanyName.Location = new System.Drawing.Point(194, 94);
            this.txtUpCompanyName.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpCompanyName.Name = "txtUpCompanyName";
            this.txtUpCompanyName.Size = new System.Drawing.Size(224, 31);
            this.txtUpCompanyName.TabIndex = 16;
            // 
            // txtUpSuplierID
            // 
            this.txtUpSuplierID.Location = new System.Drawing.Point(194, 37);
            this.txtUpSuplierID.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpSuplierID.Name = "txtUpSuplierID";
            this.txtUpSuplierID.ReadOnly = true;
            this.txtUpSuplierID.Size = new System.Drawing.Size(226, 31);
            this.txtUpSuplierID.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 37);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 25);
            this.label20.TabIndex = 22;
            this.label20.Text = "SupplierID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(476, 321);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 68);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 696);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Fax:";
            // 
            // txtUpFax
            // 
            this.txtUpFax.Location = new System.Drawing.Point(194, 683);
            this.txtUpFax.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpFax.MaxLength = 24;
            this.txtUpFax.Name = "txtUpFax";
            this.txtUpFax.Size = new System.Drawing.Size(226, 31);
            this.txtUpFax.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 623);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Phone:";
            // 
            // txtUpPhone
            // 
            this.txtUpPhone.Location = new System.Drawing.Point(194, 617);
            this.txtUpPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpPhone.MaxLength = 24;
            this.txtUpPhone.Name = "txtUpPhone";
            this.txtUpPhone.Size = new System.Drawing.Size(226, 31);
            this.txtUpPhone.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 563);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "Country:";
            // 
            // txtUpCountry
            // 
            this.txtUpCountry.Location = new System.Drawing.Point(196, 550);
            this.txtUpCountry.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpCountry.MaxLength = 15;
            this.txtUpCountry.Name = "txtUpCountry";
            this.txtUpCountry.Size = new System.Drawing.Size(226, 31);
            this.txtUpCountry.TabIndex = 14;
            // 
            // txtUpPostalCode
            // 
            this.txtUpPostalCode.Location = new System.Drawing.Point(196, 483);
            this.txtUpPostalCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpPostalCode.MaxLength = 10;
            this.txtUpPostalCode.Name = "txtUpPostalCode";
            this.txtUpPostalCode.Size = new System.Drawing.Size(226, 31);
            this.txtUpPostalCode.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 488);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "Postal code:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 425);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 25);
            this.label15.TabIndex = 11;
            this.label15.Text = "Region:";
            // 
            // txtUpRegion
            // 
            this.txtUpRegion.Location = new System.Drawing.Point(194, 419);
            this.txtUpRegion.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpRegion.MaxLength = 15;
            this.txtUpRegion.Name = "txtUpRegion";
            this.txtUpRegion.Size = new System.Drawing.Size(228, 31);
            this.txtUpRegion.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 356);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 25);
            this.label16.TabIndex = 9;
            this.label16.Text = "City:";
            // 
            // txtUpCity
            // 
            this.txtUpCity.Location = new System.Drawing.Point(194, 350);
            this.txtUpCity.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpCity.MaxLength = 15;
            this.txtUpCity.Name = "txtUpCity";
            this.txtUpCity.Size = new System.Drawing.Size(228, 31);
            this.txtUpCity.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 287);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 25);
            this.label17.TabIndex = 7;
            this.label17.Text = "Address:";
            // 
            // txtUpAddress
            // 
            this.txtUpAddress.Location = new System.Drawing.Point(194, 281);
            this.txtUpAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpAddress.MaxLength = 60;
            this.txtUpAddress.Name = "txtUpAddress";
            this.txtUpAddress.Size = new System.Drawing.Size(228, 31);
            this.txtUpAddress.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 217);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 25);
            this.label18.TabIndex = 5;
            this.label18.Text = "Contact title:";
            // 
            // txtUpContactTitle
            // 
            this.txtUpContactTitle.Location = new System.Drawing.Point(194, 212);
            this.txtUpContactTitle.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpContactTitle.MaxLength = 30;
            this.txtUpContactTitle.Name = "txtUpContactTitle";
            this.txtUpContactTitle.Size = new System.Drawing.Size(228, 31);
            this.txtUpContactTitle.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 165);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 25);
            this.label19.TabIndex = 3;
            this.label19.Text = "Contact Name:";
            // 
            // txtUpContactName
            // 
            this.txtUpContactName.Location = new System.Drawing.Point(194, 152);
            this.txtUpContactName.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpContactName.MaxLength = 30;
            this.txtUpContactName.Name = "txtUpContactName";
            this.txtUpContactName.Size = new System.Drawing.Size(228, 31);
            this.txtUpContactName.TabIndex = 2;
            // 
            // gbInsert
            // 
            this.gbInsert.Controls.Add(this.btnInsert);
            this.gbInsert.Controls.Add(this.label10);
            this.gbInsert.Controls.Add(this.txtFax);
            this.gbInsert.Controls.Add(this.label9);
            this.gbInsert.Controls.Add(this.txtPhone);
            this.gbInsert.Controls.Add(this.label8);
            this.gbInsert.Controls.Add(this.txtCountry);
            this.gbInsert.Controls.Add(this.txtPostalCode);
            this.gbInsert.Controls.Add(this.label7);
            this.gbInsert.Controls.Add(this.label6);
            this.gbInsert.Controls.Add(this.txtRegion);
            this.gbInsert.Controls.Add(this.label5);
            this.gbInsert.Controls.Add(this.txtCity);
            this.gbInsert.Controls.Add(this.label4);
            this.gbInsert.Controls.Add(this.txtAddress);
            this.gbInsert.Controls.Add(this.label3);
            this.gbInsert.Controls.Add(this.txtContactTitle);
            this.gbInsert.Controls.Add(this.label2);
            this.gbInsert.Controls.Add(this.txtContactName);
            this.gbInsert.Controls.Add(this.txtCompanyName);
            this.gbInsert.Controls.Add(this.label1);
            this.gbInsert.Location = new System.Drawing.Point(97, 537);
            this.gbInsert.Margin = new System.Windows.Forms.Padding(6);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Padding = new System.Windows.Forms.Padding(6);
            this.gbInsert.Size = new System.Drawing.Size(652, 733);
            this.gbInsert.TabIndex = 17;
            this.gbInsert.TabStop = false;
            this.gbInsert.Text = "INSERT";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(437, 298);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(158, 60);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 667);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fax:";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(194, 654);
            this.txtFax.Margin = new System.Windows.Forms.Padding(6);
            this.txtFax.MaxLength = 24;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(226, 31);
            this.txtFax.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 594);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(196, 581);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhone.MaxLength = 24;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(226, 31);
            this.txtPhone.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 527);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(194, 513);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(6);
            this.txtCountry.MaxLength = 15;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(226, 31);
            this.txtCountry.TabIndex = 14;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(194, 446);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtPostalCode.MaxLength = 10;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(226, 31);
            this.txtPostalCode.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 460);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Postal code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Region:";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(194, 383);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(6);
            this.txtRegion.MaxLength = 15;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(228, 31);
            this.txtRegion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(194, 313);
            this.txtCity.Margin = new System.Windows.Forms.Padding(6);
            this.txtCity.MaxLength = 15;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(228, 31);
            this.txtCity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(194, 244);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress.MaxLength = 60;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(228, 31);
            this.txtAddress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact title:";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(194, 175);
            this.txtContactTitle.Margin = new System.Windows.Forms.Padding(6);
            this.txtContactTitle.MaxLength = 30;
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(228, 31);
            this.txtContactTitle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact Name:";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(194, 115);
            this.txtContactName.Margin = new System.Windows.Forms.Padding(6);
            this.txtContactName.MaxLength = 30;
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(228, 31);
            this.txtContactName.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(194, 52);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(6);
            this.txtCompanyName.MaxLength = 40;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(228, 31);
            this.txtCompanyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name:";
            // 
            // gridRead
            // 
            this.gridRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRead.Location = new System.Drawing.Point(97, 54);
            this.gridRead.Margin = new System.Windows.Forms.Padding(6);
            this.gridRead.Name = "gridRead";
            this.gridRead.RowHeadersWidth = 82;
            this.gridRead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRead.Size = new System.Drawing.Size(1407, 442);
            this.gridRead.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2342, 1565);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnFilterForm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cboDelete);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.gbInsert);
            this.Controls.Add(this.gridRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.gbInsert.ResumeLayout(false);
            this.gbInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnFilterForm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboDelete;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtUpCompanyName;
        private System.Windows.Forms.TextBox txtUpSuplierID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpFax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpCountry;
        private System.Windows.Forms.TextBox txtUpPostalCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUpRegion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUpCity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUpAddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUpContactTitle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtUpContactName;
        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRead;
    }
}

