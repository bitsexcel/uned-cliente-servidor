using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Entidad;

namespace WinFormsApp1.Logica
{
    
    public static class BusLogic
    {
        public static Bus buss = new Bus();
        public static Bus[] busArray = new Bus[20];
        public static int longitudArray = 0;

        public static void setBusArray(Bus bus)
        {
            longitudArray =+ 1;
            busArray[longitudArray] = bus;

        }
        public static Bus[] getBusArray()
        {
            return busArray;
        }

    }
}
