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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numuneId);
            Numune numune = new Numune();
            
            numune.Adet = Convert.ToInt32(txtAdet.Text);
            numune.KalipKodu = Convert.ToInt32(txtNumuneKodu.Text);
            numune.NumuneAdi = txtNumuneAdi.Text;
            numune.Tarih = dateTimePicker1.Value;
            numune.UrunKodu = Convert.ToInt32(txtParcaKodu.Text);
            kalipService.Add(numune);
            reflesh();
            
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
            numune.KalipKodu = Convert.ToInt32(txtNumuneKodu.Text);
            numune.NumuneAdi = txtNumuneAdi.Text;
            numune.Tarih = dateTimePicker1.Value;
            numune.UrunKodu = Convert.ToInt32(txtParcaKodu.Text);
            kalipService.Edit(numune);
            reflesh();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kalipService.Delete(Convert.ToInt32(numuneId));
        }


        Func<ChartPoint, string> labelpoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        private void ambiance_Button_22_Click(object sender, EventArgs e)
        {

     

            if (String.IsNullOrEmpty(txtParca.Text) || String.IsNullOrEmpty(txtKalip.Text))
            {
             var a = kalipService.PieChartDate(Convert.ToDateTime(dateTimePickerBaslangic.Text).ToShortDateString(), Convert.ToDateTime(dateTimePickerBitis.Text).ToShortDateString());

                SeriesCollection series = new SeriesCollection();

                foreach (var obj in a)
                {
                    series.Add(new PieSeries() { Title = Convert.ToDateTime(obj.Tarih.ToString()).ToShortDateString(), Values = new ChartValues<int> { Convert.ToInt32(obj.Adet) }, DataLabels = true, LabelPoint = labelpoint });
                    pieChart1.Series = series;
                }
            }

            else
            {
            var a= kalipService.PieChart(Convert.ToDateTime(dateTimePickerBaslangic.Text).ToShortDateString(), Convert.ToDateTime(dateTimePickerBitis.Text).ToShortDateString(),Convert.ToInt32(txtParca.Text),Convert.ToInt32(txtKalip.Text));

                SeriesCollection series = new SeriesCollection();

                foreach (var obj in a)
                {
                    series.Add(new PieSeries() { Title = Convert.ToDateTime(obj.Tarih.ToString()).ToShortDateString(), Values = new ChartValues<int> { Convert.ToInt32(obj.Adet) }, DataLabels = true, LabelPoint = labelpoint });
                    pieChart1.Series = series;
                }
            }

          

        

        }
    }
}
