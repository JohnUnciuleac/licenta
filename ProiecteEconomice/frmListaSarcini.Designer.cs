namespace ProiecteEconomice
{
    partial class frmListaSarcini
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblIdAngajat = new System.Windows.Forms.Label();
            this.grdSarcini = new System.Windows.Forms.DataGridView();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSC = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBonusPrecedent = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalBonus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSarcini)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Angajat                                                                    ";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNume.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNume.Location = new System.Drawing.Point(164, 9);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(0, 36);
            this.lblNume.TabIndex = 3;
            // 
            // lblIdAngajat
            // 
            this.lblIdAngajat.AutoSize = true;
            this.lblIdAngajat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblIdAngajat.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAngajat.ForeColor = System.Drawing.Color.Firebrick;
            this.lblIdAngajat.Location = new System.Drawing.Point(715, 9);
            this.lblIdAngajat.Name = "lblIdAngajat";
            this.lblIdAngajat.Size = new System.Drawing.Size(0, 36);
            this.lblIdAngajat.TabIndex = 4;
            // 
            // grdSarcini
            // 
            this.grdSarcini.AllowUserToAddRows = false;
            this.grdSarcini.AllowUserToDeleteRows = false;
            this.grdSarcini.AllowUserToResizeColumns = false;
            this.grdSarcini.AllowUserToResizeRows = false;
            this.grdSarcini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdSarcini.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSarcini.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdSarcini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSarcini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSarcini.Location = new System.Drawing.Point(12, 68);
            this.grdSarcini.MultiSelect = false;
            this.grdSarcini.Name = "grdSarcini";
            this.grdSarcini.ReadOnly = true;
            this.grdSarcini.RowTemplate.Height = 24;
            this.grdSarcini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSarcini.Size = new System.Drawing.Size(590, 112);
            this.grdSarcini.TabIndex = 18;
            this.grdSarcini.TabStop = false;
            this.grdSarcini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSarcini_CellContentClick);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.Location = new System.Drawing.Point(608, 68);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(177, 42);
            this.btnAnuleaza.TabIndex = 19;
            this.btnAnuleaza.Text = "Anulează Sarcina";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(605, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 42);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Închide";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "sum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Bonus total posibil pentru sarcinile actuale:          ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sarcini Completate      ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sarcini Necompletate  ";
            // 
            // lblSC
            // 
            this.lblSC.AutoSize = true;
            this.lblSC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSC.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSC.Location = new System.Drawing.Point(212, 219);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(200, 22);
            this.lblSC.TabIndex = 32;
            this.lblSC.Text = "Sarcini Completate      ";
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSN.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSN.Location = new System.Drawing.Point(212, 241);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(220, 22);
            this.lblSN.TabIndex = 33;
            this.lblSN.Text = "Sarcini Necompletate      ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(419, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Bonus Acumulat Precedent                                    ";
            // 
            // lblBonusPrecedent
            // 
            this.lblBonusPrecedent.AutoSize = true;
            this.lblBonusPrecedent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblBonusPrecedent.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonusPrecedent.Location = new System.Drawing.Point(428, 263);
            this.lblBonusPrecedent.Name = "lblBonusPrecedent";
            this.lblBonusPrecedent.Size = new System.Drawing.Size(50, 22);
            this.lblBonusPrecedent.TabIndex = 35;
            this.lblBonusPrecedent.Text = "sum";
            // 
            // txtDescriere
            // 
            this.txtDescriere.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescriere.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriere.Location = new System.Drawing.Point(608, 130);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(177, 164);
            this.txtDescriere.TabIndex = 36;
            this.txtDescriere.Text = "Selectează o sarcină pentru descriere";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(8, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(422, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "Total Bonus                                                            ";
            // 
            // lblTotalBonus
            // 
            this.lblTotalBonus.AutoSize = true;
            this.lblTotalBonus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTotalBonus.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBonus.Location = new System.Drawing.Point(428, 318);
            this.lblTotalBonus.Name = "lblTotalBonus";
            this.lblTotalBonus.Size = new System.Drawing.Size(50, 22);
            this.lblTotalBonus.TabIndex = 38;
            this.lblTotalBonus.Text = "sum";
            // 
            // frmListaSarcini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.lblTotalBonus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.lblBonusPrecedent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.lblSC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.grdSarcini);
            this.Controls.Add(this.lblIdAngajat);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaSarcini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaSarcini";
            this.Load += new System.EventHandler(this.frmListaSarcini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSarcini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblIdAngajat;
        private System.Windows.Forms.DataGridView grdSarcini;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBonusPrecedent;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalBonus;
    }
}