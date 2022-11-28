using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBankApplication.Interface;
using MyBankApplication.UI;
using Newtonsoft.Json;
using Xceed.Wpf.Toolkit;

namespace MyBankApplication.BankServices
{
    public class ViewAccountTransaction : ITransactionView
    {
        public void ViewBankStatement(long accountNumber)
        {
            //   FormBankStatement statement = new FormBankStatement();

            ListView listView1 = new ListView();
            // listView1.Clear();
            listView1.Columns.Add("Account Number", 250);
            listView1.Columns.Add("Description", 250);
            listView1.Columns.Add("Balance ", 250);
            listView1.Columns.Add("Date", 250);
            listView1.Columns.Add("Transaction Amount", 250);


            try
            {


                // read value from file
                var strReadall = File.ReadAllText(@"Transactions.json");
                // convert json to object
                var result = JsonConvert.DeserializeObject<List<Model.TransctionModel>>(strReadall);
                // listView1.Items.Clear();
                if (result != null)
                {
                    DataGridView gridView = new DataGridView();

                    foreach (var item in result)
                    {
                        if (item.AccountNumber == accountNumber)
                        {
                            gridView.Columns.Add("Account Number", item.AccountNumber.ToString());
                            gridView.Columns.Add("Description", item.Description);
                            gridView.Columns.Add("Balance", item.Balance.ToString());
                            gridView.Columns.Add("Date", item.Date.ToString());
                            gridView.Columns.Add("Amount", item.Amount.ToString());
                        }
                        else
                        {
                            MessageBox.Show("No Record Found");
                        }
                    }



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void ViewcustomerDetails(long accountNumber)
        {
            throw new NotImplementedException();
        }
    }
}
