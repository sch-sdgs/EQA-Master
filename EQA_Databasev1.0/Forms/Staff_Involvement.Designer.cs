namespace EQA_Databasev1._0
{
    partial class Staff_Involvement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Involvement));
            this.label3 = new System.Windows.Forms.Label();
            this.getSRefText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.viewSampleLog = new System.Windows.Forms.DataGridView();
            this.viewReportingLog = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.samplesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSampleLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewReportingLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // getSRefText
            // 
            resources.ApplyResources(this.getSRefText, "getSRefText");
            this.getSRefText.Name = "getSRefText";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // viewSampleLog
            // 
            this.viewSampleLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewSampleLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.viewSampleLog, "viewSampleLog");
            this.viewSampleLog.Name = "viewSampleLog";
            // 
            // viewReportingLog
            // 
            this.viewReportingLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewReportingLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.viewReportingLog, "viewReportingLog");
            this.viewReportingLog.Name = "viewReportingLog";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sampleLog_click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.rptLog_click);
            // 
            // Staff_Involvement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewReportingLog);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.getSRefText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewSampleLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Staff_Involvement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSampleLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewReportingLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox getSRefText;
        private System.Windows.Forms.BindingSource samplesBindingSource;
        private System.Windows.Forms.BindingSource reportingBindingSource;
        private System.Windows.Forms.DataGridView viewSampleLog;
        private System.Windows.Forms.DataGridView viewReportingLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}