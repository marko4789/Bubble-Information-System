namespace Bubble_Information_System
{
    partial class Usuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbNumUs = new System.Windows.Forms.TextBox();
            this.txtbNomUs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbContra = new System.Windows.Forms.TextBox();
            this.cmbTipoUs = new System.Windows.Forms.ComboBox();
            this.cmbEmple = new System.Windows.Forms.ComboBox();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.tituloUsuario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnDeshab = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.rdbStatusUp = new System.Windows.Forms.RadioButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.rdbStatusDown = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de usuario";
            // 
            // txtbNumUs
            // 
            this.txtbNumUs.Enabled = false;
            this.txtbNumUs.Location = new System.Drawing.Point(178, 97);
            this.txtbNumUs.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNumUs.Name = "txtbNumUs";
            this.txtbNumUs.ReadOnly = true;
            this.txtbNumUs.Size = new System.Drawing.Size(43, 24);
            this.txtbNumUs.TabIndex = 5;
            this.txtbNumUs.TextChanged += new System.EventHandler(this.txtbNumUs_TextChanged);
            this.txtbNumUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNumUs_KeyPress);
            // 
            // txtbNomUs
            // 
            this.txtbNomUs.Location = new System.Drawing.Point(178, 133);
            this.txtbNomUs.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNomUs.Name = "txtbNomUs";
            this.txtbNomUs.Size = new System.Drawing.Size(115, 24);
            this.txtbNomUs.TabIndex = 0;
            this.txtbNomUs.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtbNomUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNomUs_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtbContra
            // 
            this.txtbContra.Location = new System.Drawing.Point(436, 131);
            this.txtbContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtbContra.Name = "txtbContra";
            this.txtbContra.PasswordChar = '*';
            this.txtbContra.Size = new System.Drawing.Size(148, 24);
            this.txtbContra.TabIndex = 3;
            this.txtbContra.TextChanged += new System.EventHandler(this.txtbContra_TextChanged);
            this.txtbContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbContra_KeyPress);
            // 
            // cmbTipoUs
            // 
            this.cmbTipoUs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUs.FormattingEnabled = true;
            this.cmbTipoUs.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmbTipoUs.Location = new System.Drawing.Point(178, 171);
            this.cmbTipoUs.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoUs.Name = "cmbTipoUs";
            this.cmbTipoUs.Size = new System.Drawing.Size(115, 26);
            this.cmbTipoUs.TabIndex = 1;
            this.cmbTipoUs.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUs_SelectedIndexChanged);
            this.cmbTipoUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoUs_KeyPress);
            // 
            // cmbEmple
            // 
            this.cmbEmple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmple.FormattingEnabled = true;
            this.cmbEmple.Location = new System.Drawing.Point(436, 93);
            this.cmbEmple.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmple.Name = "cmbEmple";
            this.cmbEmple.Size = new System.Drawing.Size(180, 26);
            this.cmbEmple.TabIndex = 2;
            this.cmbEmple.SelectedIndexChanged += new System.EventHandler(this.cmbEmple_SelectedIndexChanged);
            this.cmbEmple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEmple_KeyPress);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnActualizar.Location = new System.Drawing.Point(25, 168);
            this.bttnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(152, 43);
            this.bttnActualizar.TabIndex = 14;
            this.bttnActualizar.Text = "Actualizar";
            this.bttnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnActualizar.UseVisualStyleBackColor = true;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // tituloUsuario
            // 
            this.tituloUsuario.AutoSize = true;
            this.tituloUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tituloUsuario.Location = new System.Drawing.Point(326, 9);
            this.tituloUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloUsuario.MaximumSize = new System.Drawing.Size(364, 72);
            this.tituloUsuario.Name = "tituloUsuario";
            this.tituloUsuario.Size = new System.Drawing.Size(120, 31);
            this.tituloUsuario.TabIndex = 1;
            this.tituloUsuario.Text = "Usuarios";
            this.tituloUsuario.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 158);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBuscar.Location = new System.Drawing.Point(558, 18);
            this.bttnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(151, 50);
            this.bttnBuscar.TabIndex = 8;
            this.bttnBuscar.Text = "Buscar    ";
            this.bttnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // bttnDeshab
            // 
            this.bttnDeshab.Location = new System.Drawing.Point(24, 97);
            this.bttnDeshab.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDeshab.Name = "bttnDeshab";
            this.bttnDeshab.Size = new System.Drawing.Size(158, 48);
            this.bttnDeshab.TabIndex = 13;
            this.bttnDeshab.Text = "Deshabilitar";
            this.bttnDeshab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnDeshab.UseVisualStyleBackColor = true;
            this.bttnDeshab.Click += new System.EventHandler(this.bttnDeshab_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox4.Image = global::Bubble_Information_System.Properties.Resources.eliminar1;
            this.pictureBox4.Location = new System.Drawing.Point(133, 101);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.Image = global::Bubble_Information_System.Properties.Resources.actualizar1;
            this.pictureBox3.Location = new System.Drawing.Point(130, 172);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bubble_Information_System.Properties.Resources.Buscar;
            this.pictureBox1.Location = new System.Drawing.Point(68, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.bttnAgregar.BackgroundImage = global::Bubble_Information_System.Properties.Resources.Añadir;
            this.bttnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAgregar.Location = new System.Drawing.Point(567, 175);
            this.bttnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(149, 58);
            this.bttnAgregar.TabIndex = 4;
            this.bttnAgregar.Text = "Agregar   ";
            this.bttnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnAgregar.UseVisualStyleBackColor = false;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Bubble_Information_System.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(648, 16);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(81, 81);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 27;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // rdbStatusUp
            // 
            this.rdbStatusUp.AutoSize = true;
            this.rdbStatusUp.Checked = true;
            this.rdbStatusUp.Location = new System.Drawing.Point(416, 36);
            this.rdbStatusUp.Margin = new System.Windows.Forms.Padding(4);
            this.rdbStatusUp.Name = "rdbStatusUp";
            this.rdbStatusUp.Size = new System.Drawing.Size(46, 22);
            this.rdbStatusUp.TabIndex = 6;
            this.rdbStatusUp.TabStop = true;
            this.rdbStatusUp.Text = "On";
            this.rdbStatusUp.UseVisualStyleBackColor = true;
            this.rdbStatusUp.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(100, 36);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(271, 24);
            this.txtbusqueda.TabIndex = 5;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // rdbStatusDown
            // 
            this.rdbStatusDown.AutoSize = true;
            this.rdbStatusDown.Location = new System.Drawing.Point(480, 36);
            this.rdbStatusDown.Margin = new System.Windows.Forms.Padding(4);
            this.rdbStatusDown.Name = "rdbStatusDown";
            this.rdbStatusDown.Size = new System.Drawing.Size(46, 22);
            this.rdbStatusDown.TabIndex = 7;
            this.rdbStatusDown.TabStop = true;
            this.rdbStatusDown.Text = "Off";
            this.rdbStatusDown.UseVisualStyleBackColor = true;
            this.rdbStatusDown.CheckedChanged += new System.EventHandler(this.rdbStatusDown_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Image = global::Bubble_Information_System.Properties.Resources.Buscar;
            this.pictureBox2.Location = new System.Drawing.Point(563, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.rdbStatusDown);
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.rdbStatusUp);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.bttnBuscar);
            this.groupBox1.Controls.Add(this.bttnActualizar);
            this.groupBox1.Controls.Add(this.bttnDeshab);
            this.groupBox1.Location = new System.Drawing.Point(3, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 246);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.tituloUsuario);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.txtbContra);
            this.Controls.Add(this.cmbEmple);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbNomUs);
            this.Controls.Add(this.txtbNumUs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoUs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Usuarios";
            this.Text = "Bubble Information System";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbNumUs;
        private System.Windows.Forms.TextBox txtbNomUs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbContra;
        private System.Windows.Forms.ComboBox cmbTipoUs;
        private System.Windows.Forms.ComboBox cmbEmple;
        private System.Windows.Forms.Button bttnDeshab;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Label tituloUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.RadioButton rdbStatusUp;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.RadioButton rdbStatusDown;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

