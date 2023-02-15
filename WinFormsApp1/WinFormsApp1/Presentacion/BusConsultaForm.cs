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
using WinFormsApp1.Logica;

namespace WinFormsApp1.Presentacion
{
    public partial class BusConsultaForm : Form
    {
        //int variable = BusLogic.longitudArray;
        Bus bus = new Bus();
       
        public BusConsultaForm(Bus[] busArray, int vari)
        {
            InitializeComponent();
            for (int i = 0; i < vari; i++)
            {
                bus = busArray[i];
                ListViewItem lista = new ListViewItem(bus.busId.ToString());
                lista.SubItems.Add(bus.busPlate);
                lista.SubItems.Add(bus.busBrand);
                lista.SubItems.Add(bus.busModel);
                lista.SubItems.Add(bus.busCapacity.ToString());
                if (bus.busState == true) lista.SubItems.Add("Activo");
                else lista.SubItems.Add("Inactivo");
                listView1.Items.Add(lista);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
