namespace CCAuthorizer___AuthorizeAPI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.TransactionKeyLabel = new System.Windows.Forms.Label();
            this.TransactionKeyBox = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.ReportingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.SystemColors.Window;
            this.LoginBox.Location = new System.Drawing.Point(123, 42);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(137, 20);
            this.LoginBox.TabIndex = 0;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(30, 45);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(50, 13);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login ID:";
            // 
            // TransactionKeyLabel
            // 
            this.TransactionKeyLabel.AutoSize = true;
            this.TransactionKeyLabel.Location = new System.Drawing.Point(30, 71);
            this.TransactionKeyLabel.Name = "TransactionKeyLabel";
            this.TransactionKeyLabel.Size = new System.Drawing.Size(87, 13);
            this.TransactionKeyLabel.TabIndex = 3;
            this.TransactionKeyLabel.Text = "Transaction Key:";
            // 
            // TransactionKeyBox
            // 
            this.TransactionKeyBox.BackColor = System.Drawing.SystemColors.Window;
            this.TransactionKeyBox.Location = new System.Drawing.Point(123, 68);
            this.TransactionKeyBox.Name = "TransactionKeyBox";
            this.TransactionKeyBox.Size = new System.Drawing.Size(137, 20);
            this.TransactionKeyBox.TabIndex = 2;
            this.TransactionKeyBox.UseSystemPasswordChar = true;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(53, 104);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(190, 23);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // ReportingLabel
            // 
            this.ReportingLabel.Location = new System.Drawing.Point(53, 9);
            this.ReportingLabel.Name = "ReportingLabel";
            this.ReportingLabel.Size = new System.Drawing.Size(190, 13);
            this.ReportingLabel.TabIndex = 6;
            this.ReportingLabel.Text = "Please Sign In";
            this.ReportingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 141);
            this.Controls.Add(this.ReportingLabel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.TransactionKeyLabel);
            this.Controls.Add(this.TransactionKeyBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Merchant Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label TransactionKeyLabel;
        private System.Windows.Forms.TextBox TransactionKeyBox;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label ReportingLabel;
    }
}

