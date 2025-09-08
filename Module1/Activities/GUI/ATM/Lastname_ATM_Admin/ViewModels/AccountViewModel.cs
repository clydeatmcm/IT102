using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lastname_ATM_Admin.Models;

namespace Lastname_ATM_Admin.ViewModels
{
    public class AccountViewModel
    {
        public List<Account> GetAccounts()
        {
            using var db = new ATMContext();
            return db.Accounts.ToList();
        }

        public void AddAccount(Account account)
        {
            using var db = new ATMContext();
            db.Accounts.Add(account);
            db.SaveChanges();
        }
    }
}
