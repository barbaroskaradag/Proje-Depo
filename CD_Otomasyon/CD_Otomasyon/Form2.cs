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
    public partial class Form2 : Form
    {
        public OleDbConnection Bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"C:\\Documents and Settings\\bilgi işlem\\Belgelerim\\Visual Studio 2010\\Projects\\CD_Otomasyon\\CD_Otomasyon\\bin\\Debug\\CDci.mdb\"");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDciDataSet.FilmTip' table. You can move, or remove it, as needed.
            this.filmTipTableAdapter.Fill(this.cDciDataSet.FilmTip);
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool odunc;
            string fadi = textBox1.Text;
            int ftno = int.Parse(comboBox1.Text);
            if (checkBox1.Checked)
                odunc=true;
            else
                odunc=false;
            try
            {
                Bag.Open();
                MessageBox.Show("VT bağlantısı başarı ile sağlandı");
                string Sorgu = string.Format("insert into Film (FAdi,FTNo,Oduncmu) values('{0}',{1},{2})",fadi,ftno,odunc);
                OleDbCommand komut = new OleDbCommand(Sorgu,Bag);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                label3.Text = "Kayıt Başarılı olarak eklendi";

            }
            catch (Exception hata)
            {
                label3.Text = "Hata oldu. İçeriği:" + hata.Message;

            }
            finally
            {
                Bag.Close();
            }
        }
    }
}
