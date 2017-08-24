namespace EQA_Databasev1._0.Forms
{
    partial class Add_Qpulse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Qpulse));
            this.addQPulseBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addQPulsebtn = new System.Windows.Forms.Button();
            this.schemeLogIDBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addQPulseBox
            // 
            this.addQPulseBox.Location = new System.Drawing.Point(15, 46);
            this.addQPulseBox.Name = "addQPulseBox";
            this.addQPulseBox.Size = new System.Drawing.Size(231, 20);
            this.addQPulseBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter Q-Pulse Audit Number";
            // 
            // addQPulsebtn
            // 
            this.addQPulsebtn.Location = new System.Drawing.Point(171, 72);
            this.addQPulsebtn.Name = "addQPulsebtn";
            this.addQPulsebtn.Size = new System.Drawing.Size(75, 23);
            this.addQPulsebtn.TabIndex = 2;
            this.addQPulsebtn.Text = "Add Audit";
            this.addQPulsebtn.UseVisualStyleBackColor = true;
            this.addQPulsebtn.Click += new System.EventHandler(this.addAudit_click);
            // 
            // schemeLogIDBox
            // 
            this.schemeLogIDBox.Location = new System.Drawing.Point(15, 72);
            this.schemeLogIDBox.Name = "schemeLogIDBox";
            this.schemeLogIDBox.Size = new System.Drawing.Size(40, 20);
            this.schemeLogIDBox.TabIndex = 3;
            this.schemeLogIDBox.Visible = false;
            // 
            // Add_Qpulse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 106);
            this.Controls.Add(this.schemeLogIDBox);
            this.Controls.Add(this.addQPulsebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addQPulseBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Qpulse";
            this.Text = "Add_Qpulse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addQPulseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addQPulsebtn;
        public System.Windows.Forms.TextBox schemeLogIDBox;
    }
}