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

        public static void InsertIntoUsers(string cs, string username, string password)
        {
            var con = new MySqlConnection(cs);
            try
            {
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO users (username,password) VALUES (@uname,MD5(@pword))";
                command.Parameters.AddWithValue("@uname", username);
                command.Parameters.AddWithValue("@pword", password);
                con.Open();
                command.ExecuteNonQuery();
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
        public static DataTable GetRecipeInfo(string cs, string uid)
        {
            try
            {
                string sql = "SELECT * FROM recipes WHERE U_id =" + uid;
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

        public static DataTable GetRecipeByGategory(string cs, string category)
        {
            try
            {
                string sql = "SELECT * FROM recipes WHERE category = '" + category +"';";
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

        public static void InsertIntoRecipe(string cs, string title, string description, string category, string ingredients, string steps, string uid)
        {
            var con = new MySqlConnection(cs);
            try
            {
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO recipes (title,description,category,ingredients,steps,U_id) VALUES (@title,@description,@category,@ingredients,@steps,@U_id)";
                command.Parameters.AddWithValue("@title",title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@ingredients", ingredients);
                command.Parameters.AddWithValue("@steps", steps);
                command.Parameters.AddWithValue("@U_id", uid);
                con.Open();
                command.ExecuteNonQuery();
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

        public static void EditRecipe(string cs,string id, string title, string description, string category, string ingredients, string steps, string uid)
        {
            var con = new MySqlConnection(cs);
            try
            {
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "REPLACE INTO recipes (id,title,description,category,ingredients,steps,U_id) VALUES (@id,@title,@description,@category,@ingredients,@steps,@U_id)";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@ingredients", ingredients);
                command.Parameters.AddWithValue("@steps", steps);
                command.Parameters.AddWithValue("@U_id", uid);
                con.Open();
                command.ExecuteNonQuery();
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

        public static string getrecipeTitle(string id)
        {
            string titleFromDB = "";

            try
            {
                string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
                DataTable dt = CookBook.Data.DBmysql.GetRecipe(cs, id);
                foreach (DataRow dr in dt.Rows)
                {
                    titleFromDB = dr["title"].ToString();
                }
                return titleFromDB;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string getrecipeDescription(string id)
        {
            string descriptionFromDB = "";

            try
            {
                string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
                DataTable dt = CookBook.Data.DBmysql.GetRecipe(cs, id);
                foreach (DataRow dr in dt.Rows)
                {
                    descriptionFromDB = dr["description"].ToString();
                }
                return descriptionFromDB;
 
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public static string getrecipeCategory(string id)
        {
            string categoryFromDB = "";

            try
            {
                string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
                DataTable dt = CookBook.Data.DBmysql.GetRecipe(cs, id);
                foreach (DataRow dr in dt.Rows)
                {
                    categoryFromDB = dr["category"].ToString();
                }
                return categoryFromDB;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public static string getrecipeSteps(string id)
        {
            string stepsFromDB = "";

            try
            {
                string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
                DataTable dt = CookBook.Data.DBmysql.GetRecipe(cs, id);
                foreach (DataRow dr in dt.Rows)
                {
                    stepsFromDB = dr["steps"].ToString();
                }
                return stepsFromDB;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public static string getrecipeIngredients(string id)
        {
            string ingredientsFromDB = "";

            try
            {
                string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
                DataTable dt = CookBook.Data.DBmysql.GetRecipe(cs, id);
                foreach (DataRow dr in dt.Rows)
                {
                    ingredientsFromDB = dr["ingredients"].ToString();
                }
                return ingredientsFromDB;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public static void RemoveRecipe(string cs, string id)
        {
            var con = new MySqlConnection(cs);
            try
            {
                
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "DELETE FROM recipes WHERE id = " + id;
                con.Open();
                command.ExecuteNonQuery();
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

        public static DataTable LogIn(string cs, string uname, string pword)
        {
            var con = new MySqlConnection(cs);
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM users WHERE username=@UserName AND password = MD5(@Password)";
                command.Parameters.AddWithValue("@UserName", uname);
                command.Parameters.AddWithValue("@Password", pword);
                con.Open();
                command.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                da.Fill(dt);
                return dt;
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