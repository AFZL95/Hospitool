using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitool
{
    public partial class Doctor
    {
        public string DetailedInfo
        {
            get { return DoctorName +" "+ DoctorSurname; }
        }
        public string GetName
        {
            get { return DoctorName; }
        }
        public int GetDoctorID
        {
            get { return DoctorID; }
        }
    }
}
