using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace film
{
    public partial class Form2 : Form
    {
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"H:\\GÖRSEL PROGRAMLAMA 2 ÖRNEKLERİ\\film\\film\\bin\\Debug\\cd.mdb\"");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fadi = textBox1.Text;
            int ftno = int.Parse(textBox2.Text);
            bool odunc;

            if (checkBox1.Checked)
            {
                odunc = true;
            }
            else
            {
                odunc = false;
            }

            try
            {
                bag.Open();
                MessageBox.Show("Vt bağlantısı başarı ile sağlandı");
                string sorgu = string.Format("insert into film(FAdi,FTno,Oduncmu) values ('{0}',{1},{2})",fadi,ftno,odunc);
                OleDbCommand komut = new OleDbCommand(sorgu, bag);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi...");
                label4.Text = "Kayıt başarılı olarak eklendi";

            }
            catch (Exception hata)
            {
                label4.Text = "hata içeriği : " + hata.Message;
            }
            finally
            {
                bag.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
