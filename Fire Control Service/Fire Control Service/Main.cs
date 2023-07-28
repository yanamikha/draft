using ClientServerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Control_Service
{
    public partial class Main : Form
    {
        public Main()
        {  
            InitializeComponent(); 
            labelForTabRequest = labelCurrentReq.Text;
            InitAdapter();
            RefreshWindow();
        }

        private async void InitAdapter()
        {
 
        }
        string table = "Requests";
        string labelForTabRequest;

        private void sortAllReq_Click(object sender, EventArgs e)
        {
            labelCurrentReq.Text = labelForTabRequest;
        }

        private void sortNewReq_Click(object sender, EventArgs e)
        {
            labelCurrentReq.Text = labelForTabRequest + " (неопрацьовані)";
            sortNewReq.ForeColor = Color.DarkCyan;
            sortInProgressReq.ForeColor = sortDoneReq.ForeColor = Color.Black;
        }

        private void sortInProgressReq_Click(object sender, EventArgs e)
        {
            labelCurrentReq.Text = labelForTabRequest + " (в роботі)";
            sortInProgressReq.ForeColor = Color.DarkCyan;
            sortNewReq.ForeColor = sortDoneReq.ForeColor = Color.Black;
        }

        private void sortDoneReq_Click(object sender, EventArgs e)
        {
            labelCurrentReq.Text = labelForTabRequest + " (опрацьовані)";
            sortDoneReq.ForeColor = Color.DarkCyan;
            sortInProgressReq.ForeColor = sortInProgressReq.ForeColor = Color.Black;
        }

        private void openCatalogWindow_Click(object sender, EventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.ShowDialog();
        }
        Dictionary<string, string> registeredViews;
        ViewDataAdapter dataAdapter;

        private void Main_Load(object sender, EventArgs e)
        {
        

        }
        public void RefreshWindow()
        {            
             reloadTable(tableRequests);
        }
        private async void reloadTable(DataGridView gridView)
        {
            if (LoginForm.TokenValue != null)
                try
            {
                string vName = registeredViews.FirstOrDefault(i => i.Value == table).Key;
                if (string.IsNullOrEmpty(vName)) return;
                await dataAdapter.FillDataGridViewAsync(LoginForm.TokenValue, vName, gridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception encountered: {ex.Message}");
            }
        }

        private void buttonCreateMessage_Click(object sender, EventArgs e)
        {
            NewMessage newMessage = new NewMessage();
            newMessage.Show();
        }

        private void exitFromProgram_Click(object sender, EventArgs e)
        {
           var result = MessageBox.Show("Ви впевнені, що хочете припинити роботу програми?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(result == DialogResult.Yes)
            Environment.Exit(0);           
        }

        private void CarSchedule_Click(object sender, EventArgs e)
        {
            EditCarSchedule editCarSchedule = new EditCarSchedule();
            editCarSchedule.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void appointCarBatton_Click(object sender, EventArgs e)
        {
            AppointCars appointCarsForm = new AppointCars();
            appointCarsForm.Show();
        }
    }
}
