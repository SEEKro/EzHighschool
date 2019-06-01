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
    
    public partial class elev_login : Form
    {
        AplicatieScoala.ServiceReference1.WebServiceSoapClient service = new AplicatieScoala.ServiceReference1.WebServiceSoapClient();

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
            //Application.Run(new MainScreen());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            


            if (textBox2.Text == service.getPassword("elev", textBox1.Text).Tables[0].Rows[0][0].ToString())
            {
                t = new Thread(openelev);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username sau parola gresita!", "Eroare de logare");
            }
        }

        private void openelev(object obj)
        {
            Application.Run(new EleviInfoForm(textBox1.Text, 
                                service));
        }

        private void Elev_login_Load(object sender, EventArgs e)
        {

        }
    }
}
