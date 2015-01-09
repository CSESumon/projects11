using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDepartmentApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            EntryUI entry=new EntryUI();
            entry.Show();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Student_DB_UI form1=new Student_DB_UI();
            form1.Show();
        }
    }
}
