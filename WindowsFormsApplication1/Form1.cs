﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login code 
            string username = txtUName.Text;
            string password = txtPass.Text;

            if (username == "admin" && password == "1234")
            {
                this.Hide();
                new  MainWindow().Show();
            }
            else {

                MessageBox.Show("Invalide username and Password\n Please Try again.. ");
               
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
