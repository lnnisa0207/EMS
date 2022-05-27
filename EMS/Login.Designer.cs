namespace EMS
{
  partial class Login
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
      this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
      this.loginButton = new System.Windows.Forms.Button();
      this.clearButton = new System.Windows.Forms.Button();
      this.exitButton = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.OrangeRed;
      this.label1.Location = new System.Drawing.Point(13, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(176, 43);
      this.label1.TabIndex = 1;
      this.label1.Text = "SnowFire Soft";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(82, 77);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(116, 104);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // loginTextBox
      // 
      this.loginTextBox.BackColor = System.Drawing.Color.Snow;
      this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.loginTextBox.DefaultText = "";
      this.loginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
      this.loginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
      this.loginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
      this.loginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
      this.loginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
      this.loginTextBox.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
      this.loginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
      this.loginTextBox.Location = new System.Drawing.Point(268, 77);
      this.loginTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.loginTextBox.Name = "loginTextBox";
      this.loginTextBox.PasswordChar = '\0';
      this.loginTextBox.PlaceholderText = "Username";
      this.loginTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.loginTextBox.SelectedText = "";
      this.loginTextBox.Size = new System.Drawing.Size(157, 38);
      this.loginTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
      this.loginTextBox.TabIndex = 3;
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.BackColor = System.Drawing.Color.Snow;
      this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.passwordTextBox.DefaultText = "";
      this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
      this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
      this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
      this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
      this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
      this.passwordTextBox.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
      this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
      this.passwordTextBox.Location = new System.Drawing.Point(268, 140);
      this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.PasswordChar = '\0';
      this.passwordTextBox.PlaceholderText = "Password";
      this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.passwordTextBox.SelectedText = "";
      this.passwordTextBox.Size = new System.Drawing.Size(157, 38);
      this.passwordTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
      this.passwordTextBox.TabIndex = 4;
      // 
      // loginButton
      // 
      this.loginButton.BackColor = System.Drawing.Color.OrangeRed;
      this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.loginButton.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
      this.loginButton.ForeColor = System.Drawing.Color.White;
      this.loginButton.Location = new System.Drawing.Point(316, 212);
      this.loginButton.Margin = new System.Windows.Forms.Padding(4);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(109, 37);
      this.loginButton.TabIndex = 5;
      this.loginButton.Text = "Login";
      this.loginButton.UseVisualStyleBackColor = false;
      this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
      // 
      // clearButton
      // 
      this.clearButton.BackColor = System.Drawing.Color.OrangeRed;
      this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.clearButton.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
      this.clearButton.ForeColor = System.Drawing.Color.White;
      this.clearButton.Location = new System.Drawing.Point(198, 212);
      this.clearButton.Margin = new System.Windows.Forms.Padding(4);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(109, 37);
      this.clearButton.TabIndex = 6;
      this.clearButton.Text = "Clear";
      this.clearButton.UseVisualStyleBackColor = false;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // exitButton
      // 
      this.exitButton.AutoSize = true;
      this.exitButton.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.exitButton.ForeColor = System.Drawing.Color.OrangeRed;
      this.exitButton.Location = new System.Drawing.Point(502, 9);
      this.exitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(35, 43);
      this.exitButton.TabIndex = 7;
      this.exitButton.Text = "X";
      this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(550, 281);
      this.Controls.Add(this.exitButton);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.loginButton);
      this.Controls.Add(this.passwordTextBox);
      this.Controls.Add(this.loginTextBox);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximumSize = new System.Drawing.Size(550, 281);
      this.MinimumSize = new System.Drawing.Size(550, 281);
      this.Name = "Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private Guna.UI2.WinForms.Guna2TextBox loginTextBox;
    private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
    private System.Windows.Forms.Button loginButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Label exitButton;
  }
}