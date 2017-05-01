using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitool.Service
{
    public class PaymentService
    {
        HospitoolEntities db = new HospitoolEntities();
        public void Create(Payment payment)
        {
            db.Payments.Add(payment);
            db.SaveChanges();

        }
        public void Delete(Payment payment)
        {
            db.Payments.Remove(payment);
            db.SaveChanges();
        }
    }
}
