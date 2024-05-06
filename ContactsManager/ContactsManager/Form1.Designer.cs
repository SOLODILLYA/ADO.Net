namespace ContactsManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearCategory = new System.Windows.Forms.Button();
            this.EditCategory = new System.Windows.Forms.Button();
            this.DeleteCategory = new System.Windows.Forms.Button();
            this.AddCategory = new System.Windows.Forms.Button();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.CategoriesList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ContactsList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ContactNotes = new System.Windows.Forms.TextBox();
            this.ContactTelegram = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ContacntEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ContactPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContactField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContactCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContactName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ClearContact = new System.Windows.Forms.Button();
            this.DeleteContact = new System.Windows.Forms.Button();
            this.EditContact = new System.Windows.Forms.Button();
            this.AddContact = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearCategory);
            this.groupBox1.Controls.Add(this.EditCategory);
            this.groupBox1.Controls.Add(this.DeleteCategory);
            this.groupBox1.Controls.Add(this.AddCategory);
            this.groupBox1.Controls.Add(this.CategoryName);
            this.groupBox1.Controls.Add(this.CategoriesList);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Management";
            // 
            // ClearCategory
            // 
            this.ClearCategory.Location = new System.Drawing.Point(108, 109);
            this.ClearCategory.Name = "ClearCategory";
            this.ClearCategory.Size = new System.Drawing.Size(86, 23);
            this.ClearCategory.TabIndex = 7;
            this.ClearCategory.Text = "Clear";
            this.ClearCategory.UseVisualStyleBackColor = true;
            // 
            // EditCategory
            // 
            this.EditCategory.Location = new System.Drawing.Point(6, 109);
            this.EditCategory.Name = "EditCategory";
            this.EditCategory.Size = new System.Drawing.Size(86, 23);
            this.EditCategory.TabIndex = 6;
            this.EditCategory.Text = "Edit";
            this.EditCategory.UseVisualStyleBackColor = true;
            // 
            // DeleteCategory
            // 
            this.DeleteCategory.Location = new System.Drawing.Point(108, 80);
            this.DeleteCategory.Name = "DeleteCategory";
            this.DeleteCategory.Size = new System.Drawing.Size(86, 23);
            this.DeleteCategory.TabIndex = 5;
            this.DeleteCategory.Text = "Delete";
            this.DeleteCategory.UseVisualStyleBackColor = true;
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(6, 80);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(86, 23);
            this.AddCategory.TabIndex = 4;
            this.AddCategory.Text = "Add";
            this.AddCategory.UseVisualStyleBackColor = true;
            // 
            // CategoryName
            // 
            this.CategoryName.Location = new System.Drawing.Point(7, 52);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(187, 22);
            this.CategoryName.TabIndex = 1;
            // 
            // CategoriesList
            // 
            this.CategoriesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesList.FormattingEnabled = true;
            this.CategoriesList.Location = new System.Drawing.Point(7, 22);
            this.CategoriesList.Name = "CategoriesList";
            this.CategoriesList.Size = new System.Drawing.Size(187, 24);
            this.CategoriesList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ContactsList);
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacts List";
            // 
            // ContactsList
            // 
            this.ContactsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsList.FormattingEnabled = true;
            this.ContactsList.ItemHeight = 16;
            this.ContactsList.Location = new System.Drawing.Point(3, 18);
            this.ContactsList.Name = "ContactsList";
            this.ContactsList.ScrollAlwaysVisible = true;
            this.ContactsList.Size = new System.Drawing.Size(194, 258);
            this.ContactsList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ContactNotes);
            this.groupBox3.Controls.Add(this.ContactTelegram);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ContacntEmail);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ContactPhone);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ContactField);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ContactCity);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ContactName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(220, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 426);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Information";
            // 
            // ContactNotes
            // 
            this.ContactNotes.Location = new System.Drawing.Point(7, 320);
            this.ContactNotes.Multiline = true;
            this.ContactNotes.Name = "ContactNotes";
            this.ContactNotes.Size = new System.Drawing.Size(236, 100);
            this.ContactNotes.TabIndex = 12;
            // 
            // ContactTelegram
            // 
            this.ContactTelegram.Location = new System.Drawing.Point(7, 291);
            this.ContactTelegram.Name = "ContactTelegram";
            this.ContactTelegram.Size = new System.Drawing.Size(236, 22);
            this.ContactTelegram.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telegram";
            // 
            // ContacntEmail
            // 
            this.ContacntEmail.Location = new System.Drawing.Point(7, 238);
            this.ContacntEmail.Name = "ContacntEmail";
            this.ContacntEmail.Size = new System.Drawing.Size(236, 22);
            this.ContacntEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // ContactPhone
            // 
            this.ContactPhone.Location = new System.Drawing.Point(7, 189);
            this.ContactPhone.Name = "ContactPhone";
            this.ContactPhone.Size = new System.Drawing.Size(236, 22);
            this.ContactPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone:";
            // 
            // ContactField
            // 
            this.ContactField.Location = new System.Drawing.Point(7, 139);
            this.ContactField.Name = "ContactField";
            this.ContactField.Size = new System.Drawing.Size(236, 22);
            this.ContactField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Field: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ContactCity
            // 
            this.ContactCity.Location = new System.Drawing.Point(7, 90);
            this.ContactCity.Name = "ContactCity";
            this.ContactCity.Size = new System.Drawing.Size(236, 22);
            this.ContactCity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "City:  ";
            // 
            // ContactName
            // 
            this.ContactName.Location = new System.Drawing.Point(7, 42);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(236, 22);
            this.ContactName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Name: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(476, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 313);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Photo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 285);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ClearContact);
            this.groupBox5.Controls.Add(this.DeleteContact);
            this.groupBox5.Controls.Add(this.EditContact);
            this.groupBox5.Controls.Add(this.AddContact);
            this.groupBox5.Location = new System.Drawing.Point(476, 333);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contact Management";
            // 
            // ClearContact
            // 
            this.ClearContact.Location = new System.Drawing.Point(148, 60);
            this.ClearContact.Name = "ClearContact";
            this.ClearContact.Size = new System.Drawing.Size(86, 23);
            this.ClearContact.TabIndex = 11;
            this.ClearContact.Text = "Clear";
            this.ClearContact.UseVisualStyleBackColor = true;
            // 
            // DeleteContact
            // 
            this.DeleteContact.Location = new System.Drawing.Point(148, 31);
            this.DeleteContact.Name = "DeleteContact";
            this.DeleteContact.Size = new System.Drawing.Size(86, 23);
            this.DeleteContact.TabIndex = 9;
            this.DeleteContact.Text = "Delete";
            this.DeleteContact.UseVisualStyleBackColor = true;
            // 
            // EditContact
            // 
            this.EditContact.Location = new System.Drawing.Point(46, 60);
            this.EditContact.Name = "EditContact";
            this.EditContact.Size = new System.Drawing.Size(86, 23);
            this.EditContact.TabIndex = 10;
            this.EditContact.Text = "Edit";
            this.EditContact.UseVisualStyleBackColor = true;
            // 
            // AddContact
            // 
            this.AddContact.Location = new System.Drawing.Point(46, 31);
            this.AddContact.Name = "AddContact";
            this.AddContact.Size = new System.Drawing.Size(86, 23);
            this.AddContact.TabIndex = 8;
            this.AddContact.Text = "Add";
            this.AddContact.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 451);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-User Contacts Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CategoriesList;
        private System.Windows.Forms.Button ClearCategory;
        private System.Windows.Forms.Button EditCategory;
        private System.Windows.Forms.Button DeleteCategory;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ContactsList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ContactCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContactName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContactField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContacntEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ContactPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContactNotes;
        private System.Windows.Forms.TextBox ContactTelegram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button ClearContact;
        private System.Windows.Forms.Button DeleteContact;
        private System.Windows.Forms.Button EditContact;
        private System.Windows.Forms.Button AddContact;
    }
}

