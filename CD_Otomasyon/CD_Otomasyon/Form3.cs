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
    public partial class Form3 : Form
    {
        public OleDbConnection Bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"C:\\Documents and Settings\\bilgi işlem\\Belgelerim\\Visual Studio 2010\\Projects\\CD_Otomasyon\\CD_Otomasyon\\bin\\Debug\\CDci.mdb\"");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bag.Open();
                MessageBox.Show("VT bağlantısı sağlandı...");
                string sorgu = string.Format("select * from Film");
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Bag);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ht)
            {
                MessageBox.Show("Hata oldu..." + ht.Message);
            }
            finally
            {
                Bag.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Bag.Open();
                int fno = int.Parse(textBox1.Text);
                string Ssorgu = string.Format("delete from Film where FNo={0}", fno);
                OleDbCommand komut = new OleDbCommand(Ssorgu, Bag);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı bir şekilde silindi." );
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oldu." + hata.Message);
            }
            finally
            {
                Bag.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Bag.Open();
                int y_fno = int.Parse(textBox2.Text);
                string YSorgu = string.Format("select * from Film where FNo={0}", y_fno);
                OleDbCommand komut = new OleDbCommand(YSorgu, Bag);
                OleDbDataReader dr = komut.ExecuteReader();
                dr.Read();

                textBox4.Text = dr.GetValue(1).ToString();
                textBox3.Text = dr.GetValue(2).ToString();
                if (dr.GetValue(3).ToString() != "true")
                    checkBox1.Checked=true;
                else
                    checkBox1.Checked = false;
            }
            catch (Exception ht)
            {
                MessageBox.Show("hata oldu:" + ht.Message);
            }
            finally
            {
                Bag.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool od;
            string fadi = textBox4.Text;
            int ftno = int.Parse(textBox3.Text);
            if (checkBox1.Checked)
                od = true;
            else
                od = false;
            try
            {
                Bag.Open();
            string GSorgu = string.Format("update Film set FAdi='{0}',FTNo={1},Oduncmu={2} where FNo={3}",fadi,ftno,od,int.Parse(textBox2.Text));
            OleDbCommand kmt = new OleDbCommand(GSorgu,Bag);
            kmt.ExecuteNonQuery();
            label4.Text = "Güncelleme başarı ile yapıldı...";
            }
            catch(Exception h)
            {
            MessageBox.Show("hata="+h.Message);
            }
            finally
            {
            Bag.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                Bag.Open();
                string sorgu = string.Format("select * from film where Oduncmu = true");
                OleDbDataAdapter ad = new OleDbDataAdapter(sorgu, Bag);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : " + hata.Message);
            }
            finally 
            {
                Bag.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Bag.Open();
                string sorgu = string.Format("select * from FilmTip");
                OleDbDataAdapter ae = new OleDbDataAdapter(sorgu, Bag);
                DataSet dd = new DataSet();
                ae.Fill(dd);
                dataGridView1.DataSource = dd.Tables[0];
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
            finally 
            {
                Bag.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }
    }
}
