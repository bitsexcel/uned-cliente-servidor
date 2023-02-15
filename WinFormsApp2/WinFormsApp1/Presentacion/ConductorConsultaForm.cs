using System;
using System.Collections;
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
    public partial class ConductorConsultaForm : Form
    {
        
        Conductor driver = new Conductor();
        public ConductorConsultaForm()
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
                string sql = "select * from dbo.CONDUCTOR";
                SqlCommand command;
                command = new SqlCommand(sql, cnn);
                rdr = command.ExecuteReader();
                string txt = "";
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
            //for (int i = 0; i < vari; i++)
            
        }
        //public ConductorConsultaForm(Conductor[] driverArray, int vari)
        //{
        //    InitializeComponent();
        //    for (int i = 0; i < vari; i++)
        //    {
        //        driver = driverArray[i];
        //        ListViewItem lista = new ListViewItem(driver.driverId);
        //        lista.SubItems.Add(driver.driverName);
        //        lista.SubItems.Add(driver.driverLastNameOne);
        //        lista.SubItems.Add(driver.driverLastNameTwo);
        //        lista.SubItems.Add(driver.driverBirthDay.ToString());
        //        lista.SubItems.Add(driver.driverGender.ToString());
        //        lista.SubItems.Add(driver.driverSupervisor.ToString());
        //        listView1.Items.Add(lista);
        //    }
        //}
    }
}
