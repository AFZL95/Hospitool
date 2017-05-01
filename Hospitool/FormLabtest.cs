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
    public partial class FormLabtest : Form
    {
        public Labworker loginLabworker = new Labworker();
        public FormLabtest(Labworker newlabworker)
        {
            InitializeComponent();
            loginLabworker = newlabworker;
        }

        LabtestService serviceLabtest = new LabtestService();
        enum FormMode { None, Insert, Update }
        FormMode formMode = FormMode.None;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

       public void FormLabtest_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            //loginLabworker = form.loginLabworker;
            
            if (loginLabworker != null) { 
                label1.Text = loginLabworker.LabworkerName ;}
            else
            {
                MessageBox.Show("null");
            }
            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            formMode = FormMode.Insert;
            if (formMode == FormMode.Insert)
            {
                Labtest labtest = new Labtest();
                UpdateLabtestInfoFromForm(labtest);
                serviceLabtest.Create(labtest);

            }
            else if (formMode == FormMode.Update)
            {
                Labtest labtest = new Labtest();
                if (labtest != null)
                {
                    UpdateLabtestInfoFromForm(labtest);
                    serviceLabtest.Update(labtest);

                }

            }

            formMode = FormMode.None;
            this.Close();
        }

        private void UpdateLabtestInfoFromForm(Labtest labtest)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
            labtest.LabtestDate = DateTime.Now;
            labtest.LabtestFiletype = "PDF";
            labtest.LabtestStoredFile = bytes;
            labtest.LabworkerID = loginLabworker.LabworkerID;
            labtest.PatientID = Int32.Parse(txtPatientID.Text);
            
           

           

        }

    }
}
