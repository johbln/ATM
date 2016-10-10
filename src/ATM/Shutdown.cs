using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Shutdown : Form
    {
        public Shutdown()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/a");
        }

        private void Shutdown_Load(object sender, EventArgs e)
        {
            Blink();
            Shtdwn();
        }
        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                label1.BackColor = label1.BackColor == Color.Red ? Color.White : Color.Red;
            }
        }
        private void Shtdwn()
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 3");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }
    }
}
