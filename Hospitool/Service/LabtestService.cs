using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitool.Service
{
    public class LabtestService
    {
        HospitoolEntities db = new HospitoolEntities();
        public void Create(Labtest labtest)
          {
            db.Labtests.Add(labtest);

            Patient patient = db.Patients.Find(labtest.PatientID);

            db.SaveChanges();
        }
    /*
        public void Create(Labtest labtest)
        {
            db.Labtests.Add(labtest);
            db.SaveChanges();

        }*/
        

        public void Update(Labtest labtest)
        {
            //UPDATE DATA
            Labtest updateLabtest = db.Labtests.Where(c => c.LabtestID == labtest.LabtestID).FirstOrDefault();

            updateLabtest.LabtestDate = DateTime.Now;
            //updateLabtest.AdminSurname = admin.AdminSurname;
            //updateLabtest.AdminPassword = admin.AdminPassword;
            //updateLabtest.AdminTC = admin.AdminTC;
            //updateLabtest.AdminMobile1 = admin.AdminMobile1;
            //updateLabtest.AdminEmail = admin.AdminEmail;

            //if (!string.IsNullOrEmpty(car.Photo))
            //{
            //    updateCar.Photo = car.Photo;
            //}
            db.SaveChanges();
        }

        public List<Labtest> GetByPatient(int patientid)
        {
            List<Labtest> temp = db.Labtests.Where(m => m.PatientID == patientid).ToList();
            return temp;
        }
        public void Delete(Labtest labtest)
        {
            db.Labtests.Remove(labtest);
            db.SaveChanges();
        }
    }
}
