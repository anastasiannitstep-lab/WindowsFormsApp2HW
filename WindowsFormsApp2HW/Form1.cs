using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2HW
{
    public partial class Form1 : Form
    {
        private readonly string ConnectionString = $"Data Source=VIVOBOOK16\\MSSQLSERVER_2022;Database=TestShop_P51;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\"";
        public Form1()
        {
            InitializeComponent();
            new Thread(() => { ReadCustomers(); }).Start();
            new Thread(() => { ReadOrder(); }).Start();
        }
        public void ReadCustomers()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM Customers";
                var customers = db.Query<Customer>(sql);
                // 2. Передаємо оновлення UI назад у головний потік форми
                if (lb1.IsHandleCreated)
                {
                    lb1.Invoke(new Action(() =>
                    {
                        lb1.Items.Clear();
                        lb1.Items.AddRange(customers.ToArray());
                    }));
                }
            }
        }
        public void ReadOrder()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM Orders";
                var orders = db.Query<Order>(sql);
                // 2. Передаємо оновлення UI назад у головний потік форми
                if (lb2.IsHandleCreated)
                {
                    lb2.Invoke(new Action(() =>
                    {
                        lb2.Items.Clear();
                        lb2.Items.AddRange(orders.ToArray());
                    }));
                }
            }
        }

        private void find_Customer(object sender, EventArgs e)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM Customers WHERE Name = @Name";
                var customer = db.Query<Customer>(sql, new {@Name = tbc.Text});
                // 2. Передаємо оновлення UI назад у головний потік форми
                if (fc.IsHandleCreated)
                {
                    fc.Invoke(new Action(() =>
                    {
                        fc.Items.Clear();
                        fc.Items.AddRange(customer.ToArray());
                    }));
                }
            }
        }

        private void find_Order(object sender, EventArgs e)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM Orders WHERE CustomerId = @CustomerId";
                var order = db.Query<Order>(sql, new { @CustomerId = tbo.Text });
                // 2. Передаємо оновлення UI назад у головний потік форми
                if (fc.IsHandleCreated)
                {
                    fo.Invoke(new Action(() =>
                    {
                        fo.Items.Clear();
                        fo.Items.AddRange(order.ToArray());
                    }));
                }
            }
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{Id}) {Name}, Email {Email}";
        }
    }
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            string ConnectionString = $"Data Source=VIVOBOOK16\\MSSQLSERVER_2022;Database=TestShop_P51;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\"";
            string customerName = "null";

            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                using (var cmd = new SqlCommand("SELECT Name FROM Customers WHERE Id = @Id", db))
                {
                    cmd.Parameters.AddWithValue("@Id", CustomerId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        customerName = result.ToString();
                    }
                }
            }
            return $"{Id}) Customer: {customerName}, ProductName: {ProductName}, Quantity: {Quantity}";
        }
    }
}
