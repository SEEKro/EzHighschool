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
    public partial class admin_log : Form
    {
        AplicatieScoala.ServiceReference1.WebServiceSoapClient service = new AplicatieScoala.ServiceReference1.WebServiceSoapClient();

        Thread t;
        public admin_log()
        {
            InitializeComponent();
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
            Application.Run(new MainScreen());
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == service.getPassword("admin", textBox1.Text).Tables[0].Rows[0][0].ToString())
            {
                this.Close();
                t = new Thread(openadmin);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else
            {
                MessageBox.Show("Username sau parola gresita!", "Eroare de logare");
            }
        }

        private void openadmin(object obj)
        {
            Application.Run(new admin());
        }
    }
}
