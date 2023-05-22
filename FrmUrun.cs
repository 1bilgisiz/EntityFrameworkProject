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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DBEntityUrunEntities db = new DBEntityUrunEntities();


        private void BTNLİSTELE_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun
                                        select new
                                        {

                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FİYAT,
                                            x.Tbl_Kategori.AD,
                                            x.DURUM
                                        }).ToList();
            
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            Tbl_Urun urun = new Tbl_Urun();
            urun.URUNAD = txturunad.Text;
            urun.MARKA = txtmarka.Text;
            urun.FİYAT = decimal.Parse(txtfiyat.Text);
            urun.STOK = short.Parse(txtstok.Text);
            urun.KATEGORİ = int.Parse(comboBox1.SelectedValue.ToString());
            urun.DURUM = true;
            db.Tbl_Urun.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün eklendi...");

        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var sorgu = db.Tbl_Urun.Find(x);
            db.Tbl_Urun.Remove(sorgu);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi...");
        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            urun.URUNAD = txturunad.Text;
            urun.STOK = short.Parse(txtstok.Text);
            urun.MARKA = txtmarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi...");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var KATEGORİLER = (from x in db.Tbl_Kategori
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = KATEGORİLER;
        }

        private void BTNTEMİZLE_Click(object sender, EventArgs e)
        {
            txturunad.Text = comboBox1.SelectedValue.ToString();

        }
    }
}
