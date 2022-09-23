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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ConnectBtn_Click(object sender, EventArgs e)
        {

            SqlDataAdapter1 = new SqlDataAdapter("SELECT IDUser, LoginUser, PasswordUser FROM dbo.Register Where LoginUser='{Login" +
                 "TextBox.Text}' and PasswordUser='{PasswordTextBox.Text}'";
            if (shipsDBDataSet1.Register.Rows.Count==1)
             
                MessageBox.Show("Connect is successfull");
            else
                    MessageBox.Show("LOGIN/PASSWORD is incorrect");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //registerTableAdapter1.Fill(shipsDBDataSet1.Register);
           
        }


    }
}
