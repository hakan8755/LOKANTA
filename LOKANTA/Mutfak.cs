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
        string order_id;

        private void siparisGoruntule_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(gnl.connadress))
                {
                    string sql2 = "SELECT * " +
                                  "FROM orders " +
                                  "LEFT JOIN tables ON tables.table_no = orders.table_id " +
                                  "JOIN customers ON customers.customer_id = orders.customer_id ";

                    string sql3 = "SELECT * FROM order_details right JOIN products ON products.product_id = order_details.product_id where order_id=@order_id;";

                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(sql2, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string order_date = reader["order_date"].ToString();
                                string table_no;
                                if (reader["table_no"] == DBNull.Value)
                                {
                                    table_no = "0";
                                }
                                else
                                {
                                    table_no = reader["table_no"].ToString();
                                   
                                }
                               // string? table_no = reader["table_no"].ToString();
                                string customers_id = reader["customer_id"].ToString();
                                string customer_firstName = reader["first_name"].ToString();
                                string customer_lastName = reader["last_name"].ToString();
                                string order_id = reader["order_id"].ToString();

                                Panel panel = new Panel();
                                panel.Size = new Size(300, 200);
                                panel.BackColor = Color.White;
                                panel.BorderStyle = BorderStyle.FixedSingle;
                               
                          
                                Label label = new Label();
                                //MySqlCommand command2 = new MySqlCommand(sql3, connection);
                               // command2.Parameters.AddWithValue("@OrderID", order_id);
                                //string urun1=  command2.Parameters["order_id"].ToString();

                                label.Text = "Sipariş Tarihi: " + order_date + Environment.NewLine +
                                             "Masa Numarası: " + table_no + Environment.NewLine +
                                             "Müşteri ID: " + customers_id + Environment.NewLine +
                                             "Müşteri İsim/Soyisim: " + customer_firstName + " " + customer_lastName + Environment.NewLine +
                                             "Sipariş ID: " + order_id + Environment.NewLine +
                                             "- - - - - - - - - - - - - - - - - - - - - - - - - - -" + Environment.NewLine +
                                             "Ürünler:";
                                label.AutoSize = false;
                                label.Size = new Size(300, 150);
                                label.Font = new Font("Arial", 11);
                                panel.Controls.Add(label);

                                
                                panel.Tag = order_id;

                                // Dinamik buton oluştur
                                System.Windows.Forms.Button silButton = new System.Windows.Forms.Button();
                                silButton.Text = "Sil";
                                silButton.Size = new Size(60, 30);
                                silButton.Location = new Point(10, 160); // Butonun panel içindeki konumu
                                silButton.Click += (sender, args) => SilButton_Click(sender, args, panel); // Silme işlevini butona atama
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
                            string sql = "DELETE FROM orders WHERE orders.order_id = @order_id";
                            string sql2 = "DELETE FROM order_details WHERE order_id = @order_id2";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    MySqlCommand command2 = new MySqlCommand(sql2, connection);
                    command2.Parameters.AddWithValue("@order_id2", order_id);

                    command2.ExecuteNonQuery();
                    MessageBox.Show("ilki sildi");
                  
                            
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
            //try
            //{

            //    int order_id = Convert.ToInt32(siparisID.Text);
            //    int customer_id = Convert.ToInt32(musteriID.Text);
            //    int table_id = Convert.ToInt32(masaNO.Text);
            //    int employee_id = Convert.ToInt32(personelID.Text);
            //    int total_amount = Convert.ToInt32(toplamTutar.Text);
            //    string tarihMetni = tarih.Text.ToString();
            //    DateTime order_date = DateTime.Parse(tarihMetni);

            //    using (MySqlConnection connection = new MySqlConnection(gnl.connadress))
            //    {
            //        connection.Open();

            //        string sql3 = "INSERT INTO orders(order_id, customer_id, table_id, employee_id, order_date, total_amount) " +
            //                     "VALUES (@order_id, @customer_id, @table_id, @employee_id, @order_date, @total_amount)";

            //        MySqlCommand command = new MySqlCommand(sql3, connection);
            //        command.Parameters.AddWithValue("@table_id", table_id);
            //        command.Parameters.AddWithValue("@order_id", order_id);
            //        command.Parameters.AddWithValue("@customer_id", customer_id);
            //        command.Parameters.AddWithValue("@employee_id", employee_id);
            //        command.Parameters.AddWithValue("@order_date", order_date);
            //        command.Parameters.AddWithValue("@total_amount", total_amount);

            //        command.ExecuteNonQuery();

            //        MessageBox.Show("Sipariş başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
