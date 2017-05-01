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
    public partial class FormDoctor : Form
    {
        public Doctor doctor;
        public FormDoctor(Doctor newdoctor)
        {
            InitializeComponent();
            doctor = newdoctor;
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            FormSeeAppointment form = new FormSeeAppointment(doctor);
            form.Show();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            label1.Text = doctor.DoctorName + " " + doctor.DoctorSurname + " " + "خوش آمدید,";

            
        }

        private void btnLabtestResult_Click(object sender, EventArgs e)
        {
            FormDoctorSeeLabtest form = new FormDoctorSeeLabtest();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
