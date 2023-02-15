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
using WinFormsApp1.Presentacion;

namespace WinFormsApp1
{
    partial class BusForm : Form
    {
        int ipara;
        string spara;
        //Bus bus = new Bus();
        public Bus[] busArray = new Bus[20];
        public int longArray=0;



        public BusForm()
        {
            InitializeComponent();
            textBox5.Text = longArray.ToString();
        }
        public Bus[] getBusArray()
        {
            return busArray;
        }
        public int getLongArray()
        {
            return longArray;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bus bus = new Bus();
                textBox5.Text = longArray.ToString();
                bus.busId = int.Parse(textBox5.Text);
                bus.busPlate = textBox4.Text;
                bus.busCapacity = int.Parse(textBox6.Text);
                bus.busBrand = textBox3.Text;
                bus.busModel = textBox2.Text;
                if (radioButton1.Checked) bus.busState = true;
                else bus.busState = false;
                busArray[longArray] = bus;
                longArray++;
                MessageBox.Show("Guardado con exito");
                textBox4.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
