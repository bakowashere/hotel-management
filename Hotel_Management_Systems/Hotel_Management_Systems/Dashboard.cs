using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_Systems
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnCustomerRegisteration_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerRegisteration.Left+18;
            uC_CustomerRegisteration1.Visible = true;
            uC_CustomerRegisteration1.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left+18;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCheckOut.Left + 18;
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerDetails.Left + 18;
            customerDetails1.Visible = true;
            customerDetails1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnEmployee.Left + 18;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRegisteration1.Visible = false;
            customerDetails1.Visible = false;
            uC_Employee1.Visible = false;
            btnAddRoom.PerformClick();

        }
    }
}
