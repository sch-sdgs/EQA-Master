namespace EQA_Databasev1._0
{
    partial class StartUp_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp_Form));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.closeApp = new System.Windows.Forms.Button();
            this.addStaffLead = new System.Windows.Forms.Button();
            this.viewRecordsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(107, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Schemes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.updateSchemeOption_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(184, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update EQA Schemes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.addNewSchemeOption_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to EQA-Master";
            // 
            // closeApp
            // 
            this.closeApp.BackColor = System.Drawing.SystemColors.Menu;
            this.closeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeApp.Location = new System.Drawing.Point(396, 26);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(98, 29);
            this.closeApp.TabIndex = 6;
            this.closeApp.Text = "Log out";
            this.closeApp.UseVisualStyleBackColor = false;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // addStaffLead
            // 
            this.addStaffLead.BackColor = System.Drawing.SystemColors.Menu;
            this.addStaffLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffLead.Location = new System.Drawing.Point(342, 215);
            this.addStaffLead.Name = "addStaffLead";
            this.addStaffLead.Size = new System.Drawing.Size(152, 56);
            this.addStaffLead.TabIndex = 4;
            this.addStaffLead.Text = "Edit Staff ";
            this.addStaffLead.UseVisualStyleBackColor = false;
            this.addStaffLead.Click += new System.EventHandler(this.addStaffLead_Click);
            // 
            // viewRecordsBtn
            // 
            this.viewRecordsBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.viewRecordsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecordsBtn.Location = new System.Drawing.Point(265, 91);
            this.viewRecordsBtn.Name = "viewRecordsBtn";
            this.viewRecordsBtn.Size = new System.Drawing.Size(152, 56);
            this.viewRecordsBtn.TabIndex = 5;
            this.viewRecordsBtn.Text = "Scheme Review";
            this.viewRecordsBtn.UseVisualStyleBackColor = false;
            this.viewRecordsBtn.Click += new System.EventHandler(this.viewRecordsBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update EQA Bodies";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.updateBodyOption_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 51);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "EQA-Master Admin:";
            // 
            // StartUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(519, 297);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewRecordsBtn);
            this.Controls.Add(this.closeApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addStaffLead);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUp_Form";
            this.Text = "Welcome to EQA-Master!";
            this.Load += new System.EventHandler(this.StartUp_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeApp;
        private System.Windows.Forms.Button addStaffLead;
        private System.Windows.Forms.Button viewRecordsBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}