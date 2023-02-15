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
    public partial class RutaConsultaForm : Form
    {
        Ruta route = new Ruta();
        public RutaConsultaForm(Ruta[] routeArray, int vari)
        {
            InitializeComponent();
            for (int i = 0; i < vari; i++)
            {
                route = routeArray[i];
                ListViewItem lista = new ListViewItem(route.routeId.ToString());
                lista.SubItems.Add(route.routeDepart);
                lista.SubItems.Add(route.routeArrive);
                lista.SubItems.Add(route.routePrice.ToString());
                lista.SubItems.Add(route.routeDescription);
                lista.SubItems.Add(route.routeType.ToString());
                lista.SubItems.Add(route.state.ToString());
                listView1.Items.Add(lista);
            }
        }
    }
}
