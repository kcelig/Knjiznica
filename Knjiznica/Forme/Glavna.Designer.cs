namespace Knjiznica.Forme
{
    partial class Glavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ucenici = new System.Windows.Forms.ToolStripButton();
            this.knjige = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPosudbe = new System.Windows.Forms.ListBox();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ucenici,
            this.knjige});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(537, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ucenici
            // 
            this.ucenici.Image = ((System.Drawing.Image)(resources.GetObject("ucenici.Image")));
            this.ucenici.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ucenici.Name = "ucenici";
            this.ucenici.Size = new System.Drawing.Size(66, 22);
            this.ucenici.Text = "Učenici";
            this.ucenici.Click += new System.EventHandler(this.ucenici_Click);
            // 
            // knjige
            // 
            this.knjige.Image = ((System.Drawing.Image)(resources.GetObject("knjige.Image")));
            this.knjige.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.knjige.Name = "knjige";
            this.knjige.Size = new System.Drawing.Size(60, 22);
            this.knjige.Text = "Knjige";
            this.knjige.Click += new System.EventHandler(this.knjige_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posuđene knjige";
            // 
            // lbPosudbe
            // 
            this.lbPosudbe.FormattingEnabled = true;
            this.lbPosudbe.Location = new System.Drawing.Point(12, 45);
            this.lbPosudbe.Name = "lbPosudbe";
            this.lbPosudbe.Size = new System.Drawing.Size(515, 303);
            this.lbPosudbe.TabIndex = 2;
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(16, 374);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(75, 23);
            this.btnPosudi.TabIndex = 3;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(97, 374);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeni.TabIndex = 3;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(178, 374);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(75, 23);
            this.btnVrati.TabIndex = 3;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 409);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.lbPosudbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ucenici;
        private System.Windows.Forms.ToolStripButton knjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPosudbe;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnVrati;
    }
}