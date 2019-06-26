namespace ProiecteEconomice
{
    partial class frmRaportAngajat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaportAngajat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.cboAngajati = new System.Windows.Forms.ComboBox();
            this.lblAre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDom = new System.Windows.Forms.TextBox();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.txtBA = new System.Windows.Forms.TextBox();
            this.txtBN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitlu);
            this.panel1.Location = new System.Drawing.Point(-11, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 82);
            this.panel1.TabIndex = 2;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitlu.Location = new System.Drawing.Point(136, 28);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(575, 28);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Raport detaliat pentru performanța fiecărui angajat";
            // 
            // cboAngajati
            // 
            this.cboAngajati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboAngajati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAngajati.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboAngajati.Font = new System.Drawing.Font("Arial", 11F);
            this.cboAngajati.FormattingEnabled = true;
            this.cboAngajati.IntegralHeight = false;
            this.cboAngajati.Location = new System.Drawing.Point(16, 134);
            this.cboAngajati.MaxDropDownItems = 5;
            this.cboAngajati.Name = "cboAngajati";
            this.cboAngajati.Size = new System.Drawing.Size(192, 29);
            this.cboAngajati.TabIndex = 3;
            this.cboAngajati.TabStop = false;
            this.cboAngajati.SelectedIndexChanged += new System.EventHandler(this.cboAngajati_SelectedIndexChanged);
            // 
            // lblAre
            // 
            this.lblAre.AutoSize = true;
            this.lblAre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblAre.Location = new System.Drawing.Point(12, 99);
            this.lblAre.Name = "lblAre";
            this.lblAre.Size = new System.Drawing.Size(169, 19);
            this.lblAre.TabIndex = 21;
            this.lblAre.Text = "Selectați un angajat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Domeniu Experiență:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(12, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Salariu de bază:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(11, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bonus acumulat:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(11, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Bonus nerevendicat:";
            // 
            // txtDom
            // 
            this.txtDom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDom.Location = new System.Drawing.Point(174, 280);
            this.txtDom.Name = "txtDom";
            this.txtDom.ReadOnly = true;
            this.txtDom.Size = new System.Drawing.Size(146, 27);
            this.txtDom.TabIndex = 26;
            this.txtDom.TabStop = false;
            // 
            // txtSalariu
            // 
            this.txtSalariu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalariu.Location = new System.Drawing.Point(174, 325);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.ReadOnly = true;
            this.txtSalariu.Size = new System.Drawing.Size(146, 27);
            this.txtSalariu.TabIndex = 27;
            this.txtSalariu.TabStop = false;
            // 
            // txtBA
            // 
            this.txtBA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBA.Location = new System.Drawing.Point(174, 370);
            this.txtBA.Name = "txtBA";
            this.txtBA.ReadOnly = true;
            this.txtBA.Size = new System.Drawing.Size(146, 27);
            this.txtBA.TabIndex = 28;
            this.txtBA.TabStop = false;
            // 
            // txtBN
            // 
            this.txtBN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBN.Location = new System.Drawing.Point(174, 413);
            this.txtBN.Name = "txtBN";
            this.txtBN.ReadOnly = true;
            this.txtBN.Size = new System.Drawing.Size(146, 27);
            this.txtBN.TabIndex = 29;
            this.txtBN.TabStop = false;
            // 
            // frmRaportAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 474);
            this.Controls.Add(this.txtBN);
            this.Controls.Add(this.txtBA);
            this.Controls.Add(this.txtSalariu);
            this.Controls.Add(this.txtDom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAre);
            this.Controls.Add(this.cboAngajati);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRaportAngajat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport Angajat";
            this.Load += new System.EventHandler(this.frmRaportAngajat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.ComboBox cboAngajati;
        private System.Windows.Forms.Label lblAre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDom;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.TextBox txtBA;
        private System.Windows.Forms.TextBox txtBN;
    }
}