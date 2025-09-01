    using System;
    using System.IO;
    using System.Collections.Generic;

    public class CsvHandler
    {
        private string filePath = "accounts.csv";
        private string historyPath = "transactions.csv";

        public CsvHandler()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "AccountNumber,Balance,Pin\n");
            }

            if (!File.Exists(historyPath))
            {
                File.WriteAllText(historyPath, "DateTime,Account,Type,Amount\n");
            }
        }

        // Save new account
        public void SaveAccount(string accNo, double balance, string pin)
        {
            File.AppendAllText(filePath, accNo + "," + balance + "," + pin + "\n");
        }

        // Load account by number
        public BankAccount LoadAccount(string accNo)
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("AccountNumber")) continue;

                string[] parts = lines[i].Split(',');
                if (parts[0] == accNo)
                {
                    string number = parts[0];
                    double balance = double.Parse(parts[1]);
                    string pin = parts[2];
                    return new BankAccount(number, balance, pin);
                }
            }
            return null; // not found
        }

        // Update account balance
        public void UpdateAccount(string accNo, double newBalance, string pin)
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("AccountNumber")) continue;

                string[] parts = lines[i].Split(',');
                if (parts[0] == accNo)
                {
                    lines[i] = accNo + "," + newBalance + "," + pin;
                }
            }
            File.WriteAllLines(filePath, lines);
        }

        // Save transaction record
        public void SaveTransaction(string accNo, string type, double amount)
        {
            File.AppendAllText(historyPath, DateTime.Now + "," + accNo + "," + type + "," + amount + "\n");
        }

        public List<string> ReadTransactions()
        {
            string[] lines = File.ReadAllLines(historyPath);
            List<string> records = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                records.Add(lines[i]);
            }
            return records;
        }
    }
