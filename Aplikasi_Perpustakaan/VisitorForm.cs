using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace e_library
{
    public partial class VisitorForm : Form
    {
        private DatabaseHelper dbHelper;

        public VisitorForm(DatabaseHelper dbHelper)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
            LoadBooks();
        }

        private void LoadBooks()
        {
            List<Buku> bukuList = dbHelper.GetAllBooks();
            listBoxBuku.DataSource = bukuList;
            listBoxBuku.DisplayMember = "Judul";
        }

        private void btnLihatKatalog_Click(object sender, EventArgs e)
        {
            var formKatalogBuku = new FormKatalogBuku(dbHelper);
            formKatalogBuku.ShowDialog();
        }

        private void btnPinjamBuku_Click(object sender, EventArgs e)
        {
            if (listBoxBuku.SelectedItem is Buku selectedBuku)
            {
                // Implement logic to handle book borrowing
                MessageBox.Show($"Anda meminjam buku: {selectedBuku.Judul}");
            }
            else
            {
                MessageBox.Show("Pilih buku terlebih dahulu.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
