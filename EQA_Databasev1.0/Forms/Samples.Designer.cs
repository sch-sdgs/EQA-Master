namespace EQA_Databasev1._0
{
    partial class Samples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Samples));
            this.label1 = new System.Windows.Forms.Label();
            this.addSampleBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.samplesSchemeIDTBox = new System.Windows.Forms.TextBox();
            this.sampleTypeTextBox = new System.Windows.Forms.TextBox();
            this.starLimsRefTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Sample Information";
            // 
            // addSampleBtn
            // 
            this.addSampleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSampleBtn.Location = new System.Drawing.Point(354, 223);
            this.addSampleBtn.Name = "addSampleBtn";
            this.addSampleBtn.Size = new System.Drawing.Size(94, 35);
            this.addSampleBtn.TabIndex = 4;
            this.addSampleBtn.Text = "Add Sample";
            this.addSampleBtn.UseVisualStyleBackColor = true;
            this.addSampleBtn.Click += new System.EventHandler(this.addSampleBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(390, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.samplesClose_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 51);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scheme Log ID";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sample Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "StarLIMS S Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // samplesSchemeIDTBox
            // 
            this.samplesSchemeIDTBox.BackColor = System.Drawing.SystemColors.Menu;
            this.samplesSchemeIDTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.samplesSchemeIDTBox.Location = new System.Drawing.Point(208, 102);
            this.samplesSchemeIDTBox.Name = "samplesSchemeIDTBox";
            this.samplesSchemeIDTBox.ReadOnly = true;
            this.samplesSchemeIDTBox.Size = new System.Drawing.Size(240, 21);
            this.samplesSchemeIDTBox.TabIndex = 1;
            this.samplesSchemeIDTBox.Visible = false;
            // 
            // sampleTypeTextBox
            // 
            this.sampleTypeTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.sampleTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sampleTypeTextBox.Location = new System.Drawing.Point(208, 139);
            this.sampleTypeTextBox.Name = "sampleTypeTextBox";
            this.sampleTypeTextBox.Size = new System.Drawing.Size(240, 21);
            this.sampleTypeTextBox.TabIndex = 2;
            // 
            // starLimsRefTextBox
            // 
            this.starLimsRefTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.starLimsRefTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.starLimsRefTextBox.Location = new System.Drawing.Point(208, 182);
            this.starLimsRefTextBox.Name = "starLimsRefTextBox";
            this.starLimsRefTextBox.Size = new System.Drawing.Size(240, 21);
            this.starLimsRefTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "*Optional";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 1;
            // 
            // Samples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(476, 285);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addSampleBtn);
            this.Controls.Add(this.starLimsRefTextBox);
            this.Controls.Add(this.sampleTypeTextBox);
            this.Controls.Add(this.samplesSchemeIDTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Samples";
            this.Text = "Add Samples";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSampleBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox samplesSchemeIDTBox;
        private System.Windows.Forms.TextBox sampleTypeTextBox;
        private System.Windows.Forms.TextBox starLimsRefTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
    }
}