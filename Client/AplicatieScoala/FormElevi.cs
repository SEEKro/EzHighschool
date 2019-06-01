using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTestSpace
{
    public partial class Form1 : Form
    {

        private DevTestSpace.ServiceReference1.WebServiceSoapClient service;
        private string username;
        private DataSet noteDataSet, absenteDataSet, materiiDataSet;

        private void configureDataGrid(string dataType, DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            if (dataType.Equals("absente"))
            {

                dgv.DataSource = null;
                dgv.ColumnCount = 3;

                dgv.Columns[0].Name = "NumeMaterie";
                dgv.Columns[0].HeaderText = "Nume Materie";
                dgv.Columns[0].DataPropertyName = "nume_materie";

                dgv.Columns[1].Name = "Data";
                dgv.Columns[1].HeaderText = "Data";
                dgv.Columns[1].DataPropertyName = "data";

                dgv.Columns[2].Name = "Motivatie";
                dgv.Columns[2].HeaderText = "Motivatie";
                dgv.Columns[2].DataPropertyName = "motivatie";
            }

            if (dataType.Equals("note"))
            {
                dgv.DataSource = null;
                dgv.ColumnCount = 3;

                dgv.Columns[0].Name = "Materie";
                dgv.Columns[0].HeaderText = "Materie";
                dgv.Columns[0].DataPropertyName = "materie";

                dgv.Columns[1].Name = "Nota";
                dgv.Columns[1].HeaderText = "nota";
                dgv.Columns[1].DataPropertyName = "nota";

                dgv.Columns[2].Name = "Data";
                dgv.Columns[2].HeaderText = "Data";
                dgv.Columns[2].DataPropertyName = "data";

            }
        }

        //Note
        private void populateDataGridWithNote()
        {
            noteDataSet = service.getGradesByUser(username);
            dataGridView1.DataSource = noteDataSet.Tables[0];
        }

        private void populateDataGridWithNote(string materie)
        {
            noteDataSet = service.getGradesByUserAndMaaterie(username, materie);
            dataGridView1.DataSource = noteDataSet.Tables[0];
        }

        //Absente
        private void populateDataGridWithAbsente()
        {
            absenteDataSet = service.getAbsente(username);
            dataGridView1.DataSource = absenteDataSet.Tables[0];
        }

        private void populateDataGridWithAbsente(string materie)
        {
            absenteDataSet = service.getAbsenteByMaterie(materie, username);
            dataGridView1.DataSource = absenteDataSet.Tables[0];
        }

        //Materii
        private void populateMateriiListBox()
        {
            materiiDataSet = service.getMaterii();
            box_materii.DataSource = materiiDataSet.Tables[0];
            box_materii.DisplayMember = "nume";
        }

        //Handlers
        private void populateEventHandle()
        {
            if (radio_note.Checked)
            {
                if (!check_all.Checked)
                {
                    DataRowView materieView = (DataRowView)box_materii.SelectedItem;
                    populateDataGridWithNote(materieView.Row["nume"].ToString());
                }
                else
                {
                    populateDataGridWithNote();
                }
            }
            if (radio_absente.Checked)
            {
                if (!check_all.Checked)
                {
                    DataRowView materieView = (DataRowView)box_materii.SelectedItem;
                    populateDataGridWithAbsente(materieView.Row["nume"].ToString());
                }
                else
                {
                    populateDataGridWithAbsente();
                }
            }
        }

        public Form1(string username)
        {
            this.username = username;
            InitializeComponent();
            service = new DevTestSpace.ServiceReference1.WebServiceSoapClient();
            radio_note.Checked = false;
            radio_absente.Checked = false;
        }

        //Events
        private void box_materii_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateEventHandle();
        }

        private void radio_note_CheckedChanged(object sender, EventArgs e)
        {
            radio_absente.Checked = false;
            configureDataGrid("note", dataGridView1);
            populateEventHandle();
        }

        private void radio_absente_CheckedChanged_1(object sender, EventArgs e)
        {
            radio_note.Checked = false;
            configureDataGrid("absente", dataGridView1);
            populateEventHandle();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_all.Checked)
            {
                box_materii.Enabled = false;
            }
            else
            {
                box_materii.Enabled = true;
            }
            populateEventHandle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = true;
            populateMateriiListBox();
        }
    }
}
