using System;
using System.Windows.Forms;

namespace e_library
{
    public partial class AdminForm : Form
    {
        private DatabaseHelper dbHelper;

        public AdminForm(DatabaseHelper dbHelper)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
        }

        private void btnTambahBuku_Click(object sender, EventArgs e)
        {
            var formTambahBuku = new FormTambahBuku(dbHelper);
            formTambahBuku.ShowDialog();
        }

        private void btnTambahKatalog_Click(object sender, EventArgs e)
        {
            var formTambahKatalog = new FormTambahKatalog();
            formTambahKatalog.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
