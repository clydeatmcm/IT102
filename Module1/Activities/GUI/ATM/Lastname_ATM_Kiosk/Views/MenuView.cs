using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lastname_ATM_Kiosk.Models;
using Lastname_ATM_Kiosk.Views;

namespace Lastname_ATM_Kiosk
{
    public partial class MenuView : Form
    {
        private AccountModel _CurrentAccount;
        public MenuView(AccountModel CurrentAccount)
        {
            InitializeComponent();
            _CurrentAccount = CurrentAccount;
        }
        private void btnBalance_Click(object sender, EventArgs e)
        {
            BalanceView balanceView = new BalanceView(_CurrentAccount);
            balanceView.ShowDialog();
        }
        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            WithdrawalView withdrawal = new WithdrawalView(_CurrentAccount);
            withdrawal.ShowDialog();
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositView depositView = new DepositView(_CurrentAccount);
            depositView.ShowDialog();
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferView transferView = new TransferView(_CurrentAccount);
            transferView.ShowDialog();
        }
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            TransactionView transaction = new TransactionView(_CurrentAccount);
            transaction.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Optional: confirm exit
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // closes all forms and stops the app
            }
        }
    }
}
