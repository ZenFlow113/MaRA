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
    public partial class Form3 : Form
    {
        public User User { get; private set; }
        public static Form3 AUT { get; set; }
        public static User usr { get; set; }

        ADOMARA db = new ADOMARA();
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно ввести логин и пароль.");
                return;
            }
            User us = db.User.Find(textBox1.Text);
            if ((usr != null) && (usr.Password == textBox2.Text)) ;
            {
                User = usr;
                AUT = this;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 rm2 = new Form2();
            rm2.ShowDialog();
            Close();
        }
    }
}