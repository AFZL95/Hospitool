using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitool.Service
{
    public class DoctorService
    {
        HospitoolEntities db = new HospitoolEntities();
        public Doctor CheckUserNameAndPassword(string tc, string password)
        {
            
            var user = db.Doctors.FirstOrDefault(p => p.DoctorTC == tc && p.DoctorPassword == password);


            return user;

        }

        public void Create(Doctor doctor)
        {
            db.Doctors.Add(doctor);
            db.SaveChanges();

        }


        public void Update(Doctor doctor)
        {
            //UPDATE DATA
            Doctor updateDoctor = db.Doctors.Where(c => c.DoctorID == doctor.DoctorID).FirstOrDefault();

            updateDoctor.DoctorName = doctor.DoctorName;
            updateDoctor.DoctorSurname = doctor.DoctorSurname;
            updateDoctor.DoctorPassword = doctor.DoctorPassword;
            updateDoctor.DoctorTC = doctor.DoctorTC;
            updateDoctor.DoctorMobile1 = doctor.DoctorMobile1;
            updateDoctor.DoctorMobile2 = doctor.DoctorMobile2;
            updateDoctor.DoctorGender = doctor.DoctorGender;
            updateDoctor.DoctorAge = doctor.DoctorAge;
            updateDoctor.DoctorAddress1 = doctor.DoctorAddress1;
            updateDoctor.DoctorAddress2 = doctor.DoctorAddress2;
            updateDoctor.DoctorEmail = doctor.DoctorEmail;
            updateDoctor.DoctorField = doctor.DoctorField;
         
            db.SaveChanges();
        }
        public void Delete(Doctor doctor)
        {
            db.Doctors.Remove(doctor);
            db.SaveChanges();
        }

        public List<Doctor> GetAll()
        {
            return db.Doctors.ToList();
        }

        public List<Doctor> GetByDoctor(string doctorField)
        {

            List<Doctor> temp = db.Doctors.Where(m => m.DoctorField == doctorField).ToList();

            return temp;
        }

        public List<Doctor> GetByDoctorID(int doctorid)
        {

            List<Doctor> temp = db.Doctors.Where(m => m.DoctorID == doctorid).ToList();

            return temp;
        }
    }
}
