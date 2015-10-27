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
    public partial class Form3 : Form
    {
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"H:\\GÖRSEL PROGRAMLAMA 2 ÖRNEKLERİ\\film\\film\\bin\\Debug\\cd.mdb\"");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cdDataSet.film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.cdDataSet.film);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
