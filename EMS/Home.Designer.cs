namespace EMS
{
  partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salPictureBox = new System.Windows.Forms.PictureBox();
            this.viewLabel = new System.Windows.Forms.Label();
            this.ViewPictureBox = new System.Windows.Forms.PictureBox();
            this.empLabel = new System.Windows.Forms.Label();
            this.empPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.salaryLabel);
            this.panel1.Controls.Add(this.salPictureBox);
            this.panel1.Controls.Add(this.viewLabel);
            this.panel1.Controls.Add(this.ViewPictureBox);
            this.panel1.Controls.Add(this.empLabel);
            this.panel1.Controls.Add(this.empPictureBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 273);
            this.panel1.TabIndex = 0;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.BackColor = System.Drawing.Color.White;
            this.salaryLabel.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.salaryLabel.Location = new System.Drawing.Point(535, 205);
            this.salaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(67, 32);
            this.salaryLabel.TabIndex = 8;
            this.salaryLabel.Text = "Salary";
            this.salaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.salaryLabel.Click += new System.EventHandler(this.salaryLabel_Click);
            // 
            // salPictureBox
            // 
            this.salPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("salPictureBox.Image")));
            this.salPictureBox.Location = new System.Drawing.Point(527, 74);
            this.salPictureBox.Name = "salPictureBox";
            this.salPictureBox.Size = new System.Drawing.Size(76, 110);
            this.salPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.salPictureBox.TabIndex = 7;
            this.salPictureBox.TabStop = false;
            this.salPictureBox.Click += new System.EventHandler(this.salPictureBox_Click);
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.BackColor = System.Drawing.Color.White;
            this.viewLabel.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.viewLabel.Location = new System.Drawing.Point(344, 205);
            this.viewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(56, 32);
            this.viewLabel.TabIndex = 6;
            this.viewLabel.Text = "View";
            this.viewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewLabel.Click += new System.EventHandler(this.viewLabel_Click);
            // 
            // ViewPictureBox
            // 
            this.ViewPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ViewPictureBox.Image")));
            this.ViewPictureBox.Location = new System.Drawing.Point(330, 74);
            this.ViewPictureBox.Name = "ViewPictureBox";
            this.ViewPictureBox.Size = new System.Drawing.Size(76, 110);
            this.ViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewPictureBox.TabIndex = 5;
            this.ViewPictureBox.TabStop = false;
            this.ViewPictureBox.Click += new System.EventHandler(this.ViewPictureBox_Click);
            // 
            // empLabel
            // 
            this.empLabel.AutoSize = true;
            this.empLabel.BackColor = System.Drawing.Color.White;
            this.empLabel.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.empLabel.Location = new System.Drawing.Point(144, 205);
            this.empLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empLabel.Name = "empLabel";
            this.empLabel.Size = new System.Drawing.Size(98, 32);
            this.empLabel.TabIndex = 4;
            this.empLabel.Text = "Employee";
            this.empLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.empLabel.Click += new System.EventHandler(this.empLabel_Click);
            // 
            // empPictureBox
            // 
            this.empPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("empPictureBox.Image")));
            this.empPictureBox.Location = new System.Drawing.Point(153, 74);
            this.empPictureBox.Name = "empPictureBox";
            this.empPictureBox.Size = new System.Drawing.Size(76, 110);
            this.empPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empPictureBox.TabIndex = 3;
            this.empPictureBox.TabStop = false;
            this.empPictureBox.Click += new System.EventHandler(this.empPictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(289, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "SnowFire Soft";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutPictureBox
            // 
            this.logoutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoutPictureBox.Image")));
            this.logoutPictureBox.Location = new System.Drawing.Point(648, 31);
            this.logoutPictureBox.Name = "logoutPictureBox";
            this.logoutPictureBox.Size = new System.Drawing.Size(46, 42);
            this.logoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutPictureBox.TabIndex = 3;
            this.logoutPictureBox.TabStop = false;
            this.logoutPictureBox.Click += new System.EventHandler(this.logoutPictureBox_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackColor = System.Drawing.Color.OrangeRed;
            this.logoutButton.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(701, 36);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 43);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(625, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "© SnowFire Soft 2022";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.logoutPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox empPictureBox;
    private System.Windows.Forms.Label salaryLabel;
    private System.Windows.Forms.PictureBox salPictureBox;
    private System.Windows.Forms.Label viewLabel;
    private System.Windows.Forms.PictureBox ViewPictureBox;
    private System.Windows.Forms.Label empLabel;
    private System.Windows.Forms.PictureBox logoutPictureBox;
    private System.Windows.Forms.Label logoutButton;
    private System.Windows.Forms.Label label3;
  }
}