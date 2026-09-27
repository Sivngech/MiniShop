using MiniShop.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniShop.Data
{
    public class CategoryDAO
    {
        // 1. ទាញយក Categories ទាំងអស់ រួមទាំង Total Products និង Total Stock
        public DataTable GetAllCategories(string searchQuery = "")
        {
            string query = @"
                SELECT 
                    c.CategoryID AS [Category ID],
                    c.CategoryName AS [Category Name],
                    c.Description,
                    c.IsActive AS [Status],
                    COUNT(p.ProductID) AS [Total Products],
                    ISNULL(SUM(p.Quantity), 0) AS [Total Stock]
                FROM Categories c
                LEFT JOIN Products p ON c.CategoryID = p.CategoryID
                WHERE (@search = '' OR c.CategoryName LIKE @search OR c.Description LIKE @search)
                GROUP BY c.CategoryID, c.CategoryName, c.Description, c.IsActive
                ORDER BY c.CategoryID DESC";

            string searchPattern = string.IsNullOrWhiteSpace(searchQuery) ? "" : "%" + searchQuery.Trim() + "%";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@search", searchPattern)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // 2. ពិនិត្យមើលឈ្មោះ Category ជាន់គ្នា (Duplicate Check)
        public bool IsCategoryNameExists(string categoryName, int excludeId = 0)
        {
            string query = "SELECT COUNT(*) FROM Categories WHERE LOWER(CategoryName) = LOWER(@Name) AND CategoryID != @ExcludeID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", categoryName.Trim()),
                new SqlParameter("@ExcludeID", excludeId)
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        // 3. បញ្ចូល Category ថ្មី
        public bool AddCategory(string name, string description, bool isActive, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (IsCategoryNameExists(name))
            {
                errorMessage = "ឈ្មោះប្រភេទទំនិញ (Category Name) នេះមានរួចហើយ! មិនអាចបញ្ចូលជាន់គ្នាបានទេ។";
                return false;
            }

            string query = @"INSERT INTO Categories (CategoryName, Description, IsActive) 
                             VALUES (@Name, @Desc, @IsActive)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name?.Trim() ?? string.Empty),
                new SqlParameter("@Desc", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description.Trim()),
                new SqlParameter("@IsActive", isActive)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // 4. កែប្រែ Category
        public bool UpdateCategory(int id, string name, string description, bool isActive, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (IsCategoryNameExists(name, id))
            {
                errorMessage = "ឈ្មោះ Category នេះមានរួចហើយនៅក្នុង ID ផ្សេង!";
                return false;
            }

            string query = @"UPDATE Categories 
                             SET CategoryName = @Name, Description = @Desc, IsActive = @IsActive 
                             WHERE CategoryID = @ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id),
                new SqlParameter("@Name", name?.Trim() ?? string.Empty),
                new SqlParameter("@Desc", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description.Trim()),
                new SqlParameter("@IsActive", isActive)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // 5. លុប Category ជាមួយ Safe Check
        public bool DeleteCategory(int id, out string errorMessage)
        {
            errorMessage = string.Empty;

            string checkQuery = "SELECT COUNT(*) FROM Products WHERE CategoryID = @ID";
            SqlParameter[] checkParams = { new SqlParameter("@ID", id) };

            DataTable dt = DatabaseHelper.ExecuteQuery(checkQuery, checkParams);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                errorMessage = "មិនអាចលុប Category នេះបានទេ ព្រោះមាន Products កំពុងភ្ជាប់ជាមួយវា។";
                return false;
            }

            string deleteQuery = "DELETE FROM Categories WHERE CategoryID = @ID";
            SqlParameter[] deleteParams = { new SqlParameter("@ID", id) };

            return DatabaseHelper.ExecuteNonQuery(deleteQuery, deleteParams) > 0;
        }
    }
}