using System;
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
    public partial class MainScreen : Form
    {
        Thread t;
        public MainScreen()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(openelev);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void openelev(object obj)
        {
            Application.Run(new elev_login());
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(openadmin);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        private void openadmin(object obj)
        {
            Application.Run(new admin_log());
        }

        private void Button3_Click(object sender, EventArgs e)
        {         
            this.Close();
            t = new Thread(openprofesor);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void openprofesor(object obj)
        {
            Application.Run(new profesor_login());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
