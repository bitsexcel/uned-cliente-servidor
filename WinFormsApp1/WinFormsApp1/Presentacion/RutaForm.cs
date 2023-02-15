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
    public partial class RutaForm : Form
    {
        Ruta route = new Ruta();
        public Ruta[] routeArray = new Ruta[20];
        public int longArray = 0;
        public Terminal[] terminalArray = new Terminal[20];
        public int varTerminal;
        List<Terminal> dataTerminal; 
        public RutaForm()
        {
            InitializeComponent();
            textBox1.Text = longArray.ToString();
        }
        public Ruta[] getRutaArray()
        {
            return routeArray;
        }
        public int getLongArray()
        {
            return longArray;
        }
        public void setTerminals(Terminal[] terminal, int vari)
        {
            dataTerminal = new List<Terminal>();
            terminalArray = terminal; 
            varTerminal = vari;
            //var dataTerminal = new List<Terminal>();
            for(int i =0; i < vari; i++) 
                dataTerminal.Add(terminalArray[i]);
            comboBox1.DataSource = dataTerminal;
            comboBox1.DisplayMember = "terminalName";
            comboBox2.DataSource = dataTerminal;
            comboBox2.DisplayMember = "terminalName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "";
                int entero = 0;
                Ruta route = new Ruta();
                textBox1.Text = longArray.ToString();
                route.routeId = int.Parse(textBox1.Text);
                route.routePrice = double.Parse(textBox2.Text);
                route.routeDescription = textBox3.Text;
                route.routeDepart = comboBox1.Text;
                route.routeArrive = comboBox2.Text;
                if (radioButton1.Checked) route.routeType = 1;
                else if (radioButton2.Checked) route.routeType = 2;
                if (radioButton3.Checked) route.state = true;
                routeArray[longArray] = route;
                longArray++;
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
