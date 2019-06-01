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
    public partial class elev : Form
    {
        AplicatieScoala.ServiceReference1.WebServiceSoapClient service = new AplicatieScoala.ServiceReference1.WebServiceSoapClient();

        Thread t;
        Boolean open = false;
        string user;
        public elev(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
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

        private void Label5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView2);
            dataGridView2.Rows.Add(service.getAbsente(user).Tables[0].Rows[0][0].ToString());
        }

        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (open)
            {
                listBox3.Height -= 20;
                if (listBox3.Height == 0)
                {
                    open = false;
                    timer1.Stop();

                }
            }
            else if (!open)
            {
                listBox3.Height += 20;
                if (listBox3.Height >= 300)
                {
                    open = true;
                    timer1.Stop();

                }
            }
        }
    }
}
