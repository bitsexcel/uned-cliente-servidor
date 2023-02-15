using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entidad
{
    public class Conductor
    {
        public string driverId { set; get; }
        public string driverName { set; get; }
        public string driverLastNameOne { set; get; }
        public string driverLastNameTwo { set; get; }
        public DateTime driverBirthDay { set; get; }
        public char driverGender { set; get; }
        public bool driverSupervisor { set; get; }

    }
}
