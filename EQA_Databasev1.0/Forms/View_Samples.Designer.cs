namespace EQA_Databasev1._0
{
    partial class View_Samples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Samples));
            this.sampleGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.schemeLogIDSamples = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sampleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewParticipantsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sampleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleGridView
            // 
            this.sampleGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sampleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sampleGridView.Location = new System.Drawing.Point(14, 110);
            this.sampleGridView.Name = "sampleGridView";
            this.sampleGridView.ReadOnly = true;
            this.sampleGridView.Size = new System.Drawing.Size(416, 339);
            this.sampleGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sample View";
            // 
            // schemeLogIDSamples
            // 
            this.schemeLogIDSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.schemeLogIDSamples.Location = new System.Drawing.Point(250, 73);
            this.schemeLogIDSamples.Name = "schemeLogIDSamples";
            this.schemeLogIDSamples.ReadOnly = true;
            this.schemeLogIDSamples.Size = new System.Drawing.Size(63, 21);
            this.schemeLogIDSamples.TabIndex = 2;
            this.schemeLogIDSamples.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scheme Log ID";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.sampleViewClose_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 51);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // viewParticipantsBtn
            // 
            this.viewParticipantsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewParticipantsBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.viewParticipantsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewParticipantsBtn.Location = new System.Drawing.Point(267, 455);
            this.viewParticipantsBtn.Name = "viewParticipantsBtn";
            this.viewParticipantsBtn.Size = new System.Drawing.Size(163, 26);
            this.viewParticipantsBtn.TabIndex = 35;
            this.viewParticipantsBtn.Text = "Sample Participant Log";
            this.viewParticipantsBtn.UseVisualStyleBackColor = false;
            this.viewParticipantsBtn.Click += new System.EventHandler(this.viewParticipantsBtn_Click);
            // 
            // View_Samples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(442, 493);
            this.Controls.Add(this.viewParticipantsBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.schemeLogIDSamples);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sampleGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_Samples";
            this.Text = "View Samples";
            ((System.ComponentModel.ISupportInitialize)(this.sampleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox schemeLogIDSamples;
        public System.Windows.Forms.BindingSource sampleViewBindingSource;
        public System.Windows.Forms.DataGridView sampleGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewParticipantsBtn;
    }
}