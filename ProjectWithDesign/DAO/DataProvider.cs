using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDesign.BUS
{
    class DataProvider
    {
        private static DataProvider instance;
        private string connectiongString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        //private DataProvider();

        //public DataTable Query(string query)
        //{
        //    DataTable data = new DataTable();

        //    using (SqlConnection connection = new SqlConnection(connectiongString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand(query, connection);
        //        SqlDataAdapter adapter = new SqlDataAdapter(command);
        //        adapter.Fill(data);
        //        connection.Close();
        //    }
        //    return data;
        //}
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectiongString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectiongString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectiongString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
