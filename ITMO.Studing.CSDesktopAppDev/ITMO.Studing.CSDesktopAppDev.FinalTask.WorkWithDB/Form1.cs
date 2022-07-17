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


namespace ITMO.Studing.CSDesktopAppDev.FinalTask.WorkWithDB
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        bool tableisselected;
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
                StringBuilder errorMessages = new StringBuilder();
                string dbname = textBox2.Text.ToString();
                string servername = textBox1.Text.ToString();
                string connstring = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = " + dbname + "; Data Source = " + servername;
                using (conn = new SqlConnection(@connstring))
                {
                    try
                    {
                        conn.Open();
                        MessageBox.Show("DB is connected");
                        button1.Enabled = false;
                        button2.Enabled = true;
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.SCHEMATA", conn))
                        {
                            comboBox1.Visible = true;
                            label4.Visible = true;
                            using (SqlDataReader read = cmd.ExecuteReader())
                                {
                                while (read.Read())
                                    { 
                                    comboBox1.Items.Add(read["SCHEMA_NAME"].ToString());
                                    }
                                }

                        }
                                                   

                    }
                    catch (SqlException ex)
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)
                        {
                            errorMessages.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" + "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " + ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        MessageBox.Show(errorMessages.ToString());
                    }
                }
            }
            else
                MessageBox.Show("Login is incorrect");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Dispose();
            button2.Enabled = false;
            button1.Enabled = true;
            comboBox1.Visible = false;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            label4.Visible = false;
            comboBox2.Visible = false;
            label8.Visible = false;
            tableisselected = false;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            string dbname = textBox2.Text.ToString();
            string servername = textBox1.Text.ToString();
            string connstring = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = " + dbname + "; Data Source = " + servername;
            using (conn = new SqlConnection(@connstring))
            {
                try
                {
                    conn.Open();
                    string tableowner=comboBox1.SelectedItem.ToString();
                    string cmdtext = "EXEC sp_tables @table_name = '%', @table_owner = '" + tableowner + "', @table_qualifier = '" +dbname+"'; ";
                    using (SqlCommand cmd = new SqlCommand(cmdtext, conn))
                    {
                        comboBox2.Visible = true;
                        label8.Visible = true;
                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                comboBox2.Items.Add(read["TABLE_NAME"].ToString());
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" + "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " + ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString());
                }
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage != tabPage1)
            {
                if (!tableisselected)
                    e.Cancel = true;
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tableisselected = true;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage != tabPage1)
            {
                StringBuilder errorMessages = new StringBuilder();
                DataTable dt = new DataTable();
                string dbname = textBox2.Text.ToString();
                string servername = textBox1.Text.ToString();
                string connstring = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = " + dbname + "; Data Source = " + servername;
                using (conn = new SqlConnection(@connstring))
                {
                    try
                    {
                        conn.Open();
                        string tableowner = comboBox2.SelectedItem.ToString();
                        string cmdtext = "SELECT * FROM " + comboBox1.SelectedItem.ToString() + "." + comboBox2.SelectedItem.ToString() + ";";
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
                                dataGridView1.DataSource = dt;
                                dataGridView2.DataSource = dt;
                                dataGridView3.DataSource = dt;
                                dataGridView4.DataSource = dt.Columns;


                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)
                        {
                            errorMessages.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" + "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " + ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        MessageBox.Show(errorMessages.ToString());
                    }
                }
            }
   
                        
        }

        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView3_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                StringBuilder errorMessages = new StringBuilder();
                DataTable dt = new DataTable();
                string dbname = textBox2.Text.ToString();
                string servername = textBox1.Text.ToString();
                string connstring = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = " + dbname + "; Data Source = " + servername;
                using (conn = new SqlConnection(@connstring))
                {
                    try
                    {
                        conn.Open();
                        string tableowner = comboBox2.SelectedItem.ToString();
                        string cmdtext = "SELECT * FROM " + comboBox1.SelectedItem.ToString() + "." + comboBox2.SelectedItem.ToString() + ";";
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
                                dataGridView1.DataSource = dt;
                                dataGridView2.DataSource = dt;
                                dataGridView3.DataSource = dt;
                                dataGridView4.DataSource = dt.Columns;


                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)
                        {
                            errorMessages.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" + "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " + ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        MessageBox.Show(errorMessages.ToString());
                    }
                }
            }
    }
}
