using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLtask
{
    class Program
    {
        private static readonly string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = SSPI";
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("\n What action would you like to do? \n");
                Console.WriteLine("1. Get the items from the table");
                Console.WriteLine("2. Insert items to the table");
                Console.WriteLine("3. Update items in the table");
                Console.WriteLine("4. Delete items from the table");
                Console.WriteLine("5. Run Stored Procedure");
                Console.WriteLine("0. Exit\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        GetEmployees();
                        choice = -1;
                        break;
                    case 2:
                        InsertShippers();
                        break;
                    case 3:
                        UpdateShippers();
                        break;
                    case 4:
                        DeleteShippers();
                        break;
                    case 5:
                        RunSP();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
            Console.ReadLine();
        }
        public static void GetEmployees()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataReader rdr = null;
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Employees", conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(string.Format(" {0}. {1} {2}, {3} Address: {4}, {5}", rdr[0], rdr[1], rdr[2], rdr[3], rdr[7], rdr[12]));
                }
            }
        }
            
        public static void InsertShippers()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            Console.WriteLine("Enter company_name");
            string company_name = Console.ReadLine();
            Console.WriteLine("Enter phone");
            string phone = Console.ReadLine();

            using (conn)
            {
                string sqlExpression = "INSERT into Shippers(CompanyName, Phone) values(@Company, @Phone)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression, conn);
                cmd.Parameters.AddWithValue("@Company", company_name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Item is added");
            }
        }
        public static void UpdateShippers()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            Console.WriteLine("Enter company_name which you want to update");
            string company_name = Console.ReadLine();
            Console.WriteLine("Enter new phone");
            string phone = Console.ReadLine();

            using (conn)
            {
                string sqlExpression = "UPDATE Shippers SET Phone = @Phone WHERE CompanyName = @Company";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression, conn);
                cmd.Parameters.AddWithValue("@Company", company_name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    Console.WriteLine("Item was updated");
                }
                else 
                {
                    Console.WriteLine("Company was not found");
                }
            }
        }
        public static void DeleteShippers()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            Console.WriteLine("Enter company_name which you want to delete");
            string company_name = Console.ReadLine();
            using (conn)
            {
                string sqlExpression = "DELETE FROM Shippers WHERE CompanyName = @Company";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression, conn);
                cmd.Parameters.AddWithValue("@Company", company_name);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    Console.WriteLine("Item was deleted");
                }
                else
                {
                    Console.WriteLine("Company was not found");
                }
            }
        }
        public static void RunSP()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataReader rdr = null;
            Console.WriteLine("Enter CustomerID");
            string customer_id = Console.ReadLine();
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("CustOrdersOrders", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CustomerID", customer_id));
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(string.Format(" {0}. {1} {2}, {3}", rdr[0], rdr[1], rdr[2], rdr[3]));
                }
            }
        }
    }
}

