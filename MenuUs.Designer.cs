namespace Bubble_Information_System
{
    partial class MenuUs
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adeudosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Corte = new System.Windows.Forms.Button();
            this.btn_Adeudos = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.btn_Venta = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(104, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Location = new System.Drawing.Point(394, 94);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(91, 20);
            this.labelBienvenida.TabIndex = 13;
            this.labelBienvenida.Text = "Bienvenido ";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMenu.Location = new System.Drawing.Point(410, 51);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(209, 29);
            this.labelMenu.TabIndex = 12;
            this.labelMenu.Text = "MENÚ USUARIO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviciosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.adeudosToolStripMenuItem,
            this.corteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // adeudosToolStripMenuItem
            // 
            this.adeudosToolStripMenuItem.Name = "adeudosToolStripMenuItem";
            this.adeudosToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.adeudosToolStripMenuItem.Text = "Adeudos";
            // 
            // corteToolStripMenuItem
            // 
            this.corteToolStripMenuItem.Name = "corteToolStripMenuItem";
            this.corteToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.corteToolStripMenuItem.Text = "Corte de caja";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bubble_Information_System.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(760, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bubble_Information_System.Properties.Resources.Usuario1;
            this.pictureBox1.Location = new System.Drawing.Point(57, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Corte
            // 
            this.btn_Corte.Image = global::Bubble_Information_System.Properties.Resources.icons8_caja_registradora_48;
            this.btn_Corte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Corte.Location = new System.Drawing.Point(628, 371);
            this.btn_Corte.Name = "btn_Corte";
            this.btn_Corte.Size = new System.Drawing.Size(181, 103);
            this.btn_Corte.TabIndex = 18;
            this.btn_Corte.Text = "Corte de Caja";
            this.btn_Corte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Corte.UseVisualStyleBackColor = true;
            // 
            // btn_Adeudos
            // 
            this.btn_Adeudos.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Adeudos.Image = global::Bubble_Information_System.Properties.Resources.icons8_historial_de_pagos_48;
            this.btn_Adeudos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Adeudos.Location = new System.Drawing.Point(354, 371);
            this.btn_Adeudos.Name = "btn_Adeudos";
            this.btn_Adeudos.Size = new System.Drawing.Size(181, 103);
            this.btn_Adeudos.TabIndex = 17;
            this.btn_Adeudos.Text = "Adeudos";
            this.btn_Adeudos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Adeudos.UseVisualStyleBackColor = false;
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Cliente.Image = global::Bubble_Information_System.Properties.Resources.icons8_grupo_de_usuario_48;
            this.btn_Cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cliente.Location = new System.Drawing.Point(628, 213);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(181, 103);
            this.btn_Cliente.TabIndex = 16;
            this.btn_Cliente.Text = "Clientes";
            this.btn_Cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cliente.UseVisualStyleBackColor = false;
            // 
            // btn_Venta
            // 
            this.btn_Venta.Image = global::Bubble_Information_System.Properties.Resources.icons8_checkout_48;
            this.btn_Venta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Venta.Location = new System.Drawing.Point(354, 213);
            this.btn_Venta.Name = "btn_Venta";
            this.btn_Venta.Size = new System.Drawing.Size(181, 103);
            this.btn_Venta.TabIndex = 15;
            this.btn_Venta.Text = "Venta de Servicios";
            this.btn_Venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Venta.UseVisualStyleBackColor = true;
            // 
            // MenuUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 481);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Corte);
            this.Controls.Add(this.btn_Adeudos);
            this.Controls.Add(this.btn_Cliente);
            this.Controls.Add(this.btn_Venta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuUs";
            this.Text = "Bubble System Information";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Corte;
        private System.Windows.Forms.Button btn_Adeudos;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_Venta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adeudosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteToolStripMenuItem;
    }
}