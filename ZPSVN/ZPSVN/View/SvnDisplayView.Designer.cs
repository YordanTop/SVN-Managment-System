using ZPSVN.Presentation.EventArguments;

namespace ZPSVN.View
{
    partial class SvnDisplayView
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
            this.closeButton = new System.Windows.Forms.Button();
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textParserBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(591, 457);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(169, 27);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.Location = new System.Drawing.Point(404, 457);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(169, 27);
            this.saveInfoButton.TabIndex = 8;
            this.saveInfoButton.Text = "Save Info";
            this.saveInfoButton.UseVisualStyleBackColor = true;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "Svn Modifications";
            // 
            // textParserBox
            // 
            this.textParserBox.BackColor = System.Drawing.Color.White;
            this.textParserBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textParserBox.Font = new System.Drawing.Font("Myanmar Text", 16.2F);
            this.textParserBox.Location = new System.Drawing.Point(12, 78);
            this.textParserBox.MaxLength = 99999;
            this.textParserBox.Multiline = true;
            this.textParserBox.Name = "textParserBox";
            this.textParserBox.ReadOnly = true;
            this.textParserBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textParserBox.Size = new System.Drawing.Size(748, 339);
            this.textParserBox.TabIndex = 11;
            this.textParserBox.Text = "Everything is patched.\r\n";
            // 
            // SvnDisplayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 496);
            this.Controls.Add(this.textParserBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveInfoButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SvnDisplayView";
            this.Text = "InfoCheckerForm";
            this.Load += new System.EventHandler(this.SvnDisplayView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveInfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textParserBox;
    }
}