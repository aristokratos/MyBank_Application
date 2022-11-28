using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBankApplication.Interface;
using MyBankApplication.Model;
using Newtonsoft.Json;
using System.IO;
using Xceed.Wpf.Toolkit;

namespace MyBankApplication.BankServices
{
    public class Transctions : ITransaction
    {
        //private List<AccountModel> userAccountList;
        //private AccountModel  selectedUserAccount;
        private List<TransctionModel> _ListofTransactiions = new List<TransctionModel>();
        public void Deposit(long accountNumber, long amount)
        {
            try
            {
                var fileReader = File.ReadAllText(@"CustomerAccount.json");
                var resultJson = JsonConvert.DeserializeObject<List<Model.AccountModel>>(fileReader).ToList();
                if (resultJson != null)
                {
                    foreach (var account in resultJson)
                    {
                        if (account.AccountNumber == accountNumber)
                        {
                            account.Balance += amount;
                            MessageBox.Show($"you deposited {amount} and your account balance is:{account.Balance}");
                            // add to the transaction file
                            var transaction = new TransctionModel(account.AccountNumber, "Deposit", amount, account.Balance, DateTime.Now);
                            _ListofTransactiions.Add(transaction);
                            var resultJson1 = JsonConvert.SerializeObject(_ListofTransactiions);
                            // write values as json file
                            File.WriteAllText(@"Transactions.json", resultJson1);
                            MessageBox.Show("Transactions Sucessfully added");

                            break;
                        }
                        else
                        {
                            MessageBox.Show("transaction Failed");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(fileReader.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void Transfer(string receiverName, string senderName, long receiverAcc, long senderAcc, double amount)
        {
            try
            {
                var transferReader = File.ReadAllText(@"CustomerAccount.json");
                var transferJson = JsonConvert.DeserializeObject<List<Model.AccountModel>>(transferReader).ToList();
                if (transferJson != null)
                {
                    foreach (var account in transferJson)
                    {
                        if (account.AccountNumber == account.AccountNumber)
                        {
                            MessageBox.Show("Both the accounts are the same");
                        }
                        if (account.AccountNumber == senderAcc)
                        {
                            account.Balance -= amount;
                            MessageBox.Show($"You made transfer of : {amount} to {account.AccountNumber} and your account balance is:{account.Balance}");
                            // add to the transaction file
                            var transaction = new TransctionModel(account.AccountNumber, "Debit", -(long)amount, account.Balance, DateTime.Now);
                            _ListofTransactiions.Add(transaction);
                            var resultJson1 = JsonConvert.SerializeObject(_ListofTransactiions);
                            // write values as json file
                            File.WriteAllText(@"Transactions.json", resultJson1);

                        }
                        if (account.AccountNumber == receiverAcc)
                        {
                            account.Balance += amount;
                            MessageBox.Show($"You made transfer of : {amount} to {account.AccountNumber} and your account balance is:{account.Balance}/t thank you for banking with us");
                            // add to the transaction file
                            var transaction = new TransctionModel(account.AccountNumber, "credited", (long)amount, account.Balance, DateTime.Now);
                            _ListofTransactiions.Add(transaction);
                            var resultJson1 = JsonConvert.SerializeObject(_ListofTransactiions);
                            // write values as json file
                            File.WriteAllText(@"Transactions.json", resultJson1);
                        }
                        else
                        {
                            MessageBox.Show($"transaction failed on {account.AccountName}. please try again later ");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void WithDrawal()
        {
            throw new NotImplementedException();
        }
    }
}
