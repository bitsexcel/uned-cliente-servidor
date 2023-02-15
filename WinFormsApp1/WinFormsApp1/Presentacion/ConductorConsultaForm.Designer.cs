namespace WinFormsApp1.Presentacion
{
    partial class ConductorConsultaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.apellido1 = new System.Windows.Forms.ColumnHeader();
            this.apellido2 = new System.Windows.Forms.ColumnHeader();
            this.nacimiento = new System.Windows.Forms.ColumnHeader();
            this.genero = new System.Windows.Forms.ColumnHeader();
            this.supervisor = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.apellido1,
            this.apellido2,
            this.nacimiento,
            this.genero,
            this.supervisor});
            this.listView1.Location = new System.Drawing.Point(30, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(727, 180);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 70;
            // 
            // name
            // 
            this.name.Text = "NOMBRE";
            this.name.Width = 70;
            // 
            // apellido1
            // 
            this.apellido1.Text = "APELLIDO1";
            this.apellido1.Width = 80;
            // 
            // apellido2
            // 
            this.apellido2.Text = "APELLIDO2";
            this.apellido2.Width = 80;
            // 
            // nacimiento
            // 
            this.nacimiento.Text = "NACIMIENTO";
            this.nacimiento.Width = 80;
            // 
            // genero
            // 
            this.genero.Text = "GENERO";
            // 
            // supervisor
            // 
            this.supervisor.Text = "SUPERVISOR";
            this.supervisor.Width = 80;
            // 
            // ConductorConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "ConductorConsultaForm";
            this.Text = "Reporte Conductor";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader apellido1;
        private ColumnHeader apellido2;
        private ColumnHeader nacimiento;
        private ColumnHeader supervisor;
        private ColumnHeader genero;
    }
}