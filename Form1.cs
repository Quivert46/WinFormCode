namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            bool isValid = true;

            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                errorProvider1.SetError(
                    txtLogin,
                    "Vui long nhap ten dang nhap"
                );

                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(
                    txtPassword,
                    "Vui long nhap mat khau"
                );

                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show(
                    "Dang nhap thanh cong!",
                    "Thong bao"
                );
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
