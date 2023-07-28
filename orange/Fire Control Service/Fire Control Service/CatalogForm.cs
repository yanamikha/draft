using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientServerServices;

namespace Fire_Control_Service
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
            Init();
        }
        private async void Init()
        {
            dataAdapter = new ViewDataAdapter();
            registeredViews = await dataAdapter.GetRegisteredViewAsync(LoginForm.TokenValue);
            comboBox1.DataSource = registeredViews.Values.ToList();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
          }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentCell = cell;
                dataGridView1.BeginEdit(true);
                dataGridView1.ReadOnly = false;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.BeginEdit(false);
        }
        DataGridViewRow row;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            row = dataGridView1.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = Color.MediumAquamarine;           
        }

        Dictionary<string, string> registeredViews;
        ViewDataAdapter dataAdapter;
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataAdapter = new ViewDataAdapter();
                string selectedValue = comboBox1.SelectedItem as string;
                string vName = registeredViews.FirstOrDefault(i => i.Value == selectedValue).Key;
                if (string.IsNullOrEmpty(vName)) return;
                await dataAdapter.FillDataGridViewAsync(LoginForm.TokenValue, vName, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception encountered: {ex.Message}");
            }
        }

        private void openSearchDialog_Click(object sender, EventArgs e)
        {
            Button startSearch = new Button();

            startSearch.Text = "Пошук";
            startSearch.Width = 116; 
            startSearch.Height = 33;
            startSearch.Location = new Point(this.Width - 150, 130);
            startSearch.Click += new EventHandler(searchClick);
            startSearch.BackColor = Color.DarkCyan;
            startSearch.BackgroundImageLayout = ImageLayout.None;
            startSearch.FlatAppearance.BorderColor = Color.DarkSlateGray;
            startSearch.FlatAppearance.MouseDownBackColor = Color.Transparent;
            startSearch.FlatStyle = FlatStyle.Flat;
            startSearch.Font = new Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startSearch.ForeColor = Color.White;
            this.Controls.Add(startSearch);
           
        }

        private void searchClick(object sender, EventArgs e)
        {
            MessageBox.Show("Я пока ничего не умею...");
        }
    }
}
