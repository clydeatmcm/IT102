    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Author: Clyde Balaman - BSCS 1A - Aug. 4, 2004 - 'Learning by Doing'");

            CsvHandler handler = new CsvHandler();

            // Load or create accounts
            BankAccount acc1 = handler.LoadAccount("12345");
            if (acc1 == null)
            {
                acc1 = new BankAccount("12345", 10000, "1234");
                handler.SaveAccount(acc1.AccountNumber, acc1.Balance, acc1.Pin);
            }

            BankAccount acc2 = handler.LoadAccount("67890");
            if (acc2 == null)
            {
                acc2 = new BankAccount("67890", 1000, "5678");
                handler.SaveAccount(acc2.AccountNumber, acc2.Balance, acc2.Pin);
            }

            // Use account 12345 as logged-in user
            ATM atm = new ATM(acc1, handler);

            int choice;
            do
            {
                atm.ShowMenu();
                Console.Write("Enter choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        atm.BalanceInquiry();
                        break;
                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        atm.Withdraw(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("Enter amount to deposit: ");
                        atm.Deposit(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 4:
                        Console.Write("Enter destination account: ");
                        string dest = Console.ReadLine();
                        Console.Write("Enter amount to transfer: ");
                        atm.Transfer(dest, Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 5:
                        atm.ShowTransactions();
                        break;
                }

            } while (choice != 6);
        }
    }
