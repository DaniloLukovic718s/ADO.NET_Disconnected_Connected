
namespace Drugi_Deo_DrugiDomaci_Domaci_MTPP
{
    partial class InsertForm
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
            this.gbServis = new System.Windows.Forms.GroupBox();
            this.cmbKlijentId = new System.Windows.Forms.ComboBox();
            this.btnInsertServis = new System.Windows.Forms.Button();
            this.dtServis = new System.Windows.Forms.DateTimePicker();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbKlijent = new System.Windows.Forms.GroupBox();
            this.btnInsertKlijenti = new System.Windows.Forms.Button();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegBroj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivKlijenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbServis.SuspendLayout();
            this.gbKlijent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServis
            // 
            this.gbServis.Controls.Add(this.cmbKlijentId);
            this.gbServis.Controls.Add(this.btnInsertServis);
            this.gbServis.Controls.Add(this.dtServis);
            this.gbServis.Controls.Add(this.txtOpis);
            this.gbServis.Controls.Add(this.label5);
            this.gbServis.Controls.Add(this.label7);
            this.gbServis.Controls.Add(this.label8);
            this.gbServis.Location = new System.Drawing.Point(895, 50);
            this.gbServis.Margin = new System.Windows.Forms.Padding(6);
            this.gbServis.Name = "gbServis";
            this.gbServis.Padding = new System.Windows.Forms.Padding(6);
            this.gbServis.Size = new System.Drawing.Size(782, 531);
            this.gbServis.TabIndex = 9;
            this.gbServis.TabStop = false;
            this.gbServis.Text = "Servis insert";
            // 
            // cmbKlijentId
            // 
            this.cmbKlijentId.FormattingEnabled = true;
            this.cmbKlijentId.Location = new System.Drawing.Point(212, 69);
            this.cmbKlijentId.Margin = new System.Windows.Forms.Padding(6);
            this.cmbKlijentId.Name = "cmbKlijentId";
            this.cmbKlijentId.Size = new System.Drawing.Size(206, 33);
            this.cmbKlijentId.TabIndex = 13;
            // 
            // btnInsertServis
            // 
            this.btnInsertServis.Location = new System.Drawing.Point(31, 419);
            this.btnInsertServis.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsertServis.Name = "btnInsertServis";
            this.btnInsertServis.Size = new System.Drawing.Size(695, 77);
            this.btnInsertServis.TabIndex = 11;
            this.btnInsertServis.Text = "INSERT";
            this.btnInsertServis.UseVisualStyleBackColor = true;
            this.btnInsertServis.Click += new System.EventHandler(this.btnInsertServis_Click);
            // 
            // dtServis
            // 
            this.dtServis.Location = new System.Drawing.Point(212, 127);
            this.dtServis.Margin = new System.Windows.Forms.Padding(6);
            this.dtServis.Name = "dtServis";
            this.dtServis.Size = new System.Drawing.Size(396, 31);
            this.dtServis.TabIndex = 10;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(212, 202);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(6);
            this.txtOpis.MaxLength = 400;
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(440, 139);
            this.txtOpis.TabIndex = 7;
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
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "KlijentID:";
            // 
            // gbKlijent
            // 
            this.gbKlijent.Controls.Add(this.btnInsertKlijenti);
            this.gbKlijent.Controls.Add(this.txtKomentar);
            this.gbKlijent.Controls.Add(this.label4);
            this.gbKlijent.Controls.Add(this.txtKontakt);
            this.gbKlijent.Controls.Add(this.label3);
            this.gbKlijent.Controls.Add(this.txtRegBroj);
            this.gbKlijent.Controls.Add(this.label2);
            this.gbKlijent.Controls.Add(this.txtNazivKlijenta);
            this.gbKlijent.Controls.Add(this.label1);
            this.gbKlijent.Location = new System.Drawing.Point(63, 36);
            this.gbKlijent.Margin = new System.Windows.Forms.Padding(6);
            this.gbKlijent.Name = "gbKlijent";
            this.gbKlijent.Padding = new System.Windows.Forms.Padding(6);
            this.gbKlijent.Size = new System.Drawing.Size(782, 545);
            this.gbKlijent.TabIndex = 8;
            this.gbKlijent.TabStop = false;
            this.gbKlijent.Text = "Klijent insert";
            // 
            // btnInsertKlijenti
            // 
            this.btnInsertKlijenti.Location = new System.Drawing.Point(31, 443);
            this.btnInsertKlijenti.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsertKlijenti.Name = "btnInsertKlijenti";
            this.btnInsertKlijenti.Size = new System.Drawing.Size(725, 77);
            this.btnInsertKlijenti.TabIndex = 8;
            this.btnInsertKlijenti.Text = "INSERT";
            this.btnInsertKlijenti.UseVisualStyleBackColor = true;
            this.btnInsertKlijenti.Click += new System.EventHandler(this.btnInsertKlijenti_Click);
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(212, 269);
            this.txtKomentar.Margin = new System.Windows.Forms.Padding(6);
            this.txtKomentar.MaxLength = 200;
            this.txtKomentar.Multiline = true;
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(440, 139);
            this.txtKomentar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dodatni komentar:";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(212, 200);
            this.txtKontakt.Margin = new System.Windows.Forms.Padding(6);
            this.txtKontakt.MaxLength = 40;
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(316, 31);
            this.txtKontakt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kontakt:";
            // 
            // txtRegBroj
            // 
            this.txtRegBroj.Location = new System.Drawing.Point(212, 133);
            this.txtRegBroj.Margin = new System.Windows.Forms.Padding(6);
            this.txtRegBroj.MaxLength = 20;
            this.txtRegBroj.Name = "txtRegBroj";
            this.txtRegBroj.Size = new System.Drawing.Size(316, 31);
            this.txtRegBroj.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registarski broj:";
            // 
            // txtNazivKlijenta
            // 
            this.txtNazivKlijenta.Location = new System.Drawing.Point(212, 71);
            this.txtNazivKlijenta.Margin = new System.Windows.Forms.Padding(6);
            this.txtNazivKlijenta.MaxLength = 40;
            this.txtNazivKlijenta.Name = "txtNazivKlijenta";
            this.txtNazivKlijenta.Size = new System.Drawing.Size(316, 31);
            this.txtNazivKlijenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv klijenta:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(63, 633);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(1614, 84);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1893, 791);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbServis);
            this.Controls.Add(this.gbKlijent);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.gbServis.ResumeLayout(false);
            this.gbServis.PerformLayout();
            this.gbKlijent.ResumeLayout(false);
            this.gbKlijent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServis;
        private System.Windows.Forms.ComboBox cmbKlijentId;
        private System.Windows.Forms.Button btnInsertServis;
        private System.Windows.Forms.DateTimePicker dtServis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbKlijent;
        private System.Windows.Forms.Button btnInsertKlijenti;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegBroj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivKlijenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}