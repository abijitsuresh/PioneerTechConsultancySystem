﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PioneerTechConsultancySystem
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void InsertHomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeDetails EmployeeDetailsObj = new EmployeeDetails();
            EmployeeDetailsObj.Show();
        }

        private void HomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LoginScreen form1 = new LoginScreen();
            form1.Show();
        }

        private void SearchEmployeeDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayEmployeeDetails DisplayScreen = new DisplayEmployeeDetails();
            DisplayScreen.Show();
        }
    }
}
