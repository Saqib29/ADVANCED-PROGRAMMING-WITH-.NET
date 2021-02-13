using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InventoryManagementSystemWithADO.Net.Models
{
    public class CategoryModel
    {
        DataAccess dataAccess;
        public CategoryModel()
        {
            dataAccess = new DataAccess();
        }
        public List<Category> GetCategories()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader = dataAccess.GetData(sql);

            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryId = (int)reader["categoryId"];
                category.CategoryName = reader["categoryName"].ToString();
                categories.Add(category);
            }

            return categories;
        }
    }
}