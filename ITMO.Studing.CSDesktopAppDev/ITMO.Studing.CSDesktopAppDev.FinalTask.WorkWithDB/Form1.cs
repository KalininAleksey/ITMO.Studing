using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Globalization;


namespace ITMO.Studing.CSDesktopAppDev.FinalTask.WorkWithDB
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        DataTable dt = new DataTable();
        private bool logincheck(string login)
        {
            using (WindowsIdentity user = WindowsIdentity.GetCurrent())
            {
                string currentlogin = user.Name.ToString();
                if (login == currentlogin) return true;
                else return false;
            }
        }
        public Form1()
        {             
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (logincheck(textBox3.Text.ToString()) == true)
            {
                string connstring = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = test_block1; Data Source = " + textBox1.Text.ToString();
                conn = new SqlConnection(@connstring);
                try
                    {
                        conn.Open();
                        MessageBox.Show("DB is connected");
                        button1.Enabled = false;
                        button2.Enabled = true;                                                   
                    }
                    catch (SqlException ex)
                    {
                        StringBuilder errorMessages = new StringBuilder();
                        for (int i = 0; i < ex.Errors.Count; i++)
                        {
                            errorMessages.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" + "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " + ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        MessageBox.Show(errorMessages.ToString());
                    }
                    
                }
            else
                MessageBox.Show("Login is incorrect");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage != tabPage1 && conn is null)
            {
                         e.Cancel = true;
            }
        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage2 || e.TabPage == tabPage4 || e.TabPage == tabPage5)
            {
                dt.Clear();
                dt.Columns.Clear();                             
                    try
                    {                    
                        string cmdtext = "SELECT * FROM t1;";
                        using (SqlCommand cmd = new SqlCommand(cmdtext, conn))
                        {
                            using (SqlDataReader read = cmd.ExecuteReader())
                            {
                                for (int Cnum = 0; Cnum < read.FieldCount; Cnum++)
                                {
                                    dt.Columns.Add(new DataColumn(read.GetName(Cnum)));
                                }
                                dt.AcceptChanges();
                                int Rnum = 1;   
                                while (read.Read())
                                {
                                    DataRow dr = dt.NewRow();
                                    for (int Cnum = 0; Cnum < read.FieldCount; Cnum++)
                                    {
                                        if (read[read.GetName(Cnum)] != null)
                                        {
                                            dr[Cnum] = read[read.GetName(Cnum)];
                                        }
                                    }
                                    Rnum++;
                                    dt.Rows.Add(dr);
                                    dt.AcceptChanges();
                                }
                                if (e.TabPage == tabPage2) dataGridView1.DataSource = dt;
                                if (e.TabPage == tabPage5)
                                {
                                dataGridView2.DataSource = dt;
                                MessageBox.Show("Make double click on rowheader to delete row");
                            }
                        }
                        }
                    }
                    catch (SqlException ex)
                    {
                        StringBuilder errorMessages = new StringBuilder();
                        for (int i = 0; i < ex.Errors.Count; i++)
                        {
                            errorMessages.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" + "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " + ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        MessageBox.Show(errorMessages.ToString());
                    }
                
            }
   
                        
        }

        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn!= null)
            {
                conn.Close();
                conn.Dispose();
            }
         }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {                
                try
                {
                    string cmdtext = "INSERT INTO T1 (Name, Number, Price, Discount) VALUES(@Name, @Number, @Price, @Discount)";
                    using (SqlCommand cmd = new SqlCommand(cmdtext, conn))
                    {
                        cmd.Parameters.AddWithValue("Name", textBox2.Text);
                        cmd.Parameters.AddWithValue("Number", textBox4.Text);
                        cmd.Parameters.AddWithValue("Price", textBox5.Text);
                        cmd.Parameters.AddWithValue("Discount", textBox6.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Table is inserted");
                        textBox2.Text = textBox4.Text = textBox5.Text = textBox6.Text = null;
                    }
                }
                catch (SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" + "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " + ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString());
                }
            }
            else MessageBox.Show("All Fields must be filled in");
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar.Equals(',') || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("Field must contains numbers and ','");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar.Equals('.') || e.KeyChar==8))
            {
                e.Handled = true;
                MessageBox.Show("Field must contains numbers and '.'");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox11.Text))
            {
                try
                {
                    string cmdtext = "UPDATE T1 SET [Name]=@Name, [Number]=@Number, [Price]=@Price, [Discount]=@Discount WHERE [ID]=@ID";
                    using (SqlCommand cmd = new SqlCommand(cmdtext, conn))
                    {
                        cmd.Parameters.AddWithValue("ID", textBox11.Text);
                        cmd.Parameters.AddWithValue("Name", textBox10.Text);
                        cmd.Parameters.AddWithValue("Number", textBox9.Text);
                        cmd.Parameters.AddWithValue("Price", textBox8.Text);
                        cmd.Parameters.AddWithValue("Discount", textBox7.Text);
                        MessageBox.Show(cmdtext);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Table is updateded");
                        textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = null;
                    }
                }
                catch (SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" + "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " + ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString());
                }
            }
            else MessageBox.Show("All Fields must be filled in");
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 9 || e.KeyChar == 13))
            {
                e.Handled = true;
                MessageBox.Show("Field must contains numbers");
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 9 || e.KeyChar == 13))
            {
                e.Handled = true;
                MessageBox.Show("Field must contains numbers");
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar.Equals(',') || e.KeyChar == 8 || e.KeyChar == 9 || e.KeyChar == 13))
            {
                e.Handled = true;
                MessageBox.Show("Field must contains numbers and ','");
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar.Equals('.') || e.KeyChar == 8 || e.KeyChar == 9 || e.KeyChar == 13))
            {
                e.Handled = true;
                MessageBox.Show("Field must contains numbers and ','");
            }
        }


        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(textBox11.Text) <= dt.Rows.Count && int.Parse(textBox11.Text)!=0)
            {
                e.Cancel = false;
                int selID = int.Parse(textBox11.Text) - 1;
                textBox10.Text = @dt.Rows[selID]["Name"].ToString();
                textBox9.Text = @dt.Rows[selID]["Number"].ToString();
                textBox8.Text = @dt.Rows[selID]["Price"].ToString();
                textBox7.Text = @dt.Rows[selID]["Discount"].ToString();
                textBox7.Text = textBox7.Text.Replace(',', '.');
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("ID is out of range");
                textBox11.Text = null;
            }
        }

        private void textBox11_Validated(object sender, EventArgs e)
        {

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 9 || e.KeyChar == 13))
            {
                e.Handled = true;
                MessageBox.Show("Field must contains numbers");
            }
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string cmdtext = "DELETE FROM T1 WHERE [ID]=@ID";
                using (SqlCommand cmd = new SqlCommand(cmdtext, conn))
                {
                    cmd.Parameters.AddWithValue("ID", @dt.Rows[e.RowIndex]["ID"].ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Row with ID="+ @dt.Rows[e.RowIndex]["ID"].ToString() + " is deleted");
                }
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" + "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " + ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(@"Enter your current windows login in format: domen\login");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For create working database you have to execute the sql-query SQLQuery_CREATE_DATABASE.sql in  in project catalog");
        }
    }
}
