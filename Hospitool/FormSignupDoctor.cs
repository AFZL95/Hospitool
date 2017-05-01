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
    public partial class FormSignupDoctor : Form
    {
        public FormSignupDoctor()
        {
            InitializeComponent();
        }
        enum FormMode { None, Insert, Update }
        FormMode formMode = FormMode.None;
        DoctorService serviceDoctor = new DoctorService();
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtAddress1.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtPassword.Text == "" ||
                txtPhone1.Text == "" || txtTC.Text == "" || txtAge.Text == "" || txtEmail.Text == "" || cbField.Text=="")
            {
                MessageBox.Show("Textboxes with (*) cannot be empty!");
                return;
            }

            int parsedValue;
            if (!int.TryParse(txtTC.Text, out parsedValue) || !int.TryParse(txtPhone1.Text, out parsedValue) || !int.TryParse(txtAge.Text, out parsedValue))
            {
                MessageBox.Show("TC, Phone1, and Age are number only fields!");
                return;
            }


            formMode = FormMode.Insert;
            if (formMode == FormMode.Insert)
            {
                Doctor Doctor = new Doctor();
                UpdateDoctorInfoFromForm(Doctor);
                serviceDoctor.Create(Doctor);

            }
            else if (formMode == FormMode.Update)
            {
                Doctor Doctor = new Doctor();
                if (Doctor != null)
                {
                    UpdateDoctorInfoFromForm(Doctor);
                    serviceDoctor.Update(Doctor);

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
        private void UpdateDoctorInfoFromForm(Doctor doctor)
        {
            string gender;
            if (chbMale.Checked == true)
            {
                gender = "M";
            }
            else if (chbFemale.Checked == true)
            {
                gender = "F";
            }
            else
            {
                gender = "N";
            }

            doctor.DoctorName = txtName.Text;
            doctor.DoctorSurname = txtSurname.Text;
            doctor.DoctorPassword = Hash(txtPassword.Text);
            doctor.DoctorTC = txtTC.Text;
            doctor.DoctorMobile1 = txtPhone1.Text;
            doctor.DoctorMobile2 = txtPhone2.Text;
            doctor.DoctorGender = gender;
            doctor.DoctorAge = int.Parse(txtAge.Text);
            doctor.DoctorAddress1 = txtAddress1.Text;
            doctor.DoctorAddress2 = txtAddress2.Text;
            doctor.DoctorEmail = txtEmail.Text;
            //doctor.DoctorField = txtField.Text;
            doctor.DoctorField = cbField.Text;

        }

        private void FormSignupDoctor_Load(object sender, EventArgs e)
        {
            cbField.Items.Add("Allergist");
            cbField.Items.Add("Anesthesiologist");
            cbField.Items.Add("Cardiologist");
            cbField.Items.Add("Dentist");
            cbField.Items.Add("Dermatologist");
            cbField.Items.Add("Endocrinologist");
            cbField.Items.Add("Epidemiologist");
            cbField.Items.Add("Gynecologist");
            cbField.Items.Add("Immunologist");
            cbField.Items.Add("Microbiologist");
            cbField.Items.Add("Neurologist");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
