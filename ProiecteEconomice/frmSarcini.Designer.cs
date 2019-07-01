namespace ProiecteEconomice
{
    partial class frmSarcini
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSarcini));
            this.label1 = new System.Windows.Forms.Label();
            this.grdSarcini = new System.Windows.Forms.DataGridView();
            this.sarcinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licentaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRapoarteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnFiltru = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblIdAngajat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSarcini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarcinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licentaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRapoarteBindingSource)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(801, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sarcini disponibile                                              ";
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
            this.grdSarcini.Location = new System.Drawing.Point(18, 61);
            this.grdSarcini.MultiSelect = false;
            this.grdSarcini.Name = "grdSarcini";
            this.grdSarcini.ReadOnly = true;
            this.grdSarcini.RowTemplate.Height = 24;
            this.grdSarcini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSarcini.Size = new System.Drawing.Size(587, 252);
            this.grdSarcini.TabIndex = 17;
            this.grdSarcini.TabStop = false;
            // 
            // sarcinaBindingSource
            // 
            this.sarcinaBindingSource.DataMember = "sarcina";
            this.sarcinaBindingSource.DataSource = this.licentaDataSetBindingSource;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(611, 61);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(177, 42);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "Acceptă Sarcina";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnFiltru
            // 
            this.btnFiltru.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltru.Location = new System.Drawing.Point(611, 133);
            this.btnFiltru.Name = "btnFiltru";
            this.btnFiltru.Size = new System.Drawing.Size(177, 42);
            this.btnFiltru.TabIndex = 19;
            this.btnFiltru.Text = "Filtrează";
            this.btnFiltru.UseVisualStyleBackColor = true;
            this.btnFiltru.Click += new System.EventHandler(this.btnFiltru_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(18, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 42);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Adaugă Sarcină";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(224, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 42);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Modifică Sarcina";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(428, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 42);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Sterge Sarcina";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(611, 204);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(177, 42);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(611, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 42);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Închide";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblJob.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJob.Location = new System.Drawing.Point(343, 9);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(0, 36);
            this.lblJob.TabIndex = 25;
            // 
            // lblIdAngajat
            // 
            this.lblIdAngajat.AutoSize = true;
            this.lblIdAngajat.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAngajat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdAngajat.Location = new System.Drawing.Point(663, 332);
            this.lblIdAngajat.Name = "lblIdAngajat";
            this.lblIdAngajat.Size = new System.Drawing.Size(0, 16);
            this.lblIdAngajat.TabIndex = 26;
            // 
            // frmSarcini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.lblIdAngajat);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFiltru);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.grdSarcini);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSarcini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sarcini";
            this.Load += new System.EventHandler(this.frmSarcini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSarcini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRapoarteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdSarcini;
        private System.Windows.Forms.BindingSource licentaDataSetBindingSource;
        private System.Windows.Forms.BindingSource dataSetRapoarteBindingSource;
        private System.Windows.Forms.BindingSource sarcinaBindingSource;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnFiltru;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblIdAngajat;
    }
}