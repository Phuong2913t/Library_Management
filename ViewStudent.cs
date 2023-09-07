using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void txtSearchEnrollement_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchEnrollement.Text != "")
            {
                Image image = Image.FromFile("C:/Users/pc/Desktop/Liberay Management System/search1.gif");
                pictureBox1.Image = image;
            }
            else
            {
                Image image = Image.FromFile("C:/Users/pc/Desktop/Liberay Management System/search.gif");
                pictureBox1.Image = image;
            }
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
