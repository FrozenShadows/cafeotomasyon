using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class UrunGuncelleForm : Form
    {
        public UrunGuncelleForm()
        {
            InitializeComponent();
        }

        public int SiparisNo = 0;

        public double YeniUcret = 0; 

        private void button1_Click(object sender, EventArgs e)
        {
            YeniUcret = Convert.ToDouble(numericUpDown1.Value);
            CafeDB.Urunler.UrunGuncelle(SiparisNo, YeniUcret);
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
