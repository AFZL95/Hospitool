using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitool.Service
{
    public class AppointmentService
    {
        HospitoolEntities db = new HospitoolEntities();
        public void Create(Appointment appointment)
        {
            db.Appointments.Add(appointment);
            db.SaveChanges();

        }
        //public List<Appointment> GetByDoctor(int doctorID)
        //{
        //    List<Appointment> temp = db.Appointments.Where(m => m.DoctorID == doctorID).ToList();
        //    return temp;
        //}
        public List<Appointment> GetByDate(DateTime appointmentDate, int doctorid)
        {
            
            List<Appointment> temp = db.Appointments.Where(m => m.AppointmentDate == appointmentDate ).Where(m=>m.DoctorID==doctorid).ToList();
            
            return temp;
        }
        
        public void Delete(Appointment appointment)
        {
            db.Appointments.Remove(appointment);
            db.SaveChanges();
        }


    }
}
