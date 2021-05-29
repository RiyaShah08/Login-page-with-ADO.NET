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

    public partial class Form1 : Form
    {
        string AName = "Riya", Username = "UVPCE", Password = "123456";

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Reset R1 = new Reset();
            R1.Show();
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name1 = textBox1.Text;
            string username1 = textBox2.Text;
            string password1 = textBox3.Text;
            string confirmpassword1 = textBox4.Text;

            if (username1.Equals(Username) && password1.Equals(Password) && confirmpassword1.Equals(Password))
            {
                Home h2 = new Home(AName);
                h2.Show();
                this.Hide();
            }
        } 
    }
}
