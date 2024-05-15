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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        genel gnl = new genel();
        Sorgular srg = new Sorgular();
        private void Personeller_Load(object sender, EventArgs e)
        {
            #region Personel Bilgilerini Listeleme
            listView1.Items.Clear();

            string connectionString2 = gnl.connadress;

            MySqlConnection connection2 = new MySqlConnection(connectionString2);

            try
            {
                connection2.Open();

                MySqlCommand command2 = new MySqlCommand(srg.personelBilgi, connection2);

                using (MySqlDataReader reader2 = command2.ExecuteReader())
                {

                    while (reader2.Read())
                    {
                        int emp_id = reader2.GetInt32("employee_id");
                        string employee_id = emp_id.ToString();
                        int m_id = reader2.GetInt32("mission_id");
                        string mission_id = m_id.ToString();
                        string f_name = reader2.GetString("first_name");
                        string l_name = reader2.GetString("last_name");
                        double salary = reader2.GetDouble("salary");
                        string iPrice = salary.ToString();
                        ListViewItem item = new ListViewItem(employee_id);
                        item.SubItems.Add(mission_id);
                        item.SubItems.Add(f_name);
                        item.SubItems.Add(l_name);
                        item.SubItems.Add(iPrice);
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {

                connection2.Close();

            }

            #endregion
            #region Görev Bilgilerini Listeleme
            listView2.Items.Clear();
            string connectionString = gnl.connadress;
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {

                connection.Open();



                MySqlCommand command = new MySqlCommand(srg.personelGorev, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        int m_id = reader.GetInt32("mission_id");
                        string gorevId = m_id.ToString();
                        string m_name = reader.GetString("mission_name");
                        ListViewItem item = new ListViewItem(gorevId);
                        item.SubItems.Add(m_name);
                        listView2.Items.Add(item);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }
            #endregion

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string connectionString = gnl.connadress;
            string insertValue1 = gorev.Text.ToString();
            string insertValue2 = f_name.Text;
            string insertValue3 = l_name.Text;
            string insertValue4 = salary.Text.ToString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = new MySqlCommand(srg.personelBilgiGir, connection))
                {

                    command.Parameters.AddWithValue("@insertValue1", insertValue1);
                    command.Parameters.AddWithValue("@insertValue2", insertValue2);
                    command.Parameters.AddWithValue("@insertValue3", insertValue3);
                    command.Parameters.AddWithValue("@insertValue4", insertValue4);
                    connection.Open();
                    command.ExecuteNonQuery();

                };
            };

            ListViewItem newItem = new ListViewItem();
            newItem.SubItems.Add(insertValue1);
            newItem.SubItems.Add(insertValue2);
            newItem.SubItems.Add(insertValue3);
            newItem.SubItems.Add(insertValue4);
            listView1.Items.Add(newItem);
            gorev.Clear();
            f_name.Clear();
            l_name.Clear();
            salary.Clear();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string connectionString = gnl.connadress;
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string itemId = selectedItem.SubItems[0].Text;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(srg.personelBilgiSil, connection))
                    {
                        command.Parameters.AddWithValue("@itemId", itemId);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }

                    }
                }
                listView1.Items.Remove(selectedItem);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string connectionString = gnl.connadress;
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                string itemId = selectedItem.SubItems[0].Text;


                string updatedValue1 = gorev.Text.ToString();
                string updatedValue2 = f_name.Text;
                string updatedValue3 = l_name.Text;
                string updatedValue4 = salary.Text.ToString();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(srg.personelGuncelle, connection))
                    {
                        command.Parameters.AddWithValue("@uptadeValue1", updatedValue1);
                        command.Parameters.AddWithValue("@uptadeValue2", updatedValue2);
                        command.Parameters.AddWithValue("@uptadeValue3", updatedValue3);
                        command.Parameters.AddWithValue("@uptadeValue4", updatedValue4);
                        command.Parameters.AddWithValue("@itemId", itemId);


                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }

                    }
                }

                selectedItem.SubItems[1].Text = updatedValue1;
                selectedItem.SubItems[2].Text = updatedValue2;
                selectedItem.SubItems[3].Text = updatedValue3;
                selectedItem.SubItems[4].Text = updatedValue4;

                gorev.Clear();
                f_name.Clear();
                l_name.Clear();
                salary.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = gnl.connadress;

            string insertValue1 = grvNO.Text.ToString();
            string insertValue2 = grvName.Text;



            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = new MySqlCommand(srg.personelKategoriGir, connection))
                {

                    command.Parameters.AddWithValue("@insertValue1", insertValue1);
                    command.Parameters.AddWithValue("@insertValue2", insertValue2);
                    connection.Open();
                    command.ExecuteNonQuery();

                };
            };
            ListViewItem newItem = new ListViewItem(insertValue1);
            newItem.SubItems.Add(insertValue2);
            listView2.Items.Add(newItem);

            grvNO.Clear();
            grvName.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = gnl.connadress;
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];

                string itemId = selectedItem.SubItems[0].Text;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(srg.personelKategoriSil, connection))
                    {
                        command.Parameters.AddWithValue("@itemId", itemId);



                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }

                    }
                }

                listView2.Items.Remove(selectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KariyerHesap kariyerHesap = new KariyerHesap();
            kariyerHesap.Show();
        }
    }
}
