using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Entidad;

namespace WinFormsApp1.Presentacion
{
    public partial class RutaConsultaForm : Form
    {
        Ruta route = new Ruta();



        public RutaConsultaForm()
        {
            InitializeComponent();
            try
            {
                string connetionString;
                SqlConnection cnn;
                SqlDataReader rdr;
                connetionString = @"Data Source=DANIEL\SQLEXPRESS;Initial Catalog=BUSUNED;User ID=sa;Password=daniel; Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                //MessageBox.Show("Connection Open  !");
                //cnn.Close();
                string sql = "select * from dbo.RUTA";
                SqlCommand command;
                command = new SqlCommand(sql, cnn);
                rdr = command.ExecuteReader();
                
                while (rdr.Read())
                {
                    //se crea con el primer valor de la lista
                    ListViewItem lista = new ListViewItem(rdr.GetValue(0).ToString());
                    //lista.SubItems.Add();
                    lista.SubItems.Add(rdr.GetValue(1).ToString());
                    lista.SubItems.Add(rdr.GetValue(2).ToString());
                    lista.SubItems.Add(rdr.GetValue(3).ToString());
                    lista.SubItems.Add(rdr.GetValue(4).ToString());
                    lista.SubItems.Add(rdr.GetValue(5).ToString());
                    lista.SubItems.Add(rdr.GetValue(6).ToString());
                    listView1.Items.Add(lista);
                }
                //MessageBox.Show(txt);
                //respuesta = txt;
                command.Dispose();
                cnn.Close();


                //MessageBox.Show(txt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
        //public RutaConsultaForm(Ruta[] routeArray, int vari)
        //{
        //    InitializeComponent();
        //    for (int i = 0; i < vari; i++)
        //    {
        //        route = routeArray[i];
        //        ListViewItem lista = new ListViewItem(route.routeId.ToString());
        //        lista.SubItems.Add(route.routeDepart);
        //        lista.SubItems.Add(route.routeArrive);
        //        lista.SubItems.Add(route.routePrice.ToString());
        //        lista.SubItems.Add(route.routeDescription);
        //        lista.SubItems.Add(route.routeType.ToString());
        //        lista.SubItems.Add(route.state.ToString());
        //        listView1.Items.Add(lista);
        //    }
        //}
    }

