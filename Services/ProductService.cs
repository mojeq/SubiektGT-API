using SubiektGT_API.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SubiektGT_API.Services
{
    public class ProductService
    {
        public IList<Product> GetAllProducts()
        {
            int idGroupSubiekt;
            ProductsList productList = new ProductsList();
            SubiektConnectionData sqlConnection = new SubiektConnectionData();

            SqlConnection connection = new SqlConnection(@sqlConnection.SubiektSqlConnection);
            connection.Open();
            SqlCommand commandSQL = connection.CreateCommand();
            commandSQL.CommandText = "SELECT st_TowId, st_Stan, tw_Symbol, tw_IdGrupa FROM tw_Stan INNER JOIN tw__Towar ON tw__Towar.tw_Id=tw_Stan.st_TowId";

            using (SqlDataReader reader = commandSQL.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["tw_IdGrupa"] == DBNull.Value)
                    {
                        idGroupSubiekt = 0;
                    }
                    else
                    {
                        idGroupSubiekt = Convert.ToInt16(reader["tw_IdGrupa"]);
                    }
                    Product product = new Product
                    {
                        IdSubiekt = Convert.ToInt16(reader["st_TowId"]),
                        Stock = Convert.ToInt16(reader["st_Stan"]),
                        ProductSymbol = Convert.ToString(reader["tw_Symbol"]),
                        IdGroupSubiekt = idGroupSubiekt,
                    };
                    productList.Products.Add(product);
                };
            };

            return productList.Products;
        }
    }
}
