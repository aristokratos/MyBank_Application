using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ATMApp
{
    public partial class BalancePage : Form
    {
        public BalancePage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Decagon\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(" select Balance from AccountTb where AccountNumber ='" + AccNumlbl.Text + "' ", Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Balancelbl.Text = "Naira " + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            AccNumlbl.Text = Homepage.AccountNumber;
            getBalance();

        }
    }
}
