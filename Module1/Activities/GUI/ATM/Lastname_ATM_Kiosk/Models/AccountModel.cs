using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lastname_ATM_Kiosk.Models
{
    public class AccountModel
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string Pin { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
    }
}
