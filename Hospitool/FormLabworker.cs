using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitool
{
    public partial class FormLabworker : Form
    {
        public Labworker loginPersonel = new Labworker();
        public FormLabworker(Labworker newlabworker)
        {
            InitializeComponent();
            loginPersonel = newlabworker;
        }
        
        public string SomePropertyName { get; set; }
        private void btnAddLabtest_Click(object sender, EventArgs e)
        {
            FormLabtest form = new FormLabtest(loginPersonel);
            form.Show();
        }
        
        private void FormLabworker_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            //loginLabworker = form.loginLabworker2.LabworkerName;
            label1.Text = "Welcome, "+loginPersonel.LabworkerName + " "+ loginPersonel.LabworkerSurname;
            Form1 loginForm = new Form1();

           
            

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
