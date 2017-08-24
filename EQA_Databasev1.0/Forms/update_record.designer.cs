namespace EQA_Databasev1._0
{
    partial class Update_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Record));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.AddOutcome = new System.Windows.Forms.Button();
            this.SelectScheme = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AddAppeal = new System.Windows.Forms.Button();
            this.AddSample = new System.Windows.Forms.Button();
            this.schemeLogDataGrid = new System.Windows.Forms.DataGridView();
            this.addFeedbackBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchSchemeYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBodyCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.displayAllBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.deptFilterBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eQA_DatabaseDataSet = new EQA_Databasev1._0.EQA_DatabaseDataSet();
            this.schemeLogTableAdapter = new EQA_Databasev1._0.EQA_DatabaseDataSetTableAdapters.SchemeLogTableAdapter();
            this.schemeLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addQPulse = new System.Windows.Forms.Button();
            this.LogNewScheme_Btn = new System.Windows.Forms.Button();
            this.viewFeedbackGivenbtn = new System.Windows.Forms.Button();
            this.viewSamplesLoggedbtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schemeLogDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQA_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemeLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select record to update:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(189, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter by Year";
            // 
            // deleteRecord
            // 
            this.deleteRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteRecord.BackColor = System.Drawing.SystemColors.Menu;
            this.deleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecord.Location = new System.Drawing.Point(203, 511);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(113, 56);
            this.deleteRecord.TabIndex = 4;
            this.deleteRecord.Text = "Delete";
            this.deleteRecord.UseVisualStyleBackColor = false;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // AddOutcome
            // 
            this.AddOutcome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddOutcome.BackColor = System.Drawing.SystemColors.Menu;
            this.AddOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOutcome.Location = new System.Drawing.Point(436, 510);
            this.AddOutcome.Name = "AddOutcome";
            this.AddOutcome.Size = new System.Drawing.Size(113, 56);
            this.AddOutcome.TabIndex = 6;
            this.AddOutcome.Text = "Add Outcome";
            this.AddOutcome.UseVisualStyleBackColor = false;
            this.AddOutcome.Click += new System.EventHandler(this.AddOutcome_Click);
            // 
            // SelectScheme
            // 
            this.SelectScheme.HeaderText = "Select";
            this.SelectScheme.Name = "SelectScheme";
            // 
            // AddAppeal
            // 
            this.AddAppeal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddAppeal.BackColor = System.Drawing.SystemColors.Menu;
            this.AddAppeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppeal.Location = new System.Drawing.Point(555, 510);
            this.AddAppeal.Name = "AddAppeal";
            this.AddAppeal.Size = new System.Drawing.Size(113, 56);
            this.AddAppeal.TabIndex = 7;
            this.AddAppeal.Text = "Add Appeal";
            this.AddAppeal.UseVisualStyleBackColor = false;
            this.AddAppeal.Click += new System.EventHandler(this.AddAppeal_Click);
            // 
            // AddSample
            // 
            this.AddSample.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddSample.BackColor = System.Drawing.SystemColors.Menu;
            this.AddSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSample.Location = new System.Drawing.Point(322, 511);
            this.AddSample.Name = "AddSample";
            this.AddSample.Size = new System.Drawing.Size(108, 56);
            this.AddSample.TabIndex = 5;
            this.AddSample.Text = "Add Sample ";
            this.AddSample.UseVisualStyleBackColor = false;
            this.AddSample.Click += new System.EventHandler(this.AddSample_Click);
            // 
            // schemeLogDataGrid
            // 
            this.schemeLogDataGrid.AccessibleName = "schemeLogDataGrid";
            this.schemeLogDataGrid.AllowUserToAddRows = false;
            this.schemeLogDataGrid.AllowUserToDeleteRows = false;
            this.schemeLogDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schemeLogDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.schemeLogDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.schemeLogDataGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.schemeLogDataGrid.Location = new System.Drawing.Point(15, 150);
            this.schemeLogDataGrid.Name = "schemeLogDataGrid";
            this.schemeLogDataGrid.ReadOnly = true;
            this.schemeLogDataGrid.Size = new System.Drawing.Size(961, 355);
            this.schemeLogDataGrid.TabIndex = 13;
            this.schemeLogDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.colourChange_event);
            // 
            // addFeedbackBtn
            // 
            this.addFeedbackBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addFeedbackBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.addFeedbackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFeedbackBtn.Location = new System.Drawing.Point(674, 511);
            this.addFeedbackBtn.Name = "addFeedbackBtn";
            this.addFeedbackBtn.Size = new System.Drawing.Size(104, 55);
            this.addFeedbackBtn.TabIndex = 8;
            this.addFeedbackBtn.Text = "Add Feedback ";
            this.addFeedbackBtn.UseVisualStyleBackColor = false;
            this.addFeedbackBtn.Click += new System.EventHandler(this.addFeedback_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1012, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.updateClose_click);
            // 
            // searchSchemeYear
            // 
            this.searchSchemeYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchSchemeYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchSchemeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.searchSchemeYear.FormattingEnabled = true;
            this.searchSchemeYear.Items.AddRange(new object[] {
            ""});
            this.searchSchemeYear.Location = new System.Drawing.Point(310, 90);
            this.searchSchemeYear.Name = "searchSchemeYear";
            this.searchSchemeYear.Size = new System.Drawing.Size(222, 23);
            this.searchSchemeYear.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Update Records";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 51);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // searchBodyCBox
            // 
            this.searchBodyCBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchBodyCBox.BackColor = System.Drawing.SystemColors.Menu;
            this.searchBodyCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBodyCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.searchBodyCBox.FormattingEnabled = true;
            this.searchBodyCBox.IntegralHeight = false;
            this.searchBodyCBox.Items.AddRange(new object[] {
            ""});
            this.searchBodyCBox.Location = new System.Drawing.Point(705, 59);
            this.searchBodyCBox.Name = "searchBodyCBox";
            this.searchBodyCBox.Size = new System.Drawing.Size(222, 23);
            this.searchBodyCBox.Sorted = true;
            this.searchBodyCBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(553, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Filter by  EQA Body";
            // 
            // displayAllBtn
            // 
            this.displayAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayAllBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.displayAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAllBtn.Location = new System.Drawing.Point(1012, 100);
            this.displayAllBtn.Name = "displayAllBtn";
            this.displayAllBtn.Size = new System.Drawing.Size(74, 40);
            this.displayAllBtn.TabIndex = 9;
            this.displayAllBtn.Text = "Display All";
            this.displayAllBtn.UseVisualStyleBackColor = false;
            this.displayAllBtn.Click += new System.EventHandler(this.displayAllBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(139, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(837, 80);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // deptFilterBox
            // 
            this.deptFilterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deptFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptFilterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deptFilterBox.FormattingEnabled = true;
            this.deptFilterBox.Items.AddRange(new object[] {
            "",
            "Constitutional ",
            "Oncology",
            "Lab Services"});
            this.deptFilterBox.Location = new System.Drawing.Point(310, 59);
            this.deptFilterBox.Name = "deptFilterBox";
            this.deptFilterBox.Size = new System.Drawing.Size(222, 23);
            this.deptFilterBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(186, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Filter by Section";
            // 
            // eQA_DatabaseDataSet
            // 
            this.eQA_DatabaseDataSet.DataSetName = "EQA_DatabaseDataSet";
            this.eQA_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schemeLogTableAdapter
            // 
            this.schemeLogTableAdapter.ClearBeforeFill = true;
            // 
            // schemeLogBindingSource
            // 
            this.schemeLogBindingSource.DataSource = this.eQA_DatabaseDataSet;
            this.schemeLogBindingSource.Position = 0;
            // 
            // addQPulse
            // 
            this.addQPulse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addQPulse.BackColor = System.Drawing.SystemColors.Menu;
            this.addQPulse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQPulse.Location = new System.Drawing.Point(784, 511);
            this.addQPulse.Name = "addQPulse";
            this.addQPulse.Size = new System.Drawing.Size(104, 55);
            this.addQPulse.TabIndex = 8;
            this.addQPulse.Text = "Add Q-Pulse #";
            this.addQPulse.UseVisualStyleBackColor = false;
            this.addQPulse.Click += new System.EventHandler(this.addQPulse_Click);
            // 
            // LogNewScheme_Btn
            // 
            this.LogNewScheme_Btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LogNewScheme_Btn.BackColor = System.Drawing.SystemColors.Menu;
            this.LogNewScheme_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogNewScheme_Btn.Location = new System.Drawing.Point(84, 511);
            this.LogNewScheme_Btn.Name = "LogNewScheme_Btn";
            this.LogNewScheme_Btn.Size = new System.Drawing.Size(113, 56);
            this.LogNewScheme_Btn.TabIndex = 37;
            this.LogNewScheme_Btn.Text = "Log New Scheme";
            this.LogNewScheme_Btn.UseVisualStyleBackColor = false;
            this.LogNewScheme_Btn.Click += new System.EventHandler(this.logNewScheme_Click);
            // 
            // viewFeedbackGivenbtn
            // 
            this.viewFeedbackGivenbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.viewFeedbackGivenbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.viewFeedbackGivenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFeedbackGivenbtn.Location = new System.Drawing.Point(982, 223);
            this.viewFeedbackGivenbtn.Name = "viewFeedbackGivenbtn";
            this.viewFeedbackGivenbtn.Size = new System.Drawing.Size(104, 55);
            this.viewFeedbackGivenbtn.TabIndex = 39;
            this.viewFeedbackGivenbtn.Text = "View Feedback ";
            this.viewFeedbackGivenbtn.UseVisualStyleBackColor = false;
            this.viewFeedbackGivenbtn.Click += new System.EventHandler(this.viewFeedbacl_Click);
            // 
            // viewSamplesLoggedbtn
            // 
            this.viewSamplesLoggedbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.viewSamplesLoggedbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.viewSamplesLoggedbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSamplesLoggedbtn.Location = new System.Drawing.Point(982, 284);
            this.viewSamplesLoggedbtn.Name = "viewSamplesLoggedbtn";
            this.viewSamplesLoggedbtn.Size = new System.Drawing.Size(104, 55);
            this.viewSamplesLoggedbtn.TabIndex = 38;
            this.viewSamplesLoggedbtn.Text = "View Samples";
            this.viewSamplesLoggedbtn.UseVisualStyleBackColor = false;
            this.viewSamplesLoggedbtn.Click += new System.EventHandler(this.viewSamples_click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(982, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 55);
            this.button5.TabIndex = 40;
            this.button5.Text = "View  Comments";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.viewComments_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(813, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Filter results";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.filterResults_click);
            // 
            // Update_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1098, 602);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.viewFeedbackGivenbtn);
            this.Controls.Add(this.viewSamplesLoggedbtn);
            this.Controls.Add(this.LogNewScheme_Btn);
            this.Controls.Add(this.deptFilterBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBodyCBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchSchemeYear);
            this.Controls.Add(this.displayAllBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addQPulse);
            this.Controls.Add(this.addFeedbackBtn);
            this.Controls.Add(this.schemeLogDataGrid);
            this.Controls.Add(this.AddSample);
            this.Controls.Add(this.AddAppeal);
            this.Controls.Add(this.AddOutcome);
            this.Controls.Add(this.deleteRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Scheme";
            ((System.ComponentModel.ISupportInitialize)(this.schemeLogDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQA_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemeLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EQA_DatabaseDataSet eQA_DatabaseDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button AddOutcome;
        private System.Windows.Forms.Button AddAppeal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectScheme;
        private System.Windows.Forms.Button AddSample;
        public System.Windows.Forms.DataGridView schemeLogDataGrid;
        private System.Windows.Forms.Button addFeedbackBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox searchSchemeYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EQA_DatabaseDataSetTableAdapters.SchemeLogTableAdapter schemeLogTableAdapter;
        private System.Windows.Forms.BindingSource schemeLogBindingSource;
        private System.Windows.Forms.ComboBox searchBodyCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button displayAllBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox deptFilterBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addQPulse;
        private System.Windows.Forms.Button LogNewScheme_Btn;
        private System.Windows.Forms.Button viewFeedbackGivenbtn;
        private System.Windows.Forms.Button viewSamplesLoggedbtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}