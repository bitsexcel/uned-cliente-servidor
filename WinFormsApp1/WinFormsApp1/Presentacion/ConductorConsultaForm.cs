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
    public partial class ConductorConsultaForm : Form
    {
        
        Conductor driver = new Conductor();
        public ConductorConsultaForm(Conductor[] driverArray, int vari)
        {
            InitializeComponent();
            for (int i = 0; i < vari; i++)
            {
                driver = driverArray[i];
                ListViewItem lista = new ListViewItem(driver.driverId);
                lista.SubItems.Add(driver.driverName);
                lista.SubItems.Add(driver.driverLastNameOne);
                lista.SubItems.Add(driver.driverLastNameTwo);
                lista.SubItems.Add(driver.driverBirthDay.ToString());
                lista.SubItems.Add(driver.driverGender.ToString());
                lista.SubItems.Add(driver.driverSupervisor.ToString());
                listView1.Items.Add(lista);
            }
        }
    }
}
