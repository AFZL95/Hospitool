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
    public partial class FormSignupAdmin : Form
    {
        public FormSignupAdmin()
        {
            InitializeComponent();
        }
        enum FormMode { None, Insert, Update }
        FormMode formMode = FormMode.None;
        AdminService serviceAdmin = new AdminService();
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if ( txtName.Text == "" || txtSurname.Text == "" || txtPassword.Text == "" ||
                txtPhone1.Text == "" || txtTC.Text == "" ||  txtEmail.Text == "")
            {
                MessageBox.Show("بخش های ستاره دار بایستی تکمیل گردند!");
                return;
            }

            int parsedValue;
            if (!int.TryParse(txtTC.Text, out parsedValue) || !int.TryParse(txtPhone1.Text, out parsedValue) )
            {
                MessageBox.Show("شماره شناسایی یا اطلاعات وارد شده بصورت صحیح وارد نشده اند!");
                return;
            }

            formMode = FormMode.Insert;
            if (formMode == FormMode.Insert)
            {
                Admin admin = new Admin();
                UpdateAdminInfoFromForm(admin);
                serviceAdmin.Create(admin);

            }
            else if (formMode == FormMode.Update)
            {
                Admin admin = new Admin();
                if (admin != null)
                {
                    UpdateAdminInfoFromForm(admin);
                    serviceAdmin.Update(admin);

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
        private void UpdateAdminInfoFromForm(Admin admin)
        {
            //string gender;
            //if (chbMale.Checked == true)
            //{
            //    gender = "M";
            //}
            //else if (chbFemale.Checked == true)
            //{
            //    gender = "F";
            //}
            //else
            //{
            //    gender = "N";
            //}

            admin.AdminName = txtName.Text;
            admin.AdminSurname = txtSurname.Text;
            admin.AdminPassword = Hash(txtPassword.Text);
            admin.AdminTC = txtTC.Text;
            admin.AdminMobile1 = txtPhone1.Text;
            
            admin.AdminEmail = txtEmail.Text;
            

        }

        private void FormSignupAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
