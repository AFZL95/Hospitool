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
    public partial class FormDeleteUser : Form
    {
        PatientService servicePatient = new PatientService();
        LabWorkerService serviceLabworker = new LabWorkerService();
        ReceptionistService serviceReceptionist = new ReceptionistService();
        DoctorService serviceDoctor = new DoctorService();
        HospitoolEntities db = new HospitoolEntities();

        public Admin admin;

        public string patientid;
        public string doctorid;
        public string labworkerid;
        public string receptionistid;
        public FormDeleteUser(Admin newadmin)
        {
            InitializeComponent();
            admin = newadmin;
            patientid = null;
            doctorid = null;
            labworkerid = null;
            receptionistid = null;

        }

        private void FormDeleteUser_Load(object sender, EventArgs e)
        {
            cbPatient.DataSource = servicePatient.GetAll();
            cbLabworker.DataSource = serviceLabworker.GetAll();
            cbDoctor.DataSource = serviceDoctor.GetAll();
            cbReceptionist.DataSource = serviceReceptionist.GetAll();
            cbPatient.DisplayMember = "DetailedInfo";
            cbPatient.ValueMember = "PatientID";
            cbDoctor.DisplayMember = "DetailedInfo";
            cbDoctor.ValueMember = "DoctorID";
            cbLabworker.DisplayMember = "DetailedInfo";
            cbLabworker.ValueMember = "LabworkerID";
            cbReceptionist.DisplayMember = "DetailedInfo";
            cbReceptionist.ValueMember = "ReceptionistID";

            //cbDoctor.SelectedIndex = -1;
            //cbPatient.SelectedIndex = -1;
            //cbReceptionist.SelectedIndex = -1;
            //cbLabworker.SelectedIndex = -1;


        }

        private void btnClearPatient_Click(object sender, EventArgs e)
        {
            cbPatient.Text = " ";
            patientid = null;
        }

        private void btnClearDoctor_Click(object sender, EventArgs e)
        {
            cbDoctor.Text = " ";
            doctorid = null;
        }

        private void btnClearLabworker_Click(object sender, EventArgs e)
        {
            cbLabworker.Text = " ";
            labworkerid = null;
        }

        private void btnClearReceptionist_Click(object sender, EventArgs e)
        {
            cbReceptionist.Text = " ";
            receptionistid = null;
        }

        private void cbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPatient.SelectedText != " ")
            {
                patientid = cbPatient.SelectedValue.ToString();
            }
        }

        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDoctor.SelectedText != " ")
            {
                doctorid = cbDoctor.SelectedValue.ToString();
            }
                
            
        }

        private void cbLabworker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLabworker.SelectedText != " ")
            {
                labworkerid = cbLabworker.SelectedValue.ToString();
            }
        }

        private void cbReceptionist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReceptionist.SelectedText != " ")
            {
                receptionistid = cbLabworker.SelectedValue.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(patientid != null)
            {
                Patient temp = new Patient();
                var id = Int32.Parse(patientid);
                foreach (Patient patient in db.Patients.Where(m => m.PatientID == id))
                {
                    temp = patient;
                }
                db.Patients.Remove(temp);
                db.SaveChanges();
               cbPatient.DataSource = servicePatient.GetAll();
            }
            if (doctorid != null)
            {
                Doctor temp = new Doctor();
                var id = Int32.Parse(doctorid);
                foreach (Doctor doctor in db.Doctors.Where(m => m.DoctorID == id))
                {
                    temp = doctor;
                }
                db.Doctors.Remove(temp);
                db.SaveChanges();
                cbDoctor.DataSource = serviceDoctor.GetAll();
            }
            if (labworkerid != null)
            {
                Labworker temp = new Labworker();
                var id = Int32.Parse(labworkerid);
                foreach (Labworker labworker in db.Labworkers.Where(m => m.LabworkerID == id))
                {
                    temp = labworker;
                }
                db.Labworkers.Remove(temp);
                db.SaveChanges();
                cbDoctor.DataSource = serviceLabworker.GetAll();
            }
            if (receptionistid != null)
            {
                Receptionist temp = new Receptionist();
                var id = Int32.Parse(receptionistid);
                foreach (Receptionist receptionist in db.Receptionists.Where(m => m.ReceptionistID == id))
                {
                    temp = receptionist;
                }
                db.Receptionists.Remove(temp);
                db.SaveChanges();
                cbReceptionist.DataSource = serviceReceptionist.GetAll();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
