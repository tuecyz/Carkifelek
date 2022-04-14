using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carkifelek
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        int rndSayi; 
        int sayac = 0;
        int resimSayaci = 0;
        public static int hakSayisi = 2;
        public static int haksayaci=0;
        public Form1()
        {
            InitializeComponent();

            PictureBox pbCark = new PictureBox();
            pbCark.SizeMode = PictureBoxSizeMode.Zoom;
            pbCark.Left = 100;
            pbCark.Top = 199;
            pbCark.Width = 100;
            pbCark.Height = 100;
            this.Controls.Add(pbCark);
            tmr.Interval = (500);
            
        }
        private void btnCarkiCevir_Click(object sender, EventArgs e)
        {
            
            if (hakSayisi!=haksayaci)
            {
                rndSayi = rnd.Next(24);
                tmr.Start();
            }
            else
            {
                MessageBox.Show("hakkın kalmadı");
            }
            haksayaci++;
            if (lblPuan.Text == "hak")
            {
                hakSayisi++;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            resimSayaci++;
            if (resimSayaci == 9)
            {
                resimSayaci = 1;
            }
            clsCark.carkiCevir(pbResim, resimSayaci);
            if (sayac == rndSayi)
            {
                tmr.Stop();
                clsCark.puanGetir(lblPuan, resimSayaci);
                clsCark.hesapla(lblToplamPuan);
                sayac = 0;
            }
        }
    }
}
