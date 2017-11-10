using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Keygen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rand1 = RandomString(5);
            string rand2 = RandomString(5);
            string rand3 = RandomString(5);
            string rand4 = RandomString(5);
            string rand5 = RandomString(5);
            textBox1.Text = rand1 + "-" + rand2 + "-" + rand3 + "-" + rand4 + "-" + rand5;

        }
        private static Random random = new Random((int)DateTime.Now.Ticks);
        private string RandomString(int Size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++)
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                ch = chars[random.Next(chars.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}