using Dapper;
using Frontend.Core.Database.DataModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Core.Database
{
    public class DataAccess
    {

         // Gets Product Data
        public List<ProductModel> GetProduct(string ProductName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseController.ConnectionVal("Northwind")))
            {
               var output = connection.Query<ProductModel>($"Select * from Products where ProductName = '{ProductName}'").ToList();
                return output;
            }
        }

        public List<ProductModel> AddProduct(string ProductName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseController.ConnectionVal("Northwind")))
            {
                var output = connection.Query<ProductModel>($"Select * from Products where ProductName = '{ProductName}'").ToList();
                return output;
            }
        }

    }
}
