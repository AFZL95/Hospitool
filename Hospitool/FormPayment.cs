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
    public partial class FormPayment : Form
    {
        public Patient patient;
        public FormPayment(Patient newpatient)
        {
            InitializeComponent();
            patient = newpatient;
        }
        enum FormMode { None, Insert, Update }
        FormMode formMode = FormMode.None;
        PaymentService servicePayment = new PaymentService();
        private void btnPay_Click(object sender, EventArgs e)
        {
            formMode = FormMode.Insert;
            if (formMode == FormMode.Insert)
            {
                Payment payment = new Payment();
                UpdatePaymentInfoFromForm(payment);
                servicePayment.Create(payment);

            }
            formMode = FormMode.None;
            this.Close();
        }

        private void UpdatePaymentInfoFromForm(Payment payment)
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

            payment.PaymentName = txtFirstName.Text;
            payment.PaymentSurname = txtLastName.Text;
            payment.PaymentCredircard = txtCreditcard.Text;
            payment.PaymentCVV = txtCVV.Text;
            payment.PaymentExpiration = txtExpiration.Text;
            payment.PaymentCost = Int32.Parse(txtCost.Text);
            payment.PatientID = patient.PatientID;
          


        }

        private void FormPayment_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
