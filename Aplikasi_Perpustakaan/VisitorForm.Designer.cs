namespace e_library
{
    partial class VisitorForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxBuku;
        private Button btnLihatKatalog;
        private Button btnPinjamBuku;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listBoxBuku = new ListBox();
            btnLihatKatalog = new Button();
            btnPinjamBuku = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // listBoxBuku
            // 
            listBoxBuku.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxBuku.FormattingEnabled = true;
            listBoxBuku.ItemHeight = 20;
            listBoxBuku.Location = new Point(12, 12);
            listBoxBuku.Name = "listBoxBuku";
            listBoxBuku.Size = new Size(360, 264);
            listBoxBuku.TabIndex = 0;
            // 
            // btnLihatKatalog
            // 
            btnLihatKatalog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLihatKatalog.BackColor = Color.Khaki;
            btnLihatKatalog.Location = new Point(128, 290);
            btnLihatKatalog.Name = "btnLihatKatalog";
            btnLihatKatalog.Size = new Size(110, 30);
            btnLihatKatalog.TabIndex = 1;
            btnLihatKatalog.Text = "Lihat Katalog";
            btnLihatKatalog.UseVisualStyleBackColor = false;
            btnLihatKatalog.Click += btnLihatKatalog_Click;
            // 
            // btnPinjamBuku
            // 
            btnPinjamBuku.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPinjamBuku.BackColor = Color.Khaki;
            btnPinjamBuku.Location = new Point(12, 290);
            btnPinjamBuku.Name = "btnPinjamBuku";
            btnPinjamBuku.Size = new Size(110, 30);
            btnPinjamBuku.TabIndex = 2;
            btnPinjamBuku.Text = "Pinjam Buku";
            btnPinjamBuku.UseVisualStyleBackColor = false;
            btnPinjamBuku.Click += btnPinjamBuku_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.Khaki;
            btnLogout.Location = new Point(262, 290);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 30);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // VisitorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(384, 341);
            Controls.Add(btnLogout);
            Controls.Add(btnPinjamBuku);
            Controls.Add(btnLihatKatalog);
            Controls.Add(listBoxBuku);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "VisitorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visitor Form";
            ResumeLayout(false);
        }

        #endregion
    }
}
