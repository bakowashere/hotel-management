using System;

namespace Hotel_Management_Systems
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRegisteration = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Employee1 = new Hotel_Management_Systems.All_User_Control.UC_Employee();
            this.customerDetails1 = new Hotel_Management_Systems.All_User_Control.CustomerDetails();
            this.uC_CustomerCheckOut1 = new Hotel_Management_Systems.All_User_Control.UC_CustomerCheckOut();
            this.uC_CustomerRegisteration1 = new Hotel_Management_Systems.All_User_Control.UC_CustomerRegisteration();
            this.uC_AddRoom1 = new Hotel_Management_Systems.All_User_Control.UC_AddRoom();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomerDetails);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCustomerRegisteration);
            this.panel1.Controls.Add(this.btnAddRoom);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.MovingPanel, "MovingPanel");
            this.MovingPanel.Name = "MovingPanel";
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 26;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.btnEmployee, "btnEmployee");
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageSize = new System.Drawing.Size(35, 35);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BorderRadius = 26;
            this.btnCustomerDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerDetails.CheckedState.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCustomerDetails.CheckedState.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.CustomImages.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.FillColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.btnCustomerDetails, "btnCustomerDetails");
            this.btnCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetails.HoverState.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetails.Image")));
            this.btnCustomerDetails.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.ShadowDecoration.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 26;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.btnCheckOut, "btnCheckOut");
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCustomerRegisteration
            // 
            this.btnCustomerRegisteration.BorderRadius = 26;
            this.btnCustomerRegisteration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRegisteration.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerRegisteration.CheckedState.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCustomerRegisteration.CheckedState.Parent = this.btnCustomerRegisteration;
            this.btnCustomerRegisteration.CustomImages.Parent = this.btnCustomerRegisteration;
            this.btnCustomerRegisteration.FillColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.btnCustomerRegisteration, "btnCustomerRegisteration");
            this.btnCustomerRegisteration.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRegisteration.HoverState.Parent = this.btnCustomerRegisteration;
            this.btnCustomerRegisteration.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRegisteration.Image")));
            this.btnCustomerRegisteration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerRegisteration.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerRegisteration.Name = "btnCustomerRegisteration";
            this.btnCustomerRegisteration.ShadowDecoration.Parent = this.btnCustomerRegisteration;
            this.btnCustomerRegisteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerRegisteration.Click += new System.EventHandler(this.btnCustomerRegisteration_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 26;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.btnAddRoom, "btnAddRoom");
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.customerDetails1);
            this.panel2.Controls.Add(this.uC_CustomerCheckOut1);
            this.panel2.Controls.Add(this.uC_CustomerRegisteration1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Name = "panel2";
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.uC_Employee1, "uC_Employee1");
            this.uC_Employee1.Name = "uC_Employee1";
            // 
            // customerDetails1
            // 
            this.customerDetails1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.customerDetails1, "customerDetails1");
            this.customerDetails1.Name = "customerDetails1";
            // 
            // uC_CustomerCheckOut1
            // 
            this.uC_CustomerCheckOut1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.uC_CustomerCheckOut1, "uC_CustomerCheckOut1");
            this.uC_CustomerCheckOut1.Name = "uC_CustomerCheckOut1";
            // 
            // uC_CustomerRegisteration1
            // 
            this.uC_CustomerRegisteration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.uC_CustomerRegisteration1, "uC_CustomerRegisteration1");
            this.uC_CustomerRegisteration1.Name = "uC_CustomerRegisteration1";
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.uC_AddRoom1, "uC_AddRoom1");
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

  
        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetails;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegisteration;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private System.Windows.Forms.Panel MovingPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_CustomerRegisteration uC_CustomerRegisteration1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_CustomerCheckOut uC_CustomerCheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.CustomerDetails customerDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.UC_Employee uC_Employee1;
    }
}