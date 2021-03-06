﻿using Ambiance;
using KalipServiceWCF;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace KalipApp
{
    public partial class Detay : Form
    {
        public Detay()
        {
            InitializeComponent();
        }

        private KalipServiceReference1.KalipServiceClient kalipService = new KalipApp.KalipServiceReference1.KalipServiceClient();

        private void ambiance_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }
        int click = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            click++;
            if (click % 2 != 0)
            {
                txtBaskiSuresi.Text = "";
                txtCikanParcaMiktari.Text = "";
                txtHammadde.Text = "";
                txtKalipBoyutu.Text = "";
                txtKalipKodu.Text = "";
                txtNumericKalipGozu.Value = 0;
                txtNumuneAdi.Text = "";
                txtParcaAgirligi.Text = "";
                txtRenk.Text = "";
                txtTedarikciFirma.Text = "";
                txtUrunKodu.Text = "";
                pictureBox1.ImageLocation = "";
                btnEkle.Text = "Ekle";
                btnSil.Visible = false;
                btnGuncelle.Visible = false;
                ambiance_Button_21.Visible = false;
            }
          
            else
            {
                btnSil.Visible = true;
                btnGuncelle.Visible = true;
                ambiance_Button_21.Visible = true;
                try
                {

              
            NumuneDetay num = new NumuneDetay();

            num.KalipKodu = Convert.ToInt32(txtKalipKodu.Text);
            num.NumuneAdi = txtNumuneAdi.Text;
            num.BaskiSuresi = txtBaskiSuresi.Text;
            num.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);
            num.CikanParcaMiktarı = txtCikanParcaMiktari.Text;
            num.Hammadde = txtHammadde.Text;
            num.KalipBoyutu = txtKalipBoyutu.Text;
            num.KalipGozu = (short)(txtNumericKalipGozu.Value);
            num.ParcaAgirligi = txtParcaAgirligi.Text;
            num.Renk = txtRenk.Text;
            num.ResimURL = DosyaYolu;
            num.TedarikciFirma = txtTedarikciFirma.Text;


            kalipService.AddDetail(num);
                    lblAciklama.Text = "Ekleme Başarılı";
                }
                catch (Exception)
                {

                    lblAciklama.Text = "Bir Sorun Oluştu";
                }
          
            }
        }

        private void Detay_Load(object sender, EventArgs e)
        {

        }

        NumuneDetay a;
        int numuneId;
        public Detay(Numune numune)
        {
            try
            {

          
            InitializeComponent();
            a = kalipService.FindDetail((int)numune.UrunKodu, (int)numune.KalipKodu);
            txtBaskiSuresi.Text = a.BaskiSuresi.ToString();
            txtCikanParcaMiktari.Text = a.CikanParcaMiktarı.ToString();
            txtHammadde.Text = a.Hammadde.ToString();
            txtKalipBoyutu.Text = a.KalipBoyutu.ToString();
            txtKalipKodu.Text = a.KalipKodu.ToString();
            txtNumericKalipGozu.Value = (int)a.KalipGozu;
            txtNumuneAdi.Text = a.NumuneAdi.ToString();
            txtParcaAgirligi.Text = a.ParcaAgirligi.ToString();
            txtRenk.Text = a.Renk.ToString();
            txtTedarikciFirma.Text = a.TedarikciFirma.ToString();
            txtUrunKodu.Text = a.UrunKodu.ToString();
            try
            {
                pictureBox1.ImageLocation = a.ResimURL.ToString();
            }
            catch (Exception)
            {

                pictureBox1.ImageLocation = "";
            }
           
            numuneId = a.id;

            }
            catch (Exception)
            {

                lblAciklama.Text = "Bir Sorun Oluştu.";
            }

        }
        string DosyaYolu;
        private void button1_Click(object sender, EventArgs e)
        {
            //Directory.CreateDirectory("C:/Program Files(x86)/KalipProgrami"); klasör oluşturma

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "KalipApp";
            dosya.ShowDialog();
             DosyaYolu = dosya.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            NumuneDetay num = new NumuneDetay();
        


            num.id=Convert.ToInt32(numuneId);
            num.KalipKodu = Convert.ToInt32(txtKalipKodu.Text);
            num.NumuneAdi = txtNumuneAdi.Text;
            num.BaskiSuresi = txtBaskiSuresi.Text;
            num.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);
            num.CikanParcaMiktarı = txtCikanParcaMiktari.Text;
            num.Hammadde = txtHammadde.Text;
            num.KalipBoyutu = txtKalipBoyutu.Text;
            num.KalipGozu = (short)(txtNumericKalipGozu.Value);
            num.ParcaAgirligi = txtParcaAgirligi.Text;
            num.Renk = txtRenk.Text;
            num.ResimURL = DosyaYolu;
            num.TedarikciFirma = txtTedarikciFirma.Text;


            kalipService.EditDetail(num);
            lblAciklama.Text = "Güncelleme İşlemi Başarılı";
           
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kalipService.DeleteDetail(Convert.ToInt32(numuneId));
            lblAciklama.Text = "Silme İşlemi Başarılı";
        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
            //Excel.Application ExcelUygulama;             // excel uygulaması tanımla
            //Excel.Workbook CalismaKitabi;                // çalışma Kitabı tanımla
            //Excel.Worksheet CalismaSayfasi;              // çalışma Sayfası tanımla               
            //ExcelUygulama = new Excel.Application();     // yeni bir excel uygulaması yarat

            //CalismaKitabi = ExcelUygulama.Workbooks.Open(DosyaYolu);                  // dosyayı aç
            //CalismaSayfasi = (Excel.Worksheet)CalismaKitabi.Worksheets.get_Item(1);   // 1. sayfayı aç





            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook CalismaKitabi = excel.Workbooks.Add(Missing);
            Worksheet CalismaSayfasi = (Worksheet)CalismaKitabi.Sheets[1];



            int StartCol = 11;
            int StartRow = 1;


            Excel.Range bolge = (Excel.Range)excel.Cells[StartRow, StartCol]; //bu satır sütundakine uygula


            Excel.Range cerceve = (Excel.Range)excel.Range["k1", "k50"]; //Bu aralıktakilere uygula

            cerceve.EntireRow.Font.Bold = true;
            cerceve.EntireRow.Font.Size = 20;

            bolge.Value2 = "ÜRÜN ADI: "+txtNumuneAdi.Text;

            StartRow+=2;


            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "PARÇA KODU: " + txtUrunKodu.Text;

            StartRow += 2;
            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "KALIP KODU: " + txtKalipKodu.Text;

            StartRow += 2;
            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "HAMMADDE: " + txtHammadde.Text;

            StartRow += 2;
            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "RENK: " + txtUrunKodu.Text;

            StartRow += 2;
            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "KALIP GÖZÜ: " + txtUrunKodu.Text;

            StartRow += 2;
            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "TEKNİK ÖZELLİKLER: ";

            StartRow += 2;
            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "KALIP BOYUTU: " + txtKalipBoyutu.Text;

            StartRow += 2;
            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "BASKI SÜRESİ " + txtBaskiSuresi.Text;

            StartRow += 2;
            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "TEDARİKÇİ FİRMA: " + txtTedarikciFirma.Text;

            StartRow += 2;
            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "BİR BASKIDA ÇIKAN PARÇA MİKTARI: ";

            StartRow++;

            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = txtCikanParcaMiktari.Text;


            StartRow += 2;
            bolge = (Excel.Range)excel.Cells[StartRow, StartCol];
            bolge.Value2 = "PARÇA AĞIRLIĞI: " + txtParcaAgirligi.Text;


            
            CalismaSayfasi.Shapes.AddPicture(pictureBox1.ImageLocation,
                Microsoft.Office.Core.MsoTriState.msoFalse,
                Microsoft.Office.Core.MsoTriState.msoCTrue,
                0, 0, 450, 700);   // sol hiza, yukarıdan hiza, genişlik ve yükseklik değerleri

           
        }
    }

}
