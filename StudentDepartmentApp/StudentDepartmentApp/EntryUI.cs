using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDepartmentApp
{
    public partial class EntryUI : Form
    {
        public EntryUI()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            
            int regNo = Convert.ToInt32(regNoTextBox.Text);
            Department selectedDepartment = (Department)deptComboBox.SelectedItem;
            // int departmentid = selectedDepartment.Id;
            string connectionString = @"Data Source= FTFL\SQLEXPRESS; Database = StudentDB; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Student_TB VALUES('" + name + "','" + regNo + "','" + selectedDepartment.Id + "')";
            SqlCommand command = new SqlCommand(query, connection);
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowAffected > 0)
            {
                MessageBox.Show("Successfully Saved!");
            }
            else
            {
                MessageBox.Show("Couldn't Save the data ", " Error");
            }


        }

        private void EntryUI_Load(object sender, EventArgs e)
        {
            List<Department> departmentList = new List<Department>();
            string connectionString = @"Data Source= FTFL\SQLEXPRESS; Database = StudentDB; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Department_TB";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Department aDepartment = new Department();
                aDepartment.Id = (int)reader["Id"];
                aDepartment.Name = reader["Dept_Name"].ToString();
                departmentList.Add(aDepartment);

            }
            reader.Close();
            connection.Close();
            deptComboBox.Items.Clear();
            foreach (Department aDepartment in departmentList)
            {
                deptComboBox.Items.Add(aDepartment);
            }
            deptComboBox.DisplayMember = "Name";
            deptComboBox.ValueMember = "Id";
        }
    }
}
