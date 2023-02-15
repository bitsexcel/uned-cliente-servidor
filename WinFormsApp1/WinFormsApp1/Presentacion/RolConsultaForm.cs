using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Entidad;

namespace WinFormsApp1.Presentacion
{
    public partial class RolConsultaForm : Form
    {
        
        public RolConsultaForm()
        {
            Rol rol = new Rol();
            InitializeComponent();
            //for (int i = 0; i < vari; i++)
            //{
                
            //    rol = rolArray[i];
            //    ListViewItem lista = new ListViewItem(rol.rolIdRuta.routeId.ToString());
            //    lista.SubItems.Add(rol.rolIdTerminal.terminalId.ToString());
            //    lista.SubItems.Add(rol.rolIdBus.busId.ToString());
            //    lista.SubItems.Add(rol.rolDriver.driverId.ToString());
            //    listView1.Items.Add(lista);
            //}
        }
    }
}
