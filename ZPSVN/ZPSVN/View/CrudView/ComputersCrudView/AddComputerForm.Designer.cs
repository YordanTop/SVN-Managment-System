namespace ZPSVN.View.CrudView.ComputersCrudView
{
    partial class AddComputerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.computerNameTextBox = new System.Windows.Forms.TextBox();
            this.computerRepositoryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.computerRepositoryButton = new System.Windows.Forms.Button();
            this.computerDirectoryButton = new System.Windows.Forms.Button();
            this.addComputerButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.computerDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.attachComputerComboBox = new System.Windows.Forms.ComboBox();
            this.lineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Name:";
            // 
            // computerNameTextBox
            // 
            this.computerNameTextBox.Location = new System.Drawing.Point(44, 134);
            this.computerNameTextBox.Name = "computerNameTextBox";
            this.computerNameTextBox.Size = new System.Drawing.Size(186, 22);
            this.computerNameTextBox.TabIndex = 4;
            // 
            // computerRepositoryTextBox
            // 
            this.computerRepositoryTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.computerRepositoryTextBox.Enabled = false;
            this.computerRepositoryTextBox.Location = new System.Drawing.Point(296, 134);
            this.computerRepositoryTextBox.Name = "computerRepositoryTextBox";
            this.computerRepositoryTextBox.Size = new System.Drawing.Size(186, 22);
            this.computerRepositoryTextBox.TabIndex = 5;
            this.computerRepositoryTextBox.Text = "C:\\\\Program Files\\\\TortoiseSVN\\\\bin\\\\svn.exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Computer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Computer Repository:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Computer Directory:";
            // 
            // computerRepositoryButton
            // 
            this.computerRepositoryButton.Location = new System.Drawing.Point(488, 134);
            this.computerRepositoryButton.Name = "computerRepositoryButton";
            this.computerRepositoryButton.Size = new System.Drawing.Size(65, 25);
            this.computerRepositoryButton.TabIndex = 10;
            this.computerRepositoryButton.Text = "Search";
            this.computerRepositoryButton.UseVisualStyleBackColor = true;
            this.computerRepositoryButton.Click += new System.EventHandler(this.SearchRepository);
            // 
            // computerDirectoryButton
            // 
            this.computerDirectoryButton.Location = new System.Drawing.Point(488, 218);
            this.computerDirectoryButton.Name = "computerDirectoryButton";
            this.computerDirectoryButton.Size = new System.Drawing.Size(65, 25);
            this.computerDirectoryButton.TabIndex = 11;
            this.computerDirectoryButton.Text = "Search ";
            this.computerDirectoryButton.UseVisualStyleBackColor = true;
            this.computerDirectoryButton.Click += new System.EventHandler(this.SearchDirectory);
            // 
            // addComputerButton
            // 
            this.addComputerButton.Location = new System.Drawing.Point(215, 300);
            this.addComputerButton.Name = "addComputerButton";
            this.addComputerButton.Size = new System.Drawing.Size(150, 44);
            this.addComputerButton.TabIndex = 12;
            this.addComputerButton.Text = "Submit";
            this.addComputerButton.UseVisualStyleBackColor = true;
            this.addComputerButton.Click += new System.EventHandler(this.AddComputer);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Attach To Project:";
            // 
            // computerDirectoryTextBox
            // 
            this.computerDirectoryTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.computerDirectoryTextBox.Enabled = false;
            this.computerDirectoryTextBox.Location = new System.Drawing.Point(296, 218);
            this.computerDirectoryTextBox.Name = "computerDirectoryTextBox";
            this.computerDirectoryTextBox.Size = new System.Drawing.Size(186, 22);
            this.computerDirectoryTextBox.TabIndex = 14;
            // 
            // attachComputerComboBox
            // 
            this.attachComputerComboBox.DataSource = this.lineBindingSource;
            this.attachComputerComboBox.DisplayMember = "Name";
            this.attachComputerComboBox.FormattingEnabled = true;
            this.attachComputerComboBox.Location = new System.Drawing.Point(44, 218);
            this.attachComputerComboBox.Name = "attachComputerComboBox";
            this.attachComputerComboBox.Size = new System.Drawing.Size(186, 24);
            this.attachComputerComboBox.TabIndex = 15;
            // 
            // lineBindingSource
            // 
            this.lineBindingSource.DataSource = typeof(DataBaseLayer.Models.Line);
            // 
            // AddComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 378);
            this.Controls.Add(this.attachComputerComboBox);
            this.Controls.Add(this.computerDirectoryTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addComputerButton);
            this.Controls.Add(this.computerDirectoryButton);
            this.Controls.Add(this.computerRepositoryButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.computerRepositoryTextBox);
            this.Controls.Add(this.computerNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddComputerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddComputerForm";
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox computerNameTextBox;
        private System.Windows.Forms.TextBox computerRepositoryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button computerRepositoryButton;
        private System.Windows.Forms.Button computerDirectoryButton;
        private System.Windows.Forms.Button addComputerButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox computerDirectoryTextBox;
        private System.Windows.Forms.ComboBox attachComputerComboBox;
        private System.Windows.Forms.BindingSource lineBindingSource;
    }
}