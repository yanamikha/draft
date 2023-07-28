using ClientServerServices;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Fire_Control_Service
{
    public partial class LoginForm : Form
    {
        public static string TokenValue;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void cancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Environment.Exit(0);
        }

        private async void ok_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != String.Empty && passwordTextBox.Text != String.Empty)
            {
                setTokenValue();
                try
                {
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Для правильної роботи програми виконайте підключення до сервера", "Помилка підключення до сервера", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            else
            MessageBox.Show("Введіть значення пароля та логіна", "Помилка вводу", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        async void setTokenValue()
        {
            {
                try
                {
                    TokenValue = await ClientAuthorization.AuthorizeAsync(loginTextBox.Text, passwordTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Для правильної роботи програми виконайте підключення до сервера", "Помилка підключення до сервера", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }
    }
}
