using System;
using System.Linq;
using System.Windows.Forms;

namespace e_library
{
    public partial class FormPinjamBuku : Form
    {
        public FormPinjamBuku()
        {
            InitializeComponent();
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            var judul = txtJudul.Text;

            if (!string.IsNullOrEmpty(judul))
            {
                var buku = Form1.bukuList.FirstOrDefault(b => b.Judul.Equals(judul, StringComparison.OrdinalIgnoreCase));
                if (buku != null)
                {
                    MessageBox.Show($"Anda telah meminjam buku: {buku.Judul}");
                    // Logic for borrowing book can be added here
                }
                else
                {
                    MessageBox.Show("Buku tidak ditemukan!");
                }
            }
            else
            {
                MessageBox.Show("Masukkan judul buku!");
            }
        }
    }
}
