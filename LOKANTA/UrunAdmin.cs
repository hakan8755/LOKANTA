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
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LOKANTA
{
    public partial class UrunAdmin : Form
    {
        public UrunAdmin()
        {
            InitializeComponent();
        }
        genel gnl = new genel();
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(gnl.connadress))
            {
                // MySQL komutunu oluştur
                string query = "INSERT INTO products (category, product_name, price,stock_quantity,location) VALUES (@category, @product_name, @price,@stock_quantity,@location)";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Parametre ekleme
                command.Parameters.AddWithValue("@category", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@product_name", textBox2.Text.ToString());
                command.Parameters.AddWithValue("@price", textBox3.Text.ToString());
                command.Parameters.AddWithValue("@stock_quantity", textBox4.Text.ToString());
                command.Parameters.AddWithValue("@location", openFileDialog1.FileName);

                // Bağlantıyı aç
                connection.Open();

                // Komutu çalıştır
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün eklendi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(gnl.connadress))
            {
                string id = textBox5.Text.ToString();
                string query = "DELETE FROM products WHERE product_id = @Numara";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Numara", id);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün Silindi");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunSiparisEkran.kontrol = false;
            UrunSiparisEkran gec = new UrunSiparisEkran();
            gec.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
