namespace SportsEventPlanner
{
    partial class PregledTimovaNatjecateljaKontrola
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPregledTimNatj = new System.Windows.Forms.Label();
            this.cmbOdabirDogadaja = new System.Windows.Forms.ComboBox();
            this.lblOdabirDogadaja = new System.Windows.Forms.Label();
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.dgvNatjecatelji = new System.Windows.Forms.DataGridView();
            this.txtBoxTimoviTrazi = new System.Windows.Forms.TextBox();
            this.txtBoxNatjecateljTrazi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNatjecatelji)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.lblPregledTimNatj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 102);
            this.panel1.TabIndex = 3;
            // 
            // lblPregledTimNatj
            // 
            this.lblPregledTimNatj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPregledTimNatj.AutoSize = true;
            this.lblPregledTimNatj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPregledTimNatj.ForeColor = System.Drawing.Color.White;
            this.lblPregledTimNatj.Location = new System.Drawing.Point(321, 32);
            this.lblPregledTimNatj.Name = "lblPregledTimNatj";
            this.lblPregledTimNatj.Size = new System.Drawing.Size(501, 36);
            this.lblPregledTimNatj.TabIndex = 2;
            this.lblPregledTimNatj.Text = "PREGLED TIMOVA I NATJECANJA";
            // 
            // cmbOdabirDogadaja
            // 
            this.cmbOdabirDogadaja.FormattingEnabled = true;
            this.cmbOdabirDogadaja.Location = new System.Drawing.Point(190, 148);
            this.cmbOdabirDogadaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOdabirDogadaja.Name = "cmbOdabirDogadaja";
            this.cmbOdabirDogadaja.Size = new System.Drawing.Size(249, 24);
            this.cmbOdabirDogadaja.TabIndex = 20;
            this.cmbOdabirDogadaja.SelectedIndexChanged += new System.EventHandler(this.cmbOdabirDogadaja_SelectedIndexChanged);
            // 
            // lblOdabirDogadaja
            // 
            this.lblOdabirDogadaja.AutoSize = true;
            this.lblOdabirDogadaja.Location = new System.Drawing.Point(70, 151);
            this.lblOdabirDogadaja.Name = "lblOdabirDogadaja";
            this.lblOdabirDogadaja.Size = new System.Drawing.Size(114, 17);
            this.lblOdabirDogadaja.TabIndex = 19;
            this.lblOdabirDogadaja.Text = "Odaberi događaj";
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTimovi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimovi.EnableHeadersVisualStyles = false;
            this.dgvTimovi.Location = new System.Drawing.Point(63, 208);
            this.dgvTimovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvTimovi.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTimovi.RowTemplate.Height = 24;
            this.dgvTimovi.Size = new System.Drawing.Size(1085, 175);
            this.dgvTimovi.TabIndex = 21;
            this.dgvTimovi.DoubleClick += new System.EventHandler(this.dgvTimovi_DoubleClick);
            // 
            // dgvNatjecatelji
            // 
            this.dgvNatjecatelji.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNatjecatelji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNatjecatelji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNatjecatelji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNatjecatelji.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNatjecatelji.EnableHeadersVisualStyles = false;
            this.dgvNatjecatelji.Location = new System.Drawing.Point(64, 421);
            this.dgvNatjecatelji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNatjecatelji.Name = "dgvNatjecatelji";
            this.dgvNatjecatelji.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvNatjecatelji.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNatjecatelji.RowTemplate.Height = 24;
            this.dgvNatjecatelji.Size = new System.Drawing.Size(1084, 172);
            this.dgvNatjecatelji.TabIndex = 22;
            // 
            // txtBoxTimoviTrazi
            // 
            this.txtBoxTimoviTrazi.Location = new System.Drawing.Point(63, 181);
            this.txtBoxTimoviTrazi.Name = "txtBoxTimoviTrazi";
            this.txtBoxTimoviTrazi.Size = new System.Drawing.Size(225, 22);
            this.txtBoxTimoviTrazi.TabIndex = 23;
            this.txtBoxTimoviTrazi.TextChanged += new System.EventHandler(this.txtBoxTimoviTrazi_TextChanged);
            // 
            // txtBoxNatjecateljTrazi
            // 
            this.txtBoxNatjecateljTrazi.Location = new System.Drawing.Point(63, 394);
            this.txtBoxNatjecateljTrazi.Name = "txtBoxNatjecateljTrazi";
            this.txtBoxNatjecateljTrazi.Size = new System.Drawing.Size(225, 22);
            this.txtBoxNatjecateljTrazi.TabIndex = 24;
            this.txtBoxNatjecateljTrazi.TextChanged += new System.EventHandler(this.txtBoxNatjecateljTrazi_TextChanged);
            // 
            // PregledTimovaNatjecateljaKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxNatjecateljTrazi);
            this.Controls.Add(this.txtBoxTimoviTrazi);
            this.Controls.Add(this.dgvNatjecatelji);
            this.Controls.Add(this.dgvTimovi);
            this.Controls.Add(this.cmbOdabirDogadaja);
            this.Controls.Add(this.lblOdabirDogadaja);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PregledTimovaNatjecateljaKontrola";
            this.Size = new System.Drawing.Size(1201, 689);
            this.Load += new System.EventHandler(this.PregledTimovaNatjecateljaKontrola_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNatjecatelji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPregledTimNatj;
        private System.Windows.Forms.ComboBox cmbOdabirDogadaja;
        private System.Windows.Forms.Label lblOdabirDogadaja;
        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.DataGridView dgvNatjecatelji;
        private System.Windows.Forms.TextBox txtBoxTimoviTrazi;
        private System.Windows.Forms.TextBox txtBoxNatjecateljTrazi;
    }
}
