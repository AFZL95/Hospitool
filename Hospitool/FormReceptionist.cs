using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitool
{
    public partial class FormReceptionist : Form
    {
        public Receptionist receptionist;
        public FormReceptionist(Receptionist newreceptionist)
        {
            InitializeComponent();
            receptionist = newreceptionist;
        }

        private void FormReceptionist_Load(object sender, EventArgs e)
        {
            label1.Text = receptionist.ReceptionistName + " " + receptionist.ReceptionistSurname +" " + "خوش آمدید,";
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            FormDeleteAppointment form = new FormDeleteAppointment(receptionist);
            form.Show();
        }

        private void btnAddpatient_Click(object sender, EventArgs e)
        {
            FormSignup form = new FormSignup();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
