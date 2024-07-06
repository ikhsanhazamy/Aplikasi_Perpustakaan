using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace e_library
{
    public partial class Form1 : Form
    {
        public static List<Buku> bukuList = new List<Buku>();
        private bool isAdmin = false; // Variabel untuk menyimpan status admin atau bukan

        public static BindingList<User> userList;
        private DatabaseHelper dbHelper;

        public Form1(BindingList<User> users, DatabaseHelper dbHelper)
        {
            InitializeComponent();
            userList = users;
            this.dbHelper = dbHelper;
            LoadBukuDariDatabase();
        }

        private void LoadBukuDariDatabase()
        {
            bukuList.Clear();
            string connectionString = "server=localhost;port=3306;database=perpustakaan;uid=root;pwd=newpassword;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Title, Author, Year FROM books";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string judul = reader.GetString("Title");
                        string pengarang = reader.GetString("Author");
                        int tahunTerbit = reader.GetInt32("Year");
                        bukuList.Add(new Buku(judul, pengarang, tahunTerbit));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memuat data buku: " + ex.Message);
                }
            }
        }




        public void SetRole(bool isAdmin)
        {
            this.isAdmin = isAdmin;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new FormLogin(userList);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                SetRole(loginForm.IsAdmin);
            }
        }
    }

    public class Buku
    {
        public string Judul { get; set; }
        public string Pengarang { get; set; }
        public int TahunTerbit { get; set; }

        public Buku(string judul, string pengarang, int tahunTerbit)
        {
            Judul = judul;
            Pengarang = pengarang;
            TahunTerbit = tahunTerbit;
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public User(string username, string password, bool isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
