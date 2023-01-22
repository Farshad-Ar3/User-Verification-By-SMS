namespace User_Verification_By_SMS
{
    partial class Form1
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
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblGetTheCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnGetTheCode = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(147, 25);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(245, 22);
            this.txtMobile.TabIndex = 0;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(413, 28);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(45, 14);
            this.lblMobile.TabIndex = 1;
            this.lblMobile.Text = "موبایل :";
            // 
            // lblGetTheCode
            // 
            this.lblGetTheCode.AutoSize = true;
            this.lblGetTheCode.Location = new System.Drawing.Point(413, 75);
            this.lblGetTheCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGetTheCode.Name = "lblGetTheCode";
            this.lblGetTheCode.Size = new System.Drawing.Size(28, 14);
            this.lblGetTheCode.TabIndex = 3;
            this.lblGetTheCode.Text = "کد :";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(147, 69);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(245, 22);
            this.txtCode.TabIndex = 2;
            // 
            // btnGetTheCode
            // 
            this.btnGetTheCode.Location = new System.Drawing.Point(14, 22);
            this.btnGetTheCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetTheCode.Name = "btnGetTheCode";
            this.btnGetTheCode.Size = new System.Drawing.Size(126, 39);
            this.btnGetTheCode.TabIndex = 4;
            this.btnGetTheCode.Text = "دریافت کد";
            this.btnGetTheCode.UseVisualStyleBackColor = true;
            this.btnGetTheCode.Click += new System.EventHandler(this.btnGetTheCode_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(14, 62);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 39);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "زمان باقی مانده :";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(248, 120);
            this.lblRemainingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(0, 14);
            this.lblRemainingTime.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 152);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnGetTheCode);
            this.Controls.Add(this.lblGetTheCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtMobile);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فعال سازی پیامکی";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblGetTheCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnGetTheCode;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Timer timer1;
    }
}

