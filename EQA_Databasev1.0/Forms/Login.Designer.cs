namespace EQA_Databasev1._0
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.exitApp = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.usernameTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomeInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitApp
            // 
            this.exitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApp.Location = new System.Drawing.Point(296, 316);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(108, 40);
            this.exitApp.TabIndex = 34;
            this.exitApp.Text = "Exit Application";
            this.exitApp.UseVisualStyleBackColor = true;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(156, 316);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(108, 40);
            this.LoginBtn.TabIndex = 33;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTBox
            // 
            this.passwordTBox.BackColor = System.Drawing.SystemColors.Menu;
            this.passwordTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTBox.Location = new System.Drawing.Point(156, 251);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.PasswordChar = '*';
            this.passwordTBox.Size = new System.Drawing.Size(248, 21);
            this.passwordTBox.TabIndex = 32;
            // 
            // usernameTBox
            // 
            this.usernameTBox.BackColor = System.Drawing.SystemColors.Menu;
            this.usernameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTBox.Location = new System.Drawing.Point(156, 207);
            this.usernameTBox.Name = "usernameTBox";
            this.usernameTBox.Size = new System.Drawing.Size(248, 21);
            this.usernameTBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 101);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // welcomeInstruction
            // 
            this.welcomeInstruction.AutoSize = true;
            this.welcomeInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeInstruction.Location = new System.Drawing.Point(81, 173);
            this.welcomeInstruction.Name = "welcomeInstruction";
            this.welcomeInstruction.Size = new System.Drawing.Size(313, 16);
            this.welcomeInstruction.TabIndex = 36;
            this.welcomeInstruction.Text = "Please enter your Novell  Username and Password";
            // 
            // Login
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 381);
            this.Controls.Add(this.welcomeInstruction);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.passwordTBox);
            this.Controls.Add(this.usernameTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.TextBox usernameTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomeInstruction;
    }
}