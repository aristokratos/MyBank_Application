using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApplication.Interface
{
    public interface ITransactionView
    {
        void ViewBankStatement(long accountNumber);
        void ViewcustomerDetails(long accountNumber);
    }
}
