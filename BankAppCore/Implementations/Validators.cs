using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyBankApplication.Interface;


namespace MyBankApplication.BankServices
{
    public class Validation : IValidators

    {
        public bool CheckEmail(string email)
        {
            string strRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return PerformRegEx(strRegex, email);
        }

        public bool CheckName(string name)
        {
            string strRegex = @"^[A-Z]";

            return PerformRegEx(strRegex, name);
        }

        public bool CheckPassword(string password)
        {
            string strRegex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$";
            return PerformRegEx(strRegex, password);
        }

        public static bool PerformRegEx(string pattern, string value)
        {
            Regex re = new Regex(pattern);
            return re.IsMatch(value);
        }
        public long GenerateRandomAccountNumber()
        {
            long rndAccount = 0;
            Random random = new Random();
            for (int i = 1; i < 11; i++)
            {
                rndAccount = random.Next(100000000, 999999999);
            }
            return rndAccount;
        }
    }
}
