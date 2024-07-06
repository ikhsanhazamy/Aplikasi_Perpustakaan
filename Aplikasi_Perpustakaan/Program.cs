using System;
using System.Windows.Forms;

namespace e_library
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = "server=localhost;port=3306;database=perpustakaan;uid=root;pwd=newpassword;";
            DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

            FormLogin loginForm = new FormLogin(dbHelper);

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                if (loginForm.IsAdmin)
                {
                    Application.Run(new AdminForm(dbHelper));
                }
                else
                {
                    Application.Run(new VisitorForm(dbHelper));
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
