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

using Hospitool.Service;
using System.Diagnostics;

namespace Hospitool
{
    public partial class FormDoctorSeeLabtest : Form
    {
        public string PatientId;
        PatientService servicePatient = new PatientService();
       // Labtest labtest = new Labtest();
        Labtest newlabtest = new Labtest();
        HospitoolEntities db = new HospitoolEntities();
        public FormDoctorSeeLabtest()
        {
            InitializeComponent();
        }

        

        private void FormDoctorSeeLabtest_Load(object sender, EventArgs e)
        {
            cbPatients.DisplayMember = "DetailedInfo";
            cbPatients.ValueMember = "PatientID";

            cbPatients.DataSource = servicePatient.GetAll();
        }


        private void cbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedField = cbPatients.Text;

            cbPatients.DisplayMember = "DetailedInfo";
            cbPatients.ValueMember = "PatientID";
            PatientId = cbPatients.SelectedValue.ToString();
            


        }

        public List<Labtest> labtest;
        byte[] myArrayOfBytes;
        private void btnResult_Click(object sender, EventArgs e)
        {
            Labtest temp = new Labtest();
            
            int patientid2 = Int32.Parse(PatientId);
            
            //foreach (Labtest labtest in db.Labtests.Where(m => m.PatientID == patientid2).ToList())
            //{
            //    temp = labtest
            //}
            labtest = db.Labtests.Where(m => m.PatientID == patientid2).ToList();
            newlabtest = labtest.Find(x => x.PatientID == patientid2);
            if (newlabtest != null)
            {
                myArrayOfBytes = newlabtest.LabtestStoredFile;
                
                
                File.WriteAllBytes(@"C:\Users\Ibrahim\Desktop\Hospitool\Hospitool\Hospitool\Resources\Labtest" + newlabtest.PatientID + ".pdf", myArrayOfBytes);
                Process.Start(@"C:\Users\Ibrahim\Desktop\Hospitool\Hospitool\Hospitool\Resources\Labtest" + newlabtest.PatientID + ".pdf");
            }
            else
            {
                MessageBox.Show("نتیجه آزمایشی وجود ندارد.");
            }
        }
    }
}
