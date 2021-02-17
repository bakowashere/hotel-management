﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Hotel_Management_Systems.All_User_Control
{
    public partial class UC_CustomerRegisteration : UserControl
    {
        function fn = new function();
        String query;

        public UC_CustomerRegisteration()
        {
            InitializeComponent();
        }

       public void setComboBox(String query, ComboBox combo)
        {
           SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
     
            sdr.Close();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text  + "' and roomType '" + txtRoom.Text+ "' and booked 'NO'";
            setComboBox(query, txtRoomNo);
        }


        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtRoom.SelectedIndex = -1 ;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();


        }
        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String roomno = txtRoomNo.Text;
            String type = txtRoom.Text;
            String bed = txtBed.Text;
            query = "select price,roomid from rooms where roomNo ='"+roomno+"' ";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());

        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDob.Text != "" && txtIdProof.Text != "" && txtAddress.Text!="" && txtCheckİn.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String nationality = txtNationality.Text;
                String gender = txtGender.Text;
                String dob = txtDob.Text;
                String idproof = txtIdProof.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckİn.Text;

                query = " insert into customer (cname,mobile,nationality,gender,dob,idproof,address,checkin,roomid) values ('"+name+"','"+mobile+"','"+nationality+"','"+gender+"','"+dob+ "','"+idproof+"','"+address+ "','"+checkin+ "',"+rid+ ") update rooms set booked = 'YES' where roomNo = '"+txtRoomNo.Text+"' ";
                fn.setData(query, "Room No" + txtRoomNo.Text + "Allocation Successfull.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields Mandetory", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIdProof.Clear();
            txtAddress.Clear();
            txtCheckİn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();

        }

        private void UC_CustomerRegisteration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }

}