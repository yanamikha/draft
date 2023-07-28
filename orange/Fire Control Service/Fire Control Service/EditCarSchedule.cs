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

namespace Fire_Control_Service
{
    public partial class EditCarSchedule : Form
    {
        public EditCarSchedule()
        {
            InitializeComponent();
            dataAdapter = new ViewDataAdapter();
            comboBoxInit();

        }
        ViewDataAdapter dataAdapter;

        private void comboBoxInit()
        {           

            try
            {
                dataAdapter = new ViewDataAdapter();
                //carComboBox.DataSource = dataAdapter.GetHintValues(, LoginForm.TokenValue);
                //string selectedValue = ;
                //string vName = registeredViews.FirstOrDefault(i => i.Value == selectedValue).Key;
                //if (string.IsNullOrEmpty(vName)) return;
                //await dataAdapter.FillDataGridViewAsync(LoginForm.TokenValue, vName, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception encountered: {ex.Message}");
            }

        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (defaultSchedule.Checked)
                endDateTimePicker.Value = startDateTimePicker.Value.Add(TimeSpan.FromDays(1));
        }

        private void carComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void driverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeTheWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
