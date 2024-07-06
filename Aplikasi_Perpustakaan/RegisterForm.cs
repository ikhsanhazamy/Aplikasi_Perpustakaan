using System;
using System.Windows.Forms;

namespace e_library
{
    public partial class FormRegister : Form
    {
        private DatabaseHelper dbHelper;

        public FormRegister(DatabaseHelper dbHelper)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool isAdmin = false; // Default to regular user

            if (dbHelper.RegisterUser(username, password))
            {
                MessageBox.Show("Registrasi berhasil. Silakan login.");
                Close();
            }
            else
            {
                MessageBox.Show("Registrasi gagal. Username mungkin sudah ada.");
            }
        }
    }
}
