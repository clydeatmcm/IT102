namespace Lastname_ATM_Kiosk.Views
{
    partial class DepositView
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
            txtAmount = new TextBox();
            btnSubmit = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(435, 81);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(311, 157);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(324, 31);
            txtAmount.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(311, 262);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(324, 76);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMessage.Location = new Point(382, 465);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(183, 28);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Status: Processing";
            // 
            // DepositView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 744);
            Controls.Add(lblMessage);
            Controls.Add(btnSubmit);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DepositView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepositView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private Button btnSubmit;
        private Label lblMessage;
    }
}