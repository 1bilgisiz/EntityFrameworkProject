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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void BtnKategori_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            FrmUrun frmUrun = new FrmUrun();    
            frmUrun.Show();
        }

        private void Btnİstatiktik_Click(object sender, EventArgs e)
        {
            Frmİstatistik frmİstatistik = new Frmİstatistik();
            frmİstatistik.Show();
        }
    }
}
