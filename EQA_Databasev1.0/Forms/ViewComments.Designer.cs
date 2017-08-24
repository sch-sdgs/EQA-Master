namespace EQA_Databasev1._0.Forms
{
    partial class ViewComments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewComments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeComments = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.schemeLogID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.schemeCommentGrid = new System.Windows.Forms.DataGridView();
            this.sampleCommentsGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.schemeComment_bind = new System.Windows.Forms.BindingSource(this.components);
            this.sampleComment_bind = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemeCommentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleCommentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemeComment_bind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleComment_bind)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 51);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // closeComments
            // 
            this.closeComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeComments.BackColor = System.Drawing.SystemColors.Menu;
            this.closeComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeComments.Location = new System.Drawing.Point(593, 25);
            this.closeComments.Name = "closeComments";
            this.closeComments.Size = new System.Drawing.Size(74, 35);
            this.closeComments.TabIndex = 29;
            this.closeComments.Text = "Close";
            this.closeComments.UseVisualStyleBackColor = false;
            this.closeComments.Click += new System.EventHandler(this.closeComments_click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Scheme Log ID";
            this.label2.Visible = false;
            // 
            // schemeLogID
            // 
            this.schemeLogID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.schemeLogID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.schemeLogID.Location = new System.Drawing.Point(348, 87);
            this.schemeLogID.Name = "schemeLogID";
            this.schemeLogID.ReadOnly = true;
            this.schemeLogID.Size = new System.Drawing.Size(119, 21);
            this.schemeLogID.TabIndex = 28;
            this.schemeLogID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Results Comments";
            // 
            // schemeCommentGrid
            // 
            this.schemeCommentGrid.AllowUserToAddRows = false;
            this.schemeCommentGrid.AllowUserToDeleteRows = false;
            this.schemeCommentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schemeCommentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schemeCommentGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.schemeCommentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schemeCommentGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.schemeCommentGrid.Location = new System.Drawing.Point(44, 140);
            this.schemeCommentGrid.Name = "schemeCommentGrid";
            this.schemeCommentGrid.Size = new System.Drawing.Size(623, 276);
            this.schemeCommentGrid.TabIndex = 32;
            // 
            // sampleCommentsGrid
            // 
            this.sampleCommentsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleCommentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sampleCommentsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sampleCommentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sampleCommentsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.sampleCommentsGrid.Location = new System.Drawing.Point(44, 448);
            this.sampleCommentsGrid.Name = "sampleCommentsGrid";
            this.sampleCommentsGrid.Size = new System.Drawing.Size(623, 264);
            this.sampleCommentsGrid.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Overall Scheme Comments";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Individual Sample Comments";
            // 
            // ViewComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 734);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sampleCommentsGrid);
            this.Controls.Add(this.schemeCommentGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeComments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.schemeLogID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewComments";
            this.Text = "ViewComments";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemeCommentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleCommentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemeComment_bind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleComment_bind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeComments;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox schemeLogID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView schemeCommentGrid;
        private System.Windows.Forms.DataGridView sampleCommentsGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource schemeComment_bind;
        private System.Windows.Forms.BindingSource sampleComment_bind;
    }
}