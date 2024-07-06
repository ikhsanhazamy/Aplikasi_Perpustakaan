namespace e_library
{
    partial class FormPinjamBuku
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtJudul;
        private Label lblJudul;
        private Button btnPinjam;

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
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(110, 42);
            this.txtJudul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(176, 23);
            this.txtJudul.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(52, 50);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(37, 15);
            this.lblJudul.TabIndex = 3;
            this.lblJudul.Text = "Judul:";
            // 
            // btnPinjam
            // 
            this.btnPinjam.BackColor = System.Drawing.Color.Khaki;
            this.btnPinjam.Location = new System.Drawing.Point(110, 82);
            this.btnPinjam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(131, 38);
            this.btnPinjam.TabIndex = 6;
            this.btnPinjam.Text = "Pinjam";
            this.btnPinjam.UseVisualStyleBackColor = false;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // FormPinjamBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(383, 156);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.txtJudul);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPinjamBuku";
            this.Text = "Pinjam Buku";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
