using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Studing.CSDesktopAppDev.FinalTask.WorkWithDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StringBuilder errorMessages = new StringBuilder();
            using (SqlConnection conn = new SqlConnection(@"Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = test_block; Data Source = localhost\SQLEXPRESS"))
            {
                try
                {
                    conn.Open();
                    this.richTextBox1.Text = "DB is opened\n";
                    using (SqlCommand cmd = new SqlCommand("SELECT [ID], [Name], [Number], [Price], [Discount] FROM [test_block].[dbo].[t1]", conn))
                    {
                        this.richTextBox1.Text = this.richTextBox1.Text + "Commands is sent\n";
                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            this.richTextBox1.Text = this.richTextBox1.Text + "Data is get\n";
                            int j = 0;
                            while (read.Read())
                            {
                                j=j+1;
                                this.richTextBox1.Text = this.richTextBox1.Text + "String№"+j+": "+read["ID"].ToString()+ " "+read["Name"].ToString() + read["Price"].ToString() + "\n" ;
                            }
                            this.richTextBox1.Text = this.richTextBox1.Text + "All Data is printed\n";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString());

                }
            }
        }
    }
}
