using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entidad
{
    public class Terminal
    {
        public int terminalId { get; set; }
        public string terminalName { get; set; }
        public string terminalAddress { get; set; }
        public string terminalPhone { get; set; }
        public DateTime terminalOpen { get; set; }
        public DateTime terminalClose { get; set; }
        public bool terminalState { get; set; }

    }
}
