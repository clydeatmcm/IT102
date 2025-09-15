namespace Lastname_ATM_Kiosk.Views
{
    partial class TransactionView
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
            dgv = new DataGridView();
            label1 = new Label();
            txtAccountNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(36, 199);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.Size = new Size(897, 448);
            dgv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 33);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 1;
            label1.Text = "Account Number";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(303, 97);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(362, 31);
            txtAccountNumber.TabIndex = 2;
            // 
            // TransactionView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 744);
            Controls.Add(txtAccountNumber);
            Controls.Add(label1);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TransactionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionView";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label label1;
        private TextBox txtAccountNumber;
    }
}