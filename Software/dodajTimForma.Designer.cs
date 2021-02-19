namespace SportsEventPlanner
{
    partial class dodajTimForma
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
            this.lblImeTima = new System.Windows.Forms.Label();
            this.txtBoxImeTima = new System.Windows.Forms.TextBox();
            this.txtBoxBrojIgraca = new System.Windows.Forms.TextBox();
            this.lblBrojIgraca = new System.Windows.Forms.Label();
            this.txtBoxKontaktBroj = new System.Windows.Forms.TextBox();
            this.lblKontaktBroj = new System.Windows.Forms.Label();
            this.btnSpremiTim = new System.Windows.Forms.Button();
            this.btnDodajNatjecatelja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImeTima
            // 
            this.lblImeTima.AutoSize = true;
            this.lblImeTima.Location = new System.Drawing.Point(32, 56);
            this.lblImeTima.Name = "lblImeTima";
            this.lblImeTima.Size = new System.Drawing.Size(60, 17);
            this.lblImeTima.TabIndex = 0;
            this.lblImeTima.Text = "Ime tima";
            // 
            // txtBoxImeTima
            // 
            this.txtBoxImeTima.Location = new System.Drawing.Point(158, 53);
            this.txtBoxImeTima.Name = "txtBoxImeTima";
            this.txtBoxImeTima.Size = new System.Drawing.Size(100, 22);
            this.txtBoxImeTima.TabIndex = 1;
            // 
            // txtBoxBrojIgraca
            // 
            this.txtBoxBrojIgraca.Location = new System.Drawing.Point(158, 121);
            this.txtBoxBrojIgraca.Name = "txtBoxBrojIgraca";
            this.txtBoxBrojIgraca.Size = new System.Drawing.Size(100, 22);
            this.txtBoxBrojIgraca.TabIndex = 3;
            // 
            // lblBrojIgraca
            // 
            this.lblBrojIgraca.AutoSize = true;
            this.lblBrojIgraca.Location = new System.Drawing.Point(32, 124);
            this.lblBrojIgraca.Name = "lblBrojIgraca";
            this.lblBrojIgraca.Size = new System.Drawing.Size(76, 17);
            this.lblBrojIgraca.TabIndex = 2;
            this.lblBrojIgraca.Text = "Broj igrača";
            // 
            // txtBoxKontaktBroj
            // 
            this.txtBoxKontaktBroj.Location = new System.Drawing.Point(158, 187);
            this.txtBoxKontaktBroj.Name = "txtBoxKontaktBroj";
            this.txtBoxKontaktBroj.Size = new System.Drawing.Size(100, 22);
            this.txtBoxKontaktBroj.TabIndex = 5;
            // 
            // lblKontaktBroj
            // 
            this.lblKontaktBroj.AutoSize = true;
            this.lblKontaktBroj.Location = new System.Drawing.Point(32, 190);
            this.lblKontaktBroj.Name = "lblKontaktBroj";
            this.lblKontaktBroj.Size = new System.Drawing.Size(84, 17);
            this.lblKontaktBroj.TabIndex = 4;
            this.lblKontaktBroj.Text = "Kontakt broj";
            // 
            // btnSpremiTim
            // 
            this.btnSpremiTim.Location = new System.Drawing.Point(45, 258);
            this.btnSpremiTim.Name = "btnSpremiTim";
            this.btnSpremiTim.Size = new System.Drawing.Size(85, 29);
            this.btnSpremiTim.TabIndex = 6;
            this.btnSpremiTim.Text = "Spremi";
            this.btnSpremiTim.UseVisualStyleBackColor = true;
            // 
            // btnDodajNatjecatelja
            // 
            this.btnDodajNatjecatelja.Location = new System.Drawing.Point(183, 258);
            this.btnDodajNatjecatelja.Name = "btnDodajNatjecatelja";
            this.btnDodajNatjecatelja.Size = new System.Drawing.Size(106, 59);
            this.btnDodajNatjecatelja.TabIndex = 7;
            this.btnDodajNatjecatelja.Text = "Dodaj natjecatelja";
            this.btnDodajNatjecatelja.UseVisualStyleBackColor = true;
            // 
            // dodajTimForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 329);
            this.Controls.Add(this.btnDodajNatjecatelja);
            this.Controls.Add(this.btnSpremiTim);
            this.Controls.Add(this.txtBoxKontaktBroj);
            this.Controls.Add(this.lblKontaktBroj);
            this.Controls.Add(this.txtBoxBrojIgraca);
            this.Controls.Add(this.lblBrojIgraca);
            this.Controls.Add(this.txtBoxImeTima);
            this.Controls.Add(this.lblImeTima);
            this.Name = "dodajTimForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dodajTimForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImeTima;
        private System.Windows.Forms.TextBox txtBoxImeTima;
        private System.Windows.Forms.TextBox txtBoxBrojIgraca;
        private System.Windows.Forms.Label lblBrojIgraca;
        private System.Windows.Forms.TextBox txtBoxKontaktBroj;
        private System.Windows.Forms.Label lblKontaktBroj;
        private System.Windows.Forms.Button btnSpremiTim;
        private System.Windows.Forms.Button btnDodajNatjecatelja;
    }
}