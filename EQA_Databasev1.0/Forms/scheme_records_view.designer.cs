namespace EQA_Databasev1._0
{
    partial class Scheme_Records_View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scheme_Records_View));
            this.recordViewGrid = new System.Windows.Forms.DataGridView();
            this.recordViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.eqaBodyCBox = new System.Windows.Forms.ComboBox();
            this.yearCBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displayAllBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.schemeYearTextBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.deptFilterBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemeYearTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // recordViewGrid
            // 
            this.recordViewGrid.AllowUserToAddRows = false;
            this.recordViewGrid.AllowUserToDeleteRows = false;
            this.recordViewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordViewGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.recordViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordViewGrid.Location = new System.Drawing.Point(22, 79);
            this.recordViewGrid.Name = "recordViewGrid";
            this.recordViewGrid.ReadOnly = true;
            this.recordViewGrid.Size = new System.Drawing.Size(769, 559);
            this.recordViewGrid.TabIndex = 0;
            this.recordViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urlLink_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(826, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter by EQA Body";
            // 
            // eqaBodyCBox
            // 
            this.eqaBodyCBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eqaBodyCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eqaBodyCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eqaBodyCBox.FormattingEnabled = true;
            this.eqaBodyCBox.Location = new System.Drawing.Point(829, 206);
            this.eqaBodyCBox.Name = "eqaBodyCBox";
            this.eqaBodyCBox.Size = new System.Drawing.Size(279, 23);
            this.eqaBodyCBox.Sorted = true;
            this.eqaBodyCBox.TabIndex = 4;
            // 
            // yearCBox
            // 
            this.yearCBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.yearCBox.FormattingEnabled = true;
            this.yearCBox.Location = new System.Drawing.Point(829, 157);
            this.yearCBox.Name = "yearCBox";
            this.yearCBox.Size = new System.Drawing.Size(279, 23);
            this.yearCBox.Sorted = true;
            this.yearCBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1050, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 35);
            this.button2.TabIndex = 25;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.recordView_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(355, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 26);
            this.label10.TabIndex = 30;
            this.label10.Text = "Records Review";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 51);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // displayAllBtn
            // 
            this.displayAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayAllBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.displayAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAllBtn.Location = new System.Drawing.Point(717, 33);
            this.displayAllBtn.Name = "displayAllBtn";
            this.displayAllBtn.Size = new System.Drawing.Size(74, 40);
            this.displayAllBtn.TabIndex = 32;
            this.displayAllBtn.Text = "Display All";
            this.displayAllBtn.UseVisualStyleBackColor = false;
            this.displayAllBtn.Click += new System.EventHandler(this.displayAllBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(805, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 210);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker2.Location = new System.Drawing.Point(873, 437);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker2.TabIndex = 34;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker3.Location = new System.Drawing.Point(873, 411);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker3.TabIndex = 34;
            this.dateTimePicker3.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(826, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filter by Year";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(802, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "From";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(818, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            this.label4.Visible = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1038, 409);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 48);
            this.button6.TabIndex = 15;
            this.button6.Text = "Create file";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.getQuarterlyReview_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(802, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Get Yearly Review Report";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(802, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Get Quarterly Review Report:";
            this.label6.Visible = false;
            // 
            // schemeYearTextBox
            // 
            this.schemeYearTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.schemeYearTextBox.Location = new System.Drawing.Point(873, 552);
            this.schemeYearTextBox.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.schemeYearTextBox.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.schemeYearTextBox.Name = "schemeYearTextBox";
            this.schemeYearTextBox.Size = new System.Drawing.Size(145, 20);
            this.schemeYearTextBox.TabIndex = 35;
            this.schemeYearTextBox.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.schemeYearTextBox.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(818, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Year";
            this.label7.Visible = false;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.BackColor = System.Drawing.SystemColors.Menu;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(1038, 538);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 44);
            this.button8.TabIndex = 15;
            this.button8.Text = "Create file";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.getYearlyReview_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(846, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Create Q-Pulse Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.qpulseReport_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(826, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "Filter by Section";
            // 
            // deptFilterBox
            // 
            this.deptFilterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deptFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptFilterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deptFilterBox.FormattingEnabled = true;
            this.deptFilterBox.Items.AddRange(new object[] {
            "Constitutional",
            "Lab Services",
            "Oncology"});
            this.deptFilterBox.Location = new System.Drawing.Point(829, 110);
            this.deptFilterBox.Name = "deptFilterBox";
            this.deptFilterBox.Size = new System.Drawing.Size(279, 23);
            this.deptFilterBox.Sorted = true;
            this.deptFilterBox.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(994, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Filter results";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.filterResults_Click);
            // 
            // Scheme_Records_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1136, 670);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deptFilterBox);
            this.Controls.Add(this.schemeYearTextBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.displayAllBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearCBox);
            this.Controls.Add(this.eqaBodyCBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordViewGrid);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scheme_Records_View";
            this.Text = "View Logged Schemes";
            ((System.ComponentModel.ISupportInitialize)(this.recordViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemeYearTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recordViewGrid;
        private System.Windows.Forms.BindingSource recordViewBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eqaBodyCBox;
        private System.Windows.Forms.ComboBox yearCBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button displayAllBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown schemeYearTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox deptFilterBox;
        private System.Windows.Forms.Button button3;
    }
}