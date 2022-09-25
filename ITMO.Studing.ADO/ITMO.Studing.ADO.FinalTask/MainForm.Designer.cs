
namespace ITMO.Studing.ADO.FinalTask
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TablesComboBox = new System.Windows.Forms.ComboBox();
            this.shipsDBDataSet1 = new ITMO.Studing.ADO.FinalTask.ShipsDBDataSet();
            this.classesTableAdapter1 = new ITMO.Studing.ADO.FinalTask.ShipsDBDataSetTableAdapters.ClassesTableAdapter();
            this.registerTableAdapter1 = new ITMO.Studing.ADO.FinalTask.ShipsDBDataSetTableAdapters.RegisterTableAdapter();
            this.shipsTableAdapter1 = new ITMO.Studing.ADO.FinalTask.ShipsDBDataSetTableAdapters.ShipsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.battlesTableAdapter1 = new ITMO.Studing.ADO.FinalTask.ShipsDBDataSetTableAdapters.BattlesTableAdapter();
            this.outcomesTableAdapter1 = new ITMO.Studing.ADO.FinalTask.ShipsDBDataSetTableAdapters.OutcomesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the table";
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.FormattingEnabled = true;
            this.TablesComboBox.Location = new System.Drawing.Point(99, 6);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(102, 21);
            this.TablesComboBox.TabIndex = 3;
            this.TablesComboBox.SelectionChangeCommitted += new System.EventHandler(this.TablesComboBox_SelectionChangeCommitted);
            // 
            // shipsDBDataSet1
            // 
            this.shipsDBDataSet1.DataSetName = "ShipsDBDataSet";
            this.shipsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesTableAdapter1
            // 
            this.classesTableAdapter1.ClearBeforeFill = true;
            // 
            // registerTableAdapter1
            // 
            this.registerTableAdapter1.ClearBeforeFill = true;
            // 
            // shipsTableAdapter1
            // 
            this.shipsTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(409, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reject Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(254, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete Row";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(577, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update DB";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // battlesTableAdapter1
            // 
            this.battlesTableAdapter1.ClearBeforeFill = true;
            // 
            // outcomesTableAdapter1
            // 
            this.outcomesTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Working with tables";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TablesComboBox;
        private ShipsDBDataSet shipsDBDataSet1;
        private ShipsDBDataSetTableAdapters.ClassesTableAdapter classesTableAdapter1;
        private ShipsDBDataSetTableAdapters.RegisterTableAdapter registerTableAdapter1;
        private ShipsDBDataSetTableAdapters.ShipsTableAdapter shipsTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ShipsDBDataSetTableAdapters.BattlesTableAdapter battlesTableAdapter1;
        private ShipsDBDataSetTableAdapters.OutcomesTableAdapter outcomesTableAdapter1;
    }
}