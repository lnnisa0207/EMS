namespace EMS
{
  partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.empDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.empDOBPicker = new System.Windows.Forms.DateTimePicker();
            this.homeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.empEduComboBox = new System.Windows.Forms.ComboBox();
            this.empPosComboBox = new System.Windows.Forms.ComboBox();
            this.empGenComboBox = new System.Windows.Forms.ComboBox();
            this.empEdu = new System.Windows.Forms.Label();
            this.empPhone = new System.Windows.Forms.Label();
            this.empPhoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.empDOB = new System.Windows.Forms.Label();
            this.empPosition = new System.Windows.Forms.Label();
            this.empGender = new System.Windows.Forms.Label();
            this.empAddress = new System.Windows.Forms.Label();
            this.empAddressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.empName = new System.Windows.Forms.Label();
            this.empIdTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.empId = new System.Windows.Forms.Label();
            this.empNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.empDGV);
            this.panel1.Controls.Add(this.empDOBPicker);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.empEduComboBox);
            this.panel1.Controls.Add(this.empPosComboBox);
            this.panel1.Controls.Add(this.empGenComboBox);
            this.panel1.Controls.Add(this.empEdu);
            this.panel1.Controls.Add(this.empPhone);
            this.panel1.Controls.Add(this.empPhoneTextBox);
            this.panel1.Controls.Add(this.empDOB);
            this.panel1.Controls.Add(this.empPosition);
            this.panel1.Controls.Add(this.empGender);
            this.panel1.Controls.Add(this.empAddress);
            this.panel1.Controls.Add(this.empAddressTextBox);
            this.panel1.Controls.Add(this.empName);
            this.panel1.Controls.Add(this.empIdTextBox);
            this.panel1.Controls.Add(this.empId);
            this.panel1.Controls.Add(this.empNameTextBox);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 438);
            this.panel1.TabIndex = 4;
            // 
            // empDGV
            // 
            this.empDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.empDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empDGV.BackgroundColor = System.Drawing.Color.White;
            this.empDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.empDGV.EnableHeadersVisualStyles = false;
            this.empDGV.GridColor = System.Drawing.Color.White;
            this.empDGV.Location = new System.Drawing.Point(416, 28);
            this.empDGV.Name = "empDGV";
            this.empDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.empDGV.RowHeadersVisible = false;
            this.empDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empDGV.Size = new System.Drawing.Size(752, 392);
            this.empDGV.TabIndex = 26;
            this.empDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.empDGV.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.empDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.empDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.empDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.empDGV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.empDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.empDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.empDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.empDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.empDGV.ThemeStyle.ReadOnly = false;
            this.empDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.empDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.empDGV.ThemeStyle.RowsStyle.Height = 22;
            this.empDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.empDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.empDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empDGV_CellContentClick);
            // 
            // empDOBPicker
            // 
            this.empDOBPicker.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold);
            this.empDOBPicker.Location = new System.Drawing.Point(211, 201);
            this.empDOBPicker.Name = "empDOBPicker";
            this.empDOBPicker.Size = new System.Drawing.Size(187, 40);
            this.empDOBPicker.TabIndex = 25;
            this.empDOBPicker.Value = new System.DateTime(2022, 5, 26, 0, 0, 0, 0);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.OrangeRed;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(140, 389);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(84, 43);
            this.homeButton.TabIndex = 24;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(258, 330);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(83, 43);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.OrangeRed;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(140, 330);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(84, 43);
            this.editButton.TabIndex = 22;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.OrangeRed;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(39, 330);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(76, 43);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // empEduComboBox
            // 
            this.empEduComboBox.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold);
            this.empEduComboBox.ForeColor = System.Drawing.Color.Black;
            this.empEduComboBox.FormattingEnabled = true;
            this.empEduComboBox.ItemHeight = 30;
            this.empEduComboBox.Items.AddRange(new object[] {
            "BBA",
            "BTech",
            "BScEngg",
            "BCom",
            "MBA",
            "MTech",
            "MScEngg",
            "MCom"});
            this.empEduComboBox.Location = new System.Drawing.Point(211, 273);
            this.empEduComboBox.Name = "empEduComboBox";
            this.empEduComboBox.Size = new System.Drawing.Size(187, 38);
            this.empEduComboBox.TabIndex = 20;
            // 
            // empPosComboBox
            // 
            this.empPosComboBox.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold);
            this.empPosComboBox.ForeColor = System.Drawing.Color.Black;
            this.empPosComboBox.FormattingEnabled = true;
            this.empPosComboBox.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Senior Developer",
            "Junior Developer",
            "Receiptionist"});
            this.empPosComboBox.Location = new System.Drawing.Point(24, 205);
            this.empPosComboBox.Name = "empPosComboBox";
            this.empPosComboBox.Size = new System.Drawing.Size(157, 38);
            this.empPosComboBox.TabIndex = 19;
            // 
            // empGenComboBox
            // 
            this.empGenComboBox.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold);
            this.empGenComboBox.ForeColor = System.Drawing.Color.Black;
            this.empGenComboBox.FormattingEnabled = true;
            this.empGenComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.empGenComboBox.Location = new System.Drawing.Point(211, 131);
            this.empGenComboBox.Name = "empGenComboBox";
            this.empGenComboBox.Size = new System.Drawing.Size(187, 38);
            this.empGenComboBox.TabIndex = 18;
            // 
            // empEdu
            // 
            this.empEdu.AutoSize = true;
            this.empEdu.BackColor = System.Drawing.Color.White;
            this.empEdu.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEdu.ForeColor = System.Drawing.Color.OrangeRed;
            this.empEdu.Location = new System.Drawing.Point(222, 246);
            this.empEdu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empEdu.Name = "empEdu";
            this.empEdu.Size = new System.Drawing.Size(100, 32);
            this.empEdu.TabIndex = 16;
            this.empEdu.Text = "Education";
            this.empEdu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empPhone
            // 
            this.empPhone.AutoSize = true;
            this.empPhone.BackColor = System.Drawing.Color.White;
            this.empPhone.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPhone.ForeColor = System.Drawing.Color.OrangeRed;
            this.empPhone.Location = new System.Drawing.Point(67, 246);
            this.empPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(69, 32);
            this.empPhone.TabIndex = 17;
            this.empPhone.Text = "Phone";
            this.empPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empPhoneTextBox
            // 
            this.empPhoneTextBox.BackColor = System.Drawing.Color.Snow;
            this.empPhoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empPhoneTextBox.DefaultText = "";
            this.empPhoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empPhoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empPhoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empPhoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empPhoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empPhoneTextBox.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold);
            this.empPhoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.empPhoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empPhoneTextBox.Location = new System.Drawing.Point(24, 273);
            this.empPhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empPhoneTextBox.Name = "empPhoneTextBox";
            this.empPhoneTextBox.PasswordChar = '\0';
            this.empPhoneTextBox.PlaceholderText = "";
            this.empPhoneTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.empPhoneTextBox.SelectedText = "";
            this.empPhoneTextBox.Size = new System.Drawing.Size(157, 38);
            this.empPhoneTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.empPhoneTextBox.TabIndex = 15;
            // 
            // empDOB
            // 
            this.empDOB.AutoSize = true;
            this.empDOB.BackColor = System.Drawing.Color.White;
            this.empDOB.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empDOB.ForeColor = System.Drawing.Color.OrangeRed;
            this.empDOB.Location = new System.Drawing.Point(235, 172);
            this.empDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empDOB.Name = "empDOB";
            this.empDOB.Size = new System.Drawing.Size(125, 32);
            this.empDOB.TabIndex = 12;
            this.empDOB.Text = "Date of Birth";
            this.empDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empPosition
            // 
            this.empPosition.AutoSize = true;
            this.empPosition.BackColor = System.Drawing.Color.White;
            this.empPosition.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPosition.ForeColor = System.Drawing.Color.OrangeRed;
            this.empPosition.Location = new System.Drawing.Point(57, 172);
            this.empPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empPosition.Name = "empPosition";
            this.empPosition.Size = new System.Drawing.Size(84, 32);
            this.empPosition.TabIndex = 13;
            this.empPosition.Text = "Position";
            this.empPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empGender
            // 
            this.empGender.AutoSize = true;
            this.empGender.BackColor = System.Drawing.Color.White;
            this.empGender.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empGender.ForeColor = System.Drawing.Color.OrangeRed;
            this.empGender.Location = new System.Drawing.Point(256, 104);
            this.empGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empGender.Name = "empGender";
            this.empGender.Size = new System.Drawing.Size(77, 32);
            this.empGender.TabIndex = 8;
            this.empGender.Text = "Gender";
            this.empGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empAddress
            // 
            this.empAddress.AutoSize = true;
            this.empAddress.BackColor = System.Drawing.Color.White;
            this.empAddress.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAddress.ForeColor = System.Drawing.Color.OrangeRed;
            this.empAddress.Location = new System.Drawing.Point(62, 104);
            this.empAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empAddress.Name = "empAddress";
            this.empAddress.Size = new System.Drawing.Size(83, 32);
            this.empAddress.TabIndex = 9;
            this.empAddress.Text = "Address";
            this.empAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empAddressTextBox
            // 
            this.empAddressTextBox.BackColor = System.Drawing.Color.Snow;
            this.empAddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empAddressTextBox.DefaultText = "";
            this.empAddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empAddressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empAddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empAddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empAddressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empAddressTextBox.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold);
            this.empAddressTextBox.ForeColor = System.Drawing.Color.Black;
            this.empAddressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empAddressTextBox.Location = new System.Drawing.Point(24, 131);
            this.empAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empAddressTextBox.Name = "empAddressTextBox";
            this.empAddressTextBox.PasswordChar = '\0';
            this.empAddressTextBox.PlaceholderText = "";
            this.empAddressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.empAddressTextBox.SelectedText = "";
            this.empAddressTextBox.Size = new System.Drawing.Size(157, 38);
            this.empAddressTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.empAddressTextBox.TabIndex = 7;
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.BackColor = System.Drawing.Color.White;
            this.empName.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.ForeColor = System.Drawing.Color.OrangeRed;
            this.empName.Location = new System.Drawing.Point(227, 28);
            this.empName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(153, 32);
            this.empName.TabIndex = 5;
            this.empName.Text = "Employee Name";
            this.empName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empIdTextBox
            // 
            this.empIdTextBox.BackColor = System.Drawing.Color.Snow;
            this.empIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empIdTextBox.DefaultText = "";
            this.empIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empIdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empIdTextBox.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold);
            this.empIdTextBox.ForeColor = System.Drawing.Color.Black;
            this.empIdTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empIdTextBox.Location = new System.Drawing.Point(27, 62);
            this.empIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.PasswordChar = '\0';
            this.empIdTextBox.PlaceholderText = "";
            this.empIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.empIdTextBox.SelectedText = "";
            this.empIdTextBox.Size = new System.Drawing.Size(141, 38);
            this.empIdTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.empIdTextBox.TabIndex = 4;
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.BackColor = System.Drawing.Color.White;
            this.empId.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId.ForeColor = System.Drawing.Color.OrangeRed;
            this.empId.Location = new System.Drawing.Point(47, 28);
            this.empId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(122, 32);
            this.empId.TabIndex = 5;
            this.empId.Text = "Employee ID";
            this.empId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.BackColor = System.Drawing.Color.Snow;
            this.empNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empNameTextBox.DefaultText = "";
            this.empNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empNameTextBox.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold);
            this.empNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.empNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empNameTextBox.Location = new System.Drawing.Point(211, 62);
            this.empNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.PasswordChar = '\0';
            this.empNameTextBox.PlaceholderText = "";
            this.empNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.empNameTextBox.SelectedText = "";
            this.empNameTextBox.Size = new System.Drawing.Size(187, 38);
            this.empNameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.empNameTextBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.exitButton.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(1159, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 43);
            this.exitButton.TabIndex = 28;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1031, 537);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "© SnowFire Soft 2022";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1210, 575);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1210, 575);
            this.MinimumSize = new System.Drawing.Size(1210, 575);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private Guna.UI2.WinForms.Guna2TextBox empNameTextBox;
    private System.Windows.Forms.Button homeButton;
    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Button editButton;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.ComboBox empEduComboBox;
    private System.Windows.Forms.ComboBox empPosComboBox;
    private System.Windows.Forms.ComboBox empGenComboBox;
    private System.Windows.Forms.Label empEdu;
    private System.Windows.Forms.Label empPhone;
    private Guna.UI2.WinForms.Guna2TextBox empPhoneTextBox;
    private System.Windows.Forms.Label empDOB;
    private System.Windows.Forms.Label empPosition;
    private System.Windows.Forms.Label empGender;
    private System.Windows.Forms.Label empAddress;
    private Guna.UI2.WinForms.Guna2TextBox empAddressTextBox;
    private System.Windows.Forms.Label empName;
    private Guna.UI2.WinForms.Guna2TextBox empIdTextBox;
    private System.Windows.Forms.Label empId;
    private System.Windows.Forms.DateTimePicker empDOBPicker;
    private System.Windows.Forms.PictureBox pictureBox1;
    private Guna.UI2.WinForms.Guna2DataGridView empDGV;
    private System.Windows.Forms.Label exitButton;
    private System.Windows.Forms.Label label3;
  }
}