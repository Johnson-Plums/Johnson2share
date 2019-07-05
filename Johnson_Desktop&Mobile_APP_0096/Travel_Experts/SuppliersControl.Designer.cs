namespace Travel_Experts
{
    partial class SuppliersControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersControl));
            this.label1 = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.cbSupName = new System.Windows.Forms.ComboBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.txtSupId = new System.Windows.Forms.TextBox();
            this.lblSupNameDD = new System.Windows.Forms.Label();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblSupId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppliers Managment System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOptions
            // 
            this.gbOptions.BackColor = System.Drawing.Color.HotPink;
            this.gbOptions.Controls.Add(this.rbDelete);
            this.gbOptions.Controls.Add(this.rbAdd);
            this.gbOptions.Controls.Add(this.rbUpdate);
            this.gbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptions.Location = new System.Drawing.Point(94, 91);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(341, 59);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(207, 19);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(66, 20);
            this.rbDelete.TabIndex = 2;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Delete";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(32, 19);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(51, 20);
            this.rbAdd.TabIndex = 2;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(109, 19);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(71, 20);
            this.rbUpdate.TabIndex = 2;
            this.rbUpdate.TabStop = true;
            this.rbUpdate.Text = "Update";
            this.rbUpdate.UseVisualStyleBackColor = true;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(360, 302);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 34);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Submit";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbSupName
            // 
            this.cbSupName.FormattingEnabled = true;
            this.cbSupName.Location = new System.Drawing.Point(225, 174);
            this.cbSupName.Name = "cbSupName";
            this.cbSupName.Size = new System.Drawing.Size(210, 21);
            this.cbSupName.TabIndex = 14;
            this.cbSupName.SelectedIndexChanged += new System.EventHandler(this.supNameComboBox_SelectedIndexChanged);
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(225, 221);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(210, 20);
            this.txtSupName.TabIndex = 17;
            // 
            // txtSupId
            // 
            this.txtSupId.Location = new System.Drawing.Point(225, 260);
            this.txtSupId.Name = "txtSupId";
            this.txtSupId.Size = new System.Drawing.Size(210, 20);
            this.txtSupId.TabIndex = 18;
            // 
            // lblSupNameDD
            // 
            this.lblSupNameDD.BackColor = System.Drawing.Color.HotPink;
            this.lblSupNameDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupNameDD.Location = new System.Drawing.Point(94, 177);
            this.lblSupNameDD.Name = "lblSupNameDD";
            this.lblSupNameDD.Size = new System.Drawing.Size(113, 18);
            this.lblSupNameDD.TabIndex = 19;
            this.lblSupNameDD.Text = "Supplier Name:";
            // 
            // lblSupName
            // 
            this.lblSupName.BackColor = System.Drawing.Color.HotPink;
            this.lblSupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupName.Location = new System.Drawing.Point(94, 223);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(113, 18);
            this.lblSupName.TabIndex = 19;
            this.lblSupName.Text = "Supplier Name:";
            // 
            // lblSupId
            // 
            this.lblSupId.BackColor = System.Drawing.Color.HotPink;
            this.lblSupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupId.Location = new System.Drawing.Point(94, 259);
            this.lblSupId.Name = "lblSupId";
            this.lblSupId.Size = new System.Drawing.Size(113, 18);
            this.lblSupId.TabIndex = 20;
            this.lblSupId.Text = "Supplier ID:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(126, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // SuppliersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblSupId);
            this.Controls.Add(this.lblSupName);
            this.Controls.Add(this.lblSupNameDD);
            this.Controls.Add(this.txtSupId);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.cbSupName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.label1);
            this.Name = "SuppliersControl";
            this.Size = new System.Drawing.Size(620, 348);
            this.Load += new System.EventHandler(this.SuppliersControl_Load);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.ComboBox cbSupName;
        private System.Windows.Forms.TextBox txtSupId;
        private System.Windows.Forms.Label lblSupId;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblSupNameDD;
        private System.Windows.Forms.Button button1;
    }
}
