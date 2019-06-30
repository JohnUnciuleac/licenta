namespace ProiecteEconomice
{
    partial class frmRaportDomenii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaportDomenii));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAre = new System.Windows.Forms.Label();
            this.grdTop = new System.Windows.Forms.DataGridView();
            this.dtpDataStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataStop = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.grdSC = new System.Windows.Forms.DataGridView();
            this.grdSN = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grdSarcini = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSarcini)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblTitlu);
            this.panel1.Location = new System.Drawing.Point(-11, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 82);
            this.panel1.TabIndex = 3;
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
            this.lblTitlu.Location = new System.Drawing.Point(133, 26);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(614, 28);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Raport despre domeniile sarcinilor și sarcinile aferente";
            // 
            // lblAre
            // 
            this.lblAre.AutoSize = true;
            this.lblAre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblAre.Location = new System.Drawing.Point(12, 98);
            this.lblAre.Name = "lblAre";
            this.lblAre.Size = new System.Drawing.Size(221, 19);
            this.lblAre.TabIndex = 33;
            this.lblAre.Text = "Număr sarcini per domeniu";
            // 
            // grdTop
            // 
            this.grdTop.AllowUserToAddRows = false;
            this.grdTop.AllowUserToDeleteRows = false;
            this.grdTop.AllowUserToResizeColumns = false;
            this.grdTop.AllowUserToResizeRows = false;
            this.grdTop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdTop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdTop.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdTop.Location = new System.Drawing.Point(18, 134);
            this.grdTop.MultiSelect = false;
            this.grdTop.Name = "grdTop";
            this.grdTop.ReadOnly = true;
            this.grdTop.RowTemplate.Height = 24;
            this.grdTop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTop.Size = new System.Drawing.Size(202, 169);
            this.grdTop.TabIndex = 34;
            this.grdTop.TabStop = false;
            this.grdTop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTop_CellContentClick);
            // 
            // dtpDataStart
            // 
            this.dtpDataStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataStart.Location = new System.Drawing.Point(271, 155);
            this.dtpDataStart.Name = "dtpDataStart";
            this.dtpDataStart.Size = new System.Drawing.Size(245, 22);
            this.dtpDataStart.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(267, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Filtru perioadă";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(267, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "De la";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(267, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Până la";
            // 
            // dtpDataStop
            // 
            this.dtpDataStop.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataStop.Location = new System.Drawing.Point(271, 221);
            this.dtpDataStop.Name = "dtpDataStop";
            this.dtpDataStop.Size = new System.Drawing.Size(245, 22);
            this.dtpDataStop.TabIndex = 42;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(271, 269);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 34);
            this.btnFilter.TabIndex = 43;
            this.btnFilter.Text = "Filtrează";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.Location = new System.Drawing.Point(397, 269);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(119, 34);
            this.btnAnuleaza.TabIndex = 44;
            this.btnAnuleaza.Text = "Anulează";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
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
            this.grdSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSC.Location = new System.Drawing.Point(18, 368);
            this.grdSC.MultiSelect = false;
            this.grdSC.Name = "grdSC";
            this.grdSC.ReadOnly = true;
            this.grdSC.RowTemplate.Height = 24;
            this.grdSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSC.Size = new System.Drawing.Size(200, 128);
            this.grdSC.TabIndex = 46;
            this.grdSC.TabStop = false;
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
            this.grdSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSN.Location = new System.Drawing.Point(271, 368);
            this.grdSN.MultiSelect = false;
            this.grdSN.Name = "grdSN";
            this.grdSN.ReadOnly = true;
            this.grdSN.RowTemplate.Height = 24;
            this.grdSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSN.Size = new System.Drawing.Size(200, 128);
            this.grdSN.TabIndex = 49;
            this.grdSN.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(12, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Sarcini Completate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(267, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Sarcini Necompletate";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(549, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(329, 32);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Închide";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(549, 397);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(329, 32);
            this.btnPrint.TabIndex = 53;
            this.btnPrint.Text = "Printează";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.grdSarcini.Location = new System.Drawing.Point(549, 134);
            this.grdSarcini.MultiSelect = false;
            this.grdSarcini.Name = "grdSarcini";
            this.grdSarcini.ReadOnly = true;
            this.grdSarcini.RowTemplate.Height = 24;
            this.grdSarcini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSarcini.Size = new System.Drawing.Size(349, 198);
            this.grdSarcini.TabIndex = 54;
            this.grdSarcini.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(545, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Sarcini domeniu";
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
            // frmRaportDomenii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdSarcini);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdSN);
            this.Controls.Add(this.grdSC);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtpDataStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataStart);
            this.Controls.Add(this.grdTop);
            this.Controls.Add(this.lblAre);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRaportDomenii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domenii";
            this.Load += new System.EventHandler(this.frmRaportDomenii_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSarcini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAre;
        private System.Windows.Forms.DataGridView grdTop;
        private System.Windows.Forms.DateTimePicker dtpDataStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataStop;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.DataGridView grdSC;
        private System.Windows.Forms.DataGridView grdSN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView grdSarcini;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}