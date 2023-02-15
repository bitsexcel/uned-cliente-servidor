using Cliente.Presentacion;
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
        Conductor driver;

        public MDIParent1(Conductor driver)
        {
            this.driver = new Conductor();
            this.driver = driver;
            InitializeComponent();
            if(driver.driverSupervisor == false)
                rolToolStripMenuItem.Visible = false;
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
            
            //busfrm.MdiParent = this;
            //busfrm.Show();
        }

        private void conductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //driverfrm.MdiParent = this;
            //driverfrm.Show();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busArray = busfrm.getBusArray();
            varBus = busfrm.getLongArray();
            driverArray = driverfrm.getDriverArray();
            varDriver = driverfrm.getLongArray();
            routeArray = rutafrm.getRutaArray();
            varRoute = rutafrm.getLongArray();
            terminalArray = terminalfrm.getTerminalArray();
            varTerminal = terminalfrm.getLongArray();
            rolfrm.initialRol(busArray, varBus, driverArray, varDriver, routeArray,
                varRoute, terminalArray, varTerminal);
            rolfrm.MdiParent = this;
            rolfrm.Show();
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //terminalArray = terminalfrm.getTerminalArray();
            //varTerminal = terminalfrm.getLongArray();
            //rutafrm.setTerminals(terminalArray, varTerminal);
            //rutafrm.MdiParent = this;
            //rutafrm.Show();
        }

        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //terminalfrm.MdiParent = this;
            //terminalfrm.Show();
        }

        private void busToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            busArray = busfrm.getBusArray();
            varBus = busfrm.getLongArray();
            BusConsultaForm busConsultaForm = new BusConsultaForm(busArray, varBus );
            busConsultaForm.MdiParent = this;
            busConsultaForm.Show();
        }

        private void conductorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            driverArray = driverfrm.getDriverArray();
            varDriver =driverfrm.getLongArray();
            ConductorConsultaForm conductorConsultaForm = new ConductorConsultaForm(driverArray,varDriver);
            conductorConsultaForm.MdiParent = this; 
            conductorConsultaForm.Show();
        }

        private void rolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (driver.driverSupervisor == false)
            {
                RolConsultaFrm frm = new RolConsultaFrm(driver);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                //rolArray = rolfrm.getRolArray();
                //varRol = rolfrm.getLongArray();
                RolConsultaForm rolConsultaForm = new RolConsultaForm();
                rolConsultaForm.MdiParent = this;
                rolConsultaForm.Show();
            }
        }

        private void rutaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            routeArray = rutafrm.getRutaArray();
            varRoute = rutafrm.getLongArray();
            RutaConsultaForm rutaConsultaForm = new RutaConsultaForm(routeArray, varRoute);
            rutaConsultaForm.MdiParent = this;
            rutaConsultaForm.Show();
        }

        private void terminalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            terminalArray = terminalfrm.getTerminalArray();
            varTerminal = terminalfrm.getLongArray();
            TerminalConsultaForm terminalConsultaForm = new TerminalConsultaForm(terminalArray, varTerminal);
            terminalConsultaForm.MdiParent = this;
            terminalConsultaForm.Show();
        }
    }
}
