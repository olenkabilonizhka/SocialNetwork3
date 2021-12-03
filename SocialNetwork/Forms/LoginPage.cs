using BLL;
using System;
using System.Windows.Forms;

namespace SocialNetwork
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = UserManager.CheckLogin(TextBoxEmail.Text, TextBoxPassword.Text);
                StartPage form = new StartPage(userId);
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxEmail.Clear();TextBoxPassword.Clear();
            }
        }


        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonLogIn.PerformClick();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
