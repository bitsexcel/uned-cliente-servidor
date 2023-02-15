using Servidor.BaseDatos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.Presentacion
{
    public partial class RutaForm : Form
    {
        DbAgregar db;
        DbConsulta dbc;
        Ruta route = new Ruta();
        public Ruta[] routeArray = new Ruta[20];
        public int longArray = 0;
        public Terminal[] terminalArray = new Terminal[20];
        public int varTerminal;
        List<Terminal> dataTerminal;
        DbConsulta query;
        public RutaForm()
        {
            InitializeComponent();
            this.setTerminals();
        }
        public Ruta[] getRutaArray()
        {
            return routeArray;
        }
        public int getLongArray()
        {
            return longArray;
        }
        public void setTerminals()
        {
            query = new DbConsulta();
            
            var dataTerminal1 = new List<Terminal>();
            var dataTerminal2 = new List<Terminal>();
            dataTerminal1 = query.getTerminal();
            dataTerminal2 = dataTerminal1;
            //for (int i = 0; i < vari; i++)
            //    dataTerminal.Add(terminalArray[i]);
            comboBox1.DataSource = dataTerminal1;
            comboBox1.DisplayMember = "terminalName";
            comboBox1.ValueMember = "terminalId";
            comboBox2.BindingContext = new BindingContext();
            comboBox2.DataSource = dataTerminal2;
            comboBox2.ValueMember = "terminalId";
            comboBox2.DisplayMember = "terminalName";
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbc = new DbConsulta();
                string depart;
                string arrive;
                string text = "";
                int entero = 0;
                Ruta route = new Ruta();
                
                route.routeId = int.Parse(textBox1.Text);
                route.routePrice = double.Parse(textBox2.Text);
                route.routeDescription = textBox3.Text;
                //route.routeDepart = comboBox1.Text;
                depart = comboBox1.Text;
                route.routeDepart = dbc.getTerminalCode(depart);
                arrive = comboBox2.Text;
                route.routeArrive = dbc.getTerminalCode(arrive);
                // = comboBox1.
                //depart = route.routeDepart
                //route.routeArrive = 
                if (radioButton1.Checked) route.routeType = 1;
                else if (radioButton2.Checked) route.routeType = 2;
                if (radioButton3.Checked) route.state = true;
                else if(radioButton4.Checked) route.state = false;
                db = new DbAgregar();
                db.agregarRuta(route);
                
                MessageBox.Show("Guardado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("1. Debes agregar Terminal\n2. Error en formato de campo\n3. " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
