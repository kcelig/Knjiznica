namespace Knjiznica.Forme
{
    partial class KDetalji
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.nudGodinaIzdanja = new System.Windows.Forms.NumericUpDown();
            this.cbBrojPrimjeraka = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGodinaIzdanja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naslov";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Godina izdanja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Broj primjeraka";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(106, 29);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(106, 63);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(154, 20);
            this.txtAutor.TabIndex = 2;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(106, 89);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(243, 20);
            this.txtNaslov.TabIndex = 3;
            // 
            // nudGodinaIzdanja
            // 
            this.nudGodinaIzdanja.Location = new System.Drawing.Point(106, 118);
            this.nudGodinaIzdanja.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.nudGodinaIzdanja.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudGodinaIzdanja.Name = "nudGodinaIzdanja";
            this.nudGodinaIzdanja.Size = new System.Drawing.Size(120, 20);
            this.nudGodinaIzdanja.TabIndex = 4;
            this.nudGodinaIzdanja.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // cbBrojPrimjeraka
            // 
            this.cbBrojPrimjeraka.FormattingEnabled = true;
            this.cbBrojPrimjeraka.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbBrojPrimjeraka.Location = new System.Drawing.Point(106, 162);
            this.cbBrojPrimjeraka.Name = "cbBrojPrimjeraka";
            this.cbBrojPrimjeraka.Size = new System.Drawing.Size(121, 21);
            this.cbBrojPrimjeraka.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(314, 287);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // KDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 363);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbBrojPrimjeraka);
            this.Controls.Add(this.nudGodinaIzdanja);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KDetalji";
            this.Text = "frmKDetalji";
            this.Load += new System.EventHandler(this.frmKDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGodinaIzdanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.NumericUpDown nudGodinaIzdanja;
        private System.Windows.Forms.ComboBox cbBrojPrimjeraka;
        private System.Windows.Forms.Button btnOK;
    }
}