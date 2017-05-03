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
    public partial class FormSignupLabworker : Form
    {
        public FormSignupLabworker()
        {
            InitializeComponent();
        }
        enum FormMode { None, Insert, Update }
        FormMode formMode = FormMode.None;
        LabWorkerService serviceLabworker = new LabWorkerService();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAddress1.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtPassword.Text == "" ||
                txtPhone1.Text == "" || txtTC.Text == "" || txtAge.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("بخش های ستاره دار بایستی تکمیل گردند!");
                return;
            }

            int parsedValue;
            if (!int.TryParse(txtTC.Text, out parsedValue) || !int.TryParse(txtPhone1.Text, out parsedValue) || !int.TryParse(txtAge.Text, out parsedValue))
            {
                MessageBox.Show("شماره شناسایی یا اطلاعات وارد شده بصورت صحیح وارد نشده اند!");
                return;
            }


            formMode = FormMode.Insert;
            if (formMode == FormMode.Insert)
            {
                Labworker labworker = new Labworker();
                UpdateLabworkerInfoFromForm(labworker);
                serviceLabworker.Create(labworker);

            }
            else if (formMode == FormMode.Update)
            {
                Labworker labworker = new Labworker();
                if (labworker != null)
                {
                    UpdateLabworkerInfoFromForm(labworker);
                    serviceLabworker.Update(labworker);

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
        private void UpdateLabworkerInfoFromForm(Labworker labworker)
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

            labworker.LabworkerName = txtName.Text;
            labworker.LabworkerSurname = txtSurname.Text;
            labworker.LabworkerPassword = Hash(txtPassword.Text);
            labworker.LabworkerTC = txtTC.Text;
            labworker.LabworkerMobile1 = txtPhone1.Text;
            labworker.LabworkerMobile2 = txtPhone2.Text;
            labworker.LabworkerGender = gender;
            labworker.LabworkerAge = int.Parse(txtAge.Text);
            labworker.LabworkerAddress1 = txtAddress1.Text;
            labworker.LabworkerAddress2 = txtAddress2.Text;
            labworker.LabworkerEmail = txtEmail.Text;
           

        }

        private void FormSignupLabworker_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
