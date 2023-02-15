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

namespace WinFormsApp1
{
    public partial class ConductorForm : Form
    {

        
        Conductor driver = new Conductor();
        public Conductor[] driverArray = new Conductor[20];
        public int longArray = 0;
        public ConductorForm()
        {
            InitializeComponent();

        }
        public Conductor[] getDriverArray()
        {
            return driverArray;
        }
        public int getLongArray()
        {
            return longArray;
        }

        private void CoductorForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "";
                int entero = 0;
                Conductor driver = new Conductor();
                
                driver.driverId = textBox1.Text;
                driver.driverName = textBox2.Text;
                driver.driverLastNameOne = textBox3.Text;
                driver.driverLastNameTwo = textBox4.Text;
                driver.driverBirthDay = dateTimePicker1.Value;
                if (radioButton1.Checked) driver.driverGender = 'M';
                else if (radioButton2.Checked) driver.driverGender = 'F';
                if (checkBox1.Checked) driver.driverSupervisor = true;
                driverArray[longArray] = driver;
                longArray++;
                MessageBox.Show("Guardado con exito");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                if (radioButton1.Checked) radioButton1.Checked = false;
                if (radioButton2.Checked) radioButton2.Checked = false;
                if (checkBox1.Checked) checkBox1.Checked = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("ConductorForm"+ ex.Message);
            }
        }
    }
}
