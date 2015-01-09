using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class MenuUI : Form
    {
        public MenuUI()
        {
            InitializeComponent();
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
           StudentEntity student = new StudentEntity();
            student.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewUI menu = new ViewUI();
            menu.Show();
        }
    }
}
