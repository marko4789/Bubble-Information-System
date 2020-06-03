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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.rdbStatusUp = new System.Windows.Forms.RadioButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.rdbStatusDown = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de usuario";
            // 
            // txtbNumUs
            // 
            this.txtbNumUs.Location = new System.Drawing.Point(136, 85);
            this.txtbNumUs.Name = "txtbNumUs";
            this.txtbNumUs.Size = new System.Drawing.Size(30, 20);
            this.txtbNumUs.TabIndex = 5;
            this.txtbNumUs.TextChanged += new System.EventHandler(this.txtbNumUs_TextChanged);
            this.txtbNumUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNumUs_KeyPress);
            // 
            // txtbNomUs
            // 
            this.txtbNomUs.Location = new System.Drawing.Point(136, 142);
            this.txtbNomUs.Name = "txtbNomUs";
            this.txtbNomUs.Size = new System.Drawing.Size(121, 20);
            this.txtbNomUs.TabIndex = 7;
            this.txtbNomUs.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtbNomUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNomUs_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtbContra
            // 
            this.txtbContra.Location = new System.Drawing.Point(421, 158);
            this.txtbContra.Name = "txtbContra";
            this.txtbContra.PasswordChar = '*';
            this.txtbContra.Size = new System.Drawing.Size(100, 20);
            this.txtbContra.TabIndex = 11;
            this.txtbContra.TextChanged += new System.EventHandler(this.txtbContra_TextChanged);
            this.txtbContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbContra_KeyPress);
            // 
            // cmbTipoUs
            // 
            this.cmbTipoUs.FormattingEnabled = true;
            this.cmbTipoUs.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmbTipoUs.Location = new System.Drawing.Point(136, 184);
            this.cmbTipoUs.Name = "cmbTipoUs";
            this.cmbTipoUs.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoUs.TabIndex = 0;
            this.cmbTipoUs.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUs_SelectedIndexChanged);
            this.cmbTipoUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoUs_KeyPress);
            // 
            // cmbEmple
            // 
            this.cmbEmple.FormattingEnabled = true;
            this.cmbEmple.Location = new System.Drawing.Point(421, 101);
            this.cmbEmple.Name = "cmbEmple";
            this.cmbEmple.Size = new System.Drawing.Size(121, 21);
            this.cmbEmple.TabIndex = 10;
            this.cmbEmple.SelectedIndexChanged += new System.EventHandler(this.cmbEmple_SelectedIndexChanged);
            this.cmbEmple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEmple_KeyPress);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnActualizar.Location = new System.Drawing.Point(12, 397);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(84, 31);
            this.bttnActualizar.TabIndex = 14;
            this.bttnActualizar.Text = "Actualizar";
            this.bttnActualizar.UseVisualStyleBackColor = true;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // tituloUsuario
            // 
            this.tituloUsuario.AutoSize = true;
            this.tituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tituloUsuario.Location = new System.Drawing.Point(375, 40);
            this.tituloUsuario.MaximumSize = new System.Drawing.Size(243, 52);
            this.tituloUsuario.Name = "tituloUsuario";
            this.tituloUsuario.Size = new System.Drawing.Size(98, 26);
            this.tituloUsuario.TabIndex = 1;
            this.tituloUsuario.Text = "Usuarios";
            this.tituloUsuario.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttnBuscar.Location = new System.Drawing.Point(667, 238);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(104, 43);
            this.bttnBuscar.TabIndex = 16;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // bttnDeshab
            // 
            this.bttnDeshab.Location = new System.Drawing.Point(12, 311);
            this.bttnDeshab.Name = "bttnDeshab";
            this.bttnDeshab.Size = new System.Drawing.Size(84, 35);
            this.bttnDeshab.TabIndex = 13;
            this.bttnDeshab.Text = "Deshabilitar";
            this.bttnDeshab.UseVisualStyleBackColor = true;
            this.bttnDeshab.Click += new System.EventHandler(this.bttnDeshab_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Bubble_Information_System.Properties.Resources.eliminar1;
            this.pictureBox4.Location = new System.Drawing.Point(93, 311);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Bubble_Information_System.Properties.Resources.actualizar1;
            this.pictureBox3.Location = new System.Drawing.Point(93, 397);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bubble_Information_System.Properties.Resources.Buscar;
            this.pictureBox2.Location = new System.Drawing.Point(629, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bubble_Information_System.Properties.Resources.Buscar;
            this.pictureBox1.Location = new System.Drawing.Point(369, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.bttnAgregar.BackgroundImage = global::Bubble_Information_System.Properties.Resources.Añadir;
            this.bttnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAgregar.Location = new System.Drawing.Point(629, 158);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(142, 54);
            this.bttnAgregar.TabIndex = 15;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = false;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Bubble_Information_System.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(629, 22);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(141, 112);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 27;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // rdbStatusUp
            // 
            this.rdbStatusUp.AutoSize = true;
            this.rdbStatusUp.Location = new System.Drawing.Point(473, 270);
            this.rdbStatusUp.Name = "rdbStatusUp";
            this.rdbStatusUp.Size = new System.Drawing.Size(39, 17);
            this.rdbStatusUp.TabIndex = 28;
            this.rdbStatusUp.TabStop = true;
            this.rdbStatusUp.Text = "On";
            this.rdbStatusUp.UseVisualStyleBackColor = true;
            this.rdbStatusUp.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(37, 267);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(326, 20);
            this.txtbusqueda.TabIndex = 29;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // rdbStatusDown
            // 
            this.rdbStatusDown.AutoSize = true;
            this.rdbStatusDown.Location = new System.Drawing.Point(516, 270);
            this.rdbStatusDown.Name = "rdbStatusDown";
            this.rdbStatusDown.Size = new System.Drawing.Size(39, 17);
            this.rdbStatusDown.TabIndex = 30;
            this.rdbStatusDown.TabStop = true;
            this.rdbStatusDown.Text = "Off";
            this.rdbStatusDown.UseVisualStyleBackColor = true;
            this.rdbStatusDown.CheckedChanged += new System.EventHandler(this.rdbStatusDown_CheckedChanged);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbStatusDown);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.rdbStatusUp);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tituloUsuario);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.bttnDeshab);
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
            this.Name = "Usuarios";
            this.Text = "Bubble_Information_System";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.RadioButton rdbStatusUp;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.RadioButton rdbStatusDown;
    }
}

