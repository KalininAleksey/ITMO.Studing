﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Studing.ADO.Lab4.CreatingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable CustomersTable = new DataTable("Customers");
        private void Form1_Load(object sender, EventArgs e)
        {
            TableGrid.DataSource = CustomersTable;
            CustomersTable.Columns.Add("CustomerID", Type.GetType("System.String"));
            CustomersTable.Columns.Add("CompanyName", Type.GetType("System.String"));
            CustomersTable.Columns.Add("ContactName", Type.GetType("System.String"));
            CustomersTable.Columns.Add("ContactTitle", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Address", Type.GetType("System.String"));
            CustomersTable.Columns.Add("City", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Country", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Phone", Type.GetType("System.String"));
            DataColumn[] KeyColumns = new DataColumn[1];
            KeyColumns[0] = CustomersTable.Columns[0];
            CustomersTable.PrimaryKey = KeyColumns;
            CustomersTable.Columns["CustomerID"].AllowDBNull = false;
            CustomersTable.Columns["CompanyName"].AllowDBNull = false;


        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            DataRow CustRow = CustomersTable.NewRow();
            Object[] CustRecord =  {"12209","ALFKI", "Alfreds Futterkiste", "Sales Representative", "Obere Str. 57", "Berlin", "Germany", "030-0074321"};
            CustRow.ItemArray = CustRecord;
            try
            {
                CustomersTable.Rows.Add(CustRow);
            }
            catch (Exception ex)
            {                
            {
                MessageBox.Show(ex.Message, "Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }
    }
}
