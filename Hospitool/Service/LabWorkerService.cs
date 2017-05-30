using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitool.Service
{
    public class LabWorkerService
    {
        HospitoolEntities db = new HospitoolEntities();
        public Labworker CheckUserNameAndPassword(string tc, string password)
        {
            
            var user = db.Labworkers.FirstOrDefault(p => p.LabworkerTC == tc && p.LabworkerPassword == password);


            return user;

        }

        public void Create(Labworker labworker)
        {
            db.Labworkers.Add(labworker);
            db.SaveChanges();

        }
        public List<Labworker> GetAll()
        {
            return db.Labworkers.ToList();
        }


        public void Update(Labworker labworker)
        {
            //UPDATE DATA
            Labworker updateLabworker = db.Labworkers.Where(c => c.LabworkerID == labworker.LabworkerID).FirstOrDefault();

            updateLabworker.LabworkerName = labworker.LabworkerName;
            updateLabworker.LabworkerSurname = labworker.LabworkerSurname;
            updateLabworker.LabworkerPassword = labworker.LabworkerPassword;
            updateLabworker.LabworkerTC = labworker.LabworkerTC;
            updateLabworker.LabworkerMobile1 = labworker.LabworkerMobile1;
            updateLabworker.LabworkerMobile2 = labworker.LabworkerMobile2;
            updateLabworker.LabworkerGender = labworker.LabworkerGender;
            updateLabworker.LabworkerAge = labworker.LabworkerAge;
            updateLabworker.LabworkerAddress1 = labworker.LabworkerAddress1;
            updateLabworker.LabworkerAddress2 = labworker.LabworkerAddress2;
            updateLabworker.LabworkerEmail = labworker.LabworkerEmail;
         
            db.SaveChanges();
        }
        public void Delete(Labworker labworker)
        {
            db.Labworkers.Remove(labworker);
            db.SaveChanges();
        }

    }
}
