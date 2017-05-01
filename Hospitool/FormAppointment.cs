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
    public partial class FormAppointment : Form
    {
        
        enum FormMode { None, Insert, Update }
        FormMode formMode = FormMode.None;
        DoctorService serviceDoctor = new DoctorService();
        PatientService servicePatient = new PatientService();
        AppointmentService serviceAppointment = new AppointmentService();
        Patient loginPatient;
        public Patient patient;
        public int doctorid;
        public Doctor doctor;
        public FormAppointment(Patient newpatient)
        {
            InitializeComponent();
            patient = newpatient;
        }
        
        
        private void FormAppointment_Load(object sender, EventArgs e)
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
            FindButton();
           
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(4);
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
            
        }

       

        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbField.SelectedText != null)
            {
                string selectedField = cbField.Text;
                
                cbDoctors.DisplayMember = "DetailedInfo";
                cbDoctors.ValueMember = "DoctorID";
                
                cbDoctors.DataSource = serviceDoctor.GetByDoctor(selectedField);
                dateTimePicker1_ValueChanged(sender, e);
            }
        }

        public void FindButton()
        {
            Button button = new Button();
            
                button1.Click += new EventHandler(CreateAppointment);
                button2.Click += new EventHandler(CreateAppointment);
                button3.Click += new EventHandler(CreateAppointment);
                button4.Click += new EventHandler(CreateAppointment);
                button5.Click += new EventHandler(CreateAppointment);
                button6.Click += new EventHandler(CreateAppointment);
                button7.Click += new EventHandler(CreateAppointment);
                button8.Click += new EventHandler(CreateAppointment);
                button9.Click += new EventHandler(CreateAppointment);
                button10.Click += new EventHandler(CreateAppointment);
                button11.Click += new EventHandler(CreateAppointment);
                button12.Click += new EventHandler(CreateAppointment);
                button13.Click += new EventHandler(CreateAppointment);
                button14.Click += new EventHandler(CreateAppointment);
                button15.Click += new EventHandler(CreateAppointment);
                button16.Click += new EventHandler(CreateAppointment);
                button17.Click += new EventHandler(CreateAppointment);
                button18.Click += new EventHandler(CreateAppointment);
                button19.Click += new EventHandler(CreateAppointment);
                button20.Click += new EventHandler(CreateAppointment);
                // ¯\_(ツ)_/¯
            

        }
        HospitoolEntities db = new HospitoolEntities();
        Appointment appointment = new Appointment();
        
        public DateTime date;
        
        public void CreateAppointment(object sender, EventArgs e)
        {
            if(cbDoctors.Text == "" || cbField.Text == "")
            {
                MessageBox.Show("لطفا یک تخصص و نام پزشک مربوطه را انتخاب کنید.");
                return;
            }
            /*
            if (patient.PatientField !=Z null) { 
                foreach(string field in patient.PatientField)
                {
                    if (field == cbField.Text)
                    {
                        MessageBox.Show("You have an appointment in this field!");
                        return;
                    }
                }
            }*/
            Button button = sender as Button;
           
            appointment.AppointmentStartdate=button.Text;
           
           // var config = serviceAppointment.GetByDate(dateTimePicker1.Value).Find(item => item.AppointmentStartdate == button.Text);


            foreach (var appointmentt in serviceAppointment.GetByDate(dateTimePicker1.Value, Int32.Parse(DoctorId)))
            {
                if (appointmentt.AppointmentStartdate == button.Text) { 
                button.BackColor=Color.Red;
                }
            }
           
            appointment.DoctorID = Int32.Parse(DoctorId);
            appointment.PatientID = patient.PatientID;

            //patient.PatientField.Add(cbField.Text);
            
            var dateAndTime = dateTimePicker1.Value;
            date = dateAndTime.Date;
                           
            appointment.AppointmentDate = date;

            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید؟", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                serviceAppointment.Create(appointment);
            }
            else if(dialogResult == DialogResult.No)
            {
                return;
            }
            

            button.BackColor = Color.Red;
            button.Enabled = false;

            MessageBox.Show("وقت ملاقات شما با موفقیت ثبت شد!");
            
        }

        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
        }
        public string DoctorId;
        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProductIndex = cbDoctors.SelectedIndex;//this will give index
            string productName = cbDoctors.Text.ToString();//this will give DIsplay name;
            DoctorId = cbDoctors.SelectedValue.ToString();//this will give product Id
            dateTimePicker1_ValueChanged(sender, e);
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0,255,0);
            button2.BackColor = Color.FromArgb(0,255,0);
            button3.BackColor = Color.FromArgb(0,255,0);
            button4.BackColor = Color.FromArgb(0,255,0);
            button5.BackColor = Color.FromArgb(0,255,0);
            button6.BackColor = Color.FromArgb(0,255,0);
            button7.BackColor = Color.FromArgb(0,255,0);
            button8.BackColor = Color.FromArgb(0,255,0);
            button9.BackColor = Color.FromArgb(0, 255, 0);
            button10.BackColor = Color.FromArgb(0,255,0);
            button11.BackColor = Color.FromArgb(0,255,0);
            button12.BackColor = Color.FromArgb(0,255,0);
            button13.BackColor = Color.FromArgb(0,255,0);
            button14.BackColor = Color.FromArgb(0,255,0);
            button15.BackColor = Color.FromArgb(0,255,0);
            button16.BackColor = Color.FromArgb(0,255,0);
            button17.BackColor = Color.FromArgb(0,255,0);
            button18.BackColor = Color.FromArgb(0,255,0);
            button19.BackColor = Color.FromArgb(0,255,0);
            button20.BackColor = Color.FromArgb(0, 255, 0);

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;



            var dateAndTime = dateTimePicker1.Value;
            date = dateAndTime.Date;

            if (DoctorId != null) { 
            foreach (var appointment in serviceAppointment.GetByDate(date, Int32.Parse(DoctorId)))
            {
                if (appointment.AppointmentStartdate == button1.Text)
                {
                    button1.BackColor = Color.Red;
                    button1.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button2.Text)
                {
                    button2.BackColor = Color.Red;
                    button2.Enabled = false;
                }

                else if (appointment.AppointmentStartdate == button3.Text)
                {
                    button3.BackColor = Color.Red;
                    button3.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button4.Text)
                {
                    button4.BackColor = Color.Red;
                    button4.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button5.Text)
                {
                    button5.BackColor = Color.Red;
                    button5.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button6.Text)
                {
                    button6.BackColor = Color.Red;
                    button6.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button7.Text)
                {
                    button7.BackColor = Color.Red;
                    button7.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button8.Text)
                {
                    button8.BackColor = Color.Red;
                    button8.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button9.Text)
                {
                    button9.BackColor = Color.Red;
                    button9.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button10.Text)
                {
                    button10.BackColor = Color.Red;
                    button10.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button11.Text)
                {
                    button11.BackColor = Color.Red;
                    button11.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button12.Text)
                {
                    button12.BackColor = Color.Red;
                    button12.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button13.Text)
                {
                    button13.BackColor = Color.Red;
                    button13.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button14.Text)
                {
                    button14.BackColor = Color.Red;
                    button14.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button15.Text)
                {
                    button15.BackColor = Color.Red;
                    button15.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button16.Text)
                {
                    button16.BackColor = Color.Red;
                    button16.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button17.Text)
                {
                    button17.BackColor = Color.Red;
                    button17.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button18.Text)
                {
                    button18.BackColor = Color.Red;
                    button18.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button19.Text)
                {
                    button19.BackColor = Color.Red;
                    button19.Enabled = false;
                }
                else if (appointment.AppointmentStartdate == button20.Text)
                {
                    button20.BackColor = Color.Red;
                    button20.Enabled = false;
                }
                }
            }

        }
    }
}
