namespace ZPSVN.View.CrudView.ComputersCrudView
{
    partial class UpdateComputerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.renameComputerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateComputer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.computerComboBox = new System.Windows.Forms.ComboBox();
            this.lineComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Update Computer";
            // 
            // renameComputerTextBox
            // 
            this.renameComputerTextBox.Location = new System.Drawing.Point(183, 220);
            this.renameComputerTextBox.Name = "renameComputerTextBox";
            this.renameComputerTextBox.Size = new System.Drawing.Size(215, 22);
            this.renameComputerTextBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(179, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Change Computer\'s name";
            // 
            // updateComputer
            // 
            this.updateComputer.Location = new System.Drawing.Point(208, 301);
            this.updateComputer.Name = "updateComputer";
            this.updateComputer.Size = new System.Drawing.Size(150, 44);
            this.updateComputer.TabIndex = 30;
            this.updateComputer.Text = "Submit";
            this.updateComputer.UseVisualStyleBackColor = true;
            this.updateComputer.Click += new System.EventHandler(this.UpdateComputer);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(311, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Select Computer";
            // 
            // computerComboBox
            // 
            this.computerComboBox.FormattingEnabled = true;
            this.computerComboBox.Location = new System.Drawing.Point(315, 136);
            this.computerComboBox.Name = "computerComboBox";
            this.computerComboBox.Size = new System.Drawing.Size(186, 24);
            this.computerComboBox.TabIndex = 28;
            // 
            // lineComboBox
            // 
            this.lineComboBox.FormattingEnabled = true;
            this.lineComboBox.Location = new System.Drawing.Point(67, 136);
            this.lineComboBox.Name = "lineComboBox";
            this.lineComboBox.Size = new System.Drawing.Size(186, 24);
            this.lineComboBox.TabIndex = 27;
            this.lineComboBox.SelectedIndexChanged += new System.EventHandler(this.lineComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(64, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Select Line";
            // 
            // UpdateComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 378);
            this.Controls.Add(this.renameComputerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateComputer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.computerComboBox);
            this.Controls.Add(this.lineComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateComputerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UpdateComputerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox renameComputerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateComputer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox computerComboBox;
        private System.Windows.Forms.ComboBox lineComboBox;
        private System.Windows.Forms.Label label6;
    }
}