namespace SportsEventPlanner
{
    partial class unosRezultataForma
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
            this.lblBrojPoenaTim1 = new System.Windows.Forms.Label();
            this.lblBrojPoenaTim2 = new System.Windows.Forms.Label();
            this.txtBoxBrojPoenaTim1 = new System.Windows.Forms.TextBox();
            this.txtBoxBrojPoenaTim2 = new System.Windows.Forms.TextBox();
            this.btnSpremiRezultat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrojPoenaTim1
            // 
            this.lblBrojPoenaTim1.AutoSize = true;
            this.lblBrojPoenaTim1.Location = new System.Drawing.Point(29, 69);
            this.lblBrojPoenaTim1.Name = "lblBrojPoenaTim1";
            this.lblBrojPoenaTim1.Size = new System.Drawing.Size(112, 17);
            this.lblBrojPoenaTim1.TabIndex = 0;
            this.lblBrojPoenaTim1.Text = "Broj poena Tim1";
            // 
            // lblBrojPoenaTim2
            // 
            this.lblBrojPoenaTim2.AutoSize = true;
            this.lblBrojPoenaTim2.Location = new System.Drawing.Point(29, 137);
            this.lblBrojPoenaTim2.Name = "lblBrojPoenaTim2";
            this.lblBrojPoenaTim2.Size = new System.Drawing.Size(112, 17);
            this.lblBrojPoenaTim2.TabIndex = 1;
            this.lblBrojPoenaTim2.Text = "Broj poena Tim2";
            // 
            // txtBoxBrojPoenaTim1
            // 
            this.txtBoxBrojPoenaTim1.Location = new System.Drawing.Point(214, 69);
            this.txtBoxBrojPoenaTim1.Name = "txtBoxBrojPoenaTim1";
            this.txtBoxBrojPoenaTim1.Size = new System.Drawing.Size(100, 22);
            this.txtBoxBrojPoenaTim1.TabIndex = 2;
            this.txtBoxBrojPoenaTim1.TextChanged += new System.EventHandler(this.txtBoxBrojPoenaTim1_TextChanged);
            // 
            // txtBoxBrojPoenaTim2
            // 
            this.txtBoxBrojPoenaTim2.Location = new System.Drawing.Point(214, 137);
            this.txtBoxBrojPoenaTim2.Name = "txtBoxBrojPoenaTim2";
            this.txtBoxBrojPoenaTim2.Size = new System.Drawing.Size(100, 22);
            this.txtBoxBrojPoenaTim2.TabIndex = 3;
            this.txtBoxBrojPoenaTim2.TextChanged += new System.EventHandler(this.txtBoxBrojPoenaTim2_TextChanged);
            // 
            // btnSpremiRezultat
            // 
            this.btnSpremiRezultat.Location = new System.Drawing.Point(138, 196);
            this.btnSpremiRezultat.Name = "btnSpremiRezultat";
            this.btnSpremiRezultat.Size = new System.Drawing.Size(88, 37);
            this.btnSpremiRezultat.TabIndex = 4;
            this.btnSpremiRezultat.Text = "Spremi";
            this.btnSpremiRezultat.UseVisualStyleBackColor = true;
            this.btnSpremiRezultat.Click += new System.EventHandler(this.btnSpremiRezultat_Click);
            // 
            // unosRezultataForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 245);
            this.Controls.Add(this.btnSpremiRezultat);
            this.Controls.Add(this.txtBoxBrojPoenaTim2);
            this.Controls.Add(this.txtBoxBrojPoenaTim1);
            this.Controls.Add(this.lblBrojPoenaTim2);
            this.Controls.Add(this.lblBrojPoenaTim1);
            this.Name = "unosRezultataForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "unosRezultataForma";
            this.Load += new System.EventHandler(this.unosRezultataForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojPoenaTim1;
        private System.Windows.Forms.Label lblBrojPoenaTim2;
        private System.Windows.Forms.TextBox txtBoxBrojPoenaTim1;
        private System.Windows.Forms.TextBox txtBoxBrojPoenaTim2;
        private System.Windows.Forms.Button btnSpremiRezultat;
    }
}