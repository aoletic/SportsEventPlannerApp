namespace SportsEventPlanner
{
    partial class SportoviKontrola
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSportovi = new System.Windows.Forms.DataGridView();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnDodajSport = new System.Windows.Forms.Button();
            this.btnAzurirajSport = new System.Windows.Forms.Button();
            this.btnObrisiSport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportovi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 103);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(501, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "SPORTOVI";
            // 
            // dgvSportovi
            // 
            this.dgvSportovi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSportovi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSportovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSportovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSportovi.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSportovi.EnableHeadersVisualStyles = false;
            this.dgvSportovi.Location = new System.Drawing.Point(141, 141);
            this.dgvSportovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSportovi.Name = "dgvSportovi";
            this.dgvSportovi.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvSportovi.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSportovi.RowTemplate.Height = 24;
            this.dgvSportovi.Size = new System.Drawing.Size(921, 487);
            this.dgvSportovi.TabIndex = 9;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(141, 114);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(309, 22);
            this.txtBoxSearch.TabIndex = 10;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnDodajSport
            // 
            this.btnDodajSport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.btnDodajSport.ForeColor = System.Drawing.Color.White;
            this.btnDodajSport.Location = new System.Drawing.Point(15, 195);
            this.btnDodajSport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajSport.Name = "btnDodajSport";
            this.btnDodajSport.Size = new System.Drawing.Size(75, 42);
            this.btnDodajSport.TabIndex = 12;
            this.btnDodajSport.Text = "Dodaj sport";
            this.btnDodajSport.UseVisualStyleBackColor = false;
            this.btnDodajSport.Click += new System.EventHandler(this.btnDodajSport_Click);
            // 
            // btnAzurirajSport
            // 
            this.btnAzurirajSport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.btnAzurirajSport.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajSport.Location = new System.Drawing.Point(15, 245);
            this.btnAzurirajSport.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzurirajSport.Name = "btnAzurirajSport";
            this.btnAzurirajSport.Size = new System.Drawing.Size(75, 42);
            this.btnAzurirajSport.TabIndex = 13;
            this.btnAzurirajSport.Text = "Ažuriraj sport";
            this.btnAzurirajSport.UseVisualStyleBackColor = false;
            this.btnAzurirajSport.Click += new System.EventHandler(this.btnAzurirajSport_Click);
            // 
            // btnObrisiSport
            // 
            this.btnObrisiSport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.btnObrisiSport.ForeColor = System.Drawing.Color.White;
            this.btnObrisiSport.Location = new System.Drawing.Point(15, 295);
            this.btnObrisiSport.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiSport.Name = "btnObrisiSport";
            this.btnObrisiSport.Size = new System.Drawing.Size(75, 42);
            this.btnObrisiSport.TabIndex = 14;
            this.btnObrisiSport.Text = "Obriši sport";
            this.btnObrisiSport.UseVisualStyleBackColor = false;
            this.btnObrisiSport.Click += new System.EventHandler(this.btnObrisiSport_Click);
            // 
            // SportoviKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiSport);
            this.Controls.Add(this.btnAzurirajSport);
            this.Controls.Add(this.btnDodajSport);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.dgvSportovi);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SportoviKontrola";
            this.Size = new System.Drawing.Size(1201, 689);
            this.Load += new System.EventHandler(this.SportoviKontrola_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSportovi;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnDodajSport;
        private System.Windows.Forms.Button btnAzurirajSport;
        private System.Windows.Forms.Button btnObrisiSport;
    }
}
