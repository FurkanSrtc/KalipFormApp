using KalipServiceWCF;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace KalipApp
{
    public partial class Home : Form
    {
        public Home()
        {
          
            InitializeComponent();


       

        }

        private KalipServiceReference1.KalipServiceClient kalipService = new KalipApp.KalipServiceReference1.KalipServiceClient();

        private void Home_Load(object sender, EventArgs e)
        {
           
            this.dataGridView1.DataSource = kalipService.getAll();
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Width = 450;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 40;
            dataGridView1.Columns[4].Width = 40;
            dataGridView1.Columns[5].Width = 80;

            this.dataGridView1.Columns["Tarih"].SortMode =
     DataGridViewColumnSortMode.Automatic;

        }

        private void ambiance_Label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                this.dataGridView1.DataSource = kalipService.getAll();

            }
            else
            {
                try
                {
                    dataGridView1.DataSource = kalipService.FindUrunKod(Convert.ToInt32(txtSearch.Text));

                }
                catch (Exception)
                {

                    MessageBox.Show("Bir Sorun Oluştu");
                    this.dataGridView1.DataSource = kalipService.getAll();

                }

            }
        }
        string numuneId;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        int click = 0;

        private void temizle()
        {
            txtNumuneAdi.Text = "";
            txtNumuneKodu.Text = "";
            txtParcaKodu.Text = "";
            txtNumuneAdi.Text = "";
            txtAdet.Text = "";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

       


            click++;
            if (click % 2 != 0)
            {
                dataGridView1.Enabled = false;

               temizle();

                btnEkle.Text = "Ekle";
                ambiance_Button_23.Visible = false;
                ambiance_Button_21.Visible = false;
                btnSil.Visible = false;
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();

            }

            else
            {
                btnEkle.Text = "Kayıt Ekle";
                ambiance_Button_23.Visible = true;
                ambiance_Button_21.Visible = true;
                btnSil.Visible = true;
                dataGridView1.Enabled = true;
                try
                {
                    var a = kalipService.FindDetail(Convert.ToInt32(txtParcaKodu.Text), Convert.ToInt32(txtNumuneKodu.Text));

                    if (String.IsNullOrEmpty(a.id.ToString()))
                    {
                        MessageBox.Show("Girdiğiniz Koda Göre Numune Bulunamadı.");
                    }
                    else
                    {
                
                        Numune numune = new Numune();

                        numune.Adet = Convert.ToInt32(txtAdet.Text);
                        numune.KalipKodu = Convert.ToInt32(txtNumuneKodu.Text);
                        numune.NumuneAdi = txtNumuneAdi.Text;
                        numune.Tarih = dateTimePicker1.Value;
                        numune.UrunKodu = Convert.ToInt32(txtParcaKodu.Text);
                        kalipService.Add(numune);
                        reflesh();
                    }
                }
                catch (Exception)
                {
                 
                }
            }
             
           

        }

        public void reflesh()
        {
            dataGridView1.DataSource = kalipService.getAll();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNumuneAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtParcaKodu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNumuneKodu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            numuneId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           

            txtNumuneAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtParcaKodu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNumuneKodu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            numuneId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
    
            Numune numune = new Numune();
            numune.Id = Convert.ToInt32(numuneId);
            numune.Adet = Convert.ToInt32(txtAdet.Text);
        //    numune.KalipKodu = Convert.ToInt32(txtNumuneKodu.Text);
       //     numune.NumuneAdi = txtNumuneAdi.Text;
            numune.Tarih = dateTimePicker1.Value;
         //   numune.UrunKodu = Convert.ToInt32(txtParcaKodu.Text);
            kalipService.Edit(numune);
            reflesh();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kalipService.Delete(Convert.ToInt32(numuneId));
            reflesh();
        }


        Func<ChartPoint, string> labelpoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        private void ambiance_Button_22_Click(object sender, EventArgs e)
        {
            ambiance_TabControl2.SelectedIndex = 0;


            if (String.IsNullOrEmpty(txtParca.Text) || String.IsNullOrEmpty(txtKalip.Text))
            {
                btnExcell.Visible = true;

             var a = kalipService.procAylikSatisOrani(Convert.ToDateTime(dateTimePickerBaslangic.Text).ToShortDateString(), Convert.ToDateTime(dateTimePickerBitis.Text).ToShortDateString());

                LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

                foreach (var obj in a)
                {
                    series.Add(new PieSeries() { Title = obj.NumuneAdi+" "+Convert.ToDateTime(obj.Tarih.ToString()).ToShortDateString(), Values = new ChartValues<int> { Convert.ToInt32(obj.Adet) }, DataLabels = true, LabelPoint = labelpoint });
                    pieChart1.Series = series;
                }


                dataGridView2.DataSource = kalipService.procAylikSatisOrani(Convert.ToDateTime(dateTimePickerBaslangic.Text).ToShortDateString(), Convert.ToDateTime(dateTimePickerBitis.Text).ToShortDateString()); //Datagridviewa aktarım


            }

            else
            {
            var a= kalipService.PieChart(Convert.ToDateTime(dateTimePickerBaslangic.Text).ToShortDateString(), Convert.ToDateTime(dateTimePickerBitis.Text).ToShortDateString(),Convert.ToInt32(txtParca.Text),Convert.ToInt32(txtKalip.Text));

                LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

                foreach (var obj in a)
                {
                    series.Add(new PieSeries() { Title = Convert.ToDateTime(obj.Tarih.ToString()).ToShortDateString(), Values = new ChartValues<int> { Convert.ToInt32(obj.Adet) }, DataLabels = true, LabelPoint = labelpoint });
                    pieChart1.Series = series;

          
                }



               
            }

          

        

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        //private void MergeCells()
        //{
        //    Excel.Application oXL;
        //    Excel._Workbook oWB;
        //    Excel._Worksheet ws;
        //    Excel.Range oRng;
        //    //Start Excel and get Application object.
        //    oXL = new Excel.Application();
        //    oXL.Visible = true;

        //    //Get a new workbook.
        //    oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));

        //    ws = (Excel._Worksheet)oWB.ActiveSheet;


        //    oRng = ws.get_Range("A1", "M23");
        //    oRng.Value2 = "Hello World";
        //    oRng.Merge(Missing.Value);
        //}


        private void btnExcell_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;




           // MergeCells();

            for (int j = 0; j < dataGridView2.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView2.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView2[j, i].Value == null ? "" : dataGridView2[j, i].Value;
                    myRange.Select();


                }
            }
        }

        private void ambiance_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void ambiance_Button_23_Click(object sender, EventArgs e)
        {
            Detay detay = new Detay(kalipService.Find(Convert.ToInt32(txtParcaKodu.Text), Convert.ToInt32(txtNumuneKodu.Text)));
            detay.Show();
     
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kalipService.getAll();
        }

        private void ambiance_Button_24_Click(object sender, EventArgs e)
        {
            btnExcell.Visible = true;
            ambiance_TabControl2.SelectedIndex=1;
            dataGridView2.DataSource = kalipService.procAylikSatisOrani(Convert.ToDateTime(dateTimePickerBaslangic.Text).ToShortDateString(), Convert.ToDateTime(dateTimePickerBitis.Text).ToShortDateString());

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            btnEkle.Text = "Kayıt Ekle";
            ambiance_Button_23.Visible = true;
            ambiance_Button_21.Visible = true;
            btnSil.Visible = true;
            dataGridView1.Enabled = true;
        }

        private void txtParcaKodu_TextChanged(object sender, EventArgs e)
        {
            NumuneAdKontrol();
        }

        private void NumuneAdKontrol() //NUmune adını numunedetay tablosundan çeker
        {
            if (!String.IsNullOrEmpty(txtParcaKodu.Text) || !String.IsNullOrEmpty(txtParcaKodu.Text))
            {
                try
                {
                    var find = kalipService.Find(Convert.ToInt32(txtParcaKodu.Text), Convert.ToInt32(txtNumuneKodu.Text));
                    if (!String.IsNullOrEmpty(find.Id.ToString()))
                    {
                        txtNumuneAdi.Text = find.NumuneAdi;
                    }
                }
                catch (Exception)
                {
                }

            }
          
        }

        private void txtNumuneKodu_TextChanged(object sender, EventArgs e)
        {
            NumuneAdKontrol();
        }
    }
}
