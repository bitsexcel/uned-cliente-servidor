using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Servidor.BaseDatos;

namespace Servidor
{
    public class Conexion
    {
        private Socket conexion; // Socket para aceptar una conexión      
         // Thread para procesar los mensajes entrantes
        private NetworkStream socketStream; // flujo de datos de red           
        private BinaryWriter escritor; // facilita la escritura en el flujo 
        private BinaryReader lector; // facilita la lectura del flujo 
        public int users { get; set; }
        public void EjecutarServidor()
        {
            TcpListener oyente;
            //int contador = ;
            users = 0;

            // espera la conexión de un cliente y muestra el texto
            // que envía el cliente
            try
            {
                // Paso 1: crea TcpListener                    
                IPAddress local = IPAddress.Parse("127.0.0.1");
                oyente = new TcpListener(local, 50000);

                // Paso 2: TcpListener espera la solicitud de conexión
                oyente.Start();

                // Paso 3: establece la conexión en base a la solicitud del cliente
                while (true)
                {
                    //Console.WriteLine("Esperando una conexión\r\n");

                    // acepta una conexión entrante 

                    conexion = oyente.AcceptSocket();
                    ++users;

                    // crea objeto NetworkStream asociado con el socket
                    socketStream = new NetworkStream(conexion);

                    // crea objetos para transferir datos a través de un flujo
                    escritor = new BinaryWriter(socketStream);
                    lector = new BinaryReader(socketStream);

                    //Console.WriteLine("Conexión " + contador + " recibida.\r\n");

                    // informa al cliente que la conexión fue exitosa 
                    //escritor.Write("SERVIDOR>>> Conexión exitosa");

                    //DeshabilitarEntrada(false); // habilita entradaTextBox

                    string consulta = "";
                    string respuesta = "";

                    // Paso 4: lee los datos de cadena que envía el cliente
                    do
                    {
                        try
                        {
                            // lee la cadena que se envía al cliente
                            consulta = lector.ReadString();
                            DBConexion db = new DBConexion();
                            respuesta = db.conectarDB(consulta);
                            escritor.Write(respuesta);

                            // muestra el mensaje
                            //Console.WriteLine("\r\n" + laRespuesta);
                        } // fin de try
                        catch (Exception)
                        {
                            // maneja la excepción si hay error al leer los datos
                            break;
                        } // fin de catch
                    } while (consulta != "CLIENTE>>> TERMINAR" &&
                       conexion.Connected);

                    //Console.WriteLine("\r\nEl usuario terminó la conexión\r\n");

                    // Paso 5: cierra la conexión 
                    escritor.Close();
                    lector.Close();
                    socketStream.Close();
                    conexion.Close();

                    //DeshabilitarEntrada(true); // deshabilita entradaTextBox
                    --users;
                } // fin de while
            } // fin de try
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            } // fin de catch
        } // fin del méto

    }

}

