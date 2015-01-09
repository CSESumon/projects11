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
using System.Windows.Forms.VisualStyles;
using Microsoft.SqlServer.Server;

namespace UniversityApp
{
    public partial class ViewUI : Form
    {
        public ViewUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string inputId = idTextBox.Text;
            string connectionString = @"Data Source= (LOCAL)\SQLEXPRESS; Database = University DB; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT* FROM T_STUDENT";
            if (inputId != "")
            {
                query = "Select* FROM T_STUDENT WHERE ID = '"+inputId+"'";
            }
            List<Student> students = new List<Student>();
            SqlCommand command = new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();
           
            resultlistView.Items.Clear();
            while (reader.Read())
            {
                 Student aStudent = new Student();
                aStudent.id = (int) reader["Id"];
                aStudent.name = reader["Name"].ToString();
                aStudent.address = reader["Address"].ToString();
                aStudent.phone = reader["PhoneNumber"].ToString();
                aStudent.email = reader["EmailAddress"].ToString();
                students.Add(aStudent);
            



            ListViewItem myView = new ListViewItem();


                    myView.Text = (aStudent.id.ToString());
                    myView.SubItems.Add(aStudent.name);
                    myView.SubItems.Add(aStudent.address);
                    myView.SubItems.Add(aStudent.phone);
                    myView.SubItems.Add(aStudent.email);
                    
                    resultlistView.Items.Add(myView);
                    myView.Tag = aStudent;

                }

            
            connection.Close();
        }

     

        private void resultlistView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selecetedItems = resultlistView.SelectedItems[0];
            Student selectedStudent = (Student) selecetedItems.Tag;
            idlabel.Text = selectedStudent.id.ToString();
            nameTextBox.Text = selectedStudent.name;
            addressTextBox.Text = selectedStudent.address;
            phoneTextBox.Text = selectedStudent.phone;
            emailtextBox.Text = selectedStudent.email;
           

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source= (LOCAL)\SQLEXPRESS; Database = University DB; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
           // string query = "UPDATE T_Student SET Name = '" + nameTextBox.Text + "',Address = '" + addressTextBox.Text +
                          // "',PhoneNumber = '" + phoneTextBox.Text + "',EmailAddress = '" + emailtextBox.Text +
                         //  "'Where id ='" + idlabel.Text+ "'";
            string query = String.Format ("Update T_Student Set Name = '{0}',Address =  '{1}',PhoneNumber =  '{2}', EmailAddress =  '{3}'where id =  '{4}'",nameTextBox.Text,addressTextBox.Text,phoneTextBox.Text,emailtextBox.Text,idlabel.Text) ; 
            SqlCommand command = new SqlCommand(query, connection);
            int rowAffected = command.ExecuteNonQuery();
          connection.Close();
            if (rowAffected == 1)
            {
                MessageBox.Show("Succesfully Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

      
    }
}
