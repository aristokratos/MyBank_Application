using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApplication.Model
{
    public class TransctionModel
    {
        public long AccountNumber { get; set; }
        public string Description { get; set; }
        public long Amount { get; set; }
        public double Balance { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public TransctionModel(long accountNumber, string description, long amount, double balance, DateTime date)
        {
            AccountNumber = accountNumber;
            Description = description;
            Amount = amount;
            Balance = balance;
            Date = date;
        }
        public TransctionModel()
        {

        }
    }
}
