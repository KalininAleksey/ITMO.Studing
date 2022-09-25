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
    public partial class MainForm : Form
    {
        string tablename;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (DataTable table in shipsDBDataSet1.Tables)
            {
                if (table.TableName!="Register") TablesComboBox.Items.Add(table.TableName);              

            }
        }

        private void TablesComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            tablename = TablesComboBox.SelectedItem.ToString();
            workingtable(tablename,false);
            dataGridView1.DataSource = shipsDBDataSet1.Tables[tablename];
            
        }

        public void workingtable(string tbl_name, bool updparam)
        {
            try
            {
                switch (tbl_name)
                {
                    case "Ships":
                        if (updparam == true) 
                            shipsTableAdapter1.Update(shipsDBDataSet1.Ships);
                        else
                            shipsTableAdapter1.Fill(shipsDBDataSet1.Ships); 
                        break;
                    case "Classes":
                        if (updparam == true)
                            classesTableAdapter1.Update(shipsDBDataSet1.Classes);
                        else
                            classesTableAdapter1.Fill(shipsDBDataSet1.Classes);
                        break;
                    case "Battles":
                        if (updparam == true) 
                            battlesTableAdapter1.Update(shipsDBDataSet1.Battles);
                        else
                            battlesTableAdapter1.Fill(shipsDBDataSet1.Battles);
                        break;
                    case "Outcomes":
                        if (updparam == true)
                            outcomesTableAdapter1.Update(shipsDBDataSet1.Outcomes);
                        else
                            outcomesTableAdapter1.Fill(shipsDBDataSet1.Outcomes);
                        break;
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
            dataGridView1.DataSource = shipsDBDataSet1.Tables[tbl_name];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workingtable(tablename,false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                workingtable(tablename, true);
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


    private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error happened " + e.Exception.ToString());


        }

    }
}
