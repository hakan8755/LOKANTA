using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOKANTA
{
    internal class Sorgular
    {

        #region MasalarTablosuSorguları
        public string masaInsert = "INSERT INTO tables (table_no, capacity, status) VALUES (@table_no, @capacity, @status)";
        public string masaDelete = "DELETE FROM tables WHERE table_no = @Numara";
        public string masaGoster = "SELECT * FROM tables";
        #endregion
        #region UrunTablosuSorguları
        public string urunGoster = "SELECT product_id, product_name ,price,category_name,stock_quantity,location FROM products Inner Join product_category on products.category=product_category.category_id where category_id=@categoryid ;";
        public string urunMusteri = "INSERT INTO customers (first_name, last_name) VALUES (@ad, @soyad)";
        public string urunSiparisGir = "INSERT INTO orders (customer_id, table_id,cashier_id,order_date,total_amount) VALUES (@musteri_id, @masa_id,@cashier_id,@tarih,@toplamucret)";
        public string urunSonMusteriAl = "SELECT customer_id FROM customers ORDER BY customer_id DESC LIMIT 1";
        public string urunSonSiparisAl = "SELECT order_id FROM orders ORDER BY order_id DESC LIMIT 1";
        public string urunDetayGir = "INSERT INTO order_details (order_id, product_id,unit_price,total_price,amount) VALUES (@siparis_id, @urunid,@fiyat,@toplamucret,@adet)";
        #endregion
        //public string mutfakUrunGosterme= "SELECT * FROM order_details right JOIN products ON products.product_id = order_details.product_id where order_id=@order_id;";
        public string mutfakSiparisGoster = "SELECT * FROM orders LEFT JOIN tables ON tables.table_no = orders.table_id JOIN customers ON customers.customer_id = orders.customer_id ";
        public string mutfakSiparisSil = "DELETE FROM orders WHERE orders.order_id = @order_id";
        public string mutfakSiparisDetaySil = "DELETE FROM order_details WHERE order_id = @order_id2";

        public string personelGorev = "SELECT mission_id,mission_name FROM missions";
        public string personelBilgi = "SELECT employee_id,mission_id,first_name,last_name,salary FROM employee";
        public string personelGuncelle = "UPDATE employee SET employee_id=@itemId, mission_id=@uptadeValue1 , first_name = @uptadeValue2 , last_name=@uptadeValue3, salary=@uptadeValue4 WHERE employee_id = @itemId";
        public string personelBilgiGir = "INSERT INTO employee (mission_id,first_name, last_name,salary) VALUES (@insertValue1, @insertValue2,@insertValue3,@insertValue4)";
        public string personelBilgiSil = "DELETE FROM employee WHERE employee_id = @itemId";
        public string personelKategoriGir= "INSERT INTO missions (mission_id,mission_name) VALUES (@insertValue1, @insertValue2)";
        public string personelKategoriSil= "DELETE FROM missions WHERE mission_id = @itemId";
    }
}
