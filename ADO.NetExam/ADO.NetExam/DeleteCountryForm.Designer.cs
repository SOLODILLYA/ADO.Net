namespace ADO.NetExam
{
    partial class DeleteCountryForm
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
            this.CountryToDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteCountryButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountryToDeleteComboBox
            // 
            this.CountryToDeleteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryToDeleteComboBox.FormattingEnabled = true;
            this.CountryToDeleteComboBox.Location = new System.Drawing.Point(12, 25);
            this.CountryToDeleteComboBox.Name = "CountryToDeleteComboBox";
            this.CountryToDeleteComboBox.Size = new System.Drawing.Size(126, 21);
            this.CountryToDeleteComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Country To Delete";
            // 
            // DeleteCountryButton
            // 
            this.DeleteCountryButton.Location = new System.Drawing.Point(155, 16);
            this.DeleteCountryButton.Name = "DeleteCountryButton";
            this.DeleteCountryButton.Size = new System.Drawing.Size(95, 36);
            this.DeleteCountryButton.TabIndex = 2;
            this.DeleteCountryButton.Text = "Delete Selected Country";
            this.DeleteCountryButton.UseVisualStyleBackColor = true;
            this.DeleteCountryButton.Click += new System.EventHandler(this.DeleteCountryButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(84, 58);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(95, 36);
            this.FinishButton.TabIndex = 3;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // DeleteCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 110);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.DeleteCountryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryToDeleteComboBox);
            this.Name = "DeleteCountryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteCountryForm";
            this.Load += new System.EventHandler(this.DeleteCountryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountryToDeleteComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteCountryButton;
        private System.Windows.Forms.Button FinishButton;
    }
}