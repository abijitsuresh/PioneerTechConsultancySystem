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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //EmployeeDetails EmployeeDetailsObj = new EmployeeDetails();
            //this.Hide();
            //EmployeeDetailsObj.Show();

            string loginId = LoginIdTextBox.Text;
            string password = PasswordTextBox.Text;

            if (loginId.Equals("admin") && password.Equals("abc@123"))
            {
                MessageBox.Show("Login Success");
                this.Hide();
                HomeScreen HomeScreenObj = new HomeScreen();
                HomeScreenObj.Show();                
            }
            else
                MessageBox.Show("Login Failed. Enter Correct details.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
