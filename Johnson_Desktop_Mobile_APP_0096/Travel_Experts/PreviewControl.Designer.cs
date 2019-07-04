namespace Travel_Experts
{
    partial class PreviewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewControl));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.openFilePDFDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPDFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 24);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(553, 352);
            this.axAcroPDF1.TabIndex = 0;
            this.axAcroPDF1.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // openFilePDFDialog
            // 
            this.openFilePDFDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPDFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // openPDFToolStripMenuItem
            // 
            this.openPDFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPDFToolStripMenuItem1});
            this.openPDFToolStripMenuItem.Name = "openPDFToolStripMenuItem";
            this.openPDFToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openPDFToolStripMenuItem.Text = "File";
            // 
            // openPDFToolStripMenuItem1
            // 
            this.openPDFToolStripMenuItem1.Name = "openPDFToolStripMenuItem1";
            this.openPDFToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.openPDFToolStripMenuItem1.Text = "Open PDF";
            this.openPDFToolStripMenuItem1.Click += new System.EventHandler(this.openPDFToolStripMenuItem1_Click);
            // 
            // PreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PreviewControl";
            this.Size = new System.Drawing.Size(553, 376);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.OpenFileDialog openFilePDFDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPDFToolStripMenuItem1;
    }
}
