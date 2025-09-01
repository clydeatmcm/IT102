    public class ATM : Transaction, IATM
    {
        private BankAccount account;
        private CsvHandler csvHandler;

        public ATM(BankAccount acc, CsvHandler handler)
        {
            account = acc;
            csvHandler = handler;
        }

        public override void Execute()
        {
            Console.WriteLine("ATM Transaction Executed.");
        }

        public void ShowMenu()
        {
            Console.WriteLine("##########################");
            Console.WriteLine("##   Balaman ATM Logo   ##");
            Console.WriteLine("##########################");
            Console.Write("Enter PIN: ");
            string inputPin = Console.ReadLine();

            if (inputPin != account.Pin)
            {
                Console.WriteLine("Invalid PIN. Exiting...");
                Environment.Exit(0);
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("     Welcome to Balaman ATM");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Please select a transaction:");
            Console.WriteLine("[ 1 ] Balance Inquiry");
            Console.WriteLine("[ 2 ] Cash Withdrawal");
            Console.WriteLine("[ 3 ] Deposit");
            Console.WriteLine("[ 4 ] Transfer");
            Console.WriteLine("[ 5 ] Recent Transactions");
            Console.WriteLine("[ 6 ] Exit");
        }

        public void BalanceInquiry()
        {
            Console.WriteLine("Current Balance: " + account.Balance);
        }

        public void Withdraw(double amount)
        {
            account.BalamanWithdraw(amount);
            csvHandler.UpdateAccount(account.AccountNumber, account.Balance, account.Pin);
            csvHandler.SaveTransaction(account.AccountNumber, "Withdraw", amount);
            Console.WriteLine("Withdrawn " + amount + ". New Balance: " + account.Balance);
        }

        public void Deposit(double amount)
        {
            account.BalamanDeposit(amount);
            csvHandler.UpdateAccount(account.AccountNumber, account.Balance, account.Pin);
            csvHandler.SaveTransaction(account.AccountNumber, "Deposit", amount);
            Console.WriteLine("Deposited " + amount + ". New Balance: " + account.Balance);
        }

        public void Transfer(string toAccount, double amount)
        {
            BankAccount destAcc = csvHandler.LoadAccount(toAccount);
            if (destAcc == null)
            {
                Console.WriteLine("Destination account not found.");
                return;
            }

            account.BalamanWithdraw(amount);
            destAcc.BalamanDeposit(amount);

            csvHandler.UpdateAccount(account.AccountNumber, account.Balance, account.Pin);
            csvHandler.UpdateAccount(destAcc.AccountNumber, destAcc.Balance, destAcc.Pin);

            csvHandler.SaveTransaction(account.AccountNumber, "Transfer Out", amount);
            csvHandler.SaveTransaction(destAcc.AccountNumber, "Transfer In", amount);

            Console.WriteLine("Transferred " + amount + " to account " + toAccount + ".");
            Console.WriteLine("Your new balance: " + account.Balance);
        }

        public void ShowTransactions()
        {
            Console.WriteLine("Recent Transactions:");
            List<string> transactions = csvHandler.ReadTransactions();
            for (int i = 0; i < transactions.Count; i++)
            {
                Console.WriteLine(transactions[i]);
            }
        }
    }
