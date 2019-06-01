using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieScoala
{
    public partial class FormProfesori : Form
    {

        private AplicatieScoala.ServiceReference1.WebServiceSoapClient service;
        private string username;
        private DataSet materiiDataSet, claseDataSet;

        private void populateMateriiListBox()
        {
            materiiDataSet = service.getMaterii();
            box_materii.DataSource = materiiDataSet.Tables[0];
            box_materii.DisplayMember = "nume";
        }

        private void populateClaseComboBox()
        {
            claseDataSet = service.getClase();
            foreach(DataRow dr in claseDataSet.Tables[0].Rows)
            {

            }
        }

        private void FormProfesori_Load(object sender, EventArgs e)
        {
            populateMateriiListBox();
        }

        public FormProfesori(AplicatieScoala.ServiceReference1.WebServiceSoapClient service, string username)
        {
            InitializeComponent();
            this.service = service;
            this.username = username;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
