using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Studing.CSDesktopAppDev.Lab3Ex1.WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userControl11.TimeEnabled)
                userControl11.TimeEnabled = false;
            else
                userControl11.TimeEnabled = true;

        }
    }
}
