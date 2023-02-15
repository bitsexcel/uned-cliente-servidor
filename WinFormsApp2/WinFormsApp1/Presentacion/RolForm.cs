using Servidor.BaseDatos;
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
        DbAgregar dba;
        public RolForm()
        {
            InitializeComponent();
        }
        //public Rol[] getRolArray()
        //{
        //    return rolArray;
        //}
        //public int getLongArray()
        //{
        //    return longArray;
        //}
        
        public void initialRol()
        {
            
            var dataBus = new List<Bus>();
            var dataConductor = new List<Conductor>();
            var dataRuta = new List<Ruta>();
            var dataTerminal = new List<Terminal>();

            DbConsulta dbc = new DbConsulta();
            dataBus = dbc.consultaBus();
            dataConductor = dbc.consultaConductor();
            dataRuta = dbc.consultaRuta();
            dataTerminal = dbc.getTerminal();


            
            //comboBox1.ValueMember = "terminalId";
            comboBox2.DataSource = dataBus;
            comboBox2.DisplayMember = "busId";
            //comboBox2.ValueMember = "busId";
            comboBox3.DataSource = dataConductor;
            comboBox3.DisplayMember = "driverId";
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
                dba = new DbAgregar();
                Rol rol = new Rol();
                //DateTime aData1 = 
                rol.rolDate = dateTimePicker1.Value;
                rol.rolDepart = dateTimePicker2.Value;
                
                rol.rolIdRuta = int.Parse(comboBox2.Text);
               
                rol.rolDriver = int.Parse(comboBox3.Text);
                rol.rolIdRuta = int.Parse(comboBox4.Text);
                dba.agregarRol(rol);

              
                MessageBox.Show("Guardado con exito");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan registros por asignar "+ex.Message);
            }
        }
    }
}
