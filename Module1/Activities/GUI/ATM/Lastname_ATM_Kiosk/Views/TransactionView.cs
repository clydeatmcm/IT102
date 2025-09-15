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
    public partial class TransactionView : Form
    {
        private TransactionViewModel tVM;
        private AccountModel account;
        public TransactionView(AccountModel acc)
        {
            InitializeComponent();

            account = acc;
            tVM = new TransactionViewModel();

            this.Text = "Recent Transactions";
            this.Width = 1000;
            this.Height = 800;

            dgv.DataSource = tVM.GetTransactions(account.AccountId);
            txtAccountNumber.Text = account.AccountNumber;
        }
    }
}
