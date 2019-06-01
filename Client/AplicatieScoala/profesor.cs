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
    public partial class profesor : Form
    {
        Thread t;
        Boolean open1=false;
        Boolean open2 = false;
        Boolean open3 = false;
        Boolean motivat;
        string prof;
        public profesor(string prof)
        {
            this.prof = prof;
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
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (open1)
            {
                listBox1.Height -= 20;
                if (listBox1.Height == 0)
                {
                    open1 = false;
                    timer1.Stop();
                    
                }
            }
            else if(!open1)
            {
                listBox1.Height += 20;
                if (listBox1.Height >= 200)
                {
                    open1 = true;
                    timer1.Stop();
                    
                }
            }
        }

        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (open2)
            {
                listBox2.Height -= 20;
                if (listBox2.Height == 0)
                {
                    timer2.Stop();
                    open2 = false;
                }
            }
            else if (!open2)
            {
                listBox2.Height += 20;
                if (listBox2.Height >= 200)
                {
                    timer2.Stop();
                    open2 = true;
                }
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (open3)
            {
                listBox3.Height -= 20;
                if (listBox3.Height == 0)
                {
                    timer3.Stop();
                    open3 = false;
                }
            }
            else if (!open3)
            {
                listBox3.Height += 20;
                if (listBox3.Height >= 200)
                {
                    timer3.Stop();
                    open3 = true;
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int grade;
            String data = textBox1.Text;
            int i=data.IndexOf("/");
            grade = int.Parse(data.Substring(0, i));

            if (grade > 0 && grade < 11)
            {
                listBox4.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Nota introdusa nu este valida!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int grade=int.Parse(textBox1.Text);
            String data = listBox4.GetItemText(listBox4.SelectedItem);
            int i = data.IndexOf("/");
            data=data.Substring(i);

            if (grade > 0 && grade < 11)
            {
                listBox4.Items.Remove(listBox4.SelectedItem);
                listBox4.Items.Add(grade+data);
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Nota introdusa nu este valida!");
            }





        }

        private void Button2_Click(object sender, EventArgs e)
        {
           String data= listBox5.GetItemText(listBox5.SelectedItem);
           if (data.EndsWith("n"))
            {
                data = data.Remove(data.Length - 1) + "m";
                listBox5.Items.Remove(listBox5.SelectedItem);
                listBox5.Items.Add(data);
            }

            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
