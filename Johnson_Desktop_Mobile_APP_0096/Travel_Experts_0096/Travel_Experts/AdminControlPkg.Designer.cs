namespace Travel_Experts
{
    partial class AdminControlPkg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControlPkg));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pctExcel = new System.Windows.Forms.PictureBox();
            this.pctPdf = new System.Windows.Forms.PictureBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPkg = new System.Windows.Forms.DateTimePicker();
            this.packageGridView = new System.Windows.Forms.DataGridView();
            this.PackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgAgencyCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bindingSourcePackage = new System.Windows.Forms.BindingSource(this.components);
            this.saveExcelFile = new System.Windows.Forms.SaveFileDialog();
            this.savePDFFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePackage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(385, 77);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 57;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Package Information";
            // 
            // pctExcel
            // 
            this.pctExcel.Image = ((System.Drawing.Image)(resources.GetObject("pctExcel.Image")));
            this.pctExcel.Location = new System.Drawing.Point(484, 131);
            this.pctExcel.Name = "pctExcel";
            this.pctExcel.Size = new System.Drawing.Size(30, 21);
            this.pctExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctExcel.TabIndex = 55;
            this.pctExcel.TabStop = false;
            this.toolTip1.SetToolTip(this.pctExcel, "Export to Excel file");
            this.pctExcel.Click += new System.EventHandler(this.pctExcel_Click);
            // 
            // pctPdf
            // 
            this.pctPdf.Image = ((System.Drawing.Image)(resources.GetObject("pctPdf.Image")));
            this.pctPdf.Location = new System.Drawing.Point(520, 131);
            this.pctPdf.Name = "pctPdf";
            this.pctPdf.Size = new System.Drawing.Size(30, 21);
            this.pctPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPdf.TabIndex = 54;
            this.pctPdf.TabStop = false;
            this.toolTip1.SetToolTip(this.pctPdf, "Export to Pdf file");
            this.pctPdf.Click += new System.EventHandler(this.pctPdf_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.ForeColor = System.Drawing.Color.Red;
            this.lblCurrency.Location = new System.Drawing.Point(423, 52);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(129, 13);
            this.lblCurrency.TabIndex = 52;
            this.lblCurrency.Text = "Please enter valid number";
            this.lblCurrency.Visible = false;
            // 
            // cboCurrency
            // 
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Items.AddRange(new object[] {
            "Above:",
            "Below:",
            "Exactly:"});
            this.cboCurrency.Location = new System.Drawing.Point(262, 30);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(72, 21);
            this.cboCurrency.TabIndex = 51;
            this.cboCurrency.Visible = false;
            // 
            // cboDate
            // 
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Items.AddRange(new object[] {
            "Before:",
            "After:",
            "Exactly on:"});
            this.cboDate.Location = new System.Drawing.Point(262, 30);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(72, 21);
            this.cboDate.TabIndex = 50;
            this.cboDate.Visible = false;
            // 
            // dateTimePickerPkg
            // 
            this.dateTimePickerPkg.Location = new System.Drawing.Point(352, 29);
            this.dateTimePickerPkg.Name = "dateTimePickerPkg";
            this.dateTimePickerPkg.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPkg.TabIndex = 49;
            this.dateTimePickerPkg.Visible = false;
            // 
            // packageGridView
            // 
            this.packageGridView.AllowUserToAddRows = false;
            this.packageGridView.AllowUserToDeleteRows = false;
            this.packageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageID,
            this.PkgName,
            this.PkgStartDate,
            this.PkgEndDate,
            this.PkgDesc,
            this.PkgBasePrice,
            this.PkgAgencyCommission});
            this.packageGridView.Location = new System.Drawing.Point(47, 158);
            this.packageGridView.Name = "packageGridView";
            this.packageGridView.ReadOnly = true;
            this.packageGridView.Size = new System.Drawing.Size(503, 150);
            this.packageGridView.TabIndex = 47;
            // 
            // PackageID
            // 
            this.PackageID.DataPropertyName = "PackageId";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PackageID.DefaultCellStyle = dataGridViewCellStyle1;
            this.PackageID.HeaderText = "ID";
            this.PackageID.Name = "PackageID";
            this.PackageID.ReadOnly = true;
            // 
            // PkgName
            // 
            this.PkgName.DataPropertyName = "PkgName";
            this.PkgName.HeaderText = "Name";
            this.PkgName.Name = "PkgName";
            this.PkgName.ReadOnly = true;
            // 
            // PkgStartDate
            // 
            this.PkgStartDate.DataPropertyName = "PkgStartDate";
            this.PkgStartDate.HeaderText = "Start Date";
            this.PkgStartDate.Name = "PkgStartDate";
            this.PkgStartDate.ReadOnly = true;
            // 
            // PkgEndDate
            // 
            this.PkgEndDate.DataPropertyName = "PkgEndDate";
            this.PkgEndDate.HeaderText = "End Date";
            this.PkgEndDate.Name = "PkgEndDate";
            this.PkgEndDate.ReadOnly = true;
            // 
            // PkgDesc
            // 
            this.PkgDesc.DataPropertyName = "PkgDesc";
            this.PkgDesc.HeaderText = "Description";
            this.PkgDesc.Name = "PkgDesc";
            this.PkgDesc.ReadOnly = true;
            // 
            // PkgBasePrice
            // 
            this.PkgBasePrice.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.PkgBasePrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.PkgBasePrice.HeaderText = "Base Price";
            this.PkgBasePrice.Name = "PkgBasePrice";
            this.PkgBasePrice.ReadOnly = true;
            // 
            // PkgAgencyCommission
            // 
            this.PkgAgencyCommission.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.PkgAgencyCommission.DefaultCellStyle = dataGridViewCellStyle3;
            this.PkgAgencyCommission.HeaderText = "Agency Commission";
            this.PkgAgencyCommission.Name = "PkgAgencyCommission";
            this.PkgAgencyCommission.ReadOnly = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(432, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 13);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Please enter valid name";
            this.lblName.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.Red;
            this.lblId.Location = new System.Drawing.Point(411, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(141, 13);
            this.lblId.TabIndex = 45;
            this.lblId.Text = "Please enter valid Id number";
            this.lblId.Visible = false;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblEmpty.Location = new System.Drawing.Point(417, 52);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(135, 13);
            this.lblEmpty.TabIndex = 44;
            this.lblEmpty.Text = "Please enter a name/value";
            this.lblEmpty.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(475, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(280, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(54, 16);
            this.lblSearch.TabIndex = 42;
            this.lblSearch.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Search by:";
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "All",
            "Id",
            "Name",
            "Start Date",
            "End Date",
            "Base Price",
            "Commission"});
            this.cboSearch.Location = new System.Drawing.Point(110, 28);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(121, 21);
            this.cboSearch.TabIndex = 40;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(340, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 20);
            this.txtSearch.TabIndex = 39;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(47, 333);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 31);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // saveExcelFile
            // 
            this.saveExcelFile.Filter = "Excel Files (*.xlsx)|*.xlsx";
            // 
            // savePDFFile
            // 
            this.savePDFFile.Filter = "Pdf Files (*.pdf)|*.pdf";
            // 
            // AdminControlPkg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctExcel);
            this.Controls.Add(this.pctPdf);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.cboCurrency);
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.dateTimePickerPkg);
            this.Controls.Add(this.packageGridView);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "AdminControlPkg";
            this.Size = new System.Drawing.Size(601, 422);
            this.Load += new System.EventHandler(this.AdminControlPkg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePackage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctExcel;
        private System.Windows.Forms.PictureBox pctPdf;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPkg;
        private System.Windows.Forms.DataGridView packageGridView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource bindingSourcePackage;
        private System.Windows.Forms.SaveFileDialog saveExcelFile;
        private System.Windows.Forms.SaveFileDialog savePDFFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgAgencyCommission;
    }
}
