using MiniShop.Services;
using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models
{
    

    internal class SaleReport
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DataTable GetSalesByDateRange(DateTime start, DateTime end)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_GetSalesByDateRange", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@StartDate", start.Date);
                cmd.Parameters.AddWithValue("@EndDate", end.Date.AddDays(1).AddTicks(-1));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetTopSellingProducts(DateTime start, DateTime end)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_GetTopSellingProducts", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@StartDate", start.Date);
                cmd.Parameters.AddWithValue("@EndDate", end.Date.AddDays(1).AddTicks(-1));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }

}
