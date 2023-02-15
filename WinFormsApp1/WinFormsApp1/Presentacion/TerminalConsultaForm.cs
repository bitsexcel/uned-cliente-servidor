using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public TerminalConsultaForm(Terminal[] terminalArray, int vari)
        {
            InitializeComponent();
            for (int i = 0; i < vari; i++)
            {
                terminal = terminalArray[i];
                ListViewItem lista = new ListViewItem(terminal.terminalId.ToString());
                lista.SubItems.Add(terminal.terminalName);
                lista.SubItems.Add(terminal.terminalAddress);
                lista.SubItems.Add(terminal.terminalPhone);
                
                lista.SubItems.Add(terminal.terminalOpen.ToShortTimeString());
                lista.SubItems.Add(terminal.terminalClose.ToShortTimeString());
                lista.SubItems.Add(terminal.terminalState.ToString());
                listView1.Items.Add(lista);
            }
        }
    }
}
