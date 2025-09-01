    public class BankAccount
    {
        private string accountNumber;
        private double balance;
        private string pin;

        public BankAccount(string accNo, double initialBalance, string pinCode)
        {
            accountNumber = accNo;
            Balance = initialBalance; // use property for validation
            pin = pinCode;
        }

        // Account Number - Read Only
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // PIN - Read Only (can only be set in constructor)
        public string Pin
        {
            get { return pin; }
        }

        // Balance Property with Data Hiding & Validation
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0) // protect from negative balance
                {
                    balance = value;
                }
            }
        }

        // Methods for controlled access
        public void BalamanDeposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
            }
        }

        public void BalamanWithdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance = Balance - amount;
            }
        }
    }
