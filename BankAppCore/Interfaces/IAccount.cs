using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApplication.Interface
{
    public interface ITransaction
    {
        void Deposit(long accountNumber, long amount);
        void WithDrawal();
        void Transfer(string receiverName, string senderName, long receiverAcc, long senderAcc, double amount);
    }
}
