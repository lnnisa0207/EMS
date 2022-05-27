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
  public partial class Home : Form
  {
    public Home()
    {
      InitializeComponent();
    }

    private void empLabel_Click(object sender, EventArgs e)
    {
      Employee emp = new Employee();
      emp.Show();
      this.Hide();
    }

    private void empPictureBox_Click(object sender, EventArgs e)
    {
      Employee emp = new Employee();
      emp.Show();
      this.Hide();
    }

    private void logoutPictureBox_Click(object sender, EventArgs e)
    {
      Login login = new Login();
      login.Show();
      this.Hide();
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
      Login login = new Login();
      login.Show();
      this.Hide();
    }

    private void ViewPictureBox_Click(object sender, EventArgs e)
    {
      ViewEmployee viewEmployee = new ViewEmployee();
      viewEmployee.Show();
      this.Hide();
    }

    private void viewLabel_Click(object sender, EventArgs e)
    {
      ViewEmployee viewEmployee = new ViewEmployee();
      viewEmployee.Show();
      this.Hide();
    }

    private void salPictureBox_Click(object sender, EventArgs e)
    {
      Salary salary = new Salary();
      salary.Show();
      this.Hide();
    }

    private void salaryLabel_Click(object sender, EventArgs e)
    {
      Salary salary = new Salary();
      salary.Show();
      this.Hide();
    }
  }
}
