using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Logincs log = new Logincs();
            log.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Homepage log = new Homepage();
            log.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Decagon\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Logincs.AccountNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (depositAmtlbl.Text == "" || Convert.ToInt32(depositAmtlbl) <= 0)
            {
                MessageBox.Show("Enter The Amount to Deposit");
            }
            else
            {
                
                newBalance = oldBalance + Convert.ToInt32(depositAmtlbl.Text);

                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + oldBalance + " where AccNum= '"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Deposit");
                    Con.Close();
                    Homepage home = new Homepage();
                    home.Show();
                    this.Hide();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int oldBalance; int newBalance;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(" select Balance from AccountTb where AccountNumber ='" +Acc+ "' ", Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }

    }
}
