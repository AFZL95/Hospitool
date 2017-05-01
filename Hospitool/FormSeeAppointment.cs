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
    
    public partial class FormSeeAppointment : Form
    {
        AppointmentService serviceAppointment = new AppointmentService();
        public Doctor doctor;
        public string DoctorId;
        
        public FormSeeAppointment(Doctor newdoctor)
        {
            InitializeComponent();
            doctor = newdoctor;
            DoctorId = doctor.DoctorID.ToString();
        }
        
        private void FormSeeAppointment_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(4);
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
            dateTimePicker1_ValueChanged_1(sender, e);

        }


        
        

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            var dateAndTime = dateTimePicker1.Value;
            var date = dateAndTime.Date;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Red;
            button10.BackColor = Color.Red;
            button11.BackColor = Color.Red;
            button12.BackColor = Color.Red;
            button13.BackColor = Color.Red;
            button14.BackColor = Color.Red;
            button15.BackColor = Color.Red;
            button16.BackColor = Color.Red;
            button17.BackColor = Color.Red;
            button18.BackColor = Color.Red;
            button19.BackColor = Color.Red;
            button20.BackColor = Color.Red;


            
            if (DoctorId != null)
            {
                foreach (var appointment in serviceAppointment.GetByDate(date, Int32.Parse(DoctorId)))
                {
                    if (appointment.AppointmentStartdate == button1.Text)
                    {
                        button1.BackColor = Color.FromArgb(0,255,0);
                        button1.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button2.Text)
                    {
                        button2.BackColor = Color.FromArgb(0,255,0);
                        button2.Enabled = false;
                    }

                    else if (appointment.AppointmentStartdate == button3.Text)
                    {
                        button3.BackColor = Color.FromArgb(0,255,0);
                        button3.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button4.Text)
                    {
                        button4.BackColor = Color.FromArgb(0,255,0);
                        button4.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button5.Text)
                    {
                        button5.BackColor = Color.FromArgb(0,255,0);
                        button5.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button6.Text)
                    {
                        button6.BackColor = Color.FromArgb(0,255,0);
                        button6.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button7.Text)
                    {
                        button7.BackColor = Color.FromArgb(0,255,0);
                        button7.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button8.Text)
                    {
                        button8.BackColor = Color.FromArgb(0,255,0);
                        button8.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button9.Text)
                    {
                        button9.BackColor = Color.FromArgb(0,255,0);
                        button9.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button10.Text)
                    {
                        button10.BackColor = Color.FromArgb(0,255,0);
                        button10.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button11.Text)
                    {
                        button11.BackColor = Color.FromArgb(0,255,0);
                        button11.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button12.Text)
                    {
                        button12.BackColor = Color.FromArgb(0,255,0);
                        button12.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button13.Text)
                    {
                        button13.BackColor = Color.FromArgb(0,255,0);
                        button13.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button14.Text)
                    {
                        button14.BackColor = Color.FromArgb(0,255,0);
                        button14.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button15.Text)
                    {
                        button15.BackColor = Color.FromArgb(0,255,0);
                        button15.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button16.Text)
                    {
                        button16.BackColor = Color.FromArgb(0,255,0);
                        button16.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button17.Text)
                    {
                        button17.BackColor = Color.FromArgb(0,255,0);
                        button17.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button18.Text)
                    {
                        button18.BackColor = Color.FromArgb(0,255,0);
                        button18.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button19.Text)
                    {
                        button19.BackColor = Color.FromArgb(0,255,0);
                        button19.Enabled = false;
                    }
                    else if (appointment.AppointmentStartdate == button20.Text)
                    {
                        button20.BackColor = Color.FromArgb(0,255,0);
                        button20.Enabled = false;
                    }
                }
            }
        }
    }
}
