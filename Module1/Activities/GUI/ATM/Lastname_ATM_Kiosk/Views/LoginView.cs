using Lastname_ATM_Kiosk.Models;
using Lastname_ATM_Kiosk.ViewModels;

namespace Lastname_ATM_Kiosk
{
    public partial class LoginView : Form
    {
        private AccountViewModel accountVM;
        public AccountModel CurrentAccount { get; private set; }
        public LoginView()
        {
            InitializeComponent();

            accountVM = new AccountViewModel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CurrentAccount = accountVM.GetAccount(txtAccountNumber.Text, txtPin.Text);
            if (CurrentAccount != null)
            {
                MenuView menu = new MenuView(CurrentAccount);
                menu.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Invalid account or PIN.";
            }
        }
    }
}
