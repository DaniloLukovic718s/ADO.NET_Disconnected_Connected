
namespace Prvi_Deo_DrugiDomaci_Domaci_MTPP
{
    partial class FilterGrad
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
            this.btnRefersh = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCityList = new System.Windows.Forms.TextBox();
            this.gridCityList = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCityList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefersh
            // 
            this.btnRefersh.Location = new System.Drawing.Point(42, 924);
            this.btnRefersh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.Size = new System.Drawing.Size(1043, 72);
            this.btnRefersh.TabIndex = 14;
            this.btnRefersh.Text = "REFRESH";
            this.btnRefersh.UseVisualStyleBackColor = true;
            this.btnRefersh.Click += new System.EventHandler(this.btnRefersh_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(42, 191);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(6);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(1043, 50);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "CITY:";
            // 
            // txtCityList
            // 
            this.txtCityList.Location = new System.Drawing.Point(422, 94);
            this.txtCityList.Margin = new System.Windows.Forms.Padding(6);
            this.txtCityList.Multiline = true;
            this.txtCityList.Name = "txtCityList";
            this.txtCityList.Size = new System.Drawing.Size(274, 48);
            this.txtCityList.TabIndex = 11;
            // 
            // gridCityList
            // 
            this.gridCityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCityList.Location = new System.Drawing.Point(42, 279);
            this.gridCityList.Margin = new System.Windows.Forms.Padding(6);
            this.gridCityList.Name = "gridCityList";
            this.gridCityList.RowHeadersWidth = 82;
            this.gridCityList.Size = new System.Drawing.Size(1043, 633);
            this.gridCityList.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(42, 1005);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(1043, 72);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FilterGrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 1272);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefersh);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCityList);
            this.Controls.Add(this.gridCityList);
            this.Name = "FilterGrad";
            this.Text = "FilterGrad";
            this.Load += new System.EventHandler(this.FilterGrad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCityList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefersh;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCityList;
        private System.Windows.Forms.DataGridView gridCityList;
        private System.Windows.Forms.Button btnExit;
    }
}