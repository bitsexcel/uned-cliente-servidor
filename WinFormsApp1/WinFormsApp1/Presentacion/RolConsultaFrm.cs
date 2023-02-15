using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Entidad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cliente.Presentacion
{
    public partial class RolConsultaFrm : Form
    {
        Conexion cn;
        TcpClient cliente;
        string presql = "select * from dbo.ROL where FEC_ROL > ";
        //string presql = "select * from dbo.CONDUCTOR where NOM_NOMBRE =";
        string sql = "";
        string respuesta;
        Rol rol;
        public RolConsultaFrm(Conductor driver)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Value.ToString());
            try
            {
                cn = new Conexion();
                //cliente = cn.EjecutarCliente();
                cn.EjecutarCliente();
                DateTime aDate = dateTimePicker1.Value;
                sql = presql + "\'" + aDate.ToString("yyyyMMdd") + "\'";
                MessageBox.Show(sql);
                respuesta = cn.consulta(sql);
                MessageBox.Show(respuesta);
                rol = new Rol();
                rol = JsonConvert.DeserializeObject<Rol>(respuesta);
                //MessageBox.Show(driver.driverName);

                ListViewItem lista = new ListViewItem(rol.rolIdRuta.ToString());
                lista.SubItems.Add(rol.rolIdTerminal.ToString());
                lista.SubItems.Add(rol.rolIdBus.ToString());
                lista.SubItems.Add(rol.rolDriver.ToString());
                listView1.Items.Add(lista);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
