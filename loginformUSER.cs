using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Storage;
using System.IO;
namespace RIOFLIX123
{
    public partial class loginformUSER : Form
    {
        public loginformUSER()
        {
            InitializeComponent();
        }

        private void loginformUSER_Load(object sender, EventArgs e)
        {
            userlogin us = new userlogin(this);
            us.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(us);
        }

        private void userlogin1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
