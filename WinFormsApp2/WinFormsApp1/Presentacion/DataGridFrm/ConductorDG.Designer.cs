namespace Servidor.Presentacion.DataGridFrm
{
    partial class ConductorDG
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cONDUCTORBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.conductorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conductorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.conductorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cONDUCTORTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nUMCEDULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMAPELLIDO1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMAPELLIDO2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECNACIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPGENERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bITSUPERVISORDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONDUCTORBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONDUCTORTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMCEDULADataGridViewTextBoxColumn,
            this.nOMNOMBREDataGridViewTextBoxColumn,
            this.nOMAPELLIDO1DataGridViewTextBoxColumn,
            this.nOMAPELLIDO2DataGridViewTextBoxColumn,
            this.fECNACIMIENTODataGridViewTextBoxColumn,
            this.tIPGENERODataGridViewTextBoxColumn,
            this.bITSUPERVISORDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.cONDUCTORBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(31, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(757, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // cONDUCTORBindingSource3
            // 
            this.cONDUCTORBindingSource3.DataMember = "CONDUCTOR";
            this.cONDUCTORBindingSource3.DataSource = typeof(Servidor.DataSet1);
            // 
            // conductorBindingSource
            // 
            this.conductorBindingSource.DataSource = typeof(WinFormsApp1.Entidad.Conductor);
            // 
            // conductorBindingSource1
            // 
            this.conductorBindingSource1.DataSource = typeof(WinFormsApp1.Entidad.Conductor);
            // 
            // conductorBindingSource2
            // 
            this.conductorBindingSource2.DataSource = typeof(WinFormsApp1.Entidad.Conductor);
            // 
            // cONDUCTORTableAdapterBindingSource
            // 
            this.cONDUCTORTableAdapterBindingSource.DataSource = typeof(Servidor.DataSet1TableAdapters.CONDUCTORTableAdapter);
            // 
            // nUMCEDULADataGridViewTextBoxColumn
            // 
            this.nUMCEDULADataGridViewTextBoxColumn.DataPropertyName = "NUM_CEDULA";
            this.nUMCEDULADataGridViewTextBoxColumn.HeaderText = "NUM_CEDULA";
            this.nUMCEDULADataGridViewTextBoxColumn.Name = "nUMCEDULADataGridViewTextBoxColumn";
            this.nUMCEDULADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMNOMBREDataGridViewTextBoxColumn
            // 
            this.nOMNOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOM_NOMBRE";
            this.nOMNOMBREDataGridViewTextBoxColumn.HeaderText = "NOM_NOMBRE";
            this.nOMNOMBREDataGridViewTextBoxColumn.Name = "nOMNOMBREDataGridViewTextBoxColumn";
            this.nOMNOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMAPELLIDO1DataGridViewTextBoxColumn
            // 
            this.nOMAPELLIDO1DataGridViewTextBoxColumn.DataPropertyName = "NOM_APELLIDO_1";
            this.nOMAPELLIDO1DataGridViewTextBoxColumn.HeaderText = "NOM_APELLIDO_1";
            this.nOMAPELLIDO1DataGridViewTextBoxColumn.Name = "nOMAPELLIDO1DataGridViewTextBoxColumn";
            this.nOMAPELLIDO1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMAPELLIDO2DataGridViewTextBoxColumn
            // 
            this.nOMAPELLIDO2DataGridViewTextBoxColumn.DataPropertyName = "NOM_APELLIDO_2";
            this.nOMAPELLIDO2DataGridViewTextBoxColumn.HeaderText = "NOM_APELLIDO_2";
            this.nOMAPELLIDO2DataGridViewTextBoxColumn.Name = "nOMAPELLIDO2DataGridViewTextBoxColumn";
            this.nOMAPELLIDO2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECNACIMIENTODataGridViewTextBoxColumn
            // 
            this.fECNACIMIENTODataGridViewTextBoxColumn.DataPropertyName = "FEC_NACIMIENTO";
            this.fECNACIMIENTODataGridViewTextBoxColumn.HeaderText = "FEC_NACIMIENTO";
            this.fECNACIMIENTODataGridViewTextBoxColumn.Name = "fECNACIMIENTODataGridViewTextBoxColumn";
            this.fECNACIMIENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPGENERODataGridViewTextBoxColumn
            // 
            this.tIPGENERODataGridViewTextBoxColumn.DataPropertyName = "TIP_GENERO";
            this.tIPGENERODataGridViewTextBoxColumn.HeaderText = "TIP_GENERO";
            this.tIPGENERODataGridViewTextBoxColumn.Name = "tIPGENERODataGridViewTextBoxColumn";
            this.tIPGENERODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bITSUPERVISORDataGridViewCheckBoxColumn
            // 
            this.bITSUPERVISORDataGridViewCheckBoxColumn.DataPropertyName = "BIT_SUPERVISOR";
            this.bITSUPERVISORDataGridViewCheckBoxColumn.HeaderText = "BIT_SUPERVISOR";
            this.bITSUPERVISORDataGridViewCheckBoxColumn.Name = "bITSUPERVISORDataGridViewCheckBoxColumn";
            this.bITSUPERVISORDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ConductorDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConductorDG";
            this.Text = "ConductorDG";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONDUCTORBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONDUCTORTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource conductorBindingSource;
        private BindingSource conductorBindingSource1;
        private BindingSource conductorBindingSource2;
        private BindingSource cONDUCTORBindingSource3;
        private DataGridViewTextBoxColumn nUMCEDULADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMNOMBREDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMAPELLIDO1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMAPELLIDO2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fECNACIMIENTODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tIPGENERODataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn bITSUPERVISORDataGridViewCheckBoxColumn;
        private BindingSource cONDUCTORTableAdapterBindingSource;
    }
}