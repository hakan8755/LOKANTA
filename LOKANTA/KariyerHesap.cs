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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LOKANTA
{
    public partial class KariyerHesap : Form
    {
        public KariyerHesap()
        {
            InitializeComponent();

        }
        genel gnl = new genel();
        string id;
        private void KasiyerGoruntule()
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(gnl.connadress))
                {
                    connection.Open();
                    string sorgu = "Select *From Cashier where deleted= 0;";
                    using (MySqlCommand command = new MySqlCommand(sorgu, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {



                            while (reader.Read())
                            {

                                id = reader["cashier_id"].ToString();
                                string username = reader["username"].ToString();



                                Panel panel = new Panel();
                                panel.Size = new Size(200, 100);
                                panel.BackColor = Color.White;
                                panel.BorderStyle = BorderStyle.FixedSingle;

                                Label label = new Label();
                                label.Text = "Kasiyer İD: " + id + Environment.NewLine +
                                             "Username: " + username + Environment.NewLine
                                          ;

                                label.AutoSize = false;
                                label.Size = new Size(200, 50);
                                label.Font = new Font("Arial", 11);
                                panel.Controls.Add(label);


                                panel.Tag = id;

                                // Dinamik buton oluştur
                                System.Windows.Forms.Button silButton = new System.Windows.Forms.Button();
                                silButton.Text = "Sil";
                                silButton.Size = new Size(70, 30);
                                silButton.Location = new Point(50, 60); // Butonun panel içindeki konumu

                                silButton.Click += (sender, args) => SilButton_Click(sender, args, panel);
                                panel.Controls.Add(silButton); // Butonu panele ekle

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

        private void SilButton_Click(object? sender, EventArgs e, Panel panel)
        {
            DialogResult result = MessageBox.Show("Bu siparişi silmek istediğinize emin misiniz?", "Sipariş Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                flowLayoutPanel1.Controls.Remove(panel);

                if (panel.Tag != null && int.TryParse(panel.Tag.ToString(), out int id))
                {
                    MySqlConnection connection = new MySqlConnection(gnl.connadress);


                    connection.Open();
                    string sorgu2 = "UPDATE cashier SET deleted = 1 WHERE cashier_id = @id;";




                    MySqlCommand command2 = new MySqlCommand(sorgu2, connection);
                    command2.Parameters.AddWithValue("@id", id);

                    command2.ExecuteNonQuery();

                    MessageBox.Show("Sipariş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Sipariş ID'si bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(gnl.connadress);
            connection.Open();
            string username = txtAd.Text;
            string password = txtSifre.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre kısmını Doldurunuz.");
                return;
            }


            string query = $"INSERT INTO cashier (username, password) VALUES('{username}', '{password}')";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void KariyerHesap_Load(object sender, EventArgs e)
        {
            KasiyerGoruntule();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            KasiyerGoruntule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(gnl.connadress);
            connection.Open();
            string username = txtAd.Text;
            string password = txtSifre.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre kısmını Doldurunuz.");
                return;
            }
            string ay = "5";
            string gün = "14";
            string id = ay + gün + 1;


            string query = $"Update  cashier Set password ='{password}' where username='{username}'";


            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifre Başarıyla Değiştirildi!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
    

