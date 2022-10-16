
namespace ITMO.Studing.ADO.Lab9.CustomManager
{
    partial class CustomerViewer
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
            this.customerList = new System.Windows.Forms.ComboBox();
            this.orderlistBox = new System.Windows.Forms.ListBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderradioButton = new System.Windows.Forms.RadioButton();
            this.CustomerradioButton = new System.Windows.Forms.RadioButton();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(13, 13);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(163, 21);
            this.customerList.TabIndex = 0;
            // 
            // orderlistBox
            // 
            this.orderlistBox.FormattingEnabled = true;
            this.orderlistBox.Location = new System.Drawing.Point(13, 58);
            this.orderlistBox.Name = "orderlistBox";
            this.orderlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.orderlistBox.Size = new System.Drawing.Size(163, 95);
            this.orderlistBox.TabIndex = 1;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(265, 13);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(114, 20);
            this.textBoxname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Location = new System.Drawing.Point(265, 39);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(114, 20);
            this.textBoxlastname.TabIndex = 2;
            // 
            // textBoxmail
            // 
            this.textBoxmail.Location = new System.Drawing.Point(265, 65);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(114, 20);
            this.textBoxmail.TabIndex = 2;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(265, 91);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(114, 20);
            this.textBoxage.TabIndex = 2;
            this.textBoxage.TextChanged += new System.EventHandler(this.textBoxage_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Фото";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(265, 117);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(114, 36);
            this.buttonFile.TabIndex = 4;
            this.buttonFile.Text = "Выберите файл...";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(419, 9);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 50);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить данные";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(548, 9);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(100, 50);
            this.buttonOut.TabIndex = 4;
            this.buttonOut.Text = "Показать данные";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(678, 8);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(114, 25);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(678, 36);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(114, 25);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderradioButton);
            this.groupBox1.Controls.Add(this.CustomerradioButton);
            this.groupBox1.Location = new System.Drawing.Point(419, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор данных";
            // 
            // OrderradioButton
            // 
            this.OrderradioButton.AutoSize = true;
            this.OrderradioButton.Location = new System.Drawing.Point(237, 19);
            this.OrderradioButton.Name = "OrderradioButton";
            this.OrderradioButton.Size = new System.Drawing.Size(56, 17);
            this.OrderradioButton.TabIndex = 0;
            this.OrderradioButton.TabStop = true;
            this.OrderradioButton.Text = "Orders";
            this.OrderradioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerradioButton
            // 
            this.CustomerradioButton.AutoSize = true;
            this.CustomerradioButton.Location = new System.Drawing.Point(16, 19);
            this.CustomerradioButton.Name = "CustomerradioButton";
            this.CustomerradioButton.Size = new System.Drawing.Size(74, 17);
            this.CustomerradioButton.TabIndex = 0;
            this.CustomerradioButton.TabStop = true;
            this.CustomerradioButton.Text = "Customers";
            this.CustomerradioButton.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(416, 130);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(446, 127);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(346, 20);
            this.textBoxCustomer.TabIndex = 2;
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Location = new System.Drawing.Point(0, 159);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(800, 291);
            this.GridView.TabIndex = 6;
            // 
            // CustomerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.orderlistBox);
            this.Controls.Add(this.customerList);
            this.Name = "CustomerViewer";
            this.Text = "Customer Viewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerList;
        private System.Windows.Forms.ListBox orderlistBox;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OrderradioButton;
        private System.Windows.Forms.RadioButton CustomerradioButton;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.DataGridView GridView;
    }
}

