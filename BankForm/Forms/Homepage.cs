using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class Homepage : Form
    {
        public Homepage()
        {

            InitializeComponent();
        }
        public static String AccountNumber;
        private void Homepage_Load(object sender, EventArgs e)
        {
            AcctNumlbl.Text = "Account Number:" + Logincs.AccountNumber;
            AccountNumber = Logincs.AccountNumber;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangePin Pin = new ChangePin();
            Pin.Show();
            this.Hide();
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

        private void button5_Click(object sender, EventArgs e)
        {
            In_Transfer log = new In_Transfer();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit log = new Deposit();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw log = new Withdraw();
            log.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BankStatement log = new BankStatement();
            log.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BalancePage log = new BalancePage();
            this.Hide();
        }
    }
}
