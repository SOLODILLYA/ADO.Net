namespace ADO.NetExam
{
    partial class Adminka
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
            this.ContractsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCountry = new System.Windows.Forms.Button();
            this.AddCity = new System.Windows.Forms.Button();
            this.AddDistrict = new System.Windows.Forms.Button();
            this.AddFlat = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.DeleteFlatButton = new System.Windows.Forms.Button();
            this.DeleteDistrictButton = new System.Windows.Forms.Button();
            this.DeleteCityButton = new System.Windows.Forms.Button();
            this.DeleteCountryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContractsList
            // 
            this.ContractsList.FormattingEnabled = true;
            this.ContractsList.Location = new System.Drawing.Point(13, 39);
            this.ContractsList.Name = "ContractsList";
            this.ContractsList.Size = new System.Drawing.Size(242, 277);
            this.ContractsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contracts:";
            // 
            // AddCountry
            // 
            this.AddCountry.Location = new System.Drawing.Point(261, 39);
            this.AddCountry.Name = "AddCountry";
            this.AddCountry.Size = new System.Drawing.Size(81, 40);
            this.AddCountry.TabIndex = 2;
            this.AddCountry.Text = "Add Country";
            this.AddCountry.UseVisualStyleBackColor = true;
            this.AddCountry.Click += new System.EventHandler(this.AddCountry_Click);
            // 
            // AddCity
            // 
            this.AddCity.Location = new System.Drawing.Point(261, 85);
            this.AddCity.Name = "AddCity";
            this.AddCity.Size = new System.Drawing.Size(81, 40);
            this.AddCity.TabIndex = 3;
            this.AddCity.Text = "Add City";
            this.AddCity.UseVisualStyleBackColor = true;
            this.AddCity.Click += new System.EventHandler(this.AddCity_Click);
            // 
            // AddDistrict
            // 
            this.AddDistrict.Location = new System.Drawing.Point(261, 131);
            this.AddDistrict.Name = "AddDistrict";
            this.AddDistrict.Size = new System.Drawing.Size(81, 40);
            this.AddDistrict.TabIndex = 4;
            this.AddDistrict.Text = "Add District";
            this.AddDistrict.UseVisualStyleBackColor = true;
            this.AddDistrict.Click += new System.EventHandler(this.AddDistrict_Click);
            // 
            // AddFlat
            // 
            this.AddFlat.Location = new System.Drawing.Point(261, 177);
            this.AddFlat.Name = "AddFlat";
            this.AddFlat.Size = new System.Drawing.Size(81, 40);
            this.AddFlat.TabIndex = 5;
            this.AddFlat.Text = "Add Flat";
            this.AddFlat.UseVisualStyleBackColor = true;
            this.AddFlat.Click += new System.EventHandler(this.AddFlat_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(305, 269);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(81, 40);
            this.FinishButton.TabIndex = 6;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(261, 224);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(81, 40);
            this.AddUserButton.TabIndex = 7;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(348, 224);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(81, 40);
            this.DeleteUser.TabIndex = 12;
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // DeleteFlatButton
            // 
            this.DeleteFlatButton.Location = new System.Drawing.Point(348, 177);
            this.DeleteFlatButton.Name = "DeleteFlatButton";
            this.DeleteFlatButton.Size = new System.Drawing.Size(81, 40);
            this.DeleteFlatButton.TabIndex = 11;
            this.DeleteFlatButton.Text = "Delete Flat";
            this.DeleteFlatButton.UseVisualStyleBackColor = true;
            this.DeleteFlatButton.Click += new System.EventHandler(this.DeleteFlatButton_Click);
            // 
            // DeleteDistrictButton
            // 
            this.DeleteDistrictButton.Location = new System.Drawing.Point(348, 131);
            this.DeleteDistrictButton.Name = "DeleteDistrictButton";
            this.DeleteDistrictButton.Size = new System.Drawing.Size(81, 40);
            this.DeleteDistrictButton.TabIndex = 10;
            this.DeleteDistrictButton.Text = "Delete District";
            this.DeleteDistrictButton.UseVisualStyleBackColor = true;
            this.DeleteDistrictButton.Click += new System.EventHandler(this.DeleteDistrictButton_Click);
            // 
            // DeleteCityButton
            // 
            this.DeleteCityButton.Location = new System.Drawing.Point(348, 85);
            this.DeleteCityButton.Name = "DeleteCityButton";
            this.DeleteCityButton.Size = new System.Drawing.Size(81, 40);
            this.DeleteCityButton.TabIndex = 9;
            this.DeleteCityButton.Text = "Delete City";
            this.DeleteCityButton.UseVisualStyleBackColor = true;
            this.DeleteCityButton.Click += new System.EventHandler(this.DeleteCityButton_Click);
            // 
            // DeleteCountryButton
            // 
            this.DeleteCountryButton.Location = new System.Drawing.Point(348, 39);
            this.DeleteCountryButton.Name = "DeleteCountryButton";
            this.DeleteCountryButton.Size = new System.Drawing.Size(81, 40);
            this.DeleteCountryButton.TabIndex = 8;
            this.DeleteCountryButton.Text = "Delete Country";
            this.DeleteCountryButton.UseVisualStyleBackColor = true;
            this.DeleteCountryButton.Click += new System.EventHandler(this.DeleteCountryButton_Click);
            // 
            // Adminka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 321);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.DeleteFlatButton);
            this.Controls.Add(this.DeleteDistrictButton);
            this.Controls.Add(this.DeleteCityButton);
            this.Controls.Add(this.DeleteCountryButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.AddFlat);
            this.Controls.Add(this.AddDistrict);
            this.Controls.Add(this.AddCity);
            this.Controls.Add(this.AddCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContractsList);
            this.Name = "Adminka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminka";
            this.Load += new System.EventHandler(this.Adminka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ContractsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCountry;
        private System.Windows.Forms.Button AddCity;
        private System.Windows.Forms.Button AddDistrict;
        private System.Windows.Forms.Button AddFlat;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button DeleteFlatButton;
        private System.Windows.Forms.Button DeleteDistrictButton;
        private System.Windows.Forms.Button DeleteCityButton;
        private System.Windows.Forms.Button DeleteCountryButton;
    }
}