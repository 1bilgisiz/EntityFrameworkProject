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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBEntityUrunEntities db = new DBEntityUrunEntities();
            var sorgu = from x in db.Tbl_Admin where x.KULLANICI == textBox1.Text && x.SİFRE == textBox2.Text select x;
            if (sorgu.Any())
            {

                FrmAnaForm ana = new FrmAnaForm();

                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı yada Şifre Hatalı...!");

            }
        }
    }
}
