using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace LOKANTA
{
    internal class Personel
    {
        genel gnl =new genel();
        #region Fields
        private int cashier_id;
        private string username;
        private string password;
        #endregion
        #region Properties
        public int Cashier_id { get => cashier_id; set => cashier_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion
        public bool personelEntryControl(int cashier_id,string password)
        {

            bool result = false;
            MySqlConnection conn = new MySqlConnection(gnl.connadress);
            MySqlCommand cmd = new MySqlCommand("Select * from cashier where @cashier_id=cashier_id and @password=password", conn);
            cmd.Parameters.Add("@cashier_id", MySqlDbType.Int64).Value = Cashier_id;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;
            

            try
            {
                if (conn.State==ConnectionState.Closed)
                {
                   conn.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return true;
        }
       
    }
    
}
