using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lastname_ATM_Kiosk.ViewModels
{
    public class TransactionViewModel
    {
        private ATMKioskDbContext _context;

        public TransactionViewModel()
        {
            _context = new ATMKioskDbContext();
        }

        public object GetTransactions(int accountId)
        {
            var result = from t in _context.Transactions
                         where t.AccountId == accountId
                         select new
                         {
                             t.TransactionDate,
                             t.TransactionType,
                             t.Amount
                         };
            return result.ToList();
        }
    }
}
