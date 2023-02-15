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

namespace WinFormsApp1
{
    public partial class TerminalForm : Form
    {
        DbAgregar db;
        
        public TerminalForm()
        {
            InitializeComponent();
            
        }

        //public Terminal[] getTerminalArray()
        //{
        //    return terminalArray;
        //}
        //public int getLongArray()
        //{
        //    return longArray;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Terminal terminal = new Terminal();
                terminal.terminalId = int.Parse(textBox1.Text);
                terminal.terminalName = textBox6.Text;
                terminal.terminalAddress = textBox5.Text;
                terminal.terminalPhone = textBox3.Text;
                terminal.terminalOpen = dateTimePicker2.Value;
                terminal.terminalClose = dateTimePicker3.Value;
                db = new DbAgregar();
                db.agregarTerminal(terminal);
                
                MessageBox.Show("Guardado con exito");

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
