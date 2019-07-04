namespace Travel_Experts
{
    partial class AdministratorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorControl));
            this.btnAdminSup = new System.Windows.Forms.Button();
            this.btnAdminPdct = new System.Windows.Forms.Button();
            this.btnAdminPkg = new System.Windows.Forms.Button();
            this.adminControlSup1 = new Travel_Experts.AdminControlSup();
            this.adminControlPdct1 = new Travel_Experts.AdminControlPdct();
            this.adminControlPkg1 = new Travel_Experts.AdminControlPkg();
            this.SuspendLayout();
            // 
            // btnAdminSup
            // 
            this.btnAdminSup.BackColor = System.Drawing.Color.Pink;
            this.btnAdminSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSup.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdminSup.Location = new System.Drawing.Point(401, 3);
            this.btnAdminSup.Name = "btnAdminSup";
            this.btnAdminSup.Size = new System.Drawing.Size(146, 37);
            this.btnAdminSup.TabIndex = 5;
            this.btnAdminSup.Text = "Supplier";
            this.btnAdminSup.UseVisualStyleBackColor = false;
            this.btnAdminSup.Click += new System.EventHandler(this.btnAdminSup_Click);
            // 
            // btnAdminPdct
            // 
            this.btnAdminPdct.BackColor = System.Drawing.Color.Pink;
            this.btnAdminPdct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPdct.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdminPdct.Location = new System.Drawing.Point(232, 3);
            this.btnAdminPdct.Name = "btnAdminPdct";
            this.btnAdminPdct.Size = new System.Drawing.Size(146, 37);
            this.btnAdminPdct.TabIndex = 4;
            this.btnAdminPdct.Text = "Product";
            this.btnAdminPdct.UseVisualStyleBackColor = false;
            this.btnAdminPdct.Click += new System.EventHandler(this.btnAdminPdct_Click);
            // 
            // btnAdminPkg
            // 
            this.btnAdminPkg.BackColor = System.Drawing.Color.Pink;
            this.btnAdminPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPkg.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdminPkg.Location = new System.Drawing.Point(63, 3);
            this.btnAdminPkg.Name = "btnAdminPkg";
            this.btnAdminPkg.Size = new System.Drawing.Size(146, 37);
            this.btnAdminPkg.TabIndex = 3;
            this.btnAdminPkg.Text = "Package";
            this.btnAdminPkg.UseVisualStyleBackColor = false;
            this.btnAdminPkg.Click += new System.EventHandler(this.btnAdminPkg_Click);
            // 
            // adminControlSup1
            // 
            this.adminControlSup1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminControlSup1.BackgroundImage")));
            this.adminControlSup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminControlSup1.Location = new System.Drawing.Point(0, 46);
            this.adminControlSup1.Name = "adminControlSup1";
            this.adminControlSup1.Size = new System.Drawing.Size(598, 381);
            this.adminControlSup1.TabIndex = 6;
            // 
            // adminControlPdct1
            // 
            this.adminControlPdct1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminControlPdct1.BackgroundImage")));
            this.adminControlPdct1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminControlPdct1.Location = new System.Drawing.Point(0, 46);
            this.adminControlPdct1.Name = "adminControlPdct1";
            this.adminControlPdct1.Size = new System.Drawing.Size(601, 399);
            this.adminControlPdct1.TabIndex = 7;
            // 
            // adminControlPkg1
            // 
            this.adminControlPkg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminControlPkg1.BackgroundImage")));
            this.adminControlPkg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminControlPkg1.Location = new System.Drawing.Point(0, 37);
            this.adminControlPkg1.Name = "adminControlPkg1";
            this.adminControlPkg1.Size = new System.Drawing.Size(601, 390);
            this.adminControlPkg1.TabIndex = 8;
            this.adminControlPkg1.Load += new System.EventHandler(this.adminControlPkg1_Load);
            // 
            // AdministratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.adminControlSup1);
            this.Controls.Add(this.btnAdminSup);
            this.Controls.Add(this.btnAdminPdct);
            this.Controls.Add(this.btnAdminPkg);
            this.Controls.Add(this.adminControlPkg1);
            this.Controls.Add(this.adminControlPdct1);
            this.Name = "AdministratorControl";
            this.Size = new System.Drawing.Size(601, 448);
            this.Load += new System.EventHandler(this.AdministratorControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminSup;
        private System.Windows.Forms.Button btnAdminPdct;
        private System.Windows.Forms.Button btnAdminPkg;
        private AdminControlSup adminControlSup1;
        private AdminControlPdct adminControlPdct1;
        private AdminControlPkg adminControlPkg1;
    }
}
