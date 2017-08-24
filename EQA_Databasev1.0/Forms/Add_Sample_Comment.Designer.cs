namespace EQA_Databasev1._0.Forms
{
    partial class Add_Sample_Comment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Sample_Comment));
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SampleDropDown = new System.Windows.Forms.ComboBox();
            this.samplesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SampleComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Button();
            this.addComment = new System.Windows.Forms.Button();
            this.capaQuery = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.samplesTableAdapter = new EQA_Databasev1._0.EQAMDataSetTableAdapters.SamplesTableAdapter();
            this.SchemeLogID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.samplesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Add Sample Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Scheme Log ID";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Choose Sample:";
            // 
            // SampleDropDown
            // 
            this.SampleDropDown.DataSource = this.samplesBindingSource;
            this.SampleDropDown.DisplayMember = "SampleStarlimsRef";
            this.SampleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SampleDropDown.FormattingEnabled = true;
            this.SampleDropDown.Location = new System.Drawing.Point(201, 117);
            this.SampleDropDown.Name = "SampleDropDown";
            this.SampleDropDown.Size = new System.Drawing.Size(194, 21);
            this.SampleDropDown.TabIndex = 22;
            this.SampleDropDown.ValueMember = "SampleID";
            this.SampleDropDown.Click += new System.EventHandler(this.sampleDropDown_click);
            // 
            // SampleComment
            // 
            this.SampleComment.Location = new System.Drawing.Point(55, 181);
            this.SampleComment.Multiline = true;
            this.SampleComment.Name = "SampleComment";
            this.SampleComment.Size = new System.Drawing.Size(340, 241);
            this.SampleComment.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(51, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Comment:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 51);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.Menu;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(339, 15);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(74, 35);
            this.close.TabIndex = 34;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_click);
            // 
            // addComment
            // 
            this.addComment.BackColor = System.Drawing.SystemColors.Menu;
            this.addComment.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addComment.Location = new System.Drawing.Point(299, 482);
            this.addComment.Name = "addComment";
            this.addComment.Size = new System.Drawing.Size(96, 50);
            this.addComment.TabIndex = 35;
            this.addComment.Text = "Add Comment";
            this.addComment.UseVisualStyleBackColor = false;
            this.addComment.Click += new System.EventHandler(this.addComment_click);
            // 
            // capaQuery
            // 
            this.capaQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.capaQuery.FormattingEnabled = true;
            this.capaQuery.Items.AddRange(new object[] {
            "CAPA",
            "Observation",
            "Not Applicable"});
            this.capaQuery.Location = new System.Drawing.Point(201, 447);
            this.capaQuery.Name = "capaQuery";
            this.capaQuery.Size = new System.Drawing.Size(194, 21);
            this.capaQuery.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "CAPA/Observation";
            // 
            // samplesTableAdapter
            // 
            this.samplesTableAdapter.ClearBeforeFill = true;
            // 
            // SchemeLogID
            // 
            this.SchemeLogID.Cursor = System.Windows.Forms.Cursors.No;
            this.SchemeLogID.Location = new System.Drawing.Point(241, 79);
            this.SchemeLogID.Name = "SchemeLogID";
            this.SchemeLogID.ReadOnly = true;
            this.SchemeLogID.Size = new System.Drawing.Size(52, 20);
            this.SchemeLogID.TabIndex = 39;
            this.SchemeLogID.Visible = false;
            // 
            // Add_Sample_Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 544);
            this.Controls.Add(this.SchemeLogID);
            this.Controls.Add(this.capaQuery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addComment);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SampleComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SampleDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Sample_Comment";
            this.Text = "Add_Sample_Comment";
            ((System.ComponentModel.ISupportInitialize)(this.samplesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SampleDropDown;
        private System.Windows.Forms.TextBox SampleComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button addComment;
        private System.Windows.Forms.ComboBox capaQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource samplesBindingSource;
        private EQAMDataSetTableAdapters.SamplesTableAdapter samplesTableAdapter;
        public System.Windows.Forms.TextBox SchemeLogID;
    }
}