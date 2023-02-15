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
    public partial class TerminalConsultaForm : Form
    {
        Terminal terminal = new Terminal();
        public TerminalConsultaForm()
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
                string sql = "select * from dbo.TERMINAL";
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
        }
    //    public TerminalConsultaForm(Terminal[] terminalArray, int vari)
    //    {
    //        InitializeComponent();
    //        for (int i = 0; i < vari; i++)
    //        {
    //            terminal = terminalArray[i];
    //            ListViewItem lista = new ListViewItem(terminal.terminalId.ToString());
    //            lista.SubItems.Add(terminal.terminalName);
    //            lista.SubItems.Add(terminal.terminalAddress);
    //            lista.SubItems.Add(terminal.terminalPhone);

    //            lista.SubItems.Add(terminal.terminalOpen.ToShortTimeString());
    //            lista.SubItems.Add(terminal.terminalClose.ToShortTimeString());
    //            lista.SubItems.Add(terminal.terminalState.ToString());
    //            listView1.Items.Add(lista);
    //        }
    //    }
    }
}
