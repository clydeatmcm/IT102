using Lastname_ATM_Admin.Models;
using Lastname_ATM_Admin.ViewModels;

namespace Lastname_ATM_Admin
{
    public partial class MainForm : Form
    {
        private readonly AccountViewModel viewModel = new();

        public MainForm()
        {
            InitializeComponent();
            LoadAccounts();
        }

        private void LoadAccounts()
        {
            dgvAccounts.DataSource = null;
            dgvAccounts.DataSource = viewModel.GetAccounts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var account = new Account
            {
                OwnerName = txtOwner.Text,
                Balance = double.TryParse(txtBalance.Text, out var bal) ? bal : 0,
                IsActive = chkActive.Checked,
                CreatedDate = DateTime.Now
            };

            viewModel.AddAccount(account);
            LoadAccounts();
        }
    }
}
