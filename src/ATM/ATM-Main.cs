using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ATM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int balance;
        int amount;
        int sum;

        private void Form2_Load(object sender, EventArgs e)
        {
            balance = 1000;
            txtBalance.Text = Convert.ToString(balance);
            pnlComp.Visible = false;
        }

        private void ResetPnlComp()
        {
            txt200.Text = "0";
            txt100.Text = "0";
            txt50.Text = "0";
            txt20.Text = "0";
            txt10.Text = "0";
            txt5.Text = "0";
        }

        private void ChooseComp()
        {
            amount = Convert.ToInt32(txtAmount.Text);


            sum = sum + (Convert.ToInt16(txt200.Text) * 200);
            sum = sum + (Convert.ToInt16(txt100.Text) * 100);
            sum = sum + (Convert.ToInt16(txt50.Text) * 50);
            sum = sum + (Convert.ToInt16(txt20.Text) * 20);
            sum = sum + (Convert.ToInt16(txt10.Text) * 10);
            sum = sum + (Convert.ToInt16(txt5.Text) * 5);

            sum = sum - amount;

            if(balance > 0)
            {
                if(sum == 0)
                {
                    MessageBox.Show("Money is given out!");
                    balance = balance - amount;
                    txtBalance.Text = Convert.ToString(balance);
                    pnlComp.Visible = false;
                    amount = 0;
                    txtAmount.Text = "0";
                    sum = 0;
                    txtAmount.Focus();
                }
                else
                {
                    MessageBox.Show("Please choose another composition!");
                    amount = 0;
                    txtAmount.Text = "0";
                    sum = 0;
                    txtAmount.Focus();
                    ResetPnlComp();
                }
            }
            else
            {
                var nomoney = new NoMoney();
                nomoney.Show(this);
            }
        }

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cmdPayout_Click(object sender, EventArgs e)
        {
            ResetPnlComp();
            pnlComp.Visible = true;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            ChooseComp();
        }

        private void txtAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt16(txtBalance.Text) < 0)
            {
                txtBalance.ForeColor = Color.Red;
            }
            else
            {
                txtBalance.ForeColor = Color.Black;
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdPayout_Click(this, new EventArgs());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xXP4trickXx/ATM");
        }
    }
}
