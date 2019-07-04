namespace Travel_Experts
{
    partial class AdminControlPdct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControlPdct));
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pctExcel = new System.Windows.Forms.PictureBox();
            this.pctPdf = new System.Windows.Forms.PictureBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bindingSourceProduct = new System.Windows.Forms.BindingSource(this.components);
            this.saveExcelFile = new System.Windows.Forms.SaveFileDialog();
            this.savePDFFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(394, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Product Information";
            // 
            // pctExcel
            // 
            this.pctExcel.Image = ((System.Drawing.Image)(resources.GetObject("pctExcel.Image")));
            this.pctExcel.Location = new System.Drawing.Point(484, 138);
            this.pctExcel.Name = "pctExcel";
            this.pctExcel.Size = new System.Drawing.Size(30, 21);
            this.pctExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctExcel.TabIndex = 71;
            this.pctExcel.TabStop = false;
            this.toolTip1.SetToolTip(this.pctExcel, "Export to Excel file");
            this.pctExcel.Click += new System.EventHandler(this.pctExcel_Click);
            // 
            // pctPdf
            // 
            this.pctPdf.Image = ((System.Drawing.Image)(resources.GetObject("pctPdf.Image")));
            this.pctPdf.Location = new System.Drawing.Point(520, 138);
            this.pctPdf.Name = "pctPdf";
            this.pctPdf.Size = new System.Drawing.Size(30, 21);
            this.pctPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPdf.TabIndex = 70;
            this.pctPdf.TabStop = false;
            this.toolTip1.SetToolTip(this.pctPdf, "Export to Pdf file");
            this.pctPdf.Click += new System.EventHandler(this.pctPdf_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.ForeColor = System.Drawing.Color.Red;
            this.lblCurrency.Location = new System.Drawing.Point(423, 54);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(129, 13);
            this.lblCurrency.TabIndex = 68;
            this.lblCurrency.Text = "Please enter valid number";
            this.lblCurrency.Visible = false;
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProdName});
            this.productGridView.Location = new System.Drawing.Point(47, 165);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.Size = new System.Drawing.Size(503, 150);
            this.productGridView.TabIndex = 66;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ID";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProdName
            // 
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Name";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(432, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 13);
            this.lblName.TabIndex = 65;
            this.lblName.Text = "Please enter valid name";
            this.lblName.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.Red;
            this.lblId.Location = new System.Drawing.Point(411, 54);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(141, 13);
            this.lblId.TabIndex = 64;
            this.lblId.Text = "Please enter valid Id number";
            this.lblId.Visible = false;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblEmpty.Location = new System.Drawing.Point(417, 54);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(135, 13);
            this.lblEmpty.TabIndex = 63;
            this.lblEmpty.Text = "Please enter a name/value";
            this.lblEmpty.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(475, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(275, 31);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 18);
            this.lblSearch.TabIndex = 61;
            this.lblSearch.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Search by:";
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "All",
            "Id",
            "Name"});
            this.cboSearch.Location = new System.Drawing.Point(110, 30);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(121, 21);
            this.cboSearch.TabIndex = 59;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(340, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 20);
            this.txtSearch.TabIndex = 58;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(47, 345);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 33);
            this.btnRefresh.TabIndex = 74;
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
            // AdminControlPdct
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
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "AdminControlPdct";
            this.Size = new System.Drawing.Size(601, 433);
            this.Load += new System.EventHandler(this.AdminControlPdct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctExcel;
        private System.Windows.Forms.PictureBox pctPdf;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.DataGridView productGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.BindingSource bindingSourceProduct;
        private System.Windows.Forms.SaveFileDialog saveExcelFile;
        private System.Windows.Forms.SaveFileDialog savePDFFile;
    }
}
