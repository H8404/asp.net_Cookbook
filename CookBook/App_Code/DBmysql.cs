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
        public static DataTable GetRecipeInfo(string cs)
        {
            try
            {
                string sql = "SELECT * FROM recipes ";
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

        public static DataTable GetRecipe(string cs, string id)
        {
            try
            {
                string sql = "SELECT * FROM recipes WHERE id="+id;
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

        public static string InsertIntoRecipe(string cs, string title, string description, string category, string ingredients, string steps)
        {
            var con = new MySqlConnection(cs);
            try
            {
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO recipes (title,description,category,ingredients,steps,U_id) VALUES (?title,?description,?category,?ingredients,?steps,?U_id)";
                command.Parameters.AddWithValue("?title",title);
                command.Parameters.AddWithValue("?description", description);
                command.Parameters.AddWithValue("?category", category);
                command.Parameters.AddWithValue("?ingredients", ingredients);
                command.Parameters.AddWithValue("?steps", steps);
                command.Parameters.AddWithValue("?U_id", 1);
                con.Open();
                command.ExecuteNonQuery();
                return "Recipe was added succesfully!";
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}