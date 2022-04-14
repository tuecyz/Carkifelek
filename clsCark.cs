using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

public static class clsCark
{
    public static int toplamPuan=0;
    public static void carkiCevir(PictureBox pbResim, int sayac)
    {
            string sDosyaKonumu = "resimler\\Carkifelek";
            pbResim.SizeMode = PictureBoxSizeMode.Zoom;
            pbResim.ImageLocation = sDosyaKonumu + sayac + ".png";
    }
    public static void puanGetir(Label lblPuan,int sayac2)
    {
        if (sayac2 == 1)
        {
            lblPuan.Text="puanınız 100";
            toplamPuan = toplamPuan + 100;
        }
        else if (sayac2 == 2)
        {
            lblPuan.Text="iflas";
            toplamPuan = 0;
        }
        else if (sayac2 == 3)
        {
            lblPuan.Text="puanınız 200";
            toplamPuan = toplamPuan + 200;
        }
        else if (sayac2 == 4)
        {
            lblPuan.Text="hak";
            
        }
        else if (sayac2 == 5)
        {
            lblPuan.Text="puanınız 500";
            toplamPuan = toplamPuan + 500;
        }
        else if (sayac2 == 6)
        {
            lblPuan.Text="iflas";
            toplamPuan = 0;
        }
        else if (sayac2 == 7)
        {
            lblPuan.Text="puanınız 5000";
            toplamPuan = toplamPuan + 5000;
        }
        else if (sayac2 == 8)
        {
            lblPuan.Text="puanınız 2000";
            toplamPuan = toplamPuan + 2000;
        }

    }
    
    public static void hesapla(Label lblToplam)
    {
        lblToplam.Text = toplamPuan.ToString();
    }
}