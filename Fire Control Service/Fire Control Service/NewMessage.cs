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
    public partial class NewMessage : Form
    {
        public NewMessage()
        {
            InitializeComponent();
        }

        private void AppointedCar_Click(object sender, EventArgs e)
        {
            AppointCars appointCarsForm = new AppointCars();
            appointCarsForm.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
