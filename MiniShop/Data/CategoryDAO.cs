using MiniShop.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniShop.Data
{
    public class CategoryDAO
    {
        // Fetch categories with total product counts for DataGridView
        public DataTable GetAllCategories(string searchQuery = "")
        {
            string query = @"SELECT 
                                c.CategoryID AS [Category ID],
                                c.CategoryName AS [Category Name],
                                c.Description AS [Description],
                                c.IsActive AS [Status],
                                COUNT(p.ProductID) AS [Total Products]
                            FROM Categories c
                            LEFT JOIN Products p ON c.CategoryID = p.CategoryID";

            SqlParameter[] parameters = null;

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                query += " WHERE c.CategoryName LIKE @Search OR c.Description LIKE @Search";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Search", "%" + searchQuery.Trim() + "%")
                };
            }

            query += " GROUP BY c.CategoryID, c.CategoryName, c.Description, c.IsActive";

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // Add Category using RadioButton Status
        public bool AddCategory(string name, string description, bool isActive)
        {
            string query = @"INSERT INTO Categories (CategoryName, Description, IsActive) 
                             VALUES (@Name, @Desc, @IsActive)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name.Trim()),
                new SqlParameter("@Desc", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description.Trim()),
                new SqlParameter("@IsActive", isActive)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Update Category
        public bool UpdateCategory(int id, string name, string description, bool isActive)
        {
            string query = @"UPDATE Categories 
                             SET CategoryName = @Name, Description = @Desc, IsActive = @IsActive 
                             WHERE CategoryID = @ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id),
                new SqlParameter("@Name", name.Trim()),
                new SqlParameter("@Desc", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description.Trim()),
                new SqlParameter("@IsActive", isActive)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Safe Delete check against Foreign Key constraints (Products, etc.)
        public bool DeleteCategory(int id, out string errorMessage)
        {
            errorMessage = string.Empty;

            // Check if products exist under this category
            string checkQuery = "SELECT COUNT(*) FROM Products WHERE CategoryID = @ID";
            SqlParameter[] checkParams = { new SqlParameter("@ID", id) };
            DataTable dt = DatabaseHelper.ExecuteQuery(checkQuery, checkParams);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                errorMessage = "Cannot delete category: products are assigned to it.";
                return false;
            }

            string deleteQuery = "DELETE FROM Categories WHERE CategoryID = @ID";
            SqlParameter[] deleteParams = { new SqlParameter("@ID", id) };

            return DatabaseHelper.ExecuteNonQuery(deleteQuery, deleteParams) > 0;
        }
    }
}