

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Entidad;

namespace Servidor.BaseDatos
{
    
    class DBConexion
    {
        string respuesta = "";
        Conductor driver;
        Rol rol;

        public string conectarDB(string sql)
        {
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
                //sql = "SELECT * FROM [CONDUCTOR] WHERE NOM_NOMBRE = \'daniel\'";
                //sql = "select * from dbo.CONDUCTOR";
                SqlCommand command;
                if (sql.Contains("ROL"))
                {
                    command = new SqlCommand(sql, cnn);
                    rdr = command.ExecuteReader();
                    string txt = "";
                    while (rdr.Read())
                    {
                        rol = new Rol();
                        rol.rolDate = Convert.ToDateTime(rdr.GetValue(0).ToString());
                        rol.rolDepart = Convert.ToDateTime(rdr.GetValue(1).ToString());
                        rol.rolIdRuta = int.Parse(rdr.GetValue(2).ToString());
                        rol.rolIdBus = int.Parse(rdr.GetValue(3).ToString());
                        rol.rolDriver = int.Parse(rdr.GetValue(4).ToString());
                        //rol.rolIdTerminal = rdr.GetValue(1).ToString();
                    }
                    command.Dispose();
                    cnn.Close();
                    respuesta = JsonConvert.SerializeObject(rol);
                }
                if(sql.Contains("CONDUCTOR")) { 
                //var cedula = new SqlParameter("id", SqlDbType.VarChar);
                //cedula.Value = "701850132";
                command = new SqlCommand(sql, cnn);
                //command.Parameters.Add("@id", SqlDbType.VarChar);
                //command.Parameters["@id"].Value = "701850132";

                rdr = command.ExecuteReader();
                string txt = "";
                while (rdr.Read())
                {
                    driver = new Conductor();
                    driver.driverId = rdr.GetValue(0).ToString();
                    driver.driverName = rdr.GetValue(1).ToString();
                    driver.driverLastNameOne = rdr.GetValue(2).ToString();
                    driver.driverLastNameTwo = rdr.GetValue(3).ToString();
                    //driver.driverBirthDay = Convert.ToDateTime(rdr.GetValue(4).ToString());
                    //driver.driverGender = Int.parse(rdr.GetValue(5).ToString());
                    driver.driverSupervisor = Convert.ToBoolean(rdr.GetValue(6).ToString());
                        //txt = txt + rdr.GetValue(0).ToString() + " " + rdr.GetValue(1).ToString() + " " + rdr.GetValue(2).ToString()
                        //    + " " + rdr.GetValue(3).ToString() + " " + rdr.GetValue(4).ToString() + " " + rdr.GetValue(5).ToString()
                        //    + " " + rdr.GetValue(6).ToString();
                        
                    }
                    command.Dispose();
                    cnn.Close();
                    respuesta = JsonConvert.SerializeObject(driver);
                }
               
                
                
                

                //MessageBox.Show(txt);
            }
            catch(Exception ex)
            {
                MessageBox.Show("DBConexion"+ ex.Message);
            }
            return respuesta;
        }
    }
}
