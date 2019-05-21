using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KalipServiceWCF;


namespace KalipApp
{
    public partial class Form1 : Form
    {

        private KalipServiceReference1.KalipServiceClient kalipService = new KalipApp.KalipServiceReference1.KalipServiceClient();


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
        
            if (kalipService.GetUser(txt_username.Text, txtPass.Text)>=1)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
