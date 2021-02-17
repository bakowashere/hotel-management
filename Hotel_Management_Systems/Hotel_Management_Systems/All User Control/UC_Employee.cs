using System;
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
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text!= "" && txtMobile.Text!="" && txtGender.Text !=""&& txtEmail.Text!=""&& txtUsername.Text !="" && txtPassword.Text!="")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String password = txtPassword.Text;

                query = "inset into employee(ename,mobile,gender,emailid,username,pass) values ('"+name+"','"+mobile+"','"+gender+"','"+email+"','"+username+"','"+password+"')";
                fn.setData(query, "Employee Registered");

                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all fields", "Warning....!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "") {

                if(MessageBox.Show("Are you Sure? ", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query, "Removed");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }
        // METHODS
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();

            }
        }
        public void setEmployee(DataGridView dgv)
        {
           
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
               
              
        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
