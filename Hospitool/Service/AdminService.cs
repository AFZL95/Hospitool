using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitool.Service
{
    public class AdminService
    {
        HospitoolEntities db = new HospitoolEntities();
        public Admin CheckUserNameAndPassword(string tc, string password)
        {
            var user = db.Admins.FirstOrDefault(p => p.AdminTC == tc && p.AdminPassword == password);
            
            return user;

        }

        public void Create(Admin admin)
        {
            db.Admins.Add(admin);
            db.SaveChanges();

        }


        public void Update(Admin admin)
        {
            //UPDATE DATA
            Admin updateAdmin = db.Admins.Where(c => c.AdminID == admin.AdminID).FirstOrDefault();

            updateAdmin.AdminName = admin.AdminName;
            updateAdmin.AdminSurname = admin.AdminSurname;
            updateAdmin.AdminPassword = admin.AdminPassword;
            updateAdmin.AdminTC = admin.AdminTC;
            updateAdmin.AdminMobile1 = admin.AdminMobile1;
            updateAdmin.AdminEmail = admin.AdminEmail;
            
            //if (!string.IsNullOrEmpty(car.Photo))
            //{
            //    updateCar.Photo = car.Photo;
            //}
            db.SaveChanges();
        }
        public void Delete(Admin admin)
        {
            db.Admins.Remove(admin);
            db.SaveChanges();
        }

    }
}
