using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace LOKANTA
{
    public partial class AnaEkran : Form
    {

        public AnaEkran()
        {
            InitializeComponent();


            // Her 1000 milisaniyede bir (1 saniye) timer_Tick olay�n� tetikle

       
            string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            label1.Text = formattedDateTime;
            button1.Paint += Button1_Paint;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
           
          
            string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            label1.Text = formattedDateTime;
        }

        private void Button1_Paint(object? sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int arcRadius = 35; // Kavis yar��ap�, istedi�iniz de�ere g�re ayarlayabilirsiniz.

            // Dikd�rtgenin k��elerini kavisli hale getiriyoruz.
            path.AddArc(0, 0, arcRadius * 2, arcRadius * 2, 180, 90);
            path.AddArc(button1.Width - arcRadius * 2, 0, arcRadius * 2, arcRadius * 2, 270, 90);
            path.AddArc(button1.Width - arcRadius * 2, button1.Height - arcRadius * 2, arcRadius * 2, arcRadius * 2, 0, 90);
            path.AddArc(0, button1.Height - arcRadius * 2, arcRadius * 2, arcRadius * 2, 90, 90);

            // Butonun arka plan�n� kavisli �ekilde dolduruyoruz.
             // �stedi�iniz arka plan rengini ayarlayabilirsiniz.
            button1.Region = new Region(path);
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
            if (girisEkran�.kontrol == true)
            {
                MasalarForm gec = new MasalarForm();
                gec.Show();
            }
            else
            {
                MessageBox.Show("L�tgen Giri� Yap�n�z");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            girisEkran� gec = new girisEkran�();
            gec.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (girisEkran�.kontrol == true)
            {
                UrunSiparisEkran gec = new UrunSiparisEkran();
                gec.Show();
            }
            else
            {
                MessageBox.Show("L�tgen Giri� Yap�n�z");
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
            if (girisEkran�.kontrol == true)
            {
                Mutfak gec = new Mutfak();
                gec.Show();
            }
            else
            {
                MessageBox.Show("L�tgen Giri� Yap�n�z");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
