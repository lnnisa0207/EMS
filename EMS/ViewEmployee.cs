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
  public partial class ViewEmployee : Form
  {
    public ViewEmployee()
    {
      InitializeComponent();
    }

    SqlConnection Con = new SqlConnection(@"Data Source=Nisa-DellMiniPC\SQLEXPRESS;Integrated Security=True");

    private void homeButton_Click(object sender, EventArgs e)
    {
      Home home = new Home();
      home.Show();
      this.Hide();
    }


    private void fetchEmpData()
    {
      Con.Open();
      string query = "select * from EmployeeTable where empId='" + empIdTextBox.Text + "';";

      SqlCommand cmd = new SqlCommand(query, Con);
      DataTable dt = new DataTable();

      SqlDataAdapter sda = new SqlDataAdapter(cmd);
      sda.Fill(dt);
      
      foreach(DataRow dr in dt.Rows)
      {
        showEmpId.Text = dr["empId"].ToString();
        showEmpName.Text = dr["empName"].ToString();
        showEmpAddress.Text = dr["empAdd"].ToString();
        showEmpPosition.Text = dr["empPos"].ToString();
        showEmpPhone.Text = dr["empPhone"].ToString();
        showEmpGender.Text = dr["empGen"].ToString();
        showEmpDOB.Text = dr["empDOB"].ToString();
        showEmpEdu.Text = dr["empEdu"].ToString();
      }

      Con.Close();
    }

    private void refreshButton_Click(object sender, EventArgs e)
    {
      fetchEmpData();
    }

    private void exitButtonLabel_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
