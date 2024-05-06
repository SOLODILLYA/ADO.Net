namespace MyTests
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearSubjectButton = new System.Windows.Forms.Button();
            this.EditSubjectButton = new System.Windows.Forms.Button();
            this.DelSubjectButton = new System.Windows.Forms.Button();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsersList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearSubjectButton);
            this.groupBox1.Controls.Add(this.EditSubjectButton);
            this.groupBox1.Controls.Add(this.DelSubjectButton);
            this.groupBox1.Controls.Add(this.AddSubjectButton);
            this.groupBox1.Location = new System.Drawing.Point(204, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 188);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Operations";
            // 
            // ClearSubjectButton
            // 
            this.ClearSubjectButton.Location = new System.Drawing.Point(28, 142);
            this.ClearSubjectButton.Name = "ClearSubjectButton";
            this.ClearSubjectButton.Size = new System.Drawing.Size(146, 39);
            this.ClearSubjectButton.TabIndex = 3;
            this.ClearSubjectButton.Text = "Clear";
            this.ClearSubjectButton.UseVisualStyleBackColor = true;
            this.ClearSubjectButton.Click += new System.EventHandler(this.ClearSubjectButton_Click);
            // 
            // EditSubjectButton
            // 
            this.EditSubjectButton.Location = new System.Drawing.Point(28, 101);
            this.EditSubjectButton.Name = "EditSubjectButton";
            this.EditSubjectButton.Size = new System.Drawing.Size(146, 39);
            this.EditSubjectButton.TabIndex = 2;
            this.EditSubjectButton.Text = "Edit";
            this.EditSubjectButton.UseVisualStyleBackColor = true;
            this.EditSubjectButton.Click += new System.EventHandler(this.EditSubjectButton_Click);
            // 
            // DelSubjectButton
            // 
            this.DelSubjectButton.Location = new System.Drawing.Point(28, 61);
            this.DelSubjectButton.Name = "DelSubjectButton";
            this.DelSubjectButton.Size = new System.Drawing.Size(146, 39);
            this.DelSubjectButton.TabIndex = 1;
            this.DelSubjectButton.Text = "Delete";
            this.DelSubjectButton.UseVisualStyleBackColor = true;
            this.DelSubjectButton.Click += new System.EventHandler(this.DelSubjectButton_Click);
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Location = new System.Drawing.Point(28, 21);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(146, 39);
            this.AddSubjectButton.TabIndex = 0;
            this.AddSubjectButton.Text = "Add";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(204, 29);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(200, 20);
            this.UserName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User Name:";
            // 
            // UsersList
            // 
            this.UsersList.FormattingEnabled = true;
            this.UsersList.Location = new System.Drawing.Point(12, 28);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(174, 303);
            this.UsersList.TabIndex = 6;
            this.UsersList.SelectedIndexChanged += new System.EventHandler(this.UsersList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Users List:";
            // 
            // UserLogin
            // 
            this.UserLogin.Location = new System.Drawing.Point(204, 74);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(200, 20);
            this.UserLogin.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Login:";
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(204, 122);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(200, 20);
            this.UserPassword.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "User Password:";
            // 
            // Adminka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 340);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsersList);
            this.Controls.Add(this.label1);
            this.Name = "Adminka";
            this.Text = "Adminka";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Adminka_FormClosed);
            this.Load += new System.EventHandler(this.Adminka_Load);
            this.Leave += new System.EventHandler(this.Adminka_Leave);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearSubjectButton;
        private System.Windows.Forms.Button EditSubjectButton;
        private System.Windows.Forms.Button DelSubjectButton;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox UsersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Label label4;
    }
}