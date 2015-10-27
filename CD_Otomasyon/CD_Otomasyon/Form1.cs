using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CD_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();//Class yapısı
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();//Class yapısı
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();//Class yapısı
            frm.Show();
        }
    }
}
