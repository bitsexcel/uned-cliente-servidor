using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Entidad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class RolForm : Form
    {
        public Rol[] rolArray = new Rol[20];
        public int longArray = 0;
        Bus[] busArray; int varBus;
        Conductor[] driverArray; int varDriver;
        Ruta[] routeArray; int varRoute;
        Terminal[] terminalArray; int varTerminal;
        public RolForm()
        {
            InitializeComponent();
        }
        public Rol[] getRolArray()
        {
            return rolArray;
        }
        public int getLongArray()
        {
            return longArray;
        }
        
        public void initialRol(Bus[] busArray, int varBus, Conductor[] driverArray,
            int varDriver, Ruta[] routeArray, int varRoute, Terminal[] terminalArray,
            int varTerminal)
        {
            this.busArray = busArray; this.varBus = varBus; 
            this.driverArray = driverArray; this.varDriver = varDriver;  
            this.routeArray = routeArray; this.varRoute = varRoute;
            this.terminalArray = terminalArray; this.terminalArray = terminalArray;
            var dataBus = new List<Bus>();
            var dataConductor = new List<Conductor>();
            var dataRuta = new List<Ruta>();
            var dataTerminal = new List<Terminal>();
            

            for (int i = 0; i < 20; i++)
            {

                if (i < varBus) dataBus.Add(busArray[i]);
                if (i < varDriver) dataConductor.Add(driverArray[i]);
                if (i < varRoute) dataRuta.Add(routeArray[i]);
                if (i < varTerminal) dataTerminal.Add(terminalArray[i]);
            }
            //comboBox1.DataSource = dataTerminal;
            //comboBox1.DisplayMember = "terminalId";
            //comboBox1.ValueMember = "terminalId";
            comboBox2.DataSource = dataBus;
            comboBox2.DisplayMember = "busId";
            //comboBox2.ValueMember = "busId";
            comboBox3.DataSource = dataConductor;
            comboBox3.DisplayMember = "driverName";
            //comboBox3.ValueMember = "driverId";
            comboBox4.DataSource = dataRuta;
            comboBox4.DisplayMember = "routeId";
           // comboBox4.ValueMember = "routeId";
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                Rol rol = new Rol();
                rol.rolDate = dateTimePicker1.Value;
                rol.rolDepart = dateTimePicker2.Value;
                
                Bus bus = new Bus();
                bus.busId = int.Parse(comboBox2.Text);
                //rol.rolIdBus = bus;
                
                Conductor driver = new Conductor();
                driver.driverId = comboBox3.Text;
                //rol.rolDriver = driver;

                Ruta ruta = new Ruta();
                ruta.routeId = int.Parse(comboBox4.Text);
                //rol.rolIdRuta = ruta;

                //Terminal terminal = new Terminal();
                //terminal.terminalId = int.Parse(comboBox1.Text);
                //rol.rolIdTerminal = terminal;

                rolArray[longArray] = rol;
                    longArray++;
                MessageBox.Show("Guardado con exito");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan registros por asignar "+ex.Message);
            }
        }
    }
}
