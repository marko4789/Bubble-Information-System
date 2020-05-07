namespace Bubble_Information_System
{
    partial class Empleados
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textNumE = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textApeP = new System.Windows.Forms.TextBox();
            this.textApeM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDir = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dblavanderiaDataSet = new Bubble_Information_System.dblavanderiaDataSet();
            this.empleadosTableAdapter = new Bubble_Information_System.dblavanderiaDataSetTableAdapters.empleadosTableAdapter();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.numEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblavanderiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTitulo.Location = new System.Drawing.Point(330, 34);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(243, 52);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Empleados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido Paterno";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textNumE
            // 
            this.textNumE.Location = new System.Drawing.Point(265, 117);
            this.textNumE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNumE.Name = "textNumE";
            this.textNumE.Size = new System.Drawing.Size(90, 26);
            this.textNumE.TabIndex = 6;
            this.textNumE.TextChanged += new System.EventHandler(this.textNumE_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(127, 228);
            this.textNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(112, 26);
            this.textNombre.TabIndex = 7;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(132, 321);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(112, 26);
            this.textTelefono.TabIndex = 8;
            this.textTelefono.TextChanged += new System.EventHandler(this.textTelefono_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(603, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido Materno";
            // 
            // textApeP
            // 
            this.textApeP.Location = new System.Drawing.Point(461, 228);
            this.textApeP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textApeP.Name = "textApeP";
            this.textApeP.Size = new System.Drawing.Size(112, 26);
            this.textApeP.TabIndex = 11;
            this.textApeP.TextChanged += new System.EventHandler(this.textApeP_TextChanged);
            // 
            // textApeM
            // 
            this.textApeM.Location = new System.Drawing.Point(798, 226);
            this.textApeM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textApeM.Name = "textApeM";
            this.textApeM.Size = new System.Drawing.Size(112, 26);
            this.textApeM.TabIndex = 12;
            this.textApeM.TextChanged += new System.EventHandler(this.textApeM_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dirección";
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(388, 321);
            this.textDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(210, 26);
            this.textDir.TabIndex = 14;
            this.textDir.TextChanged += new System.EventHandler(this.textDir_TextChanged);
            // 
            // Column1
            // 
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            this.apellidoPaternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            this.apellidoMaternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 150;
            // 
            // status
            // 
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.Width = 150;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::Bubble_Information_System.Properties.Resources.icons8_añadir_48;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(652, 291);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(202, 86);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numEmpleadoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.apellidoPaternoDataGridViewTextBoxColumn1,
            this.apellidoMaternoDataGridViewTextBoxColumn1,
            this.telefonoDataGridViewTextBoxColumn1,
            this.direccionDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.empleadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(279, 531);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(662, 240);
            this.dataGridView1.TabIndex = 18;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.dblavanderiaDataSet;
            // 
            // dblavanderiaDataSet
            // 
            this.dblavanderiaDataSet.DataSetName = "dblavanderiaDataSet";
            this.dblavanderiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(12, 613);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(102, 55);
            this.btn_actualizar.TabIndex = 19;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // numEmpleadoDataGridViewTextBoxColumn
            // 
            this.numEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "numEmpleado";
            this.numEmpleadoDataGridViewTextBoxColumn.HeaderText = "numEmpleado";
            this.numEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numEmpleadoDataGridViewTextBoxColumn.Name = "numEmpleadoDataGridViewTextBoxColumn";
            this.numEmpleadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.Width = 150;
            // 
            // apellidoPaternoDataGridViewTextBoxColumn1
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn1.DataPropertyName = "apellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn1.HeaderText = "apellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.apellidoPaternoDataGridViewTextBoxColumn1.Name = "apellidoPaternoDataGridViewTextBoxColumn1";
            this.apellidoPaternoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // apellidoMaternoDataGridViewTextBoxColumn1
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn1.DataPropertyName = "apellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn1.HeaderText = "apellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.apellidoMaternoDataGridViewTextBoxColumn1.Name = "apellidoMaternoDataGridViewTextBoxColumn1";
            this.apellidoMaternoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // telefonoDataGridViewTextBoxColumn1
            // 
            this.telefonoDataGridViewTextBoxColumn1.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn1.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.telefonoDataGridViewTextBoxColumn1.Name = "telefonoDataGridViewTextBoxColumn1";
            this.telefonoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn1
            // 
            this.direccionDataGridViewTextBoxColumn1.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn1.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.direccionDataGridViewTextBoxColumn1.Name = "direccionDataGridViewTextBoxColumn1";
            this.direccionDataGridViewTextBoxColumn1.Width = 150;
            // 
            // textbusqueda
            // 
            this.textbusqueda.Location = new System.Drawing.Point(13, 464);
            this.textbusqueda.Name = "textbusqueda";
            this.textbusqueda.Size = new System.Drawing.Size(457, 26);
            this.textbusqueda.TabIndex = 20;
            this.textbusqueda.TextChanged += new System.EventHandler(this.textbusqueda_TextChanged);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 783);
            this.Controls.Add(this.textbusqueda);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textDir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textApeM);
            this.Controls.Add(this.textApeP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textNumE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Empleados";
            this.Text = "Bubble System Information";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblavanderiaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textApeM;
        private System.Windows.Forms.TextBox textApeP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textNumE;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dblavanderiaDataSet dblavanderiaDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private dblavanderiaDataSetTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textbusqueda;
    }
}