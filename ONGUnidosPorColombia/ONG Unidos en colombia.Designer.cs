namespace ONGUnidosPorColombia
{
    partial class ONG_Unidos_en_colombia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ONG_Unidos_en_colombia));
            this.LbDatos = new System.Windows.Forms.Label();
            this.LbAcciones = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbNombreDeEmpresa = new System.Windows.Forms.Label();
            this.LbFecha = new System.Windows.Forms.Label();
            this.LbTotal = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtHijos = new System.Windows.Forms.TextBox();
            this.LbTabla = new System.Windows.Forms.Label();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtAyuda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbDatos
            // 
            this.LbDatos.AutoSize = true;
            this.LbDatos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDatos.Location = new System.Drawing.Point(321, 28);
            this.LbDatos.Name = "LbDatos";
            this.LbDatos.Size = new System.Drawing.Size(159, 22);
            this.LbDatos.TabIndex = 0;
            this.LbDatos.Text = "Datos personales";
            // 
            // LbAcciones
            // 
            this.LbAcciones.AutoSize = true;
            this.LbAcciones.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAcciones.Location = new System.Drawing.Point(694, 28);
            this.LbAcciones.Name = "LbAcciones";
            this.LbAcciones.Size = new System.Drawing.Size(169, 22);
            this.LbAcciones.TabIndex = 1;
            this.LbAcciones.Text = "Acciones a realizar";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(698, 76);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 2;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(788, 76);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(698, 116);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar ";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(788, 116);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.Location = new System.Drawing.Point(12, 78);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(163, 18);
            this.LbNombre.TabIndex = 7;
            this.LbNombre.Text = "Nombre del empleado";
            // 
            // LbNombreDeEmpresa
            // 
            this.LbNombreDeEmpresa.AutoSize = true;
            this.LbNombreDeEmpresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombreDeEmpresa.Location = new System.Drawing.Point(12, 117);
            this.LbNombreDeEmpresa.Name = "LbNombreDeEmpresa";
            this.LbNombreDeEmpresa.Size = new System.Drawing.Size(168, 18);
            this.LbNombreDeEmpresa.TabIndex = 8;
            this.LbNombreDeEmpresa.Text = "Nombre de la empresa";
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.BackColor = System.Drawing.Color.White;
            this.LbFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFecha.Location = new System.Drawing.Point(428, 116);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(52, 18);
            this.LbFecha.TabIndex = 9;
            this.LbFecha.Text = "Fecha";
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.Location = new System.Drawing.Point(428, 77);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(101, 18);
            this.LbTotal.TabIndex = 10;
            this.LbTotal.Text = "Total de Hijos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(197, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 20);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(536, 117);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(144, 20);
            this.DtpFecha.TabIndex = 12;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(197, 116);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(225, 20);
            this.txtEmpresa.TabIndex = 13;
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtro);
            // 
            // txtHijos
            // 
            this.txtHijos.Location = new System.Drawing.Point(536, 78);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(144, 20);
            this.txtHijos.TabIndex = 14;
            // 
            // LbTabla
            // 
            this.LbTabla.AutoSize = true;
            this.LbTabla.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTabla.Location = new System.Drawing.Point(277, 167);
            this.LbTabla.Name = "LbTabla";
            this.LbTabla.Size = new System.Drawing.Size(134, 22);
            this.LbTabla.TabIndex = 15;
            this.LbTabla.Text = "Tabla de datos";
            // 
            // DtgDatos
            // 
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(15, 206);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.Size = new System.Drawing.Size(665, 150);
            this.DtgDatos.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(715, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxtAyuda
            // 
            this.TxtAyuda.Location = new System.Drawing.Point(788, 157);
            this.TxtAyuda.Name = "TxtAyuda";
            this.TxtAyuda.Size = new System.Drawing.Size(75, 20);
            this.TxtAyuda.TabIndex = 18;
            // 
            // ONG_Unidos_en_colombia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 421);
            this.Controls.Add(this.TxtAyuda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.LbTabla);
            this.Controls.Add(this.txtHijos);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LbTotal);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.LbNombreDeEmpresa);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.LbAcciones);
            this.Controls.Add(this.LbDatos);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ONG_Unidos_en_colombia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ONG Unidos en Colombia";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbDatos;
        private System.Windows.Forms.Label LbAcciones;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbNombreDeEmpresa;
        private System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtHijos;
        private System.Windows.Forms.Label LbTabla;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TxtAyuda;
    }
}