namespace Lastname_ATM_Kiosk
{
    partial class MenuView
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
            btnBalance = new Button();
            btnWithdrawal = new Button();
            btnDeposit = new Button();
            btnTransfer = new Button();
            btnTransactions = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnBalance
            // 
            btnBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBalance.Location = new Point(121, 62);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(350, 178);
            btnBalance.TabIndex = 0;
            btnBalance.Text = "View Balance";
            btnBalance.UseVisualStyleBackColor = true;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnWithdrawal
            // 
            btnWithdrawal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnWithdrawal.Location = new Point(121, 277);
            btnWithdrawal.Name = "btnWithdrawal";
            btnWithdrawal.Size = new Size(350, 179);
            btnWithdrawal.TabIndex = 1;
            btnWithdrawal.Text = "Cash Withdrawal";
            btnWithdrawal.UseVisualStyleBackColor = true;
            btnWithdrawal.Click += btnWithdrawal_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeposit.Location = new Point(121, 491);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(350, 173);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "Cash Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTransfer.Location = new Point(486, 62);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(350, 178);
            btnTransfer.TabIndex = 3;
            btnTransfer.Text = "Cash Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTransactions.Location = new Point(486, 277);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(350, 179);
            btnTransactions.TabIndex = 4;
            btnTransactions.Text = "Cash Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransaction_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(486, 491);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(350, 173);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 744);
            Controls.Add(btnExit);
            Controls.Add(btnTransactions);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdrawal);
            Controls.Add(btnBalance);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lastname ATM Kiosk - Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBalance;
        private Button btnWithdrawal;
        private Button btnDeposit;
        private Button btnTransfer;
        private Button btnTransactions;
        private Button btnExit;
    }
}