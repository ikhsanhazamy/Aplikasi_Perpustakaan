namespace e_library
{
    partial class FormTambahBuku
    {
        private System.ComponentModel.IContainer components = null;

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
            lblJudul = new Label();
            lblPengarang = new Label();
            lblTahunTerbit = new Label();
            txtJudul = new TextBox();
            txtPengarang = new TextBox();
            txtTahunTerbit = new TextBox();
            btnTambah = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(30, 30);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(38, 15);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Judul:";
            // 
            // lblPengarang
            // 
            lblPengarang.AutoSize = true;
            lblPengarang.Location = new Point(30, 70);
            lblPengarang.Name = "lblPengarang";
            lblPengarang.Size = new Size(67, 15);
            lblPengarang.TabIndex = 1;
            lblPengarang.Text = "Pengarang:";
            // 
            // lblTahunTerbit
            // 
            lblTahunTerbit.AutoSize = true;
            lblTahunTerbit.Location = new Point(30, 110);
            lblTahunTerbit.Name = "lblTahunTerbit";
            lblTahunTerbit.Size = new Size(74, 15);
            lblTahunTerbit.TabIndex = 2;
            lblTahunTerbit.Text = "Tahun Terbit:";
            // 
            // txtJudul
            // 
            txtJudul.Location = new Point(120, 27);
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new Size(200, 23);
            txtJudul.TabIndex = 3;
            // 
            // txtPengarang
            // 
            txtPengarang.Location = new Point(120, 67);
            txtPengarang.Name = "txtPengarang";
            txtPengarang.Size = new Size(200, 23);
            txtPengarang.TabIndex = 4;
            // 
            // txtTahunTerbit
            // 
            txtTahunTerbit.Location = new Point(120, 107);
            txtTahunTerbit.Name = "txtTahunTerbit";
            txtTahunTerbit.Size = new Size(200, 23);
            txtTahunTerbit.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Khaki;
            btnTambah.Location = new Point(120, 150);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(100, 30);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah Buku";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // FormTambahBuku
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(350, 200);
            Controls.Add(btnTambah);
            Controls.Add(txtTahunTerbit);
            Controls.Add(txtPengarang);
            Controls.Add(txtJudul);
            Controls.Add(lblTahunTerbit);
            Controls.Add(lblPengarang);
            Controls.Add(lblJudul);
            Name = "FormTambahBuku";
            Text = "Tambah Buku";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblJudul;
        private Label lblPengarang;
        private Label lblTahunTerbit;
        private TextBox txtJudul;
        private TextBox txtPengarang;
        private TextBox txtTahunTerbit;
        private Button btnTambah;
    }
}
