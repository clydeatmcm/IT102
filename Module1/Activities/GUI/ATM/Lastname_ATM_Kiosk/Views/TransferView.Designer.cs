namespace Lastname_ATM_Kiosk.Views
{
    partial class TransferView
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
            txtTargetAccount = new TextBox();
            txtAmount = new TextBox();
            label2 = new Label();
            btnSubmit = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(391, 66);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Target Account";
            // 
            // txtTargetAccount
            // 
            txtTargetAccount.Location = new Point(285, 153);
            txtTargetAccount.Name = "txtTargetAccount";
            txtTargetAccount.Size = new Size(343, 31);
            txtTargetAccount.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(285, 315);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(343, 31);
            txtAmount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 228);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 2;
            label2.Text = "Amount";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(281, 408);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(347, 71);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMessage.Location = new Point(285, 582);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(183, 28);
            lblMessage.TabIndex = 5;
            lblMessage.Text = "Status: Processing";
            // 
            // TransferView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 744);
            Controls.Add(lblMessage);
            Controls.Add(btnSubmit);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(txtTargetAccount);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TransferView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransferView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTargetAccount;
        private TextBox txtAmount;
        private Label label2;
        private Button btnSubmit;
        private Label lblMessage;
    }
}