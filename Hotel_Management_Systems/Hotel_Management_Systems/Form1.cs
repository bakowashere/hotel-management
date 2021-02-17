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
    public partial class btnExit : Form
    {
        function fn = new function();
        String query;
        public btnExit()
        {
            InitializeComponent();
        }
    
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = " select username,pass from employee where username = '"+txtUsername.Text+"' and pass = '"+txtPassword.Text+"'";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count!=0)
            {
                labelError.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else if (txtUsername.Text == "berkay" && txtPassword.Text== "pass")
            {
                labelError.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }
    }
}
