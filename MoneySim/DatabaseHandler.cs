using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySim
{
    class DatabaseHandler
    {
        private string connectionString;
        public DatabaseHandler()
        {
            connectionString = GetConnectionString();
        }
        public void InsertItem(Expense expense)
        {
            string query = $"INSERT INTO dbo.Expenses(Item,Price,Occurence)" +
                $" Values('{expense.Name}', {expense.Price}, {expense.Occurence})";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                }
            }
        }

        internal List<Expense> GetDailyExpenses()
        {
            string query = "SELECT TOP (1000) [id],[Item],[Price],[Occurence] FROM [Expenses]";
            List<Expense> result = null;
            try
            {
                DataTable expenses = RunSelectQuery(query);
                foreach (DataRow item in expenses.Rows)
                {

                }
                return result;
            }
            catch (Exception)
            {

                return result;
            }

        }

        public DataTable RunSelectQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    cmd.Dispose();
                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        internal List<Expense> LoadFromDatabase()
        {
            List<Expense> expenses = new List<Expense>();
            string query = "SELECT Item,Price,Occurence FROM dbo.Expenses";
            try
            {
                DataTable dataTable = RunSelectQuery(query);
                foreach(DataRow dr in dataTable.Rows)
                {
                    expenses.Add(new Expense(dr["Item"].ToString(),
                        int.Parse(dr["Price"].ToString()),
                        int.Parse(dr["Occurence"].ToString())));
                }
                return expenses;
            }
            catch
            {
                return null;
            }
        }
        private string GetConnectionString()
        {
            return ConfigurationManager.AppSettings["connstr"];
        }
    }
}
