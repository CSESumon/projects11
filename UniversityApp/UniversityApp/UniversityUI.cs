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
    public partial class UniversityUI : Form
    {
        public UniversityUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Database aDatabase = new Database();
            showListView.Items.Clear();
            aDatabase.ReadData(idSearchTextBox.Text);
            
            foreach (Student aStudent in aDatabase.students)
            {
                ListViewItem myView = new ListViewItem();
                myView.Text = (aStudent.Id.ToString());
                myView.SubItems.Add(aStudent.Name);
                myView.SubItems.Add(aStudent.Address);
                myView.SubItems.Add(aStudent.Phone);
                myView.SubItems.Add(aStudent.Department);

                showListView.Items.Add(myView);
            }
            
        }

            
            
        }
    }


  