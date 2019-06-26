namespace ProiecteEconomice
{
    partial class frmDistributieSarcini
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdAngajati = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInvalid = new System.Windows.Forms.Button();
            this.btnValid = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.lblAre = new System.Windows.Forms.Label();
            this.grdSarcini = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grdSC = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAchita = new System.Windows.Forms.Button();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdSN = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAngajati)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSarcini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSC)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSN)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAngajati
            // 
            this.grdAngajati.AllowUserToAddRows = false;
            this.grdAngajati.AllowUserToDeleteRows = false;
            this.grdAngajati.AllowUserToResizeColumns = false;
            this.grdAngajati.AllowUserToResizeRows = false;
            this.grdAngajati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdAngajati.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAngajati.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAngajati.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdAngajati.Location = new System.Drawing.Point(12, 51);
            this.grdAngajati.MultiSelect = false;
            this.grdAngajati.Name = "grdAngajati";
            this.grdAngajati.ReadOnly = true;
            this.grdAngajati.RowTemplate.Height = 24;
            this.grdAngajati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAngajati.Size = new System.Drawing.Size(514, 150);
            this.grdAngajati.TabIndex = 0;
            this.grdAngajati.TabStop = false;
            this.grdAngajati.SelectionChanged += new System.EventHandler(this.grdAngajati_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnInvalid);
            this.panel1.Controls.Add(this.btnValid);
            this.panel1.Controls.Add(this.btnAnuleaza);
            this.panel1.Controls.Add(this.lblAre);
            this.panel1.Controls.Add(this.grdSarcini);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grdAngajati);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 467);
            this.panel1.TabIndex = 1;
            // 
            // btnInvalid
            // 
            this.btnInvalid.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvalid.Location = new System.Drawing.Point(359, 391);
            this.btnInvalid.Name = "btnInvalid";
            this.btnInvalid.Size = new System.Drawing.Size(170, 42);
            this.btnInvalid.TabIndex = 26;
            this.btnInvalid.Text = "Invalidează Sarcina";
            this.btnInvalid.UseVisualStyleBackColor = true;
            this.btnInvalid.Click += new System.EventHandler(this.btnInvalid_Click);
            // 
            // btnValid
            // 
            this.btnValid.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValid.Location = new System.Drawing.Point(182, 391);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(159, 42);
            this.btnValid.TabIndex = 25;
            this.btnValid.Text = "Validează Sarcina";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.Location = new System.Drawing.Point(12, 391);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(153, 42);
            this.btnAnuleaza.TabIndex = 24;
            this.btnAnuleaza.Text = "Anulează Sarcina";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // lblAre
            // 
            this.lblAre.AutoSize = true;
            this.lblAre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblAre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblAre.Location = new System.Drawing.Point(31, 222);
            this.lblAre.Name = "lblAre";
            this.lblAre.Size = new System.Drawing.Size(82, 19);
            this.lblAre.TabIndex = 20;
            this.lblAre.Text = "Angajatul";
            // 
            // grdSarcini
            // 
            this.grdSarcini.AllowUserToAddRows = false;
            this.grdSarcini.AllowUserToDeleteRows = false;
            this.grdSarcini.AllowUserToResizeColumns = false;
            this.grdSarcini.AllowUserToResizeRows = false;
            this.grdSarcini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdSarcini.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSarcini.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.grdSarcini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSarcini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSarcini.Location = new System.Drawing.Point(12, 259);
            this.grdSarcini.MultiSelect = false;
            this.grdSarcini.Name = "grdSarcini";
            this.grdSarcini.ReadOnly = true;
            this.grdSarcini.RowTemplate.Height = 24;
            this.grdSarcini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSarcini.Size = new System.Drawing.Size(517, 112);
            this.grdSarcini.TabIndex = 19;
            this.grdSarcini.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angajați";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(18, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(500, 42);
            this.btnClose.TabIndex = 23;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Închide";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grdSC
            // 
            this.grdSC.AllowUserToAddRows = false;
            this.grdSC.AllowUserToDeleteRows = false;
            this.grdSC.AllowUserToResizeColumns = false;
            this.grdSC.AllowUserToResizeRows = false;
            this.grdSC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdSC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSC.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.grdSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSC.Location = new System.Drawing.Point(570, 51);
            this.grdSC.MultiSelect = false;
            this.grdSC.Name = "grdSC";
            this.grdSC.ReadOnly = true;
            this.grdSC.RowTemplate.Height = 24;
            this.grdSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSC.Size = new System.Drawing.Size(500, 105);
            this.grdSC.TabIndex = 27;
            this.grdSC.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.btnAchita);
            this.panel2.Controls.Add(this.txtBonus);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.grdSN);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(552, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 467);
            this.panel2.TabIndex = 29;
            // 
            // btnAchita
            // 
            this.btnAchita.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchita.Location = new System.Drawing.Point(382, 322);
            this.btnAchita.Name = "btnAchita";
            this.btnAchita.Size = new System.Drawing.Size(157, 26);
            this.btnAchita.TabIndex = 33;
            this.btnAchita.TabStop = false;
            this.btnAchita.Text = "Achită";
            this.btnAchita.UseVisualStyleBackColor = true;
            this.btnAchita.Click += new System.EventHandler(this.btnAchita_Click);
            // 
            // txtBonus
            // 
            this.txtBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBonus.Location = new System.Drawing.Point(206, 322);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.ReadOnly = true;
            this.txtBonus.Size = new System.Drawing.Size(133, 26);
            this.txtBonus.TabIndex = 32;
            this.txtBonus.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(14, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Bonus nerevendicat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Sarcini Necompletate";
            // 
            // grdSN
            // 
            this.grdSN.AllowUserToAddRows = false;
            this.grdSN.AllowUserToDeleteRows = false;
            this.grdSN.AllowUserToResizeColumns = false;
            this.grdSN.AllowUserToResizeRows = false;
            this.grdSN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdSN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSN.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.grdSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSN.Location = new System.Drawing.Point(18, 212);
            this.grdSN.MultiSelect = false;
            this.grdSN.Name = "grdSN";
            this.grdSN.ReadOnly = true;
            this.grdSN.RowTemplate.Height = 24;
            this.grdSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSN.Size = new System.Drawing.Size(500, 87);
            this.grdSN.TabIndex = 30;
            this.grdSN.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sarcini Completate";
            // 
            // frmDistributieSarcini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 467);
            this.Controls.Add(this.grdSC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDistributieSarcini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDistributieSarcini";
            this.Load += new System.EventHandler(this.frmDistributieSarcini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAngajati)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSarcini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAngajati;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdSarcini;
        private System.Windows.Forms.Label lblAre;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnInvalid;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.DataGridView grdSC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAchita;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label4;
    }
}