using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LOKANTA
{
    public partial class MasalarForm : Form
    {
        public MasalarForm()
        {
            InitializeComponent();
        }
        int renkControl = 0;
        genel gnl = new genel();
        public static string masano;
        private void button1_Click(object sender, EventArgs e)
        {
            MasalariGetir(true);
        }

        private void MasalariGetir(bool durum)
        {

            using (MySqlConnection connection = new MySqlConnection(gnl.connadress))
            {
                flowLayoutPanel1.Controls.Clear();
                connection.Open();
                string sql = "SELECT * FROM tables";


                using (MySqlCommand command = new MySqlCommand(sql, connection))//using kullanımı bağlantıyı kendiliğinden kapatıyor
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            string masaNo = reader["table_no"].ToString();
                            string masaDurum = reader["status"].ToString();
                            string kapasite = reader["capacity"].ToString();

                            PictureBox pictureBox = new PictureBox();



                            MySqlConnection cn = new MySqlConnection(gnl.connadress);
                            int no = Convert.ToInt16(masaNo);

                            string queryString = $"UPDATE tables SET status = @status WHERE table_no = {no}";
                            cn.Open();
                            MySqlCommand komut = new MySqlCommand(queryString, cn);
                            pictureBox.Click += (sender, e) =>
                            {

                                if (masaDurum == "1")
                                {
                                    MessageBox.Show($"{masaNo} Numaralı Masa Hazır Hale Geldi!");
                                    komut.Parameters.AddWithValue("@status", 0);

                                    komut.ExecuteNonQuery();
                                    cn.Close();
                                    MasalariGetir(true);
                                }
                                else
                                {
                                    MessageBox.Show($"{masaNo} Numaralı Masaya İşlem Yapmaktasınız!");
                                    UrunSiparisEkran gec = new UrunSiparisEkran();
                                    gec.Show();
                                    komut.Parameters.AddWithValue("@status", 1);

                                    //masano = pictureBox.Tag.ToString();
                                    komut.ExecuteNonQuery();
                                    masano = no.ToString();
                                    cn.Close();
                                    MasalariGetir(true);
                                }




                            };
                            string uygulamaDizini = Application.StartupPath;
                            string istenilenDizin = "LOKANTA"; // istediğiniz dizin
                            string yenidizin = uygulamaDizini.Replace("\\", "\\\\");

                            int index = yenidizin.IndexOf(istenilenDizin); // Başlangıç dizinini bul
                            string istenilenDizinYol = yenidizin.Substring(0, index + istenilenDizin.Length);
                            if (masaDurum == "1")
                            {
                             
                            
                                string resimYolu = istenilenDizinYol+ "\\\\LOKANTA\\\\resim\\\\red.png";
                              
                                pictureBox.ImageLocation = resimYolu;
                               // pictureBox.ImageLocation = "C:\\Users\\firat\\OneDrive\\Masaüstü\\LOKANTA\\LOKANTA\\resim\\red.png";
                                //pictureBox.ImageLocation = "resim/red.png";

                            }
                            else
                            {
                                string resimYolu = istenilenDizinYol + "\\\\LOKANTA\\\\resim\\\\green.png";
                                pictureBox.ImageLocation = resimYolu;
                            }
                            //pictureBox.Tag = $"masaNo";
                            pictureBox.Width = 100; // Resim kutusunun genişliği
                            pictureBox.Height = 100; // Resim kutusunun yüksekliği
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                            Label label = new Label();
                            label.Parent = pictureBox;
                            label.Location = new Point(25, 16);
                            if (durum == true)
                            {
                                label.Font = new Font("Arial", 15, FontStyle.Bold);
                                label.Text = masaNo;
                            }
                            else
                            {
                                label.Font = new Font("Arial", 12, FontStyle.Regular);
                                label.Text = $"{kapasite} Kişilik";
                            }


                            label.ForeColor = Color.Black;
                            label.BackColor = Color.Transparent;
                            flowLayoutPanel1.Controls.Add(pictureBox);
                        }
                    }

                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string table_no = textBox1.Text.ToString();
            string capacity = textBox2.Text.ToString();
            string status;

            if (renkControl == 1)
            {
                status = "1";
            }
            else
            {
                status = "0";
            }
            using (MySqlConnection connection = new MySqlConnection(gnl.connadress))
            {
                // MySQL komutunu oluştur
                string query = "INSERT INTO tables (table_no, capacity, status) VALUES (@table_no, @capacity, @status)";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Parametre ekleme
                command.Parameters.AddWithValue("@table_no", table_no);
                command.Parameters.AddWithValue("@capacity", capacity);
                command.Parameters.AddWithValue("@status", status);

                // Bağlantıyı aç
                connection.Open();

                // Komutu çalıştır
                command.ExecuteNonQuery();
            }
            MasalariGetir(true);
        }

        private void button3_Click(object sender, EventArgs e)//renkButonu durum belirtmek için
        {

            if (button3.BackColor == Color.Green)
            {
                button3.BackColor = Color.Red;
                renkControl = 1;
            }
            else
            {
                button3.BackColor = Color.Green;
                renkControl = 0;
            }

        }

        private void button5_Click(object sender, EventArgs e)//masaSilme
        {
            using (MySqlConnection connection = new MySqlConnection(gnl.connadress))
            {
                string numara = textBox1.Text.ToString();
                string query = "DELETE FROM tables WHERE table_no = @Numara";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Numara", numara);
                connection.Open();
                command.ExecuteNonQuery();
            }
            MasalariGetir(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MasalariGetir(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



    
