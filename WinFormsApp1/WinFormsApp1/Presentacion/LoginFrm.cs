using Cliente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Entidad;
using WinFormsApp1.Presentacion;

namespace Cliente.Presentacion
{
    public partial class LoginFrm : Form
    {
        Conductor driver;
        Conexion cn;
        TcpClient cliente;
        string presql = "select * from dbo.CONDUCTOR where NUM_CEDULA = ";
        //string presql = "select * from dbo.CONDUCTOR where NOM_NOMBRE =";
        string sql = "";
        string respuesta;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new Conexion();
                //cliente = cn.EjecutarCliente();
                cn.EjecutarCliente();
                sql = presql + "\'" + textBox1.Text + "\'";
                respuesta = cn.consulta(sql);
                MessageBox.Show(respuesta);
                driver = new Conductor();
                driver = JsonConvert.DeserializeObject<Conductor>(respuesta);
                MessageBox.Show(driver.driverName);
                MDIParent1 md = new MDIParent1(driver);
                md.Text = "BUSUNED - " + driver.driverName + " " + driver.driverLastNameOne +
                    " " + driver.driverLastNameTwo;
                md.Show();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("LoginFrm"+ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
