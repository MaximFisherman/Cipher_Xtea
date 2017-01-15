using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xtea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            XXTea x = new XXTea();
            string str = textBox1.Text;
            textBox2.Text = x.Encrypt(str, "1234567890123456");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            XXTea x = new XXTea();
            string str = textBox1.Text;
            textBox2.Text = x.Decrypt(str, "1234567890123456");
        }
    }
}
