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
    public partial class Student_DB_UI : Form
    {
        public Student_DB_UI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        
            string inputId = searchTextBox.Text;
            string connectionString = @"Data Source= FTFL\SQLEXPRESS; Database = StudentDB; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT Student_TB.Id, Student_TB.Name,Student_TB.Reg_No,Department_TB.Dept_name FROM Student_TB JOIN Department_TB ON Student_TB.Dept_Id = Department_TB.Id";
            if (inputId != "")
            {
                query = "SELECT Student_TB.Id, Student_TB.Name,Student_TB.Reg_No, Department_TB.Dept_name FROM Student_TB JOIN Department_TB ON Student_TB.Dept_Id = Department_TB.Id WHERE Student_TB.Id = '" + inputId + "'";
            }
            List<Student> students = new List<Student>();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            showListView.Items.Clear();
            while (reader.Read())
            {
                Student aStudent = new Student();
                aStudent.Id = (int)reader["Id"];
                aStudent.Name = reader["Name"].ToString();
                aStudent.RegNo = reader["Reg_No"].ToString();
                aStudent.Department = reader["Dept_name"].ToString();
                students.Add(aStudent);




                ListViewItem myView = new ListViewItem();


                myView.Text = (aStudent.Id.ToString());
                myView.SubItems.Add(aStudent.Name);
                myView.SubItems.Add(aStudent.RegNo);
                myView.SubItems.Add(aStudent.Department);

                showListView.Items.Add(myView);

            }


            connection.Close();
        
        }
    }
}
