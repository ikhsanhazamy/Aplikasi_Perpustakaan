using System;
using System.Windows.Forms;

namespace e_library
{
    public partial class FormTambahBuku : Form
    {
        private DatabaseHelper dbHelper;

        public FormTambahBuku(DatabaseHelper dbHelper)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {

            string judul = txtJudul.Text.Trim();
            string pengarang = txtPengarang.Text.Trim();
            int tahunTerbit = Convert.ToInt32(txtTahunTerbit.Text);

            dbHelper.AddBook(judul, pengarang, tahunTerbit);
            MessageBox.Show("Buku berhasil ditambahkan.");

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string judul = txtJudul.Text.Trim();
            string pengarang = txtPengarang.Text.Trim();
            int tahunTerbit = int.Parse(txtTahunTerbit.Text.Trim());

            dbHelper.AddBook(judul, pengarang, tahunTerbit);
            MessageBox.Show("Buku berhasil ditambahkan.");

            txtJudul.Clear();
            txtPengarang.Clear();
            txtTahunTerbit.Clear();
        }
    }
}
