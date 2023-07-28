using ClientServerServices;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Fire_Control_Service
{
    public partial class LoginForm : Form
    {
        public static string login;
        public static string password;
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
            login = loginTextBox.Text;
            password = passwordTextBox.Text;
           // setTokenValue();
            
            Main main = new Main();
            main.Show();
            this.Hide();                     
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
                }
            }
        }
    }
}
