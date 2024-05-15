using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
namespace LOKANTA
{
    public partial class UrunSiparisEkran : Form
    {
        public UrunSiparisEkran()
        {
            InitializeComponent();

            if (kontrol == false)
            {
                groupBox1.Visible = false;
            }
        }

       
        genel gnl = new genel();
        Sorgular srg = new Sorgular();
        public static bool kontrol = true;
        int adet = 0;
        int sayac = 0;
       
        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            urunGetir(1);

        }

        private void urunGetir(int categoryNo)
        {

            if (MasalarForm.masano != null)
            {
                label7.Text = $"Sipariş Masa No: {MasalarForm.masano}";
                label7.Visible = true;
            
            }
          
            using (MySqlConnection connection = new MySqlConnection(gnl.connadress))
            {
                connection.Open();

                //string sql = "SELECT product_id, product_name ,price,category_name,stock_quantity,location FROM products Inner Join product_category on products.category=product_category.category_id where category_id=@categoryid ;";

                using (MySqlCommand command = new MySqlCommand(srg.urunGoster, connection))
                {
                    command.Parameters.Add("@categoryid", MySqlDbType.Int32).Value = categoryNo;
                    using (MySqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string id = dr["product_id"].ToString();
                            string adi = dr["product_name"].ToString();
                            string lokasyon = dr["location"].ToString();
                            string ucret = dr["price"].ToString();

                            Label label = new Label();


                            label.Location = new Point(10, 15);

                            if (kontrol == true)
                            {
                                label.Font = new System.Drawing.Font("Arial", 15);
                                label.Text = $"{adi} Fiyatı: {ucret} TL";
                            }
                            else
                            {
                                label.Font = new System.Drawing.Font("Arial", 13);
                                label.Text = $"İD:{id}, {adi} Fiyatı: {ucret} TL";

                            }

                            label.ForeColor = Color.Black;
                            label.AutoSize = true;
                            label.BackColor = Color.Transparent;
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Width = 200; // Resim kutusunun genişliği
                            pictureBox.Location = new Point(50, 60);

                            pictureBox.Height = 200; // Resim kutusunun yüksekliği
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox.ImageLocation = lokasyon;
                            pictureBox.Click += (sender, e) =>
                            {
                                label3.Text = adi;
                                label6.Text = adet.ToString();
                                label10.Text = id.ToString();
                                label4.Text = (Convert.ToInt16(ucret) * adet).ToString();

                                // listView1.Items[sayac].SubItems.Add(dr["stock_quantity"].ToString());

                            };
                            GroupBox panel = new GroupBox();
                            panel.Width = 300;
                            panel.Height = 300;
                            panel.Controls.Add(label);
                            panel.Controls.Add(pictureBox);
                            flowLayoutPanel1.Controls.Add(panel);



                        }
                    };
                };
            };
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            urunGetir(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            urunGetir(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            urunGetir(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            urunGetir(1);
            urunGetir(2);
            urunGetir(3);
            urunGetir(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Add(label3.Text.ToString());
            listView1.Items[sayac].SubItems.Add(label4.Text.ToString());
            listView1.Items[sayac].SubItems.Add(label6.Text.ToString());
            listView1.Items[sayac].SubItems.Add(label10.Text.ToString());
            sayac++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adet++;

            label6.Text = adet.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adet--;
            if (adet == 0)
            {
                adet = 1;
            }
            label6.Text = adet.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Her seçili öğe için
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    // Öğeyi ListView'dan kaldırın
                    listView1.Items.Remove(item);
                    sayac--;
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(gnl.connadress);

            int totalPrice = 0;
            try
            {
                connection.Open();


                string zaman = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                MySqlCommand cmd = new MySqlCommand(srg.urunMusteri, connection);
                MySqlCommand command = new MySqlCommand(srg.urunSonMusteriAl, connection);
                MySqlCommand command2 = new MySqlCommand(srg.urunSiparisGir, connection);
                MySqlCommand command4 = new MySqlCommand(srg.urunDetayGir, connection);
                MySqlCommand command5 = new MySqlCommand(srg.urunSonSiparisAl, connection);

                cmd.Parameters.AddWithValue("@ad", musteriAD.Text);
                cmd.Parameters.AddWithValue("@soyad", musteriSoyad.Text);
                cmd.ExecuteNonQuery();
                int lastOrderId = Convert.ToInt32(command5.ExecuteScalar());
                int lastCustomerId = Convert.ToInt32(command.ExecuteScalar());
                if (lastCustomerId != 0)
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        int price = Convert.ToInt32(item.SubItems[1].Text) * Convert.ToInt32(item.SubItems[2].Text); // İlgili sütundaki fiyatı al
                        totalPrice += price;
                    }

                    command.ExecuteNonQuery();
                    command2.Parameters.AddWithValue("@musteri_id", lastCustomerId);
                    command2.Parameters.AddWithValue("@masa_id", MasalarForm.masano);
                    command2.Parameters.AddWithValue("@cashier_id", girisEkranı.personel_id);
                    command2.Parameters.AddWithValue("@tarih", zaman);
                    command2.Parameters.AddWithValue("@toplamucret", totalPrice);
                    
                    command2.ExecuteNonQuery();
                    // Başarılı mesajı göster

                    command4.Parameters.AddWithValue("@siparis_id", 0);
                    command4.Parameters.AddWithValue("@urunid", 0);
                    command4.Parameters.AddWithValue("@fiyat", 0);
                    command4.Parameters.AddWithValue("@toplamucret", 0);
                    command4.Parameters.AddWithValue("@adet", 0);

                    foreach (ListViewItem item in listView1.Items)
                    {
                        string urunAdi = item.SubItems[0].Text; // Ürün adı
                        string fiyat = item.SubItems[1].Text; // Fiyat
                        string adet = item.SubItems[2].Text;
                        int toplamUcret = Convert.ToInt16(fiyat.ToString()) * Convert.ToInt16(adet.ToString());
                        int urunid = Convert.ToInt16(item.SubItems[3].Text);
                        command4.Parameters["@siparis_id"].Value = lastOrderId + 1;
                        command4.Parameters["@urunid"].Value = urunid;
                        command4.Parameters["@fiyat"].Value = fiyat;
                        command4.Parameters["@toplamucret"].Value = toplamUcret;
                        command4.Parameters["@adet"].Value = Convert.ToInt16(adet);


                        command4.ExecuteNonQuery();

                    }

                    MessageBox.Show("Sipariş Oluşturuldu.");



                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı.");
                }




            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajını göster
                MessageBox.Show("Siparişi kaydetme sırasında bir hata oluştu lütfen doğru işlem yaptığınızdan emin olun: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                connection.Close();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UrunSiparisEkran_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            urunGetir(1);
            urunGetir(2);
            urunGetir(3);
            urunGetir(4);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
