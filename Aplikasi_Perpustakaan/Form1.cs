
using System.ComponentModel;

namespace e_library
{
    public partial class FormLogin : Form
    {
        private DatabaseHelper dbHelper;


        public bool IsAdmin { get; private set; }

        public FormLogin(DatabaseHelper dbHelper)
        {

            InitializeComponent();
            this.dbHelper = dbHelper;
        }

        public FormLogin(BindingList<User> userList)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            var user = dbHelper.GetUser(username, password);

            if (user != null)
            {
                IsAdmin = user.IsAdmin;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Username atau password salah.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var formRegister = new FormRegister(dbHelper);
            formRegister.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

