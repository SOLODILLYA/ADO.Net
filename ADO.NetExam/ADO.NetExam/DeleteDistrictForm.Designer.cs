namespace ADO.NetExam
{
    partial class DeleteDistrictForm
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
            this.SeleteDistrictButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeleteDistrictButton
            // 
            this.SeleteDistrictButton.Location = new System.Drawing.Point(39, 142);
            this.SeleteDistrictButton.Name = "SeleteDistrictButton";
            this.SeleteDistrictButton.Size = new System.Drawing.Size(97, 46);
            this.SeleteDistrictButton.TabIndex = 35;
            this.SeleteDistrictButton.Text = "Delete Selected District";
            this.SeleteDistrictButton.UseVisualStyleBackColor = true;
            this.SeleteDistrictButton.Click += new System.EventHandler(this.SeleteDistrictButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "District Name: ";
            // 
            // CityComboBox
            // 
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(12, 70);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(147, 21);
            this.CityComboBox.TabIndex = 33;
            this.CityComboBox.SelectedIndexChanged += new System.EventHandler(this.CityComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "City: ";
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Location = new System.Drawing.Point(12, 26);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(147, 21);
            this.CountryComboBox.TabIndex = 31;
            this.CountryComboBox.SelectedIndexChanged += new System.EventHandler(this.CountryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Country: ";
            // 
            // DistrictComboBox
            // 
            this.DistrictComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DistrictComboBox.FormattingEnabled = true;
            this.DistrictComboBox.Location = new System.Drawing.Point(12, 116);
            this.DistrictComboBox.Name = "DistrictComboBox";
            this.DistrictComboBox.Size = new System.Drawing.Size(147, 21);
            this.DistrictComboBox.TabIndex = 36;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(39, 194);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(97, 46);
            this.FinishButton.TabIndex = 37;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // DeleteDistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 248);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.DistrictComboBox);
            this.Controls.Add(this.SeleteDistrictButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountryComboBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteDistrictForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteDistrictForm";
            this.Load += new System.EventHandler(this.DeleteDistrictForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SeleteDistrictButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DistrictComboBox;
        private System.Windows.Forms.Button FinishButton;
    }
}