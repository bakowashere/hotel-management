﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_Systems.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds =  fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if(txtRoomNumber.Text != "" && txtType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                String roomno = txtRoomNumber.Text;
                String type = txtType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                query = "insert into rooms (roomNo,roomType,bed,price) values ('" + roomno + "','" + type + "','" + bed + "','" + price + "')";
                fn.setData(query, "Room Added");

                UC_AddRoom_Load(this, null);
                clearAll();



            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtRoomNumber.Clear();
            txtType.SelectedIndex = 0;
            txtBed.SelectedIndex = 0;
            txtPrice.Clear();


        }

       
    }
}
