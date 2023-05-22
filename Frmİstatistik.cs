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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        DBEntityUrunEntities db = new DBEntityUrunEntities();


        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategori.Count().ToString();
            label3.Text = db.Tbl_Urun.Count().ToString();
            label5.Text = db.Tbl_Musteri.Count(x=>x.DURUM==true).ToString();
            label7.Text = db.Tbl_Musteri.Count(x=>x.DURUM==false).ToString();
            label19.Text = db.Tbl_Satıs.Sum(x => x.FIYAT).ToString() + "TL";
            label13.Text = (from x in db.Tbl_Urun orderby x.FİYAT descending select x.URUNAD).FirstOrDefault();
            label15.Text = (from x in db.Tbl_Urun orderby x.FİYAT ascending select x.URUNAD).FirstOrDefault();
            label9.Text = db.Tbl_Urun.Count(x=>x.KATEGORİ==1).ToString();
            label23.Text = db.Tbl_Urun.Count(x=>x.URUNAD=="BUZDOLABI").ToString();
            label17.Text = (from a in db.Tbl_Musteri select a.SEHIR).Distinct().Count().ToString(); 
            label21.Text= db.MARKAGETİR().FirstOrDefault().ToString();
            label11.Text= db.Tbl_Urun.Sum(y=>y.STOK).ToString();    

        }
    }
}
