using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Cliente
{
    public class Conexion
    {
        private NetworkStream salida; // flujo para recibir datos 
        private BinaryWriter escritor; // facilita la escritura en el flujo    
        private BinaryReader lector; // facilita la lectura del flujo  
        private Thread lecturaThread; // Thread para procesar mensajes entrantes
        private string mensaje = "";
        TcpClient cliente = null;
        public void EjecutarCliente()
        {
            

            // crea instancia de TcpClient para enviar datos al servidor
            try
            {
                Console.WriteLine("Tratando de conectar\r\n");

                // Paso 1: crear TcpClient y conectar al servidor
                cliente = new TcpClient();
                cliente.Connect("127.0.0.1", 50000);

                // Paso 2: obtener NetworkStream asociado con TcpClient
                salida = cliente.GetStream();

                // crea objetos para escribir y leer a través del flujo
                escritor = new BinaryWriter(salida);
                lector = new BinaryReader(salida);
                //mensaje = lector.ReadString();

                //Console.WriteLine("\r\nSe recibieron flujos de E/S\r\n");
                //DeshabilitarSalida(false); // habilita entradaTextBox

                // itera hasta que el servidor indica la terminación
                // do
                //{
                // Paso 3: fase de procesamiento
                // try
                //      {
                //          // lee mensaje del servidor 
                //          mensaje = lector.ReadString();
                //          Console.WriteLine("\r\n" + mensaje);
                //      } // fin de try
                //      catch (Exception)
                //      {
                //          // maneja excepcion si hay error al leer datos del servidor
                //          System.Environment.Exit(System.Environment.ExitCode);
                //      } // fin de catch
                ////  } while (mensaje != "SERVIDOR>>> TERMINAR");

                // Paso 4: cierra la conexión
                //escritor.Close();
                //lector.Close();
                //salida.Close();
                //cliente.Close();


            } // fin de try
            catch (Exception error)
            {
                // maneja excepción si hay error al establecer la conexión
                //Console.WriteLine(error.ToString(), "Error en la conexión" );
                System.Environment.Exit(System.Environment.ExitCode);
            } // fin de catch
            //return cliente;
        } // fin del método EjecutarCliente
        public string consulta(String str)
        {
            escritor.Write(str);
            mensaje = lector.ReadString();
            lector.Close();
            salida.Close();
            cliente.Close();

            return mensaje;
        }

    }
}

