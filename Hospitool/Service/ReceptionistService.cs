using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitool.Service
{
    public class ReceptionistService
    {
        HospitoolEntities db = new HospitoolEntities();
        public Receptionist CheckUserNameAndPassword(string tc, string password)
        {
            
            var user = db.Receptionists.FirstOrDefault(p => p.ReceptionistTC == tc && p.ReceptionistPassword == password);


            return user;

        }

        public void Create(Receptionist receptionist)
        {
            db.Receptionists.Add(receptionist);
            db.SaveChanges();

        }
        public List<Receptionist> GetAll()
        {
            return db.Receptionists.ToList();
        }


        public void Update(Receptionist receptionist)
        {
            //UPDATE DATA
            Receptionist updateReceptionist = db.Receptionists.Where(c => c.ReceptionistID == receptionist.ReceptionistID).FirstOrDefault();

            updateReceptionist.ReceptionistName = receptionist.ReceptionistName;
            updateReceptionist.ReceptionistSurname = receptionist.ReceptionistSurname;
            updateReceptionist.ReceptionistPassword = receptionist.ReceptionistPassword;
            updateReceptionist.ReceptionistTC = receptionist.ReceptionistTC;
            updateReceptionist.ReceptionistMobile1 = receptionist.ReceptionistMobile1;
            updateReceptionist.ReceptionistMobile2 = receptionist.ReceptionistMobile2;
            updateReceptionist.ReceptionistGender = receptionist.ReceptionistGender;
            updateReceptionist.ReceptionistAge = receptionist.ReceptionistAge;
            updateReceptionist.ReceptionistAddress1 = receptionist.ReceptionistAddress1;
            updateReceptionist.ReceptionistAddress2 = receptionist.ReceptionistAddress2;
            updateReceptionist.ReceptionistEmail = receptionist.ReceptionistEmail;
            
            //if (!string.IsNullOrEmpty(car.Photo))
            //{
            //    updateCar.Photo = car.Photo;
            //}
            db.SaveChanges();
        }
        public void Delete(Receptionist receptionist)
        {
            db.Receptionists.Remove(receptionist);
            db.SaveChanges();
        }

    }
}
