using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace e_library
{
    public partial class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public BindingList<User> GetUserList()
        {
            BindingList<User> userList = new BindingList<User>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Username, Password, IsAdmin FROM users";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader.GetString("Username");
                    string password = reader.GetString("Password");
                    bool isAdmin = reader.GetBoolean("IsAdmin");
                    userList.Add(new User(username, password, isAdmin));
                }
            }
            return userList;
        }

        public void AddBook(string title, string author, int year)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO books (Title, Author, Year) VALUES (@Title, @Author, @Year)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.ExecuteNonQuery();
            }
        }

        public User GetUser(string username, string password)
        {
            User user = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Username, Password, IsAdmin FROM users WHERE Username = @Username AND Password = @Password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string userUsername = reader.GetString("Username");
                    string userPassword = reader.GetString("Password");
                    bool isAdmin = reader.GetBoolean("IsAdmin");
                    user = new User(userUsername, userPassword, isAdmin);
                }
            }
            return user;
        }

        public bool RegisterUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO users (Username, Password, IsAdmin) VALUES (@Username, @Password, false)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
            }
     
        }
        public List<Buku> GetAllBooks()
        {
            List<Buku> books = new List<Buku>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM books";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string judul = reader.GetString("Title");
                    string pengarang = reader.GetString("Author");
                    int tahunTerbit = reader.GetInt32("Year");
                    books.Add(new Buku(judul, pengarang, tahunTerbit));
                }
            }

            return books;
        }
    }
}
