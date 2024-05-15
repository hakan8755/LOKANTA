using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace LOKANTA
{
    public partial class AnaEkran : Form
    {

        public AnaEkran()
        {
            InitializeComponent();


            // Her 1000 milisaniyede bir (1 saniye) timer_Tick olayýný tetikle


            string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            label1.Text = formattedDateTime;
            
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {


            string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            label1.Text = formattedDateTime;
        }

        private void Button1_Paint(object? sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminGirisEkrani gec = new AdminGirisEkrani();
            gec.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (girisEkraný.kontrol == true)
            {
                MasalarForm gec = new MasalarForm();
                gec.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Giriþ Yapýnýz");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            girisEkraný gec = new girisEkraný();
            gec.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (girisEkraný.kontrol == true)
            {
                UrunSiparisEkran gec = new UrunSiparisEkran();
                gec.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Giriþ Yapýnýz");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrunAdmin gec = new UrunAdmin();
            gec.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            if (girisEkraný.kontrol == true)
            {
                Mutfak gec = new Mutfak();
                gec.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Giriþ Yapýnýz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KariyerHesap gec = new KariyerHesap();
            gec.Show();
        }
    }
}
