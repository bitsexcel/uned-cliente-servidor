namespace WinFormsApp1.Presentacion
{
    partial class BusConsultaForm
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
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.PLACA = new System.Windows.Forms.ColumnHeader();
            this.MARCA = new System.Windows.Forms.ColumnHeader();
            this.MODELO = new System.Windows.Forms.ColumnHeader();
            this.CAPACIDAD = new System.Windows.Forms.ColumnHeader();
            this.ESTADO = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.PLACA,
            this.MARCA,
            this.MODELO,
            this.CAPACIDAD,
            this.ESTADO});
            this.listView1.Location = new System.Drawing.Point(28, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(601, 169);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 70;
            // 
            // PLACA
            // 
            this.PLACA.Text = "PLACA";
            this.PLACA.Width = 80;
            // 
            // MARCA
            // 
            this.MARCA.Text = "MARCA";
            this.MARCA.Width = 80;
            // 
            // MODELO
            // 
            this.MODELO.Text = "MODELO";
            this.MODELO.Width = 70;
            // 
            // CAPACIDAD
            // 
            this.CAPACIDAD.Text = "CAPACIDAD";
            this.CAPACIDAD.Width = 80;
            // 
            // ESTADO
            // 
            this.ESTADO.Text = "ESTADO";
            this.ESTADO.Width = 70;
            // 
            // BusConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.listView1);
            this.Name = "BusConsultaForm";
            this.Text = "BusConsultaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader PLACA;
        private ColumnHeader MARCA;
        private ColumnHeader MODELO;
        private ColumnHeader CAPACIDAD;
        private ColumnHeader ESTADO;
    }
}