﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AplicatieScoala
{
    public partial class elev_login : Form
    {
        Thread t;
        public elev_login()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(openmenu);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void openmenu(object obj)
        {
            Application.Run(new Form1());
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            if ((textBox1.Text == "user") && (textBox2.Text == "parola"))
            {
                this.Close();
                t = new Thread(openelev);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else
            {
                MessageBox.Show("Username sau parola gresita!", "Eroare de logare");
            }
        }

        private void openelev(object obj)
        {
            Application.Run(new elev());
        }
    }
}
