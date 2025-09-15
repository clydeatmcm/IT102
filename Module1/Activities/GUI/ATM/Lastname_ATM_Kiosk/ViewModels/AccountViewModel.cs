using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lastname_ATM_Kiosk.Models;

namespace Lastname_ATM_Kiosk.ViewModels
{
    public class AccountViewModel
    {
        private ATMKioskDbContext _context;

        public AccountViewModel()
        {
            _context = new ATMKioskDbContext();
        }

        public AccountModel GetAccount(string accountNumber, string pin)
        {
            AccountModel account = null;
            foreach (var a in _context.Accounts)
            {
                if (a.AccountNumber == accountNumber && a.Pin == pin)
                {
                    account = a;
                    break;
                }
            }
            return account;
        }

        public void Deposit(AccountModel account, decimal amount)
        {
            account.Balance += amount;
            _context.SaveChanges();
        }

        public bool Withdraw(AccountModel account, decimal amount)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void AddTransaction(AccountModel account, string type, decimal amount)
        {
            TransactionModel t = new TransactionModel();
            t.AccountId = account.AccountId;
            t.TransactionType = type;
            t.Amount = amount;
            t.TransactionDate = DateTime.Now;
            t.Description = "default";
            _context.Transactions.Add(t);
            _context.SaveChanges();
        }

        public AccountModel FindAccountByNumber(string accountNumber)
        {
            AccountModel account = null;
            foreach (var a in _context.Accounts)
            {
                if (a.AccountNumber == accountNumber)
                {
                    account = a;
                    break;
                }
            }
            return account;
        }
    }
}
