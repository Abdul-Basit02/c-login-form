using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email = textBox1.Text;
            String pass = textBox2.Text;

            String EMAIL = "basit@gmail.com";
            String PASS = "12345";

            if (email == email && pass == PASS)
            {
               MessageBox.Show("! You are now signed in.");
            }
            else
                MessageBox.Show("Access denied. Please check your credentials.");
        }
    }
}
