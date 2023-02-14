using DemoThuctap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DemoThuctap.DAO
{
    public class DAOProduct
    {
        public DAOProduct()
        {

        }
        SqlConnection Connect()
        {
            SqlConnection conn;
            string connect = @"Data Source=LAPTOP-K9OTI2P6\SQLEXPRESS;Initial Catalog=Demodb;Persist Security Info=True;User ID=sa;Password=123456";
            conn = new SqlConnection(connect);
            conn.Open();
            return conn;
        }
        /*        public List<Product> LoadDB()
                {
                    List<Product> ListProduct = new List<Product>();
                    SqlConnection conn=this.Connect();
                    SqlCommand command;
                    SqlDataReader dataReader;
                    string sql;
                    sql = "select ID,NAME from Product";
                    command = new SqlCommand(sql, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Product a = new Product();
                        a.setId(dataReader.GetValue(0).ToString());
                        a.setName(dataReader.GetValue(1).ToString());
                        ListProduct.Add(a);
                    }
                    dataReader.Close();
                    command.Dispose();
                    conn.Close();
                    return ListProduct;
                }*/
        public DataTable LoadDB()
        {
            DataTable tbl = new DataTable();
            SqlConnection conn = this.Connect();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            sql = "select ID,NAME from Product";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            tbl.Load(dataReader);
            dataReader.Close();
            command.Dispose();
            conn.Close();
            return tbl;
        }
        public void Add(String name)
        {
            SqlConnection conn = this.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;
            string sql;
            sql = "Insert into Product (Name) values('" +name+ "')";
            command = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            conn.Close();
        }
        public void Update(Product a)
        {
            SqlConnection conn = this.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;
            string sql;
            sql = "Update Product set NAME='" + a.getName().ToString() + "' where ID="+a.getId().ToString();
            command = new SqlCommand(sql, conn);
            adapter.UpdateCommand = new SqlCommand(sql, conn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            conn.Close();
        }
        public void Delete(String id)
        {
            SqlConnection conn = this.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;
            string sql;
            sql = "delete Product where ID="+ id;
            command = new SqlCommand(sql, conn);
            adapter.DeleteCommand = new SqlCommand(sql, conn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            conn.Close();
        }
/*        public Product Findid(String id)
        {
            Product product = new Product();

            return product;
        }*/
    }
}