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

namespace UniversityApp
{
    public partial class StudentEntity : Form
    {
        public StudentEntity()
        {
            InitializeComponent();
        }

        
        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;

            string connectionString = @"Data Source= (LOCAL)\SQLEXPRESS; Database = University DB; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO T_STUDENT VALUES('" +name+ "','" +address+ "','" +phone+ "','" +email+"')";
            SqlCommand command = new SqlCommand(query,connection);
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

        private void closeButton_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
