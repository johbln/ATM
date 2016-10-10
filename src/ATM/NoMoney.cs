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
    public partial class NoMoney : Form
    {
        public NoMoney()
        {
            InitializeComponent();
        }

        private void NoMoney_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Your bank account is empty!");
        }
    }
}
