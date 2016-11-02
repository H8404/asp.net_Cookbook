using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DBmysql
/// </summary>

namespace CookBook.Data
{
    public class DBmysql
    {
        public static DataTable GetMySql(string cs)
        {
            try
            {
                string sql = "SELECT * FROM users ";
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       /* public string InsertIntoRecipe(string cs)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }*/
    }
}