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
    public partial class FormSignupReceptionist : Form
    {
        public FormSignupReceptionist()
        {
            InitializeComponent();
        }
        enum FormMode { None, Insert, Update }
        FormMode formMode = FormMode.None;
        ReceptionistService serviceReceptionist = new ReceptionistService();
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtAddress1.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtPassword.Text == "" ||
                txtPhone1.Text == "" || txtTC.Text == "" || txtAge.Text == "" || txtEmail.Text == "")
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
                Receptionist receptionist = new Receptionist();
                UpdateReceptionistInfoFromForm(receptionist);
                serviceReceptionist.Create(receptionist);
                this.Close();

            }
            else if (formMode == FormMode.Update)
            {
                Receptionist receptionist = new Receptionist();
                if (receptionist != null)
                {
                    UpdateReceptionistInfoFromForm(receptionist);
                    serviceReceptionist.Update(receptionist);

                }

            }

            formMode = FormMode.None;
        }
        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }
        private void UpdateReceptionistInfoFromForm(Receptionist receptionist)
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
            
            receptionist.ReceptionistName = txtName.Text;
            receptionist.ReceptionistSurname = txtSurname.Text;
            receptionist.ReceptionistPassword = Hash(txtPassword.Text);
            receptionist.ReceptionistTC = txtTC.Text;
            receptionist.ReceptionistMobile1 = txtPhone1.Text;
            receptionist.ReceptionistMobile2 = txtPhone2.Text;
            receptionist.ReceptionistGender = gender;
            receptionist.ReceptionistAge = int.Parse(txtAge.Text);
            receptionist.ReceptionistAddress1 = txtAddress1.Text;
            receptionist.ReceptionistAddress2 = txtAddress2.Text;
            receptionist.ReceptionistEmail = txtEmail.Text;
           

        }

        private void FormSignupReceptionist_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
