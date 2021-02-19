namespace SportsEventPlanner
{
    partial class PrijavaNatjecanjeKontrola
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrijavaNatjecanje = new System.Windows.Forms.Label();
            this.lblOdabirDogadaja = new System.Windows.Forms.Label();
            this.cmbOdabirDogadaja = new System.Windows.Forms.ComboBox();
            this.btnDodajNatjecatelja = new System.Windows.Forms.Button();
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.lblPrijavaNatjecanje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 102);
            this.panel1.TabIndex = 4;
            // 
            // lblPrijavaNatjecanje
            // 
            this.lblPrijavaNatjecanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrijavaNatjecanje.AutoSize = true;
            this.lblPrijavaNatjecanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrijavaNatjecanje.ForeColor = System.Drawing.Color.White;
            this.lblPrijavaNatjecanje.Location = new System.Drawing.Point(491, 31);
            this.lblPrijavaNatjecanje.Name = "lblPrijavaNatjecanje";
            this.lblPrijavaNatjecanje.Size = new System.Drawing.Size(376, 36);
            this.lblPrijavaNatjecanje.TabIndex = 2;
            this.lblPrijavaNatjecanje.Text = "PRIJAVA U NATJECANJE";
            // 
            // lblOdabirDogadaja
            // 
            this.lblOdabirDogadaja.AutoSize = true;
            this.lblOdabirDogadaja.Location = new System.Drawing.Point(67, 379);
            this.lblOdabirDogadaja.Name = "lblOdabirDogadaja";
            this.lblOdabirDogadaja.Size = new System.Drawing.Size(114, 17);
            this.lblOdabirDogadaja.TabIndex = 7;
            this.lblOdabirDogadaja.Text = "Odaberi događaj";
            // 
            // cmbOdabirDogadaja
            // 
            this.cmbOdabirDogadaja.FormattingEnabled = true;
            this.cmbOdabirDogadaja.Location = new System.Drawing.Point(187, 375);
            this.cmbOdabirDogadaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOdabirDogadaja.Name = "cmbOdabirDogadaja";
            this.cmbOdabirDogadaja.Size = new System.Drawing.Size(121, 24);
            this.cmbOdabirDogadaja.TabIndex = 8;
            // 
            // btnDodajNatjecatelja
            // 
            this.btnDodajNatjecatelja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.btnDodajNatjecatelja.ForeColor = System.Drawing.Color.White;
            this.btnDodajNatjecatelja.Location = new System.Drawing.Point(728, 366);
            this.btnDodajNatjecatelja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajNatjecatelja.Name = "btnDodajNatjecatelja";
            this.btnDodajNatjecatelja.Size = new System.Drawing.Size(192, 42);
            this.btnDodajNatjecatelja.TabIndex = 24;
            this.btnDodajNatjecatelja.Text = "Dodaj natjecatelja";
            this.btnDodajNatjecatelja.UseVisualStyleBackColor = false;
            this.btnDodajNatjecatelja.Click += new System.EventHandler(this.btnDodajNatjecatelja_Click);
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.btnDodajTim.ForeColor = System.Drawing.Color.White;
            this.btnDodajTim.Location = new System.Drawing.Point(420, 366);
            this.btnDodajTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(192, 42);
            this.btnDodajTim.TabIndex = 23;
            this.btnDodajTim.Text = "Dodaj tim";
            this.btnDodajTim.UseVisualStyleBackColor = false;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // PrijavaNatjecanjeKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajNatjecatelja);
            this.Controls.Add(this.btnDodajTim);
            this.Controls.Add(this.cmbOdabirDogadaja);
            this.Controls.Add(this.lblOdabirDogadaja);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrijavaNatjecanjeKontrola";
            this.Size = new System.Drawing.Size(1201, 689);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrijavaNatjecanje;
        private System.Windows.Forms.Label lblOdabirDogadaja;
        private System.Windows.Forms.ComboBox cmbOdabirDogadaja;
        private System.Windows.Forms.Button btnDodajNatjecatelja;
        private System.Windows.Forms.Button btnDodajTim;
    }
}
