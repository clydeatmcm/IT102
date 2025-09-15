namespace Lastname_ATM_Kiosk.Views
{
    partial class BalanceView
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
            label1 = new Label();
            txtAccountNumber = new TextBox();
            label2 = new Label();
            txtBalance = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 56);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Account Number";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(306, 140);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(334, 31);
            txtAccountNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 236);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 2;
            label2.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(306, 326);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(334, 31);
            txtBalance.TabIndex = 3;
            // 
            // BalanceView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 744);
            Controls.Add(txtBalance);
            Controls.Add(label2);
            Controls.Add(txtAccountNumber);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BalanceView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BalanceView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAccountNumber;
        private Label label2;
        private TextBox txtBalance;
    }
}