namespace ZPSVN.View.CrudView.LineCrudView
{
    partial class LineCrudView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addingLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removingLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.givePermissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crudDisplayPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.crudDisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addingLineToolStripMenuItem,
            this.removingLineToolStripMenuItem,
            this.givePermissionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addingLineToolStripMenuItem
            // 
            this.addingLineToolStripMenuItem.Name = "addingLineToolStripMenuItem";
            this.addingLineToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.addingLineToolStripMenuItem.Text = "Adding Line";
            this.addingLineToolStripMenuItem.Click += new System.EventHandler(this.AddLine);
            // 
            // removingLineToolStripMenuItem
            // 
            this.removingLineToolStripMenuItem.Name = "removingLineToolStripMenuItem";
            this.removingLineToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.removingLineToolStripMenuItem.Text = "Removing Line";
            this.removingLineToolStripMenuItem.Click += new System.EventHandler(this.RemoveLine);
            // 
            // givePermissionsToolStripMenuItem
            // 
            this.givePermissionsToolStripMenuItem.Name = "givePermissionsToolStripMenuItem";
            this.givePermissionsToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.givePermissionsToolStripMenuItem.Text = "Updating Line";
            this.givePermissionsToolStripMenuItem.Click += new System.EventHandler(this.UpdatePermissions);
            // 
            // crudDisplayPanel
            // 
            this.crudDisplayPanel.Controls.Add(this.label1);
            this.crudDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudDisplayPanel.Location = new System.Drawing.Point(0, 28);
            this.crudDisplayPanel.Name = "crudDisplayPanel";
            this.crudDisplayPanel.Size = new System.Drawing.Size(582, 425);
            this.crudDisplayPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Operation!";
            // 
            // LineCrudView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.crudDisplayPanel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LineCrudView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line Maintaining";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.crudDisplayPanel.ResumeLayout(false);
            this.crudDisplayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addingLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removingLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem givePermissionsToolStripMenuItem;
        private System.Windows.Forms.Panel crudDisplayPanel;
        private System.Windows.Forms.Label label1;
    }
}