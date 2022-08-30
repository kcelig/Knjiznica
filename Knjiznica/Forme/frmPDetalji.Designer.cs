namespace Knjiznica.Forme
{
    partial class PDetalji
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
            this.lbUcenici = new System.Windows.Forms.ListBox();
            this.lbKnjige = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtpDatumPosudbe = new System.Windows.Forms.DateTimePicker();
            this.nudBrojDana = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojDana)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUcenici
            // 
            this.lbUcenici.FormattingEnabled = true;
            this.lbUcenici.Location = new System.Drawing.Point(12, 25);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.Size = new System.Drawing.Size(285, 199);
            this.lbUcenici.TabIndex = 0;
            // 
            // lbKnjige
            // 
            this.lbKnjige.FormattingEnabled = true;
            this.lbKnjige.Location = new System.Drawing.Point(317, 25);
            this.lbKnjige.Name = "lbKnjige";
            this.lbKnjige.Size = new System.Drawing.Size(310, 199);
            this.lbKnjige.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Učenici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Knjige";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(552, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtpDatumPosudbe
            // 
            this.dtpDatumPosudbe.Location = new System.Drawing.Point(15, 239);
            this.dtpDatumPosudbe.Name = "dtpDatumPosudbe";
            this.dtpDatumPosudbe.Size = new System.Drawing.Size(147, 20);
            this.dtpDatumPosudbe.TabIndex = 3;
            // 
            // nudBrojDana
            // 
            this.nudBrojDana.Location = new System.Drawing.Point(177, 239);
            this.nudBrojDana.Name = "nudBrojDana";
            this.nudBrojDana.Size = new System.Drawing.Size(120, 20);
            this.nudBrojDana.TabIndex = 4;
            // 
            // PDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 289);
            this.Controls.Add(this.nudBrojDana);
            this.Controls.Add(this.dtpDatumPosudbe);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKnjige);
            this.Controls.Add(this.lbUcenici);
            this.Name = "PDetalji";
            this.Text = "frmPDetalji";
            this.Load += new System.EventHandler(this.PDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojDana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUcenici;
        private System.Windows.Forms.ListBox lbKnjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtpDatumPosudbe;
        private System.Windows.Forms.NumericUpDown nudBrojDana;
    }
}