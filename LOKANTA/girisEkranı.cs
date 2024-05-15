using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace LOKANTA
{
    public partial class girisEkranı : Form
    {

        //MySqlConnection conna=new MySqlConnection("Server=deneme;Database=mydb;Uid=root;Pwd=1234");
        //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;uid=root;port=3306;pwd=1234;database=mydb;");
        //MySqlCommand cmd;
        //MySqlDataAdapter adp;
        //DataTable dt;
        public girisEkranı()
        {
            InitializeComponent();
            //girisBilgileri();
           

        }
        genel gnl = new genel();
        public static bool kontrol = false;
        public static int personel_id;

        //void girisBilgileri()
        //{
        //    dt =new DataTable();
        //    conn.Open();
        //    adp = new MySqlDataAdapter("Select *from cashier",conn);
        //    adp.Fill(dt);
        //    conn.Close();
        //}
        private void girisEkranı_Load(object sender, PaintEventArgs e)
        {
           
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UrunSiparisEkran.kontrol = true;
            string username = txtAd.Text.ToString();
            string password = txtSifre.Text.ToString();
            genel gnl = new genel();
            MySqlConnection connection = new MySqlConnection(gnl.connadress);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from cashier where @username=username and @password=password and deleted=0", connection);
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                personel_id = (int)dr["cashier_id"];
                MessageBox.Show("Giriş Yapıldı");
                kontrol = true;
                this.Hide();
            }
            else { MessageBox.Show("Giriş Yapılmadı!"); }

        }
    }
}
