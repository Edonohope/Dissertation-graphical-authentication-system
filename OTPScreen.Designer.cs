
namespace WindowsFormsApplication1
{
    partial class OTPScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsubotp = new System.Windows.Forms.Button();
            this.txtotp = new System.Windows.Forms.TextBox();
            this.labelotp = new System.Windows.Forms.Label();
            this.lbotp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnsubotp);
            this.panel1.Controls.Add(this.txtotp);
            this.panel1.Controls.Add(this.labelotp);
            this.panel1.Controls.Add(this.lbotp);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 433);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btnsubotp
            // 
            this.btnsubotp.BackColor = System.Drawing.Color.White;
            this.btnsubotp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnsubotp.Location = new System.Drawing.Point(537, 254);
            this.btnsubotp.Name = "btnsubotp";
            this.btnsubotp.Size = new System.Drawing.Size(279, 50);
            this.btnsubotp.TabIndex = 19;
            this.btnsubotp.Text = "Submit";
            this.btnsubotp.UseVisualStyleBackColor = false;
            this.btnsubotp.Click += new System.EventHandler(this.btnsubotp_Click);
            // 
            // txtotp
            // 
            this.txtotp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtotp.Location = new System.Drawing.Point(651, 123);
            this.txtotp.Name = "txtotp";
            this.txtotp.Size = new System.Drawing.Size(339, 37);
            this.txtotp.TabIndex = 18;
            // 
            // labelotp
            // 
            this.labelotp.AutoSize = true;
            this.labelotp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelotp.Location = new System.Drawing.Point(498, 123);
            this.labelotp.Name = "labelotp";
            this.labelotp.Size = new System.Drawing.Size(85, 31);
            this.labelotp.TabIndex = 17;
            this.labelotp.Text = "OTP :";
            // 
            // lbotp
            // 
            this.lbotp.AutoSize = true;
            this.lbotp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.lbotp.Location = new System.Drawing.Point(499, 22);
            this.lbotp.Name = "lbotp";
            this.lbotp.Size = new System.Drawing.Size(460, 29);
            this.lbotp.TabIndex = 15;
            this.lbotp.Text = "Check OTP in your email and Enter Here :";
            // 
            // OTPScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.panel1);
            this.Name = "OTPScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTPScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbotp;
        private System.Windows.Forms.TextBox txtotp;
        private System.Windows.Forms.Label labelotp;
        private System.Windows.Forms.Button btnsubotp;
        private System.Windows.Forms.Label label1;
    }
}