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
  public partial class Employee : Form
  {
    public Employee()
    {
      InitializeComponent();
    }

    SqlConnection Con = new SqlConnection(@"Data Source=Nisa-DellMiniPC\SQLEXPRESS;Integrated Security=True");

    private void addButton_Click(object sender, EventArgs e)
    {
      if(empNameTextBox.Text == "" || empIdTextBox.Text == "" || empAddressTextBox.Text == "" || empPhoneTextBox.Text == "")
      {
        MessageBox.Show("Missing Information.");
      }
      else
      {
        try
        {
          Con.Open();
          string query = "insert into EmployeeTable values('" + empIdTextBox.Text + "', '" + empNameTextBox.Text + "', '" + empAddressTextBox.Text + "', '" + empPosComboBox.SelectedItem.ToString() + "', '" + empDOBPicker.Value.ToShortDateString() + "', '" + empPhoneTextBox.Text + "', '" + empEduComboBox.SelectedItem.ToString() + "', '" + empGenComboBox.SelectedItem.ToString() + "');";

          SqlCommand cmd = new SqlCommand(query, Con);
          cmd.ExecuteNonQuery();
          MessageBox.Show("Record Has Been Added Succesfully.");

          Con.Close();
          populate();
        }
        catch(Exception ex)
        {
          MessageBox.Show(ex.Message);
          Con.Close();
        }
      }
    }

    private void populate()
    {
      Con.Open();
      string query = "select * from EmployeeTable";

      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Con);
      SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
      var ds = new DataSet();
      sqlDataAdapter.Fill(ds);
      empDGV.DataSource = ds.Tables[0];
      Con.Close();
    }

    private void Employee_Load(object sender, EventArgs e)
    {
      populate();
      empPosComboBox.Text = "-----select-----";
      empEduComboBox.Text = "-----select-----";
      empGenComboBox.Text = "-----select-----";
      empDOBPicker.Text = "Tuesday, June 28, 1994";

    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      if (empNameTextBox.Text == "")
      {
        MessageBox.Show("Please Enter Employee ID.");
      }
      else
      {
        try
        {
          Con.Open();
          string query = "delete from EmployeeTable where empId = '" + empNameTextBox.Text + "';";

          SqlCommand cmd = new SqlCommand(query, Con);
          cmd.ExecuteNonQuery();
          MessageBox.Show("Record Has Been Deleted Succesfully.");

          Con.Close();
          populate();
          empNameTextBox.Text = "";

        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
          Con.Close();
        }
      }
    }

    private void empDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      empNameTextBox.Text = empDGV.SelectedRows[0].Cells[0].Value.ToString();
      empIdTextBox.Text = empDGV.SelectedRows[0].Cells[1].Value.ToString();
      empAddressTextBox.Text = empDGV.SelectedRows[0].Cells[2].Value.ToString();
      empPosComboBox.SelectedItem = empDGV.SelectedRows[0].Cells[3].Value.ToString();
      empPhoneTextBox.Text = empDGV.SelectedRows[0].Cells[5].Value.ToString();
      empEduComboBox.SelectedItem = empDGV.SelectedRows[0].Cells[6].Value.ToString();
      empGenComboBox.SelectedItem = empDGV.SelectedRows[0].Cells[7].Value.ToString();

    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void editButton_Click(object sender, EventArgs e)
    {
      if (empIdTextBox.Text == "" || empAddressTextBox.Text == "" || empPhoneTextBox.Text == "")
      {
        MessageBox.Show("Missing Information.");
      }
      else
      {
        try
        {
          Con.Open();
          string query = "update EmployeeTable set empName='" + empIdTextBox.Text + "', empAdd='" + empAddressTextBox.Text + "', empPos='" + empPosComboBox.SelectedItem.ToString() + "', empDOB='" + empDOBPicker.Value.ToShortDateString() + "', empPhone='" + empPhoneTextBox.Text + "', empEdu='" + empEduComboBox.SelectedItem.ToString() + "', empGen='" + empGenComboBox.SelectedItem.ToString() + "' where empId='" + empNameTextBox.Text + "';";

          SqlCommand cmd = new SqlCommand(query, Con);
          cmd.ExecuteNonQuery();
          MessageBox.Show("Record Has Been Updated Succesfully.");

          Con.Close();
          populate();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
          Con.Close();
        }
      }
    }

    private void homeButton_Click(object sender, EventArgs e)
    {
      Home home = new Home();
      home.Show();
      this.Hide();
    }
  }
}
