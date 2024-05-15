using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Mysqlx.Notice.Warning.Types;

namespace LOKANTA
{
    public partial class Mutfak : Form
    {
        public Mutfak()
        {
            InitializeComponent();

        }
        genel gnl = new genel();
        Sorgular srg = new Sorgular();
        string order_id;
        bool paket;
        private void siparisGoruntule_Click(object sender, EventArgs e)
        {
            string a = "";
            siparisGoruntulee(a);

        }

        private void siparisGoruntulee(string ekSorgu)
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection baglanti = new MySqlConnection(gnl.connadress);
            
            try
            {
                using (MySqlConnection connection = new MySqlConnection(gnl.connadress))
                {
                    string mutfakSiparisGoster= $"SELECT * FROM viewmutfak";
                    connection.Open();
  
                    if (checkBox1.Checked && ekSorgu!= null)
                    {
                        mutfakSiparisGoster = $"SELECT * FROM orders LEFT JOIN tables ON tables.table_no = orders.table_id JOIN customers ON customers.customer_id = orders.customer_id {ekSorgu} and table_id is null ";
                    }
                    else if (checkBox1.Checked && ekSorgu == null)
                    {
                        mutfakSiparisGoster = $"SELECT * FROM viewmutfak where table_id is null ";
                    }
                    else { 
                        
                        mutfakSiparisGoster = $"SELECT * FROM viewmutfak {ekSorgu}";

                    }
                    string sorgu = "select count(*) from orders;";
                    MySqlConnection ba=new MySqlConnection(gnl.connadress);
                    ba.Open();
                    MySqlCommand komut = new MySqlCommand(sorgu, ba);
                   

                    int toplam= Convert.ToInt32(komut.ExecuteScalar()); //sorgunun döndürdüğü değeri toplam değişkenine verdik

                    label6.Text = "Toplam Sipariş Sayısı: "+toplam.ToString();
                    
                    using (MySqlCommand command = new MySqlCommand(mutfakSiparisGoster, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {


                            string table_no;
                            while (reader.Read())
                            {
                                paket = false;
                                string urun = "";
                                string order_date = reader["order_date"].ToString();

                                if (reader["table_no"] == DBNull.Value)
                                {
                                    table_no = "0";
                                    paket=true;
                                }
                                else
                                {
                                    table_no = reader["table_no"].ToString();

                                }
                                string fiyat = reader["total_amount"].ToString();
                                string customers_id = reader["customer_id"].ToString();
                                string customer_firstName = reader["first_name"].ToString();
                                string customer_lastName = reader["last_name"].ToString();
                                string order_id = reader["order_id"].ToString();
                                baglanti.Open();
                                string sqlSorgusu = $"SELECT * FROM order_details right JOIN products ON products.product_id = order_details.product_id where order_id={order_id};";
                                MySqlCommand command2 = new MySqlCommand(sqlSorgusu, baglanti);
                                MySqlDataReader reader2 = command2.ExecuteReader();
                                int sayac = 1;


                                while (reader2.Read())
                                {
                                    urun += reader2["amount"].ToString() + " Tane " + reader2["product_name"].ToString() + ", ";
                                    sayac++;
                                }
                                baglanti.Close();


                                Panel panel = new Panel();
                                panel.Size = new Size(300, 200+(sayac*5));
                               
                                panel.BackColor = Color.White;
                                panel.BorderStyle = BorderStyle.FixedSingle;
                                string al = "Paket Siparişi";
                                if (paket == false)
                                {
                                 al= "Masa Numarası: " + table_no;
                                }
                                
                                Label label = new Label();
                                label.Text = "Sipariş Tarihi: " + order_date + Environment.NewLine +
                                             al+ Environment.NewLine +
                                             "Müşteri ID: " + customers_id + Environment.NewLine +
                                             "Müşteri İsim/Soyisim: " + customer_firstName + " " + customer_lastName + Environment.NewLine +
                                             "Sipariş ID: " + order_id + Environment.NewLine +
                                             "- - - - - - - - - - - - - - - - - - - - - - - - - - -" + Environment.NewLine +
                                             "Ürünler: " + urun + Environment.NewLine +
                                             "Toplam Ücret: "+fiyat+" TL";

                                label.AutoSize = false;
                                label.Size = new Size(300, 150+(sayac*5));
                                label.Font = new Font("Arial", 11);
                                panel.Controls.Add(label);

                               
                                panel.Tag = order_id;

                                // Dinamik buton oluştur
                                System.Windows.Forms.Button silButton = new System.Windows.Forms.Button();
                                silButton.Text = "Sil";
                                silButton.Size = new Size(60, 30);
                                silButton.Location = new Point(10, 160+(sayac*5)); // Butonun panel içindeki konumu
                                silButton.Click += (sender, args) => SilButton_Click(sender, args, panel); // Silme işlevini butona atama
                                panel.Controls.Add(silButton); // Butonu panele ekle
                                sayac = 1;
                                flowLayoutPanel1.Controls.Add(panel);
                            }


                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilButton_Click(object sender, EventArgs args, Panel panel)
        {

            DialogResult result = MessageBox.Show("Bu siparişi silmek istediğinize emin misiniz?", "Sipariş Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                flowLayoutPanel1.Controls.Remove(panel);

                if (panel.Tag != null && int.TryParse(panel.Tag.ToString(), out int orderID))
                {
                    MySqlConnection connection = new MySqlConnection(gnl.connadress);


                    connection.Open();


                    MySqlCommand command = new MySqlCommand(srg.mutfakSiparisSil, connection);
                    MySqlCommand command2 = new MySqlCommand(srg.mutfakSiparisDetaySil, connection);
                    command2.Parameters.AddWithValue("@order_id2", order_id);

                    command2.ExecuteNonQuery();



                    command.Parameters.AddWithValue("@order_id", orderID);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Sipariş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                    MessageBox.Show("Sipariş ID'si bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void siparisEkle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siparisEkle_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string tarih= selectedDate.ToString("yyyy-MM-dd HH:mm:ss");
            //MessageBox.Show("Seçilen tarih: " + tarih);
            string ek = $"where order_date > '{tarih}'";
            

            siparisGoruntulee(ek);


        }

        private void Mutfak_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
