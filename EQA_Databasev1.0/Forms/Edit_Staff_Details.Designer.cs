namespace EQA_Databasev1._0
{
    partial class Edit_Staff_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Staff_Details));
            this.label7 = new System.Windows.Forms.Label();
            this.staffComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newNameTBox = new System.Windows.Forms.TextBox();
            this.newEmailTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editStaffBtn = new System.Windows.Forms.Button();
            this.closeWindow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(165, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Edit Staff Details";
            // 
            // staffComboBox
            // 
            this.staffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffComboBox.FormattingEnabled = true;
            this.staffComboBox.Location = new System.Drawing.Point(214, 119);
            this.staffComboBox.Name = "staffComboBox";
            this.staffComboBox.Size = new System.Drawing.Size(253, 21);
            this.staffComboBox.TabIndex = 18;
            this.staffComboBox.Click += new System.EventHandler(this.fill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select Staff Member";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(79, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter New Name";
            // 
            // newNameTBox
            // 
            this.newNameTBox.Location = new System.Drawing.Point(214, 170);
            this.newNameTBox.Name = "newNameTBox";
            this.newNameTBox.Size = new System.Drawing.Size(253, 20);
            this.newNameTBox.TabIndex = 21;
            // 
            // newEmailTBox
            // 
            this.newEmailTBox.Location = new System.Drawing.Point(214, 220);
            this.newEmailTBox.Name = "newEmailTBox";
            this.newEmailTBox.Size = new System.Drawing.Size(253, 20);
            this.newEmailTBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(19, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Enter New Email Address";
            // 
            // editStaffBtn
            // 
            this.editStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStaffBtn.Location = new System.Drawing.Point(392, 246);
            this.editStaffBtn.Name = "editStaffBtn";
            this.editStaffBtn.Size = new System.Drawing.Size(75, 48);
            this.editStaffBtn.TabIndex = 24;
            this.editStaffBtn.Text = "Edit Staff";
            this.editStaffBtn.UseVisualStyleBackColor = true;
            this.editStaffBtn.Click += new System.EventHandler(this.editStaffBtn_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.SystemColors.Menu;
            this.closeWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow.Location = new System.Drawing.Point(400, 12);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(67, 36);
            this.closeWindow.TabIndex = 25;
            this.closeWindow.Text = "Close";
            this.closeWindow.UseVisualStyleBackColor = false;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 51);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Edit_Staff_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(472, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.editStaffBtn);
            this.Controls.Add(this.newEmailTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newNameTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffComboBox);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Staff_Details";
            this.Text = "Edit Staff Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox staffComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newNameTBox;
        private System.Windows.Forms.TextBox newEmailTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editStaffBtn;
        private System.Windows.Forms.Button closeWindow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}