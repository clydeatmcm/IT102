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

namespace Lastname_ATM_Kiosk.Views
{
    public partial class BalanceView : Form
    {
        public BalanceView(AccountModel account)
        {
            InitializeComponent();

            txtAccountNumber.Text = account.AccountNumber;
            txtBalance.Text = account.Balance.ToString();

            txtAccountNumber.ReadOnly = true;
            txtBalance.ReadOnly = true;
        }
    }
}
