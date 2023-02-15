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
using WinFormsApp1.Logica;
using Servidor.Presentacion.DataGridFrm;

namespace WinFormsApp1.Presentacion
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        ConductorForm driverfrm = new ConductorForm();
        Conductor[] driverArray = new Conductor[20];
        int varDriver = 0;
        RolForm rolfrm = new RolForm();
        Rol[] rolArray = new Rol[20];
        int varRol = 0;
        RutaForm rutafrm = new RutaForm();
        Ruta[] routeArray = new Ruta[20];
        int varRoute = 0;
        TerminalForm terminalfrm = new TerminalForm();
        Terminal[] terminalArray = new Terminal[20];
        int varTerminal = 0;
        BusForm busfrm = new BusForm();
        Bus[] busArray = new Bus[20];
        int varBus = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            busfrm.MdiParent = this;
            busfrm.Show();
        }

        private void conductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            driverfrm.MdiParent = this;
            driverfrm.Show();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busArray = busfrm.getBusArray();
            varBus = busfrm.getLongArray();
            driverArray = driverfrm.getDriverArray();
            varDriver = driverfrm.getLongArray();
            routeArray = rutafrm.getRutaArray();
            varRoute = rutafrm.getLongArray();
            
            rolfrm.initialRol();
            rolfrm.MdiParent = this;
            rolfrm.Show();
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            rutafrm.setTerminals();
            rutafrm.MdiParent = this;
            rutafrm.Show();
        }

        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            terminalfrm.MdiParent = this;
            terminalfrm.Show();
        }

        private void busToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            busArray = busfrm.getBusArray();
            varBus = busfrm.getLongArray();
            //BusConsultaForm busConsultaForm = new BusConsultaForm(busArray, varBus );
            BusConsultaForm busConsultaForm = new BusConsultaForm();
            busConsultaForm.MdiParent = this;
            busConsultaForm.Show();
        }

        private void conductorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            driverArray = driverfrm.getDriverArray();
            varDriver =driverfrm.getLongArray();
            // ConductorConsultaForm conductorConsultaForm = new ConductorConsultaForm(driverArray, varDriver);
            ConductorConsultaForm conductorConsultaForm = new ConductorConsultaForm();
            conductorConsultaForm.MdiParent = this;
            conductorConsultaForm.Show();
            //ConductorDG cdg = new ConductorDG();
            //cdg.MdiParent = this;
            //cdg.Show();

        }

        private void rolToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            RolConsultaForm rolConsultaForm = new RolConsultaForm();
            //RolConsultaForm rolConsultaForm = new RolConsultaForm(rolArray, varRol);
            rolConsultaForm.MdiParent = this;
            rolConsultaForm.Show();
        }

        private void rutaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            routeArray = rutafrm.getRutaArray();
            varRoute = rutafrm.getLongArray();
            RutaConsultaForm rutaConsultaForm = new RutaConsultaForm();
            //RutaConsultaForm rutaConsultaForm = new RutaConsultaForm(routeArray, varRoute);
            rutaConsultaForm.MdiParent = this;
            rutaConsultaForm.Show();
        }

        private void terminalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            TerminalConsultaForm terminalConsultaForm = new TerminalConsultaForm();
            //TerminalConsultaForm terminalConsultaForm = new TerminalConsultaForm(terminalArray, varTerminal);
            terminalConsultaForm.MdiParent = this;
            terminalConsultaForm.Show();
        }
    }
}
