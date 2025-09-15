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
using Lastname_ATM_Kiosk.ViewModels;

namespace Lastname_ATM_Kiosk.Views
{
    public partial class TransferView : Form
    {
        private AccountModel senderAccount;
        private AccountViewModel vm;
        public TransferView(AccountModel acc)
        {
            InitializeComponent();

            senderAccount = acc;
            vm = new AccountViewModel();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string targetAccountNumber = txtTargetAccount.Text;
            decimal amount;
            decimal.TryParse(txtAmount.Text, out amount);

            if (amount <= 0)
            {
                lblMessage.Text = "Invalid amount.";
                return;
            }

            AccountModel targetAccount = vm.FindAccountByNumber(targetAccountNumber);

            if (targetAccount == null)
            {
                lblMessage.Text = "Target account not found.";
                return;
            }

            if (senderAccount.AccountId == targetAccount.AccountId)
            {
                lblMessage.Text = "Cannot transfer to same account.";
                return;
            }

            if (senderAccount.Balance >= amount)
            {
                // Deduct from sender
                vm.Withdraw(senderAccount, amount);
                vm.AddTransaction(senderAccount, "Transfer Out", amount);

                // Add to receiver
                vm.Deposit(targetAccount, amount);
                vm.AddTransaction(targetAccount, "Transfer In", amount);

                lblMessage.Text = "Transfer successful! New Balance: " + senderAccount.Balance.ToString("C");
            }
            else
            {
                lblMessage.Text = "Insufficient balance.";
            }
        }
    }
}
