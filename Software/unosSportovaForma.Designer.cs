namespace SportsEventPlanner
{
    partial class unosSportovaForma
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
            this.lblNazivSporta = new System.Windows.Forms.Label();
            this.lblBrojClanova = new System.Windows.Forms.Label();
            this.txtBoxNazivSporta = new System.Windows.Forms.TextBox();
            this.txtBoxBroj = new System.Windows.Forms.TextBox();
            this.btnSpremiSport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNazivSporta
            // 
            this.lblNazivSporta.AutoSize = true;
            this.lblNazivSporta.Location = new System.Drawing.Point(67, 73);
            this.lblNazivSporta.Name = "lblNazivSporta";
            this.lblNazivSporta.Size = new System.Drawing.Size(87, 17);
            this.lblNazivSporta.TabIndex = 0;
            this.lblNazivSporta.Text = "Naziv sporta";
            // 
            // lblBrojClanova
            // 
            this.lblBrojClanova.AutoSize = true;
            this.lblBrojClanova.Location = new System.Drawing.Point(38, 138);
            this.lblBrojClanova.Name = "lblBrojClanova";
            this.lblBrojClanova.Size = new System.Drawing.Size(116, 17);
            this.lblBrojClanova.TabIndex = 1;
            this.lblBrojClanova.Text = "Broj clanova tima";
            // 
            // txtBoxNazivSporta
            // 
            this.txtBoxNazivSporta.Location = new System.Drawing.Point(169, 73);
            this.txtBoxNazivSporta.Name = "txtBoxNazivSporta";
            this.txtBoxNazivSporta.Size = new System.Drawing.Size(148, 22);
            this.txtBoxNazivSporta.TabIndex = 2;
            // 
            // txtBoxBroj
            // 
            this.txtBoxBroj.Location = new System.Drawing.Point(169, 138);
            this.txtBoxBroj.Name = "txtBoxBroj";
            this.txtBoxBroj.Size = new System.Drawing.Size(148, 22);
            this.txtBoxBroj.TabIndex = 3;
            // 
            // btnSpremiSport
            // 
            this.btnSpremiSport.Location = new System.Drawing.Point(124, 257);
            this.btnSpremiSport.Name = "btnSpremiSport";
            this.btnSpremiSport.Size = new System.Drawing.Size(101, 35);
            this.btnSpremiSport.TabIndex = 4;
            this.btnSpremiSport.Text = "Spremi";
            this.btnSpremiSport.UseVisualStyleBackColor = true;
            this.btnSpremiSport.Click += new System.EventHandler(this.btnSpremiSport_Click);
            // 
            // unosSportovaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 356);
            this.Controls.Add(this.btnSpremiSport);
            this.Controls.Add(this.txtBoxBroj);
            this.Controls.Add(this.txtBoxNazivSporta);
            this.Controls.Add(this.lblBrojClanova);
            this.Controls.Add(this.lblNazivSporta);
            this.Name = "unosSportovaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "unosSportovaForma";
            this.Load += new System.EventHandler(this.unosSportovaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivSporta;
        private System.Windows.Forms.Label lblBrojClanova;
        private System.Windows.Forms.TextBox txtBoxNazivSporta;
        private System.Windows.Forms.TextBox txtBoxBroj;
        private System.Windows.Forms.Button btnSpremiSport;
    }
}