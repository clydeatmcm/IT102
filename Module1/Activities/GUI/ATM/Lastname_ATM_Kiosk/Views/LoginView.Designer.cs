namespace Lastname_ATM_Kiosk
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtAccountNumber = new TextBox();
            txtPin = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(243, 60);
            label1.Name = "label1";
            label1.Size = new Size(492, 41);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Lastname ATM Kiosk ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 167);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 1;
            label2.Text = "Account Number";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(311, 219);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(357, 31);
            txtAccountNumber.TabIndex = 2;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(311, 337);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(357, 31);
            txtPin.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 285);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 3;
            label3.Text = "PIN";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(309, 413);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(361, 104);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMessage.Location = new Point(384, 611);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(211, 28);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "Message Placeholder";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 744);
            Controls.Add(lblMessage);
            Controls.Add(btnLogin);
            Controls.Add(txtPin);
            Controls.Add(label3);
            Controls.Add(txtAccountNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lastname ATM Kiosk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAccountNumber;
        private TextBox txtPin;
        private Label label3;
        private Button btnLogin;
        private Label lblMessage;
    }
}
