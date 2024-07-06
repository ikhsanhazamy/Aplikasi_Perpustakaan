namespace e_library
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnTambahBuku;
        private Button btnTambahKatalog;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnTambahBuku = new Button();
            btnTambahKatalog = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnTambahBuku
            // 
            btnTambahBuku.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTambahBuku.BackColor = Color.Khaki;
            btnTambahBuku.Location = new Point(12, 18);
            btnTambahBuku.Name = "btnTambahBuku";
            btnTambahBuku.Size = new Size(145, 30);
            btnTambahBuku.TabIndex = 0;
            btnTambahBuku.Text = "Tambah Buku";
            btnTambahBuku.UseVisualStyleBackColor = false;
            btnTambahBuku.Click += btnTambahBuku_Click;
            // 
            // btnTambahKatalog
            // 
            btnTambahKatalog.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTambahKatalog.BackColor = Color.Khaki;
            btnTambahKatalog.Location = new Point(186, 18);
            btnTambahKatalog.Name = "btnTambahKatalog";
            btnTambahKatalog.Size = new Size(145, 30);
            btnTambahKatalog.TabIndex = 1;
            btnTambahKatalog.Text = "Tambah Katalog";
            btnTambahKatalog.UseVisualStyleBackColor = false;
            btnTambahKatalog.Click += btnTambahKatalog_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.BackColor = Color.Khaki;
            btnLogout.Location = new Point(231, 68);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(343, 110);
            Controls.Add(btnLogout);
            Controls.Add(btnTambahBuku);
            Controls.Add(btnTambahKatalog);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Form";
            ResumeLayout(false);
        }
    }
}
