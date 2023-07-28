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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }
        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void pictureBoxYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC0bHYrQkjif7o6aj7t6GiyA");
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100011246022684");
        }

        private void pictureBoxInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/nguyenthuphuong2913/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
