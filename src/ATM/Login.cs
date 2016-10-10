using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        String pin;
        String pin2;
        int pininvalid = 0;

        private void cmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtPIN.Text = "";
            pin = null;
            txtPIN.Focus();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdAccept_Click(object sender, EventArgs e)
        {
            pin2 = txtPIN.Text;
            if (pin2.Equals("1234"))
            {
                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("PIN invalid");
                pininvalid++;
                Clear();
            }

            if(pininvalid >= 3)
            {
                var shutdown = new Shutdown();
                shutdown.Show(this);

            }
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            if(txtPIN.TextLength < 4)
            {
                this.txtPIN.Text = "";
                pin += "1";
                this.txtPIN.Text += pin;
            }
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if (txtPIN.TextLength < 4)
            {
                this.txtPIN.Text = "";
                pin += "2";
                this.txtPIN.Text += pin;
            }
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            if (txtPIN.TextLength < 4)
            {
                this.txtPIN.Text = "";
                pin += "3";
                this.txtPIN.Text += pin;
            }
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            if (txtPIN.TextLength < 4)
            {
                this.txtPIN.Text = "";
                pin += "4";
                this.txtPIN.Text += pin;
            }
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            if (txtPIN.TextLength < 4)
            {
                this.txtPIN.Text = "";
                pin += "5";
                this.txtPIN.Text += pin;
            }
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            if (txtPIN.TextLength < 4)
            {
                this.txtPIN.Text = "";
                pin += "6";
                this.txtPIN.Text += pin;
            }
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            if (txtPIN.TextLength < 4)
            {
                this.txtPIN.Text = "";
                pin += "7";
                this.txtPIN.Text += pin;
            }
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            if (txtPIN.TextLength < 4)
            {
                this.txtPIN.Text = "";
                pin += "8";
                this.txtPIN.Text += pin;
            }
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            if (txtPIN.TextLength < 4)
            {
                this.txtPIN.Text = "";
                pin += "9";
                this.txtPIN.Text += pin;
            }
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            if (txtPIN.TextLength < 4)
            {
                this.txtPIN.Text = "";
                pin += "0";
                this.txtPIN.Text += pin;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPIN.Focus();
        }

        private void txtPIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdAccept_Click(this, new EventArgs());
            }
        }
    }
}
