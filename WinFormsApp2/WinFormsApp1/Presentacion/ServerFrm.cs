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
using WinFormsApp1.Presentacion;
using Timer = System.Threading.Timer;

namespace Servidor.Presentacion
{
    public partial class ServerFrm : Form
    {

        //Conexion conexion;
        string users = "";
        int iusers = 0;
        int luser = 0;
        public ServerFrm()
        {
            InitializeComponent();

            //Timer timer = new Timer(callback, "Some state", TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConexion con = new DBConexion();
            //String dato = con.conectarDB();
            MDIParent1 md = new MDIParent1();
            md.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Servidor Iniciado";
            Conexion conexion = new Conexion();
            Thread lecturaThread;
            lecturaThread = new Thread(new ThreadStart(conexion.EjecutarServidor));
            lecturaThread.Start();
        }
        //private static void callback(object state)
        //{
        //    user = conexion.user
        //    if(conexion.users > luser ) {
        //        luser = conexion.users;

        //        textBox1.AppendText("nuevo usuario conectado");

        //}
    }
}
