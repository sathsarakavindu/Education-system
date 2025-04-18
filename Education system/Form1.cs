namespace Education_system
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_password.Text == "123")
            {
                new Dashboard_form().ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
                txt_username.Clear();
                txt_password.Clear();
            }
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
