namespace ISVSUR.UI
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasTelefonixasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reposterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdmin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCliente = new System.Windows.Forms.ToolStripButton();
            this.btnChofer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuses = new System.Windows.Forms.ToolStripButton();
            this.btnRuta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVentas = new System.Windows.Forms.ToolStripButton();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpCargo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpReloj = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 70;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.choferesToolStripMenuItem,
            this.busToolStripMenuItem1,
            this.rutaToolStripMenuItem,
            this.programacionToolStripMenuItem1});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // choferesToolStripMenuItem
            // 
            this.choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            this.choferesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.choferesToolStripMenuItem.Text = "Chofer";
            this.choferesToolStripMenuItem.Click += new System.EventHandler(this.choferesToolStripMenuItem_Click);
            // 
            // busToolStripMenuItem1
            // 
            this.busToolStripMenuItem1.Name = "busToolStripMenuItem1";
            this.busToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.busToolStripMenuItem1.Text = "Bus";
            this.busToolStripMenuItem1.Click += new System.EventHandler(this.busToolStripMenuItem1_Click);
            // 
            // rutaToolStripMenuItem
            // 
            this.rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            this.rutaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rutaToolStripMenuItem.Text = "Ruta";
            this.rutaToolStripMenuItem.Click += new System.EventHandler(this.rutaToolStripMenuItem_Click);
            // 
            // programacionToolStripMenuItem1
            // 
            this.programacionToolStripMenuItem1.Name = "programacionToolStripMenuItem1";
            this.programacionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.programacionToolStripMenuItem1.Text = "Programacion";
            this.programacionToolStripMenuItem1.Click += new System.EventHandler(this.programacionToolStripMenuItem1_Click);
            // 
            // ventasToolStripMenuItem2
            // 
            this.ventasToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem3,
            this.ventasTelefonixasToolStripMenuItem});
            this.ventasToolStripMenuItem2.Name = "ventasToolStripMenuItem2";
            this.ventasToolStripMenuItem2.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem2.Text = "Ventas";
            // 
            // ventasToolStripMenuItem3
            // 
            this.ventasToolStripMenuItem3.Name = "ventasToolStripMenuItem3";
            this.ventasToolStripMenuItem3.Size = new System.Drawing.Size(168, 22);
            this.ventasToolStripMenuItem3.Text = "Registrar Venta";
            this.ventasToolStripMenuItem3.Click += new System.EventHandler(this.ventasToolStripMenuItem3_Click);
            // 
            // ventasTelefonixasToolStripMenuItem
            // 
            this.ventasTelefonixasToolStripMenuItem.Name = "ventasTelefonixasToolStripMenuItem";
            this.ventasTelefonixasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ventasTelefonixasToolStripMenuItem.Text = "Ventas telefonicas";
            // 
            // reposterToolStripMenuItem
            // 
            this.reposterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem});
            this.reposterToolStripMenuItem.Name = "reposterToolStripMenuItem";
            this.reposterToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reposterToolStripMenuItem.Text = "Reportes";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.inicioToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.ventasToolStripMenuItem2,
            this.reposterToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdmin,
            this.toolStripSeparator1,
            this.btnCliente,
            this.btnChofer,
            this.toolStripSeparator2,
            this.btnBuses,
            this.btnRuta,
            this.toolStripSeparator3,
            this.btnVentas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(905, 39);
            this.toolStrip1.TabIndex = 72;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdmin
            // 
            this.btnAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(36, 36);
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnCliente
            // 
            this.btnCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(36, 36);
            this.btnCliente.Text = "Clientes";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnChofer
            // 
            this.btnChofer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChofer.Image = ((System.Drawing.Image)(resources.GetObject("btnChofer.Image")));
            this.btnChofer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChofer.Name = "btnChofer";
            this.btnChofer.Size = new System.Drawing.Size(36, 36);
            this.btnChofer.Text = "Chofer";
            this.btnChofer.Click += new System.EventHandler(this.btnChofer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnBuses
            // 
            this.btnBuses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuses.Image = ((System.Drawing.Image)(resources.GetObject("btnBuses.Image")));
            this.btnBuses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuses.Name = "btnBuses";
            this.btnBuses.Size = new System.Drawing.Size(36, 36);
            this.btnBuses.Text = "Buses";
            this.btnBuses.Click += new System.EventHandler(this.btnBuses_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRuta.Image = ((System.Drawing.Image)(resources.GetObject("btnRuta.Image")));
            this.btnRuta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(36, 36);
            this.btnRuta.Text = "Rutas";
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnVentas
            // 
            this.btnVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(36, 36);
            this.btnVentas.Text = "Registrar Ventas";
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tpID,
            this.tpNombre,
            this.tpCargo,
            this.tpFecha,
            this.tpReloj});
            this.statusStrip2.Location = new System.Drawing.Point(0, 413);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(905, 25);
            this.statusStrip2.TabIndex = 73;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(310, 20);
            this.toolStripStatusLabel1.Text = "Sistema de Ventas  de Pasajes: CRUZ DEL SUR";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(241, 20);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(27, 20);
            this.toolStripStatusLabel3.Text = "ID : ";
            // 
            // tpID
            // 
            this.tpID.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tpID.Name = "tpID";
            this.tpID.Size = new System.Drawing.Size(4, 20);
            // 
            // tpNombre
            // 
            this.tpNombre.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tpNombre.Name = "tpNombre";
            this.tpNombre.Size = new System.Drawing.Size(101, 20);
            this.tpNombre.Text = "Nombre: Usuario";
            // 
            // tpCargo
            // 
            this.tpCargo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tpCargo.Name = "tpCargo";
            this.tpCargo.Size = new System.Drawing.Size(89, 20);
            this.tpCargo.Text = "Cargo: Usuario";
            // 
            // tpFecha
            // 
            this.tpFecha.Name = "tpFecha";
            this.tpFecha.Size = new System.Drawing.Size(65, 20);
            this.tpFecha.Text = "01/01/2020";
            // 
            // tpReloj
            // 
            this.tpReloj.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tpReloj.Name = "tpReloj";
            this.tpReloj.Size = new System.Drawing.Size(53, 20);
            this.tpReloj.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTA DE PASAJES TERRESTRES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.General_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reposterToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choferesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ventasTelefonixasToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdmin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCliente;
        private System.Windows.Forms.ToolStripButton btnChofer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnBuses;
        private System.Windows.Forms.ToolStripButton btnRuta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnVentas;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tpCargo;
        private System.Windows.Forms.ToolStripStatusLabel tpReloj;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel tpID;
        public System.Windows.Forms.ToolStripStatusLabel tpNombre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel tpFecha;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}