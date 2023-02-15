using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Entidad;

namespace Servidor.BaseDatos
{
    public class DbConsulta
    {
        string connetionString = @"Data Source=DANIEL\SQLEXPRESS;Initial Catalog=BUSUNED;User ID=sa;Password=daniel; Integrated Security=True";
        SqlConnection cnn;
        SqlDataReader rdr;
        List<Terminal> list;
        List<Bus> listb;
        List<Conductor> listc;
        List<Ruta> listr;
        //Terminal terminal;

        public DbConsulta()
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Conductor> consultaConductor()
        {
            try
            {
                listc = new List<Conductor>();
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command;
                string sql = "select * from dbo.CONDUCTOR";
                command = new SqlCommand(sql, cnn);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    Conductor driver = new Conductor();
                    driver.driverId = rdr.GetValue(0).ToString();
                    driver.driverName = rdr.GetValue(1).ToString();
                    driver.driverLastNameOne = rdr.GetValue(2).ToString();
                    driver.driverLastNameTwo = rdr.GetValue(3).ToString();
                    driver.driverBirthDay = Convert.ToDateTime(rdr.GetValue(4).ToString());
                    driver.driverGender = Convert.ToChar(rdr.GetValue(5).ToString());
                    driver.driverSupervisor = Convert.ToBoolean(rdr.GetValue(6).ToString());
                    listc.Add(driver);
                    
                }
                command.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("dbc.conductor"+ex.Message);
            }

            return listc;
        }
        public List<Ruta> consultaRuta()
        {
            try
            {
                listr = new List<Ruta>();
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command;
                string sql = "select * from dbo.RUTA";
                command = new SqlCommand(sql, cnn);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    Ruta ruta = new Ruta();
                    ruta.routeId = int.Parse(rdr.GetValue(0).ToString());
                    ruta.routeDepart = int.Parse(rdr.GetValue(1).ToString());
                    ruta.routeArrive = int.Parse(rdr.GetValue(2).ToString());
                    ruta.routePrice = double.Parse(rdr.GetValue(3).ToString());
                    ruta.routeDescription = rdr.GetValue(4).ToString();
                    ruta.routeType = int.Parse(rdr.GetValue(5).ToString());
                    ruta.state = Convert.ToBoolean(rdr.GetValue(6).ToString());
                    listr.Add(ruta);
                }
                command.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("dbc.ruta"+ex.Message);
            }

            return listr;
        }
        public List<Bus> consultaBus()
        {
            try
            {
                listb = new List<Bus>();
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command;
                string sql = "select * from dbo.AUTOBUS";
                command = new SqlCommand(sql, cnn);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    Bus bus = new Bus();
                    bus.busId = int.Parse(rdr.GetValue(0).ToString());
                   bus.busPlate = rdr.GetValue(1).ToString();
                    bus.busBrand = rdr.GetValue(2).ToString();
                    bus.busModel = int.Parse(rdr.GetValue(3).ToString());
                    bus.busCapacity = int.Parse(rdr.GetValue(4).ToString());
                    bus.busState = Convert.ToBoolean(rdr.GetValue(5).ToString());
                   listb.Add(bus);
                }
                command.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("dbc.bus"+ex.Message);
            }

            return listb;
        }

        public List<Terminal> getTerminal()
        {
            try
            {
                list = new List<Terminal>();
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command;
                string sql = "select * from dbo.TERMINAL";
                command = new SqlCommand(sql, cnn);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    Terminal terminal = new Terminal();
                    terminal.terminalId = int.Parse(rdr.GetValue(0).ToString());
                    terminal.terminalName = rdr.GetValue(1).ToString();
                    terminal.terminalAddress = rdr.GetValue(2).ToString();
                    terminal.terminalPhone = rdr.GetValue(3).ToString();
                    terminal.terminalOpen = Convert.ToDateTime(rdr.GetValue(4).ToString());
                    terminal.terminalClose = Convert.ToDateTime(rdr.GetValue(5).ToString());
                    terminal.terminalState = Convert.ToBoolean(rdr.GetValue(6).ToString());
                    list.Add(terminal);
                }
                command.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return list;
        }
        public int getTerminalCode(string str)
        {
            int cod = 0;
            try
            {
                //list = new List<Terminal>();
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command;
                string sql = "select COD_TERMINAL from dbo.TERMINAL WHERE NOM_TERMINAL = \'" + str+"\'";
                command = new SqlCommand(sql, cnn);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    Terminal terminal = new Terminal();
                    cod = terminal.terminalId = int.Parse(rdr.GetValue(0).ToString());
                    
                }

                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DbConsulta" +ex.Message);
            }

            return cod;
        }
    }

}

           



