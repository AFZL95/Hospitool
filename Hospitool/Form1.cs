using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using EASendMail;
using System.Net.Mail;


using Hospitool.Service;
namespace Hospitool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
            
        }
        
       LoginType type =LoginType.None;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cbLoginType.Items.Add("Patient");
            cbLoginType.Items.Add("Doctor");
            cbLoginType.Items.Add("Receptionist");
            cbLoginType.Items.Add("Labworker");
            cbLoginType.Items.Add("Admin");
            
        }

        public void SwitchLoginType()
        {
            string logintype = cbLoginType.SelectedValue.ToString();
            if (logintype == "Patient")
            {

            }
        }
       
        //public Patient loginPatient;
        //public int patientid { get; set; }
        public Doctor loginDoctor;
        public Receptionist loginReceptionist;
        public Labworker loginLabworker;
     
        public Admin loginAdmin;
        public Patient loginPatient;
        public static Int32 patientid { get; set; }

        
        PatientService servicePatient = new PatientService();
        DoctorService serviceDoctor = new DoctorService();
        ReceptionistService serviceReceptionist = new ReceptionistService();
        LabWorkerService serviceLabworker = new LabWorkerService();
        AdminService serviceAdmin = new AdminService();

        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        //when user clicked on the Login button...
        public void btnLogin_Click(object sender, EventArgs e)
        {

            
            if (cbLoginType.SelectedItem == "Patient")
            {
                loginPatient = servicePatient.CheckUserNameAndPassword(txtTC.Text, Hash(txtPassword.Text));

                if (loginPatient != null)
                {
                    patientid = loginPatient.PatientID;
                    FormPatient formPatient = new FormPatient(loginPatient);
                    this.Hide();
                    formPatient.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    

                }
               

            }
            else if(cbLoginType.SelectedItem == "Doctor")
            {
                loginDoctor = serviceDoctor.CheckUserNameAndPassword(txtTC.Text, Hash(txtPassword.Text));
                if (loginDoctor != null)
                {
                    FormDoctor formDoctor = new FormDoctor(loginDoctor);
                    this.Hide();
                    formDoctor.Show();
                    this.DialogResult = DialogResult.OK;
                    
                }
            }
            else if (cbLoginType.SelectedItem == "Receptionist")
            {
                loginReceptionist = serviceReceptionist.CheckUserNameAndPassword(txtTC.Text, Hash(txtPassword.Text));
                if (loginReceptionist != null)
                {
                    FormReceptionist formReceptionist = new FormReceptionist(loginReceptionist);
                    this.Hide();
                    formReceptionist.Show();
                    this.DialogResult = DialogResult.OK;
                    
                }
            }
           
            else if (cbLoginType.SelectedItem == "Labworker")
            {
               // var myForm = Application.OpenForms["FormLabworker"] as FormLabworker;
                //myForm = "Hello world!";
                

                loginLabworker = serviceLabworker.CheckUserNameAndPassword(txtTC.Text, Hash(txtPassword.Text));
                if (loginLabworker != null)
                {
                    FormLabworker formLabworker = new FormLabworker(loginLabworker);
                    this.Hide();
                    formLabworker.Show();
                    this.DialogResult = DialogResult.OK;
                    
                }
            }
            else if (cbLoginType.SelectedItem == "Admin")
            {
                //i made a little change that made the second argument without Hash() finction
                //so it transfers with plain text
                loginAdmin = serviceAdmin.CheckUserNameAndPassword(txtTC.Text, Hash(txtPassword.Text));
                if (loginAdmin != null)
                {
                    FormAdmin formAdmin = new FormAdmin(loginAdmin);
                    this.Hide();
                    formAdmin.Show();
                    this.DialogResult = DialogResult.OK;
                    
                }
            }
            else
            {
                MessageBox.Show("قسمت نوع دسترسی انتخاب نشده است!");
            }
          

            if (loginPatient  != null || loginDoctor != null || loginReceptionist != null || loginLabworker != null || loginAdmin != null)
            {

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("شماره شناسایی یا رمز عبور اشتباه است.");
            }
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Close();
            FormSignup formSignup = new FormSignup();
            formSignup.Show();
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

  
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add("a.fzl@live.com");
            message.Subject = "This is the Subject line";
            message.From = new System.Net.Mail.MailAddress("a.fzl@live.com");
            message.Body = "This is the message body";
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.live.com");

            smtp.Send(message);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
