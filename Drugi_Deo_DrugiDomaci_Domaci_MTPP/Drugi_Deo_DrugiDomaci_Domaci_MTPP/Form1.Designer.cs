
namespace Drugi_Deo_DrugiDomaci_Domaci_MTPP
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
            this.gbKlijentUpdate = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.txtUpdateNazivKlijenta = new System.Windows.Forms.TextBox();
            this.cboKlijentID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateKomentar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateKontakt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateRegBroj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.cboKlijentDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gridKlijentList = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.gbServisUpdate = new System.Windows.Forms.GroupBox();
            this.cboServisId = new System.Windows.Forms.ComboBox();
            this.dtUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboServisDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteServis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridServisList = new System.Windows.Forms.DataGridView();
            this.gbKlijentUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKlijentList)).BeginInit();
            this.gbServisUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServisList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKlijentUpdate
            // 
            this.gbKlijentUpdate.Controls.Add(this.label10);
            this.gbKlijentUpdate.Controls.Add(this.txtUpdateNazivKlijenta);
            this.gbKlijentUpdate.Controls.Add(this.cboKlijentID);
            this.gbKlijentUpdate.Controls.Add(this.btnUpdateClient);
            this.gbKlijentUpdate.Controls.Add(this.label6);
            this.gbKlijentUpdate.Controls.Add(this.txtUpdateKomentar);
            this.gbKlijentUpdate.Controls.Add(this.label4);
            this.gbKlijentUpdate.Controls.Add(this.txtUpdateKontakt);
            this.gbKlijentUpdate.Controls.Add(this.label3);
            this.gbKlijentUpdate.Controls.Add(this.txtUpdateRegBroj);
            this.gbKlijentUpdate.Controls.Add(this.label9);
            this.gbKlijentUpdate.Location = new System.Drawing.Point(85, 611);
            this.gbKlijentUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.gbKlijentUpdate.Name = "gbKlijentUpdate";
            this.gbKlijentUpdate.Padding = new System.Windows.Forms.Padding(6);
            this.gbKlijentUpdate.Size = new System.Drawing.Size(792, 537);
            this.gbKlijentUpdate.TabIndex = 34;
            this.gbKlijentUpdate.TabStop = false;
            this.gbKlijentUpdate.Text = "Klijent update";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "KlijentID";
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(37, 418);
            this.btnUpdateService.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(704, 77);
            this.btnUpdateService.TabIndex = 11;
            this.btnUpdateService.Text = "Update servis";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // txtUpdateNazivKlijenta
            // 
            this.txtUpdateNazivKlijenta.Location = new System.Drawing.Point(212, 92);
            this.txtUpdateNazivKlijenta.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateNazivKlijenta.Name = "txtUpdateNazivKlijenta";
            this.txtUpdateNazivKlijenta.Size = new System.Drawing.Size(316, 31);
            this.txtUpdateNazivKlijenta.TabIndex = 12;
            // 
            // cboKlijentID
            // 
            this.cboKlijentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKlijentID.FormattingEnabled = true;
            this.cboKlijentID.Location = new System.Drawing.Point(212, 42);
            this.cboKlijentID.Margin = new System.Windows.Forms.Padding(6);
            this.cboKlijentID.Name = "cboKlijentID";
            this.cboKlijentID.Size = new System.Drawing.Size(316, 33);
            this.cboKlijentID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Naziv klijenta:";
            // 
            // txtUpdateKomentar
            // 
            this.txtUpdateKomentar.Location = new System.Drawing.Point(212, 242);
            this.txtUpdateKomentar.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateKomentar.MaxLength = 200;
            this.txtUpdateKomentar.Multiline = true;
            this.txtUpdateKomentar.Name = "txtUpdateKomentar";
            this.txtUpdateKomentar.Size = new System.Drawing.Size(440, 139);
            this.txtUpdateKomentar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dodatni komentar:";
            // 
            // txtUpdateKontakt
            // 
            this.txtUpdateKontakt.Location = new System.Drawing.Point(212, 190);
            this.txtUpdateKontakt.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateKontakt.MaxLength = 40;
            this.txtUpdateKontakt.Name = "txtUpdateKontakt";
            this.txtUpdateKontakt.Size = new System.Drawing.Size(316, 31);
            this.txtUpdateKontakt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kontakt:";
            // 
            // txtUpdateRegBroj
            // 
            this.txtUpdateRegBroj.Location = new System.Drawing.Point(212, 138);
            this.txtUpdateRegBroj.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateRegBroj.MaxLength = 20;
            this.txtUpdateRegBroj.Name = "txtUpdateRegBroj";
            this.txtUpdateRegBroj.Size = new System.Drawing.Size(316, 31);
            this.txtUpdateRegBroj.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 152);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Registarski broj:";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(38, 418);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(704, 77);
            this.btnUpdateClient.TabIndex = 8;
            this.btnUpdateClient.Text = "Update klijenta";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // cboKlijentDelete
            // 
            this.cboKlijentDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKlijentDelete.FormattingEnabled = true;
            this.cboKlijentDelete.Location = new System.Drawing.Point(321, 33);
            this.cboKlijentDelete.Margin = new System.Windows.Forms.Padding(6);
            this.cboKlijentDelete.Name = "cboKlijentDelete";
            this.cboKlijentDelete.Size = new System.Drawing.Size(238, 33);
            this.cboKlijentDelete.TabIndex = 33;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(51, 93);
            this.btnDeleteClient.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(826, 58);
            this.btnDeleteClient.TabIndex = 32;
            this.btnDeleteClient.Text = "Izbrisi klijenta";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "KlijentID:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(85, 1287);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(1725, 82);
            this.btnInsert.TabIndex = 30;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gridKlijentList
            // 
            this.gridKlijentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKlijentList.Location = new System.Drawing.Point(51, 188);
            this.gridKlijentList.Margin = new System.Windows.Forms.Padding(6);
            this.gridKlijentList.Name = "gridKlijentList";
            this.gridKlijentList.RowHeadersWidth = 82;
            this.gridKlijentList.Size = new System.Drawing.Size(826, 373);
            this.gridKlijentList.TabIndex = 29;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(85, 1179);
            this.btnRead.Margin = new System.Windows.Forms.Padding(6);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(1725, 82);
            this.btnRead.TabIndex = 28;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // gbServisUpdate
            // 
            this.gbServisUpdate.Controls.Add(this.cboServisId);
            this.gbServisUpdate.Controls.Add(this.btnUpdateService);
            this.gbServisUpdate.Controls.Add(this.dtUpdateDate);
            this.gbServisUpdate.Controls.Add(this.txtUpdateOpis);
            this.gbServisUpdate.Controls.Add(this.label5);
            this.gbServisUpdate.Controls.Add(this.label7);
            this.gbServisUpdate.Controls.Add(this.label8);
            this.gbServisUpdate.Location = new System.Drawing.Point(1017, 611);
            this.gbServisUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.gbServisUpdate.Name = "gbServisUpdate";
            this.gbServisUpdate.Padding = new System.Windows.Forms.Padding(6);
            this.gbServisUpdate.Size = new System.Drawing.Size(793, 537);
            this.gbServisUpdate.TabIndex = 39;
            this.gbServisUpdate.TabStop = false;
            this.gbServisUpdate.Text = "Servis update";
            // 
            // cboServisId
            // 
            this.cboServisId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServisId.FormattingEnabled = true;
            this.cboServisId.Location = new System.Drawing.Point(212, 71);
            this.cboServisId.Margin = new System.Windows.Forms.Padding(6);
            this.cboServisId.Name = "cboServisId";
            this.cboServisId.Size = new System.Drawing.Size(184, 33);
            this.cboServisId.TabIndex = 13;
            // 
            // dtUpdateDate
            // 
            this.dtUpdateDate.Location = new System.Drawing.Point(212, 127);
            this.dtUpdateDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtUpdateDate.Name = "dtUpdateDate";
            this.dtUpdateDate.Size = new System.Drawing.Size(396, 31);
            this.dtUpdateDate.TabIndex = 10;
            // 
            // txtUpdateOpis
            // 
            this.txtUpdateOpis.Location = new System.Drawing.Point(212, 202);
            this.txtUpdateOpis.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateOpis.MaxLength = 400;
            this.txtUpdateOpis.Multiline = true;
            this.txtUpdateOpis.Name = "txtUpdateOpis";
            this.txtUpdateOpis.Size = new System.Drawing.Size(486, 171);
            this.txtUpdateOpis.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Opis usluga:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Datum servisa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "servisID:";
            // 
            // cboServisDelete
            // 
            this.cboServisDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServisDelete.FormattingEnabled = true;
            this.cboServisDelete.Location = new System.Drawing.Point(1277, 36);
            this.cboServisDelete.Margin = new System.Windows.Forms.Padding(6);
            this.cboServisDelete.Name = "cboServisDelete";
            this.cboServisDelete.Size = new System.Drawing.Size(238, 33);
            this.cboServisDelete.TabIndex = 38;
            // 
            // btnDeleteServis
            // 
            this.btnDeleteServis.Location = new System.Drawing.Point(984, 93);
            this.btnDeleteServis.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteServis.Name = "btnDeleteServis";
            this.btnDeleteServis.Size = new System.Drawing.Size(826, 58);
            this.btnDeleteServis.TabIndex = 37;
            this.btnDeleteServis.Text = "Izbrisi servis";
            this.btnDeleteServis.UseVisualStyleBackColor = true;
            this.btnDeleteServis.Click += new System.EventHandler(this.btnDeleteServis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1173, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "ServisID:";
            // 
            // gridServisList
            // 
            this.gridServisList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServisList.Location = new System.Drawing.Point(984, 188);
            this.gridServisList.Margin = new System.Windows.Forms.Padding(6);
            this.gridServisList.Name = "gridServisList";
            this.gridServisList.RowHeadersWidth = 82;
            this.gridServisList.Size = new System.Drawing.Size(826, 373);
            this.gridServisList.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1926, 1432);
            this.Controls.Add(this.gbServisUpdate);
            this.Controls.Add(this.cboServisDelete);
            this.Controls.Add(this.btnDeleteServis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridServisList);
            this.Controls.Add(this.gbKlijentUpdate);
            this.Controls.Add(this.cboKlijentDelete);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gridKlijentList);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbKlijentUpdate.ResumeLayout(false);
            this.gbKlijentUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKlijentList)).EndInit();
            this.gbServisUpdate.ResumeLayout(false);
            this.gbServisUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServisList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKlijentUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateNazivKlijenta;
        private System.Windows.Forms.ComboBox cboKlijentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.TextBox txtUpdateKomentar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateKontakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateRegBroj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboKlijentDelete;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView gridKlijentList;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox gbServisUpdate;
        private System.Windows.Forms.ComboBox cboServisId;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.DateTimePicker dtUpdateDate;
        private System.Windows.Forms.TextBox txtUpdateOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboServisDelete;
        private System.Windows.Forms.Button btnDeleteServis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridServisList;
    }
}

