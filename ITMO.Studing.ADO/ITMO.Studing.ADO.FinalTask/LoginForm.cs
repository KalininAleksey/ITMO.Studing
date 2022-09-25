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

namespace ITMO.Studing.ADO.FinalTask
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            registerTableAdapter1.Fill(shipsDBDataSet1.Register);
            for (int i = 0; i < shipsDBDataSet1.Register.Rows.Count; i++)
            {
                if ((LoginTextBox.Text == shipsDBDataSet1.Register.Rows[i][1].ToString()) & (PasswordTextBox.Text == shipsDBDataSet1.Register.Rows[i][2].ToString()))
                {
                    MessageBox.Show("Successfull");
                    i = shipsDBDataSet1.Register.Rows.Count;
                    new MainForm();
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("LOGIN/PASSWORD is incorrect");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar= '*';
           
        }


    }
}
