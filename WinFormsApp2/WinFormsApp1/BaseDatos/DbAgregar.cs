using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Entidad;

namespace Servidor.BaseDatos
{

    public class DbAgregar
    {
        string connetionString = @"Data Source=DANIEL\SQLEXPRESS;Initial Catalog=BUSUNED;User ID=sa;Password=daniel; Integrated Security=True";
        SqlConnection cnn;
        SqlDataReader rdr;
        SqlCommand command;
        string sql;


        public DbAgregar()
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void agregarRol(Rol obj)
        {

            try
            {
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                DateTime aDate1 = obj.rolDate;
                DateTime aDate2 = obj.rolDepart; 
                sql = "insert into dbo.ROL (FEC_ROL, TIM_HORA_SALIDA, NUM_RUTA, " +
                    "NUM_IDENTIFICACION_BUS, NUM_CEDULA_CONDUCTOR) values(\'" +
                 aDate1.ToString("yyyyMMdd") + "\', \'" + aDate2.ToString("HH:mm:ss") + "\', " +
                 obj.rolIdRuta + ", " +
                 obj.rolIdBus + ", " +
                 obj.rolDriver + ")";

                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void agregarBus(Bus bus)
        {
            
            try
            {
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                sql = "insert into dbo.AUTOBUS(NUM_IDENTIFICACION, NUM_PLACA, DSC_MARCA, " +
                "NUM_MODELO, NUM_CAPACIDAD, BOL_ESTADO) values(" +
                 bus.busId + ", \'" + bus.busPlate + "\', \'" +
                 bus.busBrand + "\', \'" +
                 bus.busModel + "\', " +
                 bus.busCapacity + ", " +
                 bus.busState + ")";

                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void agregarConductor(Conductor driver)
        {
            try
            {
                DateTime aDate = driver.driverBirthDay;
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                if (driver.driverSupervisor = true)
                {
                    sql = "insert into dbo.CONDUCTOR ( NUM_CEDULA, NOM_NOMBRE, NOM_APELLIDO_1, " +
                        "NOM_APELLIDO_2, FEC_NACIMIENTO, TIP_GENERO, " +
                        "BIT_SUPERVISOR) values(\'" +
                        driver.driverId + "\', \'" +
                        driver.driverName + "\', \'" +
                        driver.driverLastNameOne + "\', \'" +
                        driver.driverLastNameTwo + "\', \'" +
                        aDate.ToString("yyyyMMdd") + "\', \'" +
                        driver.driverGender + "\', " +
                        1 + ")";
                }
                else
                {
                    sql = "insert into dbo.CONDUCTOR ( NUM_CEDULA, NOM_NOMBRE, NOM_APELLIDO_1, " +
                "NOM_APELLIDO_2, FEC_NACIMIENTO, TIP_GENERO, " +
                "BIT_SUPERVISOR) values(\'" +
                driver.driverId + "\', \'" +
                driver.driverName + "\', \'" +
                driver.driverLastNameOne + "\', \'" +
                driver.driverLastNameTwo + "\', \'" +
                aDate.ToString("yyyyMMdd") + "\', \'" +
                driver.driverGender + "\', " +
                0 + ")";
                }

                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DbAgregar" + ex.Message);
            }

        }

            public void agregarTerminal(Terminal obj)
            {
            int bo = 1;
            if(obj.terminalState == false)
                bo = 0;
                try
                {
                DateTime aDate1 = obj.terminalOpen;
                DateTime aDate2 = obj.terminalClose;
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
      
                        sql = "insert into dbo.Terminal ( COD_TERMINAL, NOM_TERMINAL, DIR_TERMINAL, " +
                    "NUM_TELEFONO, TIM_HORA_APERTURA, " +
                    "TIM_HORA_CIERRE, BOL_ESTADO) values(" +
                    obj.terminalId + ", \'" +
                    obj.terminalName + "\', \'" +
                    obj.terminalAddress + "\', \'" +
                    obj.terminalPhone + "\', \'" +
                    aDate1.ToString("HH:mm:ss") + "\', \'" +
                    aDate2.ToString("HH:mm:ss") + "\', " +
                    bo + ")";
                    

                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DbAgregar" + ex.Message);
                }


            }
        public void agregarRuta(Ruta obj)
        {
            int bo = 1;
            if (obj.state == false)
                bo = 0;
            try
            {
                MessageBox.Show(Convert.ToString(obj.routeDepart));
                
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                sql = "insert into dbo.RUTA ( NUM_RUTA, COD_TERMINAL_SALIDA, COD_TERMINAL_LLEGADA, " +
            "NUM_TARIFA, DSC_RUTA, " +
            "NUM_TIPO_RUTA, BOL_ESTADO) values(" +
            obj.routeId + ", " +
            obj.routeDepart + ", " +
            obj.routeArrive + ", " +
            obj.routePrice + ", \'" +
           obj.routeDescription + "\', " +
            obj.routeType + ", " +
            bo + ")";


                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DbAgregar" + ex.Message);
            }


        }

    }
   
}
