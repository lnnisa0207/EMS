using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
      if (loginTextBox.Text == "" || passwordTextBox.Text == "")
      {
        MessageBox.Show("Please Enter Username and Password");
      }
      else if (loginTextBox.Text == "Admin" && passwordTextBox.Text == "Admin12345")
      {
        Home home = new Home();
        home.Show();
        this.Hide();
      }
      else
      {
        MessageBox.Show("Username or/and Password is Wrong.");
        loginTextBox.Text = "";
        passwordTextBox.Text = "";
      }
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      loginTextBox.Text = "";
      passwordTextBox.Text = "";
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
