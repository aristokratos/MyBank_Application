using MyBankApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApplication.Model
{
    public class AccountModel
    {


        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public long AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime DateOfBirth { get; set; }
        public List<TransctionModel> TransactionsList { get; set; }

        public AccountModel(string userId, long accountNumber, double balance, string accountType, DateTime createdDate, DateTime dateOfBirth, List<TransctionModel> transactionsList)
        {
            UserId = userId;
            AccountNumber = accountNumber;
            Balance = balance;
            AccountType = accountType;
            CreatedDate = createdDate;
            DateOfBirth = dateOfBirth;
            TransactionsList = transactionsList;
        }
        public AccountModel(string accountName, long accountNumber, double balance, string accounttype, DateTime createdDate, DateTime DOB)
        {
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.AccountType = accounttype;
            this.CreatedDate = createdDate;
            this.DateOfBirth = DOB;
        }
        public AccountModel()
        {
        }





    }

}
