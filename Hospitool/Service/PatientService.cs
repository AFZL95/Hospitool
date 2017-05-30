using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitool.Service
{
    public class PatientService
    {
        HospitoolEntities db = new HospitoolEntities();
        public Patient CheckUserNameAndPassword(string tc, string password)
        {
            
            var user = db.Patients.FirstOrDefault(p => p.PatientTC == tc && p.PatientPassword == password);

            
            return user;

        }

       
        public void Create(Patient patient)
        {
            db.Patients.Add(patient);
            db.SaveChanges();
            
        }


        public void Update(Patient patient)
        {
            //UPDATE DATA
            Patient updatePatient = db.Patients.Where(c => c.PatientID == patient.PatientID).FirstOrDefault();

            updatePatient.PatientName = patient.PatientName;
            updatePatient.PatientSurname = patient.PatientSurname;
            updatePatient.PatientPassword = patient.PatientPassword;
            updatePatient.PatientTC = patient.PatientTC;
            updatePatient.PatientMobile1 = patient.PatientMobile1;
            updatePatient.PatientMobile2 = patient.PatientMobile2;
            updatePatient.PatientGender = patient.PatientGender;
            updatePatient.PatientAge = patient.PatientAge;
            updatePatient.PatientAddress1 = patient.PatientAddress1;
            updatePatient.PatientAddress2 = patient.PatientAddress2;
            updatePatient.PatientEmail = patient.PatientEmail;
            updatePatient.PatientDateAdmitted = patient.PatientDateAdmitted;
            updatePatient.PatientDateDischarged = patient.PatientDateDischarged;
     
            db.SaveChanges();
        }
        public void Delete(Patient patient)
        {
            db.Patients.Remove(patient);
            db.SaveChanges();
        }
        public List<Patient> GetAll()
        {
            return db.Patients.ToList();
        }
    }
}
