using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMApp
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Decagon\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private int length;

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccountTypeTb.Text == "" || AccountNameTb.Text == "" || AccountNumTb.Text == "" || PhoneNumTb.Text == "" || PinTb.Text == "" || AcctBalanceTb.Text == "" || DOBTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                   // Con.Open();
                   // string query = "insert into AccountTb1 values('" + AccountTypeTb.SelectedItem.ToString() + "', '" + AccountNumTb.Text + "', '" + AccountNameTb.Text + "', '" + PhoneNumTb.Text + "', '" + PinTb.Text + "', '" + AcctBalanceTb.Text + "', '" + DOBTb.Value.Date + "', '" + AddressTb.Text + "', '" + bal + "' )";
                   // SqlCommand cmd = new SqlCommand(query, Con);
                   // cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Logincs log = new Logincs();
                    log.Show();
                    this.Hide();

                  //  Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Logincs log = new Logincs();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
