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

namespace EMS
{
  public partial class Salary : Form
  {
    public Salary()
    {
      InitializeComponent();
    }

    string ID;

    SqlConnection Con = new SqlConnection(@"Data Source=Nisa-DellMiniPC\SQLEXPRESS;Integrated Security=True");
    private void fetchEmpData()
    {
      if(empIdTextBox.Text == "")
      {
        MessageBox.Show("Please Enter Employee ID.");
        empIdTextBox.Text = "";
      }
      else
      {
        Con.Open();
        string query = "select * from EmployeeTable where empId='" + empIdTextBox.Text + "';";

        SqlCommand cmd = new SqlCommand(query, Con);
        DataTable dt = new DataTable();

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
          empNameTextBox.Text = dr["empName"].ToString();
          empPosTextBox.Text = dr["empPos"].ToString();
        }

        Con.Close();
      }
    }

    private void fetchButton_Click(object sender, EventArgs e)
    {
      Con.Open();
      string query = "select * from EmployeeTable where empId='" + empIdTextBox.Text + "';";

      SqlCommand cmd = new SqlCommand(query, Con);
      DataTable dt = new DataTable();

      SqlDataAdapter sda = new SqlDataAdapter(cmd);
      sda.Fill(dt);

      foreach (DataRow dr in dt.Rows)
      {
        ID = dr["empId"].ToString();
      }

      Con.Close();

      if(ID==empIdTextBox.Text)
      {
        fetchEmpData();
      }
      else
      {
        MessageBox.Show("Please Enter A Correct Employee ID.");
        empIdTextBox.Text = "";
        empNameTextBox.Text = "";
        empPosTextBox.Text = "";
      }
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private int Dailybase, Total;

    private void homeButton_Click(object sender, EventArgs e)
    {
      Home home = new Home();
      home.Show();
      this.Hide();
    }

    private void viewButton_Click(object sender, EventArgs e)
    {
      if (empPosTextBox.Text == "")
      {
        MessageBox.Show("Please Select an Employee.");
      }
      else if (wDaysTextBox.Text == "" || Convert.ToInt32(wDaysTextBox.Text) > 28)
      {
        MessageBox.Show("Please Enter A Valid Number of Days.");
      }
      else
      {
        if (empPosTextBox.Text == "Administrator")
        {
          Dailybase = 100;
        }
        else if (empPosTextBox.Text == "Manager")
        {
          Dailybase = 80;
        }
        else if (empPosTextBox.Text == "Senior Developer")
        {
          Dailybase = 60;
        }
        else if (empPosTextBox.Text == "Junior Developer")
        {
          Dailybase = 50;
        }
        else if (empPosTextBox.Text == "Receiptionist")
        {
          Dailybase = 20;
        }

        Total = Dailybase * Convert.ToInt32(wDaysTextBox.Text);

        empIdTb.Text = empNameTextBox.Text;
        empNameTb.Text = empIdTextBox.Text;
        empPosTb.Text = empPosTextBox.Text;
        workDaysTb.Text = wDaysTextBox.Text;
        dailySalaryTb.Text = "$" + Dailybase.ToString();
        totalAmtTb.Text = "$" + Total.ToString();
      }
    }
  }
}
