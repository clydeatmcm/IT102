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
    public partial class DepositView : Form
    {
        private AccountViewModel vm;
        private AccountModel account;

        public DepositView(AccountModel acc)
        {
            InitializeComponent();

            account = acc;
            vm = new AccountViewModel();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(txtAmount.Text);

            vm.Deposit(account, amount);
            vm.AddTransaction(account, "Deposit", amount);
            lblMessage.Text = "Success! New Balance: " + account.Balance.ToString("C");
        }
    }
}
