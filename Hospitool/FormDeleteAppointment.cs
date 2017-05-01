using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Hospitool.Service;
namespace Hospitool
{
   
    public partial class FormDeleteAppointment : Form
    {
        DoctorService serviceDoctor = new DoctorService();
        public Receptionist receptionist;
        public string DoctorId;
        AppointmentService serviceAppointment = new AppointmentService();
        public string timeID;
        HospitoolEntities db = new HospitoolEntities();
        public FormDeleteAppointment(Receptionist newreceptionist)
        {
            
            InitializeComponent();
            receptionist = newreceptionist;
            timeID = null;
            DoctorId = null;
        }
        public FormDeleteAppointment()
        {

            InitializeComponent();

            timeID = null;
            DoctorId = null;
        }

        private void FormDeleteAppointment_Load(object sender, EventArgs e)
        {
                cbDoctors.DisplayMember = "DetailedInfo";
                cbDoctors.ValueMember = "DoctorID";

                cbDoctors.DataSource = serviceDoctor.GetAll();

                dateTimePicker1.MaxDate = DateTime.Now.AddDays(4);
                dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
        }

        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctors.SelectedText != null)
            {
                string selectedField = cbDoctors.Text;

                cbDoctors.DisplayMember = "DetailedInfo";
                cbDoctors.ValueMember = "DoctorID";
                DoctorId = cbDoctors.SelectedValue.ToString();
                dateTimePicker1_ValueChanged(sender, e);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dateAndTime = dateTimePicker1.Value;
            var date = dateAndTime.Date;

            if (DoctorId != null)
            {               
                    cbHours.DataSource = serviceAppointment.GetByDate(date, Int32.Parse(DoctorId));
                    cbHours.DisplayMember = "AppointmentStartdate";
                    cbHours.ValueMember = "AppointmentID";
            }
        }

        private void cbHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeID = cbHours.SelectedValue.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(timeID != null && DoctorId != null)
            {
                Appointment temp = new Appointment();
                int appointmentid = Int32.Parse(timeID);
                foreach(Appointment appointment in db.Appointments.Where(m=>m.AppointmentID == appointmentid))
                {
                    temp = appointment;
                }
                db.Appointments.Remove(temp);
                db.SaveChanges();
                MessageBox.Show("قرار ملاقات با موفقیت حذف گردید.");
                dateTimePicker1_ValueChanged(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
