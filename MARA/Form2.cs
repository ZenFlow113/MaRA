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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 rm3 = new Form3();
            rm3.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 rm4 = new Form4();
            rm4.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //back
            Hide();
            Form1 rm1 = new Form1();
            rm1.ShowDialog();
            Close();
        }
    }
}