using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CD_Otomasyon
{
    public partial class Form6 : Form

    {
        public OleDbConnection Bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"C:\\Documents and Settings\\bilgi işlem\\Belgelerim\\Visual Studio 2010\\Projects\\CD_Otomasyon\\CD_Otomasyon\\bin\\Debug\\CDci.mdb\"");
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bag.Open();
                string sorgu = string.Format("insert into FilmTip (FTAdi) values ('{0}')", textBox1.Text);
                OleDbCommand komut = new OleDbCommand(sorgu, Bag);
                komut.ExecuteNonQuery();
                label2.Text = "Kayıt başarılı olarak eklendi..";

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata" + hata.Message);
            }
            finally
            {
                Bag.Close();
            }
        }
    }
}
