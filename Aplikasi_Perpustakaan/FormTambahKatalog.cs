using System;
using System.Windows.Forms;

namespace e_library
{
    public partial class FormTambahKatalog : Form
    {
        public FormTambahKatalog()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Ambil input dari pengguna
            string judul = txtJudul.Text;
            string pengarang = txtPengarang.Text;
            int tahunTerbit;

            if (!int.TryParse(txtTahunTerbit.Text, out tahunTerbit))
            {
                MessageBox.Show("Tahun terbit harus berupa angka.");
                return;
            }

            // Buat objek Buku baru
            Buku bukuBaru = new Buku(judul, pengarang, tahunTerbit);

            // Simpan buku baru ke dalam list katalog buku di Form1 (sebagai contoh, bisa disesuaikan dengan struktur Anda)
            Form1.bukuList.Add(bukuBaru);

            // Tampilkan pesan sukses
            MessageBox.Show("Buku telah ditambahkan ke katalog.");

            // Kosongkan input setelah ditambahkan
            txtJudul.Text = "";
            txtPengarang.Text = "";
            txtTahunTerbit.Text = "";
        }
    }
}
