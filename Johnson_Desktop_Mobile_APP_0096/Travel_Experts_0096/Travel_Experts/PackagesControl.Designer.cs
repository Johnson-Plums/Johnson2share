namespace Travel_Experts
{
    partial class PackagesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackagesControl));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDelete = new System.Windows.Forms.RadioButton();
            this.radUpdate = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbPS = new System.Windows.Forms.ListBox();
            this.lbAdded = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.gbPS = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbPS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Packages Management System";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.HotPink;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.radDelete);
            this.groupBox1.Controls.Add(this.radUpdate);
            this.groupBox1.Controls.Add(this.radAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // radDelete
            // 
            this.radDelete.AutoSize = true;
            this.radDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDelete.Location = new System.Drawing.Point(486, 21);
            this.radDelete.Name = "radDelete";
            this.radDelete.Size = new System.Drawing.Size(66, 20);
            this.radDelete.TabIndex = 2;
            this.radDelete.TabStop = true;
            this.radDelete.Text = "Delete";
            this.radDelete.UseVisualStyleBackColor = true;
            this.radDelete.CheckedChanged += new System.EventHandler(this.radDelete_CheckedChanged);
            // 
            // radUpdate
            // 
            this.radUpdate.AutoSize = true;
            this.radUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUpdate.Location = new System.Drawing.Point(273, 21);
            this.radUpdate.Name = "radUpdate";
            this.radUpdate.Size = new System.Drawing.Size(71, 20);
            this.radUpdate.TabIndex = 1;
            this.radUpdate.TabStop = true;
            this.radUpdate.Text = "Update";
            this.radUpdate.UseVisualStyleBackColor = true;
            this.radUpdate.CheckedChanged += new System.EventHandler(this.radUpdate_CheckedChanged);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdd.Location = new System.Drawing.Point(94, 21);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(51, 20);
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radAdd_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(317, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Tag = "Name234";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(207, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblCommission
            // 
            this.lblCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommission.Location = new System.Drawing.Point(204, 188);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(97, 18);
            this.lblCommission.TabIndex = 5;
            this.lblCommission.Text = "Commission:";
            // 
            // txtCommission
            // 
            this.txtCommission.Enabled = false;
            this.txtCommission.Location = new System.Drawing.Point(317, 186);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(134, 20);
            this.txtCommission.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(207, 162);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(94, 18);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(317, 161);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(135, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(24, 131);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(132, 20);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Select  Package: ";
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "yyyy-MM-dd";
            this.dateStart.Enabled = false;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(317, 216);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(135, 20);
            this.dateStart.TabIndex = 11;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(204, 218);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(97, 18);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(204, 250);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(97, 18);
            this.lblEndDate.TabIndex = 14;
            this.lblEndDate.Text = "End Date:";
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "yyyy-MM-dd";
            this.dateEnd.Enabled = false;
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(317, 248);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(135, 20);
            this.dateEnd.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(427, 433);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 34);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.Enabled = false;
            this.richTxtDescription.Location = new System.Drawing.Point(469, 141);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(135, 127);
            this.richTxtDescription.TabIndex = 17;
            this.richTxtDescription.Text = "";
            // 
            // lblPackage
            // 
            this.lblPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.Location = new System.Drawing.Point(466, 120);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(138, 18);
            this.lblPackage.TabIndex = 18;
            this.lblPackage.Text = "Description:";
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(6, 48);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(121, 21);
            this.cbProduct.TabIndex = 26;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(165, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbPS
            // 
            this.lbPS.FormattingEnabled = true;
            this.lbPS.Location = new System.Drawing.Point(146, 48);
            this.lbPS.Name = "lbPS";
            this.lbPS.Size = new System.Drawing.Size(212, 82);
            this.lbPS.TabIndex = 28;
            // 
            // lbAdded
            // 
            this.lbAdded.FormattingEnabled = true;
            this.lbAdded.Location = new System.Drawing.Point(379, 48);
            this.lbAdded.Name = "lbAdded";
            this.lbAdded.Size = new System.Drawing.Size(215, 82);
            this.lbAdded.TabIndex = 29;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(405, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 26);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(22, 159);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(134, 21);
            this.cbID.TabIndex = 31;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // gbPS
            // 
            this.gbPS.BackColor = System.Drawing.Color.HotPink;
            this.gbPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbPS.Controls.Add(this.cbProduct);
            this.gbPS.Controls.Add(this.btnAdd);
            this.gbPS.Controls.Add(this.btnRemove);
            this.gbPS.Controls.Add(this.lbPS);
            this.gbPS.Controls.Add(this.lbAdded);
            this.gbPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPS.Location = new System.Drawing.Point(13, 279);
            this.gbPS.Name = "gbPS";
            this.gbPS.Size = new System.Drawing.Size(597, 148);
            this.gbPS.TabIndex = 32;
            this.gbPS.TabStop = false;
            this.gbPS.Text = "Select Products to Add";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PackagesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbPS);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PackagesControl";
            this.Size = new System.Drawing.Size(656, 484);
            this.Load += new System.EventHandler(this.PackagesControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDelete;
        private System.Windows.Forms.RadioButton radUpdate;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbPS;
        private System.Windows.Forms.ListBox lbAdded;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.GroupBox gbPS;
        private System.Windows.Forms.Button button1;
    }
}
