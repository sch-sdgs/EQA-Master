namespace EQA_Databasev1._0.Forms
{
    partial class Add_Scheme_Comment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Scheme_Comment));
            this.label10 = new System.Windows.Forms.Label();
            this.addSchComment = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SchemeComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SchemeLogID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.capaQuery = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Add Scheme Comment";
            // 
            // addSchComment
            // 
            this.addSchComment.BackColor = System.Drawing.SystemColors.Menu;
            this.addSchComment.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSchComment.Location = new System.Drawing.Point(289, 460);
            this.addSchComment.Name = "addSchComment";
            this.addSchComment.Size = new System.Drawing.Size(96, 50);
            this.addSchComment.TabIndex = 45;
            this.addSchComment.Text = "Add Comment";
            this.addSchComment.UseVisualStyleBackColor = false;
            this.addSchComment.Click += new System.EventHandler(this.addSchComment_click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.Menu;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(337, 20);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(74, 35);
            this.close.TabIndex = 44;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 51);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // SchemeComment
            // 
            this.SchemeComment.Location = new System.Drawing.Point(45, 143);
            this.SchemeComment.Multiline = true;
            this.SchemeComment.Name = "SchemeComment";
            this.SchemeComment.Size = new System.Drawing.Size(340, 271);
            this.SchemeComment.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(41, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Comment:";
            // 
            // SchemeLogID
            // 
            this.SchemeLogID.Location = new System.Drawing.Point(254, 93);
            this.SchemeLogID.Name = "SchemeLogID";
            this.SchemeLogID.ReadOnly = true;
            this.SchemeLogID.Size = new System.Drawing.Size(47, 20);
            this.SchemeLogID.TabIndex = 40;
            this.SchemeLogID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Scheme Log ID";
            this.label2.Visible = false;
            // 
            // capaQuery
            // 
            this.capaQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.capaQuery.FormattingEnabled = true;
            this.capaQuery.Items.AddRange(new object[] {
            "CAPA",
            "Observation",
            "Not Applicable"});
            this.capaQuery.Location = new System.Drawing.Point(191, 433);
            this.capaQuery.Name = "capaQuery";
            this.capaQuery.Size = new System.Drawing.Size(194, 21);
            this.capaQuery.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "CAPA/Observation";
            // 
            // Add_Scheme_Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 531);
            this.Controls.Add(this.capaQuery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addSchComment);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SchemeComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SchemeLogID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Scheme_Comment";
            this.Text = "Add_Scheme_Comment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addSchComment;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SchemeComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox SchemeLogID;
        private System.Windows.Forms.ComboBox capaQuery;
        private System.Windows.Forms.Label label4;
    }
}