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
    public partial class KullaniciGuncelleTur : Form
    {
        public KullaniciGuncelleTur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciYetkiCombo.Enabled = false;
            this.Hide();
        }

        private void KullaniciGuncelleTur_Load(object sender, EventArgs e)
        {
            KullaniciYetkiCombo.Enabled = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
