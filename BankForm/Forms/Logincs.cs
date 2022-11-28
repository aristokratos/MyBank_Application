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
    public partial class Logincs : Form
    {
        public Logincs()
        {
          
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage log = new Homepage();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Account log = new Account();
            log.Show();
            this.Hide();
        }
        public static String AccountNumber;
      //  SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Decagon\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // Con.Open();
           // SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from AccountTb1 where AccountNumber ='" +AccountNumberTb.Text+ "' and PIN = "+PinTb.Text+ "", Con);
            DataTable dt = new DataTable();
           // adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccountNumber = AccountNumberTb.Text;
                Homepage home = new Homepage();
                home.Show();
                this.Hide();
              //  Con.Close();
            }else
            {
                MessageBox.Show("Wrong Account Number of Pin");
            }
           // Con.Close();
        }
    }
}
