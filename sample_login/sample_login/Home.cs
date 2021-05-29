using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_login
{
    public partial class Home : Form
    {
        //string f1;
        public Home(string AName)
        {
            InitializeComponent();
            label2.Text += " " +AName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

     
    }
}

