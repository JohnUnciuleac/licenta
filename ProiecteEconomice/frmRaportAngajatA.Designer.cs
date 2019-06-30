namespace ProiecteEconomice
{
    partial class frmRaportAngajatA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaportAngajatA));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtBN = new System.Windows.Forms.TextBox();
            this.txtBA = new System.Windows.Forms.TextBox();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.txtDom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumeRap = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtSC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdSN = new System.Windows.Forms.DataGridView();
            this.grdSC = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(464, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(329, 32);
            this.btnClose.TabIndex = 64;
            this.btnClose.Text = "Închide";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(59, 427);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(329, 32);
            this.btnPrint.TabIndex = 63;
            this.btnPrint.Text = "Printează";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtBN
            // 
            this.txtBN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBN.Location = new System.Drawing.Point(667, 287);
            this.txtBN.Name = "txtBN";
            this.txtBN.ReadOnly = true;
            this.txtBN.Size = new System.Drawing.Size(146, 27);
            this.txtBN.TabIndex = 52;
            this.txtBN.TabStop = false;
            // 
            // txtBA
            // 
            this.txtBA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBA.Location = new System.Drawing.Point(667, 199);
            this.txtBA.Name = "txtBA";
            this.txtBA.ReadOnly = true;
            this.txtBA.Size = new System.Drawing.Size(146, 27);
            this.txtBA.TabIndex = 51;
            this.txtBA.TabStop = false;
            // 
            // txtSalariu
            // 
            this.txtSalariu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalariu.Location = new System.Drawing.Point(667, 244);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.ReadOnly = true;
            this.txtSalariu.Size = new System.Drawing.Size(146, 27);
            this.txtSalariu.TabIndex = 50;
            this.txtSalariu.TabStop = false;
            // 
            // txtDom
            // 
            this.txtDom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDom.Location = new System.Drawing.Point(667, 149);
            this.txtDom.Name = "txtDom";
            this.txtDom.ReadOnly = true;
            this.txtDom.Size = new System.Drawing.Size(146, 27);
            this.txtDom.TabIndex = 49;
            this.txtDom.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(504, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Bonus nerevendicat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(505, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "Bonus acumulat:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(504, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Salariu de bază:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(505, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Domeniu Experiență:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNumeRap);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblTitlu);
            this.panel1.Location = new System.Drawing.Point(-11, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 82);
            this.panel1.TabIndex = 42;
            // 
            // lblNumeRap
            // 
            this.lblNumeRap.AutoSize = true;
            this.lblNumeRap.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeRap.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumeRap.Location = new System.Drawing.Point(599, 28);
            this.lblNumeRap.Name = "lblNumeRap";
            this.lblNumeRap.Size = new System.Drawing.Size(0, 28);
            this.lblNumeRap.TabIndex = 31;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblId.Location = new System.Drawing.Point(23, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "id";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitlu.Location = new System.Drawing.Point(69, 28);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(524, 28);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Raport detaliat pentru performanța angajatului";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(667, 354);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(146, 27);
            this.txtTotal.TabIndex = 74;
            this.txtTotal.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(505, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 54);
            this.label9.TabIndex = 73;
            this.label9.Text = "Total plată:\r\n\r\n (salariu bază + bonus nerevendicat)";
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(319, 220);
            this.txtSN.Name = "txtSN";
            this.txtSN.ReadOnly = true;
            this.txtSN.Size = new System.Drawing.Size(51, 27);
            this.txtSN.TabIndex = 72;
            this.txtSN.TabStop = false;
            // 
            // txtSC
            // 
            this.txtSC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSC.Location = new System.Drawing.Point(319, 383);
            this.txtSC.Name = "txtSC";
            this.txtSC.ReadOnly = true;
            this.txtSC.Size = new System.Drawing.Size(51, 27);
            this.txtSC.TabIndex = 71;
            this.txtSC.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(102, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 18);
            this.label8.TabIndex = 70;
            this.label8.Text = "Total Sarcini Completate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(102, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "Total Sarcini Necompletate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(25, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "Sarcini Completate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(25, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 24);
            this.label5.TabIndex = 67;
            this.label5.Text = "Sarcini Necompletate";
            // 
            // grdSN
            // 
            this.grdSN.AllowUserToAddRows = false;
            this.grdSN.AllowUserToDeleteRows = false;
            this.grdSN.AllowUserToResizeColumns = false;
            this.grdSN.AllowUserToResizeRows = false;
            this.grdSN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdSN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSN.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grdSN.Location = new System.Drawing.Point(16, 126);
            this.grdSN.MultiSelect = false;
            this.grdSN.Name = "grdSN";
            this.grdSN.ReadOnly = true;
            this.grdSN.RowTemplate.Height = 24;
            this.grdSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSN.Size = new System.Drawing.Size(450, 88);
            this.grdSN.TabIndex = 66;
            this.grdSN.TabStop = false;
            // 
            // grdSC
            // 
            this.grdSC.AllowUserToAddRows = false;
            this.grdSC.AllowUserToDeleteRows = false;
            this.grdSC.AllowUserToResizeColumns = false;
            this.grdSC.AllowUserToResizeRows = false;
            this.grdSC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdSC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSC.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grdSC.Location = new System.Drawing.Point(16, 283);
            this.grdSC.MultiSelect = false;
            this.grdSC.Name = "grdSC";
            this.grdSC.ReadOnly = true;
            this.grdSC.RowTemplate.Height = 24;
            this.grdSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSC.Size = new System.Drawing.Size(450, 96);
            this.grdSC.TabIndex = 65;
            this.grdSC.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(504, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 18);
            this.label10.TabIndex = 75;
            this.label10.Text = "Marca Angajat:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(667, 101);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(146, 27);
            this.txtMarca.TabIndex = 76;
            this.txtMarca.TabStop = false;
            // 
            // frmRaportAngajatA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 480);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.txtSC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdSN);
            this.Controls.Add(this.grdSC);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtBN);
            this.Controls.Add(this.txtBA);
            this.Controls.Add(this.txtSalariu);
            this.Controls.Add(this.txtDom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRaportAngajatA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRaportAngajatA";
            this.Load += new System.EventHandler(this.frmRaportAngajatA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtBN;
        private System.Windows.Forms.TextBox txtBA;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.TextBox txtDom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitlu;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblNumeRap;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtSC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdSN;
        private System.Windows.Forms.DataGridView grdSC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMarca;
    }
}