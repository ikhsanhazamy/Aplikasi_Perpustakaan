using System;
using System.Windows.Forms;

namespace e_library
{
    public partial class FormKatalogBuku : Form
    {
        public FormKatalogBuku(DatabaseHelper dbHelper)
        {
            InitializeComponent();
            LoadBukuKeListBox();
        }

        private void LoadBukuKeListBox()
        {
            foreach (var buku in Form1.bukuList)
            {
                listBoxBuku.Items.Add($"{buku.Judul} - {buku.Pengarang} ({buku.TahunTerbit})");
            }
        }
    }
}
