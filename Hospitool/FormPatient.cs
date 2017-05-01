using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Hospitool
{
    public partial class FormPatient : Form
    {
        public Patient patient;
        HospitoolEntities db = new HospitoolEntities();
        public FormPatient(Patient newpatient)
        {
            InitializeComponent();
            //f1 = ParentForm;
            patient = newpatient;
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            FormAppointment form = new FormAppointment(patient);
            form.Show();
        }



        private void FormPatient_Load(object sender, EventArgs e)
        {
            label1.Text = patient.PatientName + " "+ patient.PatientSurname +" "+"خوش آمدید," ;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FormPayment form = new FormPayment(patient);
            form.Show();
        }
        public List<Labtest> labtest;
        public Labtest newlabtest;
        byte[] myArrayOfBytes;
        public int patientid;
        private void btnTestResults_Click(object sender, EventArgs e)
        {
            labtest = db.Labtests.Where(m => m.PatientID == patient.PatientID).ToList();
            newlabtest = labtest.Find(x => x.PatientID == patient.PatientID);
            if (newlabtest != null) { 
                myArrayOfBytes = newlabtest.LabtestStoredFile;
                File.WriteAllBytes(@"C:\Users\Ibrahim\Desktop\Hospitool\Hospitool\Hospitool\Resources\Labtest" + newlabtest.PatientID + ".pdf", myArrayOfBytes);
                Process.Start(@"C:\Users\Ibrahim\Desktop\Hospitool\Hospitool\Hospitool\Resources\Labtest" + newlabtest.PatientID + ".pdf");
            }
            else
            {
                MessageBox.Show("There is no available lab test.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
