namespace ZPSVN.View
{
    partial class MainView
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectTool = new System.Windows.Forms.ToolStripMenuItem();
            this.lineTool = new System.Windows.Forms.ToolStripMenuItem();
            this.computerTool = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.computersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.errorHandler = new System.Windows.Forms.Panel();
            this.userRoleShower = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.projectManagerLabel = new System.Windows.Forms.Label();
            this.ProjectPanel = new System.Windows.Forms.Panel();
            this.searchingTextBox = new System.Windows.Forms.TextBox();
            this.linePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.autoRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.computersPanel.SuspendLayout();
            this.errorHandler.SuspendLayout();
            this.ProjectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectTool,
            this.timerToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1579, 30);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAllInfoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAllInfoToolStripMenuItem
            // 
            this.saveAllInfoToolStripMenuItem.Name = "saveAllInfoToolStripMenuItem";
            this.saveAllInfoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.saveAllInfoToolStripMenuItem.Text = "Save all info.";
            this.saveAllInfoToolStripMenuItem.Click += new System.EventHandler(this.SaveAll);
            // 
            // projectTool
            // 
            this.projectTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineTool,
            this.computerTool});
            this.projectTool.Name = "projectTool";
            this.projectTool.Size = new System.Drawing.Size(90, 24);
            this.projectTool.Text = "Maintaing";
            // 
            // lineTool
            // 
            this.lineTool.Name = "lineTool";
            this.lineTool.Size = new System.Drawing.Size(235, 26);
            this.lineTool.Text = "Maintaing Line";
            this.lineTool.Click += new System.EventHandler(this.lineTool_Click);
            // 
            // computerTool
            // 
            this.computerTool.Name = "computerTool";
            this.computerTool.Size = new System.Drawing.Size(235, 26);
            this.computerTool.Text = "Maintaing Computers";
            this.computerTool.Click += new System.EventHandler(this.computerTool_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.computersPanel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(267, 30);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1312, 695);
            this.infoPanel.TabIndex = 7;
            // 
            // computersPanel
            // 
            this.computersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.computersPanel.AutoScroll = true;
            this.computersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.computersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computersPanel.Controls.Add(this.label8);
            this.computersPanel.Location = new System.Drawing.Point(117, 59);
            this.computersPanel.Margin = new System.Windows.Forms.Padding(4);
            this.computersPanel.Name = "computersPanel";
            this.computersPanel.Size = new System.Drawing.Size(1078, 445);
            this.computersPanel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(777, 70);
            this.label8.TabIndex = 0;
            this.label8.Text = "Select project from the \"Project Manager\".";
            // 
            // errorHandler
            // 
            this.errorHandler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(54)))));
            this.errorHandler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorHandler.Controls.Add(this.userRoleShower);
            this.errorHandler.Controls.Add(this.timerLabel);
            this.errorHandler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorHandler.Location = new System.Drawing.Point(267, 605);
            this.errorHandler.Margin = new System.Windows.Forms.Padding(4);
            this.errorHandler.Name = "errorHandler";
            this.errorHandler.Size = new System.Drawing.Size(1312, 120);
            this.errorHandler.TabIndex = 9;
            // 
            // userRoleShower
            // 
            this.userRoleShower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userRoleShower.AutoSize = true;
            this.userRoleShower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(54)))));
            this.userRoleShower.Font = new System.Drawing.Font("Myanmar Text", 15.75F);
            this.userRoleShower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.userRoleShower.Location = new System.Drawing.Point(32, 47);
            this.userRoleShower.Name = "userRoleShower";
            this.userRoleShower.Size = new System.Drawing.Size(153, 48);
            this.userRoleShower.TabIndex = 1;
            this.userRoleShower.Text = "User Role:  ";
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(54)))));
            this.timerLabel.Font = new System.Drawing.Font("Myanmar Text", 15.75F);
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.timerLabel.Location = new System.Drawing.Point(816, 47);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(298, 48);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "Project reloading timer:";
            // 
            // projectManagerLabel
            // 
            this.projectManagerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.projectManagerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectManagerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectManagerLabel.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectManagerLabel.Location = new System.Drawing.Point(0, 0);
            this.projectManagerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectManagerLabel.Name = "projectManagerLabel";
            this.projectManagerLabel.Padding = new System.Windows.Forms.Padding(20, 12, 17, 0);
            this.projectManagerLabel.Size = new System.Drawing.Size(267, 100);
            this.projectManagerLabel.TabIndex = 7;
            this.projectManagerLabel.Text = "Project Manager";
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.AutoScroll = true;
            this.ProjectPanel.AutoSize = true;
            this.ProjectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(179)))), ((int)(((byte)(150)))));
            this.ProjectPanel.Controls.Add(this.searchingTextBox);
            this.ProjectPanel.Controls.Add(this.linePanel);
            this.ProjectPanel.Controls.Add(this.projectManagerLabel);
            this.ProjectPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProjectPanel.Location = new System.Drawing.Point(0, 30);
            this.ProjectPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProjectPanel.MaximumSize = new System.Drawing.Size(467, 0);
            this.ProjectPanel.MinimumSize = new System.Drawing.Size(267, 0);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(267, 695);
            this.ProjectPanel.TabIndex = 7;
            // 
            // searchingTextBox
            // 
            this.searchingTextBox.AcceptsTab = true;
            this.searchingTextBox.HideSelection = false;
            this.searchingTextBox.Location = new System.Drawing.Point(28, 60);
            this.searchingTextBox.Name = "searchingTextBox";
            this.searchingTextBox.Size = new System.Drawing.Size(200, 22);
            this.searchingTextBox.TabIndex = 2;
            this.searchingTextBox.TabStop = false;
            this.searchingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Submit);
            // 
            // linePanel
            // 
            this.linePanel.AutoScroll = true;
            this.linePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.linePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linePanel.Location = new System.Drawing.Point(0, 100);
            this.linePanel.Margin = new System.Windows.Forms.Padding(4);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(267, 595);
            this.linePanel.TabIndex = 7;
            // 
            // autoRefresh
            // 
            this.autoRefresh.Enabled = true;
            this.autoRefresh.Interval = 190;
            this.autoRefresh.Tick += new System.EventHandler(this.autoRefresh_Tick);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 725);
            this.Controls.Add(this.errorHandler);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.ProjectPanel);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1594, 762);
            this.Name = "MainView";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppClosed);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainView_ResetLines);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.computersPanel.ResumeLayout(false);
            this.computersPanel.PerformLayout();
            this.errorHandler.ResumeLayout(false);
            this.errorHandler.PerformLayout();
            this.ProjectPanel.ResumeLayout(false);
            this.ProjectPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

#pragma warning disable CS0169 // The field 'MainView.label1' is never used
        private System.Windows.Forms.Label label1;
#pragma warning restore CS0169 // The field 'MainView.label1' is never used
#pragma warning disable CS0169 // The field 'MainView.label2' is never used
        private System.Windows.Forms.Label label2;
#pragma warning restore CS0169 // The field 'MainView.label2' is never used
#pragma warning disable CS0169 // The field 'MainView.label3' is never used
        private System.Windows.Forms.Label label3;
#pragma warning restore CS0169 // The field 'MainView.label3' is never used
#pragma warning disable CS0169 // The field 'MainView.label4' is never used
        private System.Windows.Forms.Label label4;
#pragma warning restore CS0169 // The field 'MainView.label4' is never used
#pragma warning disable CS0169 // The field 'MainView.label5' is never used
        private System.Windows.Forms.Label label5;
#pragma warning restore CS0169 // The field 'MainView.label5' is never used
#pragma warning disable CS0169 // The field 'MainView.label6' is never used
        private System.Windows.Forms.Label label6;
#pragma warning restore CS0169 // The field 'MainView.label6' is never used
#pragma warning disable CS0169 // The field 'MainView.label7' is never used
        private System.Windows.Forms.Label label7;
#pragma warning restore CS0169 // The field 'MainView.label7' is never used
#pragma warning disable CS0169 // The field 'MainView.timer1' is never used
        private System.Windows.Forms.Timer timer1;
#pragma warning restore CS0169 // The field 'MainView.timer1' is never used
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem projectTool;
        private System.Windows.Forms.ToolStripMenuItem lineTool;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel errorHandler;
        private System.Windows.Forms.Label projectManagerLabel;
        private System.Windows.Forms.Panel ProjectPanel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllInfoToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel linePanel;
        private System.Windows.Forms.FlowLayoutPanel computersPanel;
        private System.Windows.Forms.Timer autoRefresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.ToolStripMenuItem computerTool;
        private System.Windows.Forms.TextBox searchingTextBox;
        private System.Windows.Forms.Label userRoleShower;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
    }
}