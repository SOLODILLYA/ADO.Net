namespace MyTests
{
    partial class CreateTests
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.DelSubjectButton = new System.Windows.Forms.Button();
            this.EditSubjectButton = new System.Windows.Forms.Button();
            this.ClearSubjectButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.SubjectName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SubjectsList);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Subjects Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1059, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tests Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subjects List:";
            // 
            // SubjectsList
            // 
            this.SubjectsList.FormattingEnabled = true;
            this.SubjectsList.ItemHeight = 16;
            this.SubjectsList.Location = new System.Drawing.Point(11, 34);
            this.SubjectsList.Name = "SubjectsList";
            this.SubjectsList.Size = new System.Drawing.Size(174, 308);
            this.SubjectsList.TabIndex = 1;
            this.SubjectsList.SelectedIndexChanged += new System.EventHandler(this.SubjectsList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subjects Name:";
            // 
            // SubjectName
            // 
            this.SubjectName.Location = new System.Drawing.Point(203, 35);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(200, 22);
            this.SubjectName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearSubjectButton);
            this.groupBox1.Controls.Add(this.EditSubjectButton);
            this.groupBox1.Controls.Add(this.DelSubjectButton);
            this.groupBox1.Controls.Add(this.AddSubjectButton);
            this.groupBox1.Location = new System.Drawing.Point(203, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 269);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subjects Operations";
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Location = new System.Drawing.Point(29, 37);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(146, 39);
            this.AddSubjectButton.TabIndex = 0;
            this.AddSubjectButton.Text = "Add";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // DelSubjectButton
            // 
            this.DelSubjectButton.Location = new System.Drawing.Point(29, 96);
            this.DelSubjectButton.Name = "DelSubjectButton";
            this.DelSubjectButton.Size = new System.Drawing.Size(146, 39);
            this.DelSubjectButton.TabIndex = 1;
            this.DelSubjectButton.Text = "Delete";
            this.DelSubjectButton.UseVisualStyleBackColor = true;
            this.DelSubjectButton.Click += new System.EventHandler(this.DelSubjectButton_Click);
            // 
            // EditSubjectButton
            // 
            this.EditSubjectButton.Location = new System.Drawing.Point(29, 151);
            this.EditSubjectButton.Name = "EditSubjectButton";
            this.EditSubjectButton.Size = new System.Drawing.Size(146, 39);
            this.EditSubjectButton.TabIndex = 2;
            this.EditSubjectButton.Text = "Edit";
            this.EditSubjectButton.UseVisualStyleBackColor = true;
            this.EditSubjectButton.Click += new System.EventHandler(this.EditSubjectButton_Click);
            // 
            // ClearSubjectButton
            // 
            this.ClearSubjectButton.Location = new System.Drawing.Point(29, 211);
            this.ClearSubjectButton.Name = "ClearSubjectButton";
            this.ClearSubjectButton.Size = new System.Drawing.Size(146, 39);
            this.ClearSubjectButton.TabIndex = 3;
            this.ClearSubjectButton.Text = "Clear";
            this.ClearSubjectButton.UseVisualStyleBackColor = true;
            this.ClearSubjectButton.Click += new System.EventHandler(this.ClearSubjectButton_Click);
            // 
            // CreateTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 378);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateTests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateTests_FormClosed);
            this.Load += new System.EventHandler(this.CreateTests_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox SubjectsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearSubjectButton;
        private System.Windows.Forms.Button EditSubjectButton;
        private System.Windows.Forms.Button DelSubjectButton;
        private System.Windows.Forms.Button AddSubjectButton;
    }
}