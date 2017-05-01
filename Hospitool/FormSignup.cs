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
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }
        enum FormMode { None, Insert, Update }
        FormMode formMode = FormMode.None;
        PatientService servicePatient = new PatientService();
        DoctorService serviceDoctor = new DoctorService();
        ReceptionistService serviceReceptionist = new ReceptionistService();
        LabWorkerService serviceLabworker = new LabWorkerService();
        AdminService serviceAdmin = new AdminService();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtAddress1.Text=="" || txtName.Text == "" || txtSurname.Text == "" || txtPassword.Text == "" || 
                txtPhone1.Text == "" || txtTC.Text == "" || txtAge.Text == "" || txtEmail.Text=="" )
            {
                MessageBox.Show("Textboxes with (*) cannot be empty!");
                return;
            }

            int parsedValue;
            if(!int.TryParse(txtTC.Text, out parsedValue) || !int.TryParse(txtPhone1.Text, out parsedValue) || !int.TryParse(txtAge.Text, out parsedValue))
            {
                MessageBox.Show("TC, Phone1, and Age are number only fields!");
                return;
            }
            formMode = FormMode.Insert;
            if (formMode == FormMode.Insert)
            {
                Patient patient = new Patient();
                UpdatePatientInfoFromForm(patient);
                servicePatient.Create(patient);

            }
            else if (formMode == FormMode.Update)
            {
                Patient patient = new Patient();
                if (patient != null)
                {
                    UpdatePatientInfoFromForm(patient);
                    servicePatient.Update(patient);

                }

            }
           
            formMode = FormMode.None;
            this.Close();
        }

        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        private void UpdatePatientInfoFromForm(Patient patient)
        {
            string gender;
            if (chbMale.Checked == true)
            {
                gender = "M";
            }
            else if(chbFemale.Checked == true)
            {
                gender = "F";
            }
            else
            {
                gender = "N";
            }

            patient.PatientName = txtName.Text;
            patient.PatientSurname = txtSurname.Text;
            patient.PatientPassword = Hash(txtPassword.Text);
            patient.PatientTC = txtTC.Text;
            patient.PatientMobile1 = txtPhone1.Text;
            patient.PatientMobile2 = txtPhone2.Text;
            patient.PatientGender = gender;
            patient.PatientAge = int.Parse(txtAge.Text);
            patient.PatientAddress1 = txtAddress1.Text;
            patient.PatientAddress2 = txtAddress2.Text;
            patient.PatientEmail = txtEmail.Text;
            patient.PatientIsDischarged = false;
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSignup_Load(object sender, EventArgs e)
        {

        }
    }
}
