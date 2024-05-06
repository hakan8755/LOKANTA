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

namespace LOKANTA
{
    public partial class AdminGirisEkrani : Form
    {
        public AdminGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = txtAd.Text.ToString();
            string password = txtSifre.Text.ToString();
            genel gnl = new genel();
            MySqlConnection connection = new MySqlConnection(gnl.connadress);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from admin where @username=username and @password=password", connection);
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Yapıldı");

                AdminEkrani gec = new AdminEkrani();
                gec.Show();
                this.Close();
                this.Hide();
            }
            else { MessageBox.Show("Giriş Yapılmadı!"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
