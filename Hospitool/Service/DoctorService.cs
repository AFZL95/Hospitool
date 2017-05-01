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
            
            //if (!string.IsNullOrEmpty(car.Photo))
            //{
            //    updateCar.Photo = car.Photo;
            //}
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
            //List<Model> temp2 = db.Models.Where(x => x.BrandID == brandID).ToList();

            //var models = from m in db.Models where m.BrandID == brandID select m;


            /*SELECT  [ID]
      ,[Name]
      ,[BrandID]
  FROM [RentACar].[dbo].[Model] Where BrandID = 2*/

            return temp;
        }

        public List<Doctor> GetByDoctorID(int doctorid)
        {

            List<Doctor> temp = db.Doctors.Where(m => m.DoctorID == doctorid).ToList();
            //List<Model> temp2 = db.Models.Where(x => x.BrandID == brandID).ToList();

            //var models = from m in db.Models where m.BrandID == brandID select m;


            /*SELECT  [ID]
      ,[Name]
      ,[BrandID]
  FROM [RentACar].[dbo].[Model] Where BrandID = 2*/

            return temp;
        }
        //public List<DoctorGrid> GetRentReport()
        //{
        //    List<DoctorGrid> data = db.Appointments.Include("Patients").Include("Doctors").Include("Appointments").Include("Model.Brands").Select(r => new DoctorGrid
        //    {
        //        PlateNumber = r.Car.PlateNumber,
        //        Brand = r.Car.Model.Brand.Name,
        //        Model = r.Car.Model.Name,
        //        DailyPrice = r.Car.Price,
        //        StartDate = r.StartDate,
        //        EndDate = r.EndDate,
        //        isReturned = r.isReturned,
        //        KM = r.Car.KM,
        //        NameSurname = r.Customer.Name + " " + r.Customer.Surname,
        //        TCKimlik = r.Customer.TCKimlik,
        //        TotalPrice = r.Price,
        //        Year = r.Car.Year


        //    }).ToList();

        //    return data;
        //}
    }
}
