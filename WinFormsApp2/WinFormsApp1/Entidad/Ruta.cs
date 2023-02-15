using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entidad
{
    public class Ruta
    {
        public int routeId { get; set; }
        public int routeDepart { get; set; }
        public int routeArrive { get; set; }
        public double routePrice { get; set; }

        public string routeDescription { get; set; }
        public int routeType { get; set; }
        public bool state { get; set; }

    }
}
