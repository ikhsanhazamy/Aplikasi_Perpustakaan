namespace e_library
{
    partial class FormTambahKatalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblPengarang = new System.Windows.Forms.Label();
            this.lblTahunTerbit = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtPengarang = new System.Windows.Forms.TextBox();
            this.txtTahunTerbit = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(30, 30);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(37, 15);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Judul:";
            // 
            // lblPengarang
            // 
            this.lblPengarang.AutoSize = true;
            this.lblPengarang.Location = new System.Drawing.Point(30, 70);
            this.lblPengarang.Name = "lblPengarang";
            this.lblPengarang.Size = new System.Drawing.Size(66, 15);
            this.lblPengarang.TabIndex = 1;
            this.lblPengarang.Text = "Pengarang:";
            // 
            // lblTahunTerbit
            // 
            this.lblTahunTerbit.AutoSize = true;
            this.lblTahunTerbit.Location = new System.Drawing.Point(30, 110);
            this.lblTahunTerbit.Name = "lblTahunTerbit";
            this.lblTahunTerbit.Size = new System.Drawing.Size(73, 15);
            this.lblTahunTerbit.TabIndex = 2;
            this.lblTahunTerbit.Text = "Tahun Terbit:";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(120, 27);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(200, 23);
            this.txtJudul.TabIndex = 3;
            // 
            // txtPengarang
            // 
            this.txtPengarang.Location = new System.Drawing.Point(120, 67);
            this.txtPengarang.Name = "txtPengarang";
            this.txtPengarang.Size = new System.Drawing.Size(200, 23);
            this.txtPengarang.TabIndex = 4;
            // 
            // txtTahunTerbit
            // 
            this.txtTahunTerbit.Location = new System.Drawing.Point(120, 107);
            this.txtTahunTerbit.Name = "txtTahunTerbit";
            this.txtTahunTerbit.Size = new System.Drawing.Size(200, 23);
            this.txtTahunTerbit.TabIndex = 5;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(120, 150);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 30);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah Buku";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // FormTambahKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtTahunTerbit);
            this.Controls.Add(this.txtPengarang);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.lblTahunTerbit);
            this.Controls.Add(this.lblPengarang);
            this.Controls.Add(this.lblJudul);
            this.Name = "FormTambahKatalog";
            this.Text = "Tambah Katalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPengarang;
        private System.Windows.Forms.Label lblTahunTerbit;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtPengarang;
        private System.Windows.Forms.TextBox txtTahunTerbit;
        private System.Windows.Forms.Button btnTambah;
    }
}
