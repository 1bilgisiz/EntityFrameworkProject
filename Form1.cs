using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EntityProjeUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBEntityUrunEntities db = new DBEntityUrunEntities();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var kt = db.Tbl_Kategori.ToList();
            dataGridView1.DataSource = kt;

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Kategori t = new Tbl_Kategori();
            t.AD = textBox2.Text;
            db.Tbl_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);

            var kategorisil = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(kategorisil);
            db.SaveChanges();
            MessageBox.Show("Katgeori Silindi");

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var kategorisil = db.Tbl_Kategori.Find(x);
            kategorisil.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
        }
    }
}