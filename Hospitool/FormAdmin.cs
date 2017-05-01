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
    public partial class FormAdmin : Form
    {
        public Admin admin;
        public FormAdmin(Admin newadmin)
        {
            InitializeComponent();
            admin = newadmin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSignup form = new FormSignup();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSignupDoctor form = new FormSignupDoctor();
            form.Show();
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            FormSignupReceptionist form = new FormSignupReceptionist();
            form.Show();
        }

        private void btnLabworker_Click(object sender, EventArgs e)
        {
            FormSignupLabworker form = new FormSignupLabworker();
            form.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormSignupAdmin form = new FormSignupAdmin();
            form.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            FormDeleteAppointment form = new FormDeleteAppointment();
            form.Show();
            //FormAppointment form = new FormAppointment();
            //form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormDeleteUser form = new FormDeleteUser(admin);
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
