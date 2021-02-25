using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARA
{
    public partial class Form4 : Form
    {
        User us = new User();
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 rm3 = new Form3();
            rm3.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="" && textBox2.Text!= "" && textBox4.Text!= "" && textBox5.Text != "")
            {
                us.Email = textBox1.Text;
                us.Password = textBox2.Text;
                us.FirstName = textBox3.Text;
                us.LastName = textBox4.Text;
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }
    }
}
