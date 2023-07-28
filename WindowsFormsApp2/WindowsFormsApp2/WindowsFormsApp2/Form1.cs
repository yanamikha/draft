using ClientServerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string TokenValue;
        Dictionary<string, string> registeredViews;
        ViewDataAdapter dataAdapter;
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private async void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataAdapter = new ViewDataAdapter();
                string selectedValue = comboBox1.SelectedItem as string;
                string vName = registeredViews.FirstOrDefault(i => i.Value == selectedValue).Key;
                if (string.IsNullOrEmpty(vName)) return;
                await dataAdapter.FillDataGridViewAsync(TokenValue, vName, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception encountered: {ex.Message}");
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            TokenValue = await ClientAuthorization.AuthorizeAsync(login, password);
            ViewDataAdapter dataAdapter = new ViewDataAdapter();
            registeredViews = await dataAdapter.GetRegisteredViewAsync(TokenValue);
            comboBox1.DataSource = registeredViews.Values.ToList();
        }

    }
}
