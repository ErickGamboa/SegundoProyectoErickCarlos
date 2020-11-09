namespace Presentation
{
    partial class WindowBuilder
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpgConsultaServicios = new System.Windows.Forms.TabPage();
            this.dgvConsultaServicio = new System.Windows.Forms.DataGridView();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscarServicio = new System.Windows.Forms.TextBox();
            this.tpgAntencionServicio = new System.Windows.Forms.TabPage();
            this.pnlObservaciones = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.pnlServicio = new System.Windows.Forms.Panel();
            this.lblCantidadServicio = new System.Windows.Forms.Label();
            this.btoAgregarCarritoServicio = new System.Windows.Forms.Button();
            this.txtCantidadServicio = new System.Windows.Forms.TextBox();
            this.lblCodigoServicio = new System.Windows.Forms.Label();
            this.txtCodigoServicio = new System.Windows.Forms.TextBox();
            this.lblNombreServicioT = new System.Windows.Forms.Label();
            this.btoBuscarServicio = new System.Windows.Forms.Button();
            this.lblNombreServicioL = new System.Windows.Forms.Label();
            this.btoNuevaOrden = new System.Windows.Forms.Button();
            this.btoLogOut = new System.Windows.Forms.Button();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.lblColon2 = new System.Windows.Forms.Label();
            this.lblSubtotalT = new System.Windows.Forms.Label();
            this.lblTotalT = new System.Windows.Forms.Label();
            this.lblIVAT = new System.Windows.Forms.Label();
            this.lblColon1 = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.lblCodigoConstructorT = new System.Windows.Forms.Label();
            this.lblNombreConstructorT = new System.Windows.Forms.Label();
            this.lblTotalL = new System.Windows.Forms.Label();
            this.lblIVAL = new System.Windows.Forms.Label();
            this.lblSubtotalL = new System.Windows.Forms.Label();
            this.lblCedulaCliente = new System.Windows.Forms.Label();
            this.btoRealizarCompra = new System.Windows.Forms.Button();
            this.lblCodigoConstructorL = new System.Windows.Forms.Label();
            this.lblNombreConstructorL = new System.Windows.Forms.Label();
            this.tpgCarritoCompras = new System.Windows.Forms.TabPage();
            this.btoEliminar = new System.Windows.Forms.Button();
            this.dgvCarritoCompras = new System.Windows.Forms.DataGridView();
            this.tpgBodega = new System.Windows.Forms.TabPage();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.pnlSalida = new System.Windows.Forms.Panel();
            this.btoSalida = new System.Windows.Forms.Button();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.lblSalida = new System.Windows.Forms.Label();
            this.pnlTitulo2 = new System.Windows.Forms.Panel();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.pnlTitulo1 = new System.Windows.Forms.Panel();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.pnlRecibido = new System.Windows.Forms.Panel();
            this.btoRecibido = new System.Windows.Forms.Button();
            this.dtpRecibido = new System.Windows.Forms.DateTimePicker();
            this.lblRecibido = new System.Windows.Forms.Label();
            this.clmpePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpeTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpeRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpeSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tpgConsultaServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaServicio)).BeginInit();
            this.tpgAntencionServicio.SuspendLayout();
            this.pnlObservaciones.SuspendLayout();
            this.pnlServicio.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            this.tpgCarritoCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCompras)).BeginInit();
            this.tpgBodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.pnlSalida.SuspendLayout();
            this.pnlTitulo2.SuspendLayout();
            this.pnlTitulo1.SuspendLayout();
            this.pnlRecibido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpgConsultaServicios);
            this.tabControl.Controls.Add(this.tpgAntencionServicio);
            this.tabControl.Controls.Add(this.tpgCarritoCompras);
            this.tabControl.Controls.Add(this.tpgBodega);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(838, 441);
            this.tabControl.TabIndex = 0;
            // 
            // tpgConsultaServicios
            // 
            this.tpgConsultaServicios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgConsultaServicios.Controls.Add(this.dgvConsultaServicio);
            this.tpgConsultaServicios.Controls.Add(this.cboCategoria);
            this.tpgConsultaServicios.Controls.Add(this.txtBuscarServicio);
            this.tpgConsultaServicios.Location = new System.Drawing.Point(4, 27);
            this.tpgConsultaServicios.Name = "tpgConsultaServicios";
            this.tpgConsultaServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tpgConsultaServicios.Size = new System.Drawing.Size(830, 410);
            this.tpgConsultaServicios.TabIndex = 2;
            this.tpgConsultaServicios.Text = "Consultar Servicios";
            // 
            // dgvConsultaServicio
            // 
            this.dgvConsultaServicio.AllowUserToAddRows = false;
            this.dgvConsultaServicio.AllowUserToDeleteRows = false;
            this.dgvConsultaServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConsultaServicio.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvConsultaServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaServicio.Location = new System.Drawing.Point(0, 38);
            this.dgvConsultaServicio.Name = "dgvConsultaServicio";
            this.dgvConsultaServicio.ReadOnly = true;
            this.dgvConsultaServicio.RowHeadersVisible = false;
            this.dgvConsultaServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaServicio.Size = new System.Drawing.Size(830, 372);
            this.dgvConsultaServicio.TabIndex = 2;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(622, 6);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(200, 26);
            this.cboCategoria.TabIndex = 1;
            this.cboCategoria.SelectionChangeCommitted += new System.EventHandler(this.cboCategoria_SelectionChangeCommitted);
            // 
            // txtBuscarServicio
            // 
            this.txtBuscarServicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscarServicio.Location = new System.Drawing.Point(130, 7);
            this.txtBuscarServicio.Name = "txtBuscarServicio";
            this.txtBuscarServicio.Size = new System.Drawing.Size(340, 24);
            this.txtBuscarServicio.TabIndex = 0;
            this.txtBuscarServicio.TextChanged += new System.EventHandler(this.txtBuscarServicio_TextChanged);
            this.txtBuscarServicio.Enter += new System.EventHandler(this.txtBuscarServicio_Enter);
            this.txtBuscarServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarServicio_KeyPress);
            this.txtBuscarServicio.Leave += new System.EventHandler(this.txtBuscarServicio_Leave);
            // 
            // tpgAntencionServicio
            // 
            this.tpgAntencionServicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgAntencionServicio.Controls.Add(this.pnlObservaciones);
            this.tpgAntencionServicio.Controls.Add(this.pnlServicio);
            this.tpgAntencionServicio.Controls.Add(this.btoNuevaOrden);
            this.tpgAntencionServicio.Controls.Add(this.btoLogOut);
            this.tpgAntencionServicio.Controls.Add(this.pnlInformacion);
            this.tpgAntencionServicio.Location = new System.Drawing.Point(4, 27);
            this.tpgAntencionServicio.Margin = new System.Windows.Forms.Padding(4);
            this.tpgAntencionServicio.Name = "tpgAntencionServicio";
            this.tpgAntencionServicio.Padding = new System.Windows.Forms.Padding(4);
            this.tpgAntencionServicio.Size = new System.Drawing.Size(830, 410);
            this.tpgAntencionServicio.TabIndex = 0;
            this.tpgAntencionServicio.Text = "Atención de Servicio";
            // 
            // pnlObservaciones
            // 
            this.pnlObservaciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlObservaciones.Controls.Add(this.txtObservaciones);
            this.pnlObservaciones.Controls.Add(this.lblObservaciones);
            this.pnlObservaciones.Location = new System.Drawing.Point(425, 215);
            this.pnlObservaciones.Name = "pnlObservaciones";
            this.pnlObservaciones.Size = new System.Drawing.Size(385, 175);
            this.pnlObservaciones.TabIndex = 28;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Location = new System.Drawing.Point(20, 50);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(345, 105);
            this.txtObservaciones.TabIndex = 21;
            this.txtObservaciones.Text = "";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(20, 20);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(112, 18);
            this.lblObservaciones.TabIndex = 20;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // pnlServicio
            // 
            this.pnlServicio.BackColor = System.Drawing.SystemColors.Control;
            this.pnlServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServicio.Controls.Add(this.lblCantidadServicio);
            this.pnlServicio.Controls.Add(this.btoAgregarCarritoServicio);
            this.pnlServicio.Controls.Add(this.txtCantidadServicio);
            this.pnlServicio.Controls.Add(this.lblCodigoServicio);
            this.pnlServicio.Controls.Add(this.txtCodigoServicio);
            this.pnlServicio.Controls.Add(this.lblNombreServicioT);
            this.pnlServicio.Controls.Add(this.btoBuscarServicio);
            this.pnlServicio.Controls.Add(this.lblNombreServicioL);
            this.pnlServicio.Location = new System.Drawing.Point(425, 20);
            this.pnlServicio.Name = "pnlServicio";
            this.pnlServicio.Size = new System.Drawing.Size(385, 175);
            this.pnlServicio.TabIndex = 27;
            // 
            // lblCantidadServicio
            // 
            this.lblCantidadServicio.AutoSize = true;
            this.lblCantidadServicio.Location = new System.Drawing.Point(20, 90);
            this.lblCantidadServicio.Name = "lblCantidadServicio";
            this.lblCantidadServicio.Size = new System.Drawing.Size(70, 18);
            this.lblCantidadServicio.TabIndex = 27;
            this.lblCantidadServicio.Text = "Cantidad:";
            // 
            // btoAgregarCarritoServicio
            // 
            this.btoAgregarCarritoServicio.Image = global::Presentation.Properties.Resources.add_shopping_cart_24px;
            this.btoAgregarCarritoServicio.Location = new System.Drawing.Point(106, 130);
            this.btoAgregarCarritoServicio.Name = "btoAgregarCarritoServicio";
            this.btoAgregarCarritoServicio.Size = new System.Drawing.Size(170, 32);
            this.btoAgregarCarritoServicio.TabIndex = 20;
            this.btoAgregarCarritoServicio.Text = "Agregar al Carrito";
            this.btoAgregarCarritoServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoAgregarCarritoServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoAgregarCarritoServicio.UseVisualStyleBackColor = true;
            this.btoAgregarCarritoServicio.Click += new System.EventHandler(this.btoAgregarCarritoServicio_Click);
            // 
            // txtCantidadServicio
            // 
            this.txtCantidadServicio.Location = new System.Drawing.Point(160, 87);
            this.txtCantidadServicio.Name = "txtCantidadServicio";
            this.txtCantidadServicio.Size = new System.Drawing.Size(160, 24);
            this.txtCantidadServicio.TabIndex = 26;
            // 
            // lblCodigoServicio
            // 
            this.lblCodigoServicio.AutoSize = true;
            this.lblCodigoServicio.Location = new System.Drawing.Point(20, 20);
            this.lblCodigoServicio.Name = "lblCodigoServicio";
            this.lblCodigoServicio.Size = new System.Drawing.Size(117, 18);
            this.lblCodigoServicio.TabIndex = 23;
            this.lblCodigoServicio.Text = "Código Servicio:";
            // 
            // txtCodigoServicio
            // 
            this.txtCodigoServicio.Location = new System.Drawing.Point(160, 17);
            this.txtCodigoServicio.Name = "txtCodigoServicio";
            this.txtCodigoServicio.Size = new System.Drawing.Size(160, 24);
            this.txtCodigoServicio.TabIndex = 22;
            // 
            // lblNombreServicioT
            // 
            this.lblNombreServicioT.AutoSize = true;
            this.lblNombreServicioT.Location = new System.Drawing.Point(157, 55);
            this.lblNombreServicioT.Name = "lblNombreServicioT";
            this.lblNombreServicioT.Size = new System.Drawing.Size(119, 18);
            this.lblNombreServicioT.TabIndex = 25;
            this.lblNombreServicioT.Text = "Nombre Servicio";
            // 
            // btoBuscarServicio
            // 
            this.btoBuscarServicio.Image = global::Presentation.Properties.Resources.search_24px;
            this.btoBuscarServicio.Location = new System.Drawing.Point(332, 13);
            this.btoBuscarServicio.Name = "btoBuscarServicio";
            this.btoBuscarServicio.Size = new System.Drawing.Size(32, 32);
            this.btoBuscarServicio.TabIndex = 21;
            this.btoBuscarServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoBuscarServicio.UseVisualStyleBackColor = true;
            this.btoBuscarServicio.Click += new System.EventHandler(this.btoBuscarServicio_Click);
            // 
            // lblNombreServicioL
            // 
            this.lblNombreServicioL.AutoSize = true;
            this.lblNombreServicioL.Location = new System.Drawing.Point(20, 55);
            this.lblNombreServicioL.Name = "lblNombreServicioL";
            this.lblNombreServicioL.Size = new System.Drawing.Size(123, 18);
            this.lblNombreServicioL.TabIndex = 24;
            this.lblNombreServicioL.Text = "Nombre Servicio:";
            // 
            // btoNuevaOrden
            // 
            this.btoNuevaOrden.Image = global::Presentation.Properties.Resources.shopping_cart_24px;
            this.btoNuevaOrden.Location = new System.Drawing.Point(216, 20);
            this.btoNuevaOrden.Name = "btoNuevaOrden";
            this.btoNuevaOrden.Size = new System.Drawing.Size(190, 32);
            this.btoNuevaOrden.TabIndex = 26;
            this.btoNuevaOrden.Text = "Nueva Orden";
            this.btoNuevaOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoNuevaOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoNuevaOrden.UseVisualStyleBackColor = true;
            this.btoNuevaOrden.Click += new System.EventHandler(this.btoNuevaOrden_Click);
            // 
            // btoLogOut
            // 
            this.btoLogOut.Image = global::Presentation.Properties.Resources.logout_rounded_left_24px;
            this.btoLogOut.Location = new System.Drawing.Point(20, 20);
            this.btoLogOut.Name = "btoLogOut";
            this.btoLogOut.Size = new System.Drawing.Size(190, 32);
            this.btoLogOut.TabIndex = 25;
            this.btoLogOut.Text = "Cerrar Sesión";
            this.btoLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoLogOut.UseVisualStyleBackColor = true;
            this.btoLogOut.Click += new System.EventHandler(this.btoLogOut_Click);
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInformacion.Controls.Add(this.lblColon2);
            this.pnlInformacion.Controls.Add(this.lblSubtotalT);
            this.pnlInformacion.Controls.Add(this.lblTotalT);
            this.pnlInformacion.Controls.Add(this.lblIVAT);
            this.pnlInformacion.Controls.Add(this.lblColon1);
            this.pnlInformacion.Controls.Add(this.txtCedulaCliente);
            this.pnlInformacion.Controls.Add(this.lblCodigoConstructorT);
            this.pnlInformacion.Controls.Add(this.lblNombreConstructorT);
            this.pnlInformacion.Controls.Add(this.lblTotalL);
            this.pnlInformacion.Controls.Add(this.lblIVAL);
            this.pnlInformacion.Controls.Add(this.lblSubtotalL);
            this.pnlInformacion.Controls.Add(this.lblCedulaCliente);
            this.pnlInformacion.Controls.Add(this.btoRealizarCompra);
            this.pnlInformacion.Controls.Add(this.lblCodigoConstructorL);
            this.pnlInformacion.Controls.Add(this.lblNombreConstructorL);
            this.pnlInformacion.Location = new System.Drawing.Point(20, 60);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(385, 330);
            this.pnlInformacion.TabIndex = 24;
            // 
            // lblColon2
            // 
            this.lblColon2.AutoSize = true;
            this.lblColon2.Location = new System.Drawing.Point(177, 230);
            this.lblColon2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColon2.Name = "lblColon2";
            this.lblColon2.Size = new System.Drawing.Size(19, 18);
            this.lblColon2.TabIndex = 39;
            this.lblColon2.Text = "₡";
            // 
            // lblSubtotalT
            // 
            this.lblSubtotalT.AutoSize = true;
            this.lblSubtotalT.Location = new System.Drawing.Point(204, 150);
            this.lblSubtotalT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalT.Name = "lblSubtotalT";
            this.lblSubtotalT.Size = new System.Drawing.Size(36, 18);
            this.lblSubtotalT.TabIndex = 38;
            this.lblSubtotalT.Text = "0.00";
            // 
            // lblTotalT
            // 
            this.lblTotalT.AutoSize = true;
            this.lblTotalT.Location = new System.Drawing.Point(204, 230);
            this.lblTotalT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalT.Name = "lblTotalT";
            this.lblTotalT.Size = new System.Drawing.Size(36, 18);
            this.lblTotalT.TabIndex = 37;
            this.lblTotalT.Text = "0.00";
            // 
            // lblIVAT
            // 
            this.lblIVAT.AutoSize = true;
            this.lblIVAT.Location = new System.Drawing.Point(204, 190);
            this.lblIVAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVAT.Name = "lblIVAT";
            this.lblIVAT.Size = new System.Drawing.Size(37, 18);
            this.lblIVAT.TabIndex = 36;
            this.lblIVAT.Text = "13%";
            // 
            // lblColon1
            // 
            this.lblColon1.AutoSize = true;
            this.lblColon1.Location = new System.Drawing.Point(177, 150);
            this.lblColon1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColon1.Name = "lblColon1";
            this.lblColon1.Size = new System.Drawing.Size(19, 18);
            this.lblColon1.TabIndex = 35;
            this.lblColon1.Text = "₡";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Location = new System.Drawing.Point(180, 110);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(185, 24);
            this.txtCedulaCliente.TabIndex = 34;
            // 
            // lblCodigoConstructorT
            // 
            this.lblCodigoConstructorT.AutoSize = true;
            this.lblCodigoConstructorT.Location = new System.Drawing.Point(177, 30);
            this.lblCodigoConstructorT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoConstructorT.Name = "lblCodigoConstructorT";
            this.lblCodigoConstructorT.Size = new System.Drawing.Size(70, 18);
            this.lblCodigoConstructorT.TabIndex = 33;
            this.lblCodigoConstructorT.Text = "COS-000";
            // 
            // lblNombreConstructorT
            // 
            this.lblNombreConstructorT.AutoSize = true;
            this.lblNombreConstructorT.Location = new System.Drawing.Point(177, 70);
            this.lblNombreConstructorT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreConstructorT.Name = "lblNombreConstructorT";
            this.lblNombreConstructorT.Size = new System.Drawing.Size(145, 18);
            this.lblNombreConstructorT.TabIndex = 32;
            this.lblNombreConstructorT.Text = "Nombre Constructor";
            // 
            // lblTotalL
            // 
            this.lblTotalL.AutoSize = true;
            this.lblTotalL.Location = new System.Drawing.Point(20, 230);
            this.lblTotalL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalL.Name = "lblTotalL";
            this.lblTotalL.Size = new System.Drawing.Size(45, 18);
            this.lblTotalL.TabIndex = 31;
            this.lblTotalL.Text = "Total:";
            // 
            // lblIVAL
            // 
            this.lblIVAL.AutoSize = true;
            this.lblIVAL.Location = new System.Drawing.Point(20, 190);
            this.lblIVAL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVAL.Name = "lblIVAL";
            this.lblIVAL.Size = new System.Drawing.Size(33, 18);
            this.lblIVAL.TabIndex = 30;
            this.lblIVAL.Text = "IVA:";
            // 
            // lblSubtotalL
            // 
            this.lblSubtotalL.AutoSize = true;
            this.lblSubtotalL.Location = new System.Drawing.Point(20, 150);
            this.lblSubtotalL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalL.Name = "lblSubtotalL";
            this.lblSubtotalL.Size = new System.Drawing.Size(66, 18);
            this.lblSubtotalL.TabIndex = 29;
            this.lblSubtotalL.Text = "Subtotal:";
            // 
            // lblCedulaCliente
            // 
            this.lblCedulaCliente.AutoSize = true;
            this.lblCedulaCliente.Location = new System.Drawing.Point(20, 110);
            this.lblCedulaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedulaCliente.Name = "lblCedulaCliente";
            this.lblCedulaCliente.Size = new System.Drawing.Size(107, 18);
            this.lblCedulaCliente.TabIndex = 28;
            this.lblCedulaCliente.Text = "Cédula Cliente:";
            // 
            // btoRealizarCompra
            // 
            this.btoRealizarCompra.Image = global::Presentation.Properties.Resources.buy_24px;
            this.btoRealizarCompra.Location = new System.Drawing.Point(107, 285);
            this.btoRealizarCompra.Name = "btoRealizarCompra";
            this.btoRealizarCompra.Size = new System.Drawing.Size(170, 32);
            this.btoRealizarCompra.TabIndex = 27;
            this.btoRealizarCompra.Text = "Realizar Compra";
            this.btoRealizarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoRealizarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoRealizarCompra.UseVisualStyleBackColor = true;
            this.btoRealizarCompra.Click += new System.EventHandler(this.btoRealizarCompra_Click);
            // 
            // lblCodigoConstructorL
            // 
            this.lblCodigoConstructorL.AutoSize = true;
            this.lblCodigoConstructorL.Location = new System.Drawing.Point(20, 30);
            this.lblCodigoConstructorL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoConstructorL.Name = "lblCodigoConstructorL";
            this.lblCodigoConstructorL.Size = new System.Drawing.Size(143, 18);
            this.lblCodigoConstructorL.TabIndex = 12;
            this.lblCodigoConstructorL.Text = "Código Constructor:";
            // 
            // lblNombreConstructorL
            // 
            this.lblNombreConstructorL.AutoSize = true;
            this.lblNombreConstructorL.Location = new System.Drawing.Point(20, 70);
            this.lblNombreConstructorL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreConstructorL.Name = "lblNombreConstructorL";
            this.lblNombreConstructorL.Size = new System.Drawing.Size(149, 18);
            this.lblNombreConstructorL.TabIndex = 13;
            this.lblNombreConstructorL.Text = "Nombre Constructor:";
            // 
            // tpgCarritoCompras
            // 
            this.tpgCarritoCompras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgCarritoCompras.Controls.Add(this.btoEliminar);
            this.tpgCarritoCompras.Controls.Add(this.dgvCarritoCompras);
            this.tpgCarritoCompras.Location = new System.Drawing.Point(4, 27);
            this.tpgCarritoCompras.Name = "tpgCarritoCompras";
            this.tpgCarritoCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCarritoCompras.Size = new System.Drawing.Size(830, 410);
            this.tpgCarritoCompras.TabIndex = 3;
            this.tpgCarritoCompras.Text = "Ver Carrito de Compras";
            // 
            // btoEliminar
            // 
            this.btoEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btoEliminar.Image = global::Presentation.Properties.Resources.clear_shopping_cart_24px;
            this.btoEliminar.Location = new System.Drawing.Point(642, 6);
            this.btoEliminar.Name = "btoEliminar";
            this.btoEliminar.Size = new System.Drawing.Size(180, 32);
            this.btoEliminar.TabIndex = 3;
            this.btoEliminar.Text = "Eliminar Servicio";
            this.btoEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoEliminar.UseVisualStyleBackColor = true;
            this.btoEliminar.Click += new System.EventHandler(this.btoEliminar_Click);
            // 
            // dgvCarritoCompras
            // 
            this.dgvCarritoCompras.AllowUserToAddRows = false;
            this.dgvCarritoCompras.AllowUserToDeleteRows = false;
            this.dgvCarritoCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCarritoCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarritoCompras.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCarritoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarritoCompras.Location = new System.Drawing.Point(0, 44);
            this.dgvCarritoCompras.Name = "dgvCarritoCompras";
            this.dgvCarritoCompras.ReadOnly = true;
            this.dgvCarritoCompras.RowHeadersVisible = false;
            this.dgvCarritoCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarritoCompras.Size = new System.Drawing.Size(830, 366);
            this.dgvCarritoCompras.TabIndex = 2;
            // 
            // tpgBodega
            // 
            this.tpgBodega.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgBodega.Controls.Add(this.dgvVentas);
            this.tpgBodega.Controls.Add(this.dgvPedidos);
            this.tpgBodega.Controls.Add(this.pnlSalida);
            this.tpgBodega.Controls.Add(this.pnlTitulo2);
            this.tpgBodega.Controls.Add(this.pnlTitulo1);
            this.tpgBodega.Controls.Add(this.pnlRecibido);
            this.tpgBodega.Location = new System.Drawing.Point(4, 27);
            this.tpgBodega.Margin = new System.Windows.Forms.Padding(4);
            this.tpgBodega.Name = "tpgBodega";
            this.tpgBodega.Padding = new System.Windows.Forms.Padding(4);
            this.tpgBodega.Size = new System.Drawing.Size(830, 410);
            this.tpgBodega.TabIndex = 1;
            this.tpgBodega.Text = "Bodega";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmvTipo,
            this.clmvId,
            this.clmvNombre,
            this.clmvCategoria,
            this.clmvDescripcion,
            this.clmvCantidad});
            this.dgvVentas.Location = new System.Drawing.Point(0, 273);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(830, 137);
            this.dgvVentas.TabIndex = 5;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmpePedido,
            this.clmpeTipo,
            this.clmpeId,
            this.clmpeRecibido,
            this.clmpeSalida});
            this.dgvPedidos.Location = new System.Drawing.Point(0, 100);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(830, 129);
            this.dgvPedidos.TabIndex = 4;
            this.dgvPedidos.SelectionChanged += new System.EventHandler(this.dgvPedidos_SelectionChanged);
            // 
            // pnlSalida
            // 
            this.pnlSalida.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSalida.Controls.Add(this.btoSalida);
            this.pnlSalida.Controls.Add(this.dtpSalida);
            this.pnlSalida.Controls.Add(this.lblSalida);
            this.pnlSalida.Location = new System.Drawing.Point(418, 38);
            this.pnlSalida.Name = "pnlSalida";
            this.pnlSalida.Size = new System.Drawing.Size(412, 56);
            this.pnlSalida.TabIndex = 3;
            // 
            // btoSalida
            // 
            this.btoSalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btoSalida.Image = global::Presentation.Properties.Resources.clock_24px;
            this.btoSalida.Location = new System.Drawing.Point(275, 12);
            this.btoSalida.Name = "btoSalida";
            this.btoSalida.Size = new System.Drawing.Size(100, 32);
            this.btoSalida.TabIndex = 2;
            this.btoSalida.Text = "Agregar";
            this.btoSalida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoSalida.UseVisualStyleBackColor = true;
            this.btoSalida.Click += new System.EventHandler(this.btoSalida_Click);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalida.Location = new System.Drawing.Point(151, 16);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(110, 24);
            this.dtpSalida.TabIndex = 1;
            // 
            // lblSalida
            // 
            this.lblSalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(50, 19);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(87, 18);
            this.lblSalida.TabIndex = 0;
            this.lblSalida.Text = "Hora salida:";
            // 
            // pnlTitulo2
            // 
            this.pnlTitulo2.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTitulo2.Controls.Add(this.lblTitulo2);
            this.pnlTitulo2.Location = new System.Drawing.Point(0, 235);
            this.pnlTitulo2.Name = "pnlTitulo2";
            this.pnlTitulo2.Size = new System.Drawing.Size(830, 32);
            this.pnlTitulo2.TabIndex = 2;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Location = new System.Drawing.Point(339, 7);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(153, 18);
            this.lblTitulo2.TabIndex = 0;
            this.lblTitulo2.Text = "Productos y Servicios";
            // 
            // pnlTitulo1
            // 
            this.pnlTitulo1.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTitulo1.Controls.Add(this.lblTitulo1);
            this.pnlTitulo1.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo1.Name = "pnlTitulo1";
            this.pnlTitulo1.Size = new System.Drawing.Size(830, 32);
            this.pnlTitulo1.TabIndex = 1;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Location = new System.Drawing.Point(384, 7);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(62, 18);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "Pedidos";
            // 
            // pnlRecibido
            // 
            this.pnlRecibido.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRecibido.Controls.Add(this.btoRecibido);
            this.pnlRecibido.Controls.Add(this.dtpRecibido);
            this.pnlRecibido.Controls.Add(this.lblRecibido);
            this.pnlRecibido.Location = new System.Drawing.Point(0, 38);
            this.pnlRecibido.Name = "pnlRecibido";
            this.pnlRecibido.Size = new System.Drawing.Size(412, 56);
            this.pnlRecibido.TabIndex = 0;
            // 
            // btoRecibido
            // 
            this.btoRecibido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btoRecibido.Image = global::Presentation.Properties.Resources.clock_24px;
            this.btoRecibido.Location = new System.Drawing.Point(275, 12);
            this.btoRecibido.Name = "btoRecibido";
            this.btoRecibido.Size = new System.Drawing.Size(100, 32);
            this.btoRecibido.TabIndex = 2;
            this.btoRecibido.Text = "Agregar";
            this.btoRecibido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoRecibido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoRecibido.UseVisualStyleBackColor = true;
            this.btoRecibido.Click += new System.EventHandler(this.btoRecibido_Click);
            // 
            // dtpRecibido
            // 
            this.dtpRecibido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpRecibido.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRecibido.Location = new System.Drawing.Point(151, 16);
            this.dtpRecibido.Name = "dtpRecibido";
            this.dtpRecibido.Size = new System.Drawing.Size(110, 24);
            this.dtpRecibido.TabIndex = 1;
            // 
            // lblRecibido
            // 
            this.lblRecibido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRecibido.AutoSize = true;
            this.lblRecibido.Location = new System.Drawing.Point(36, 19);
            this.lblRecibido.Name = "lblRecibido";
            this.lblRecibido.Size = new System.Drawing.Size(101, 18);
            this.lblRecibido.TabIndex = 0;
            this.lblRecibido.Text = "Hora recibido:";
            // 
            // clmpePedido
            // 
            this.clmpePedido.HeaderText = "Pedido";
            this.clmpePedido.Name = "clmpePedido";
            this.clmpePedido.ReadOnly = true;
            this.clmpePedido.Visible = false;
            // 
            // clmpeTipo
            // 
            this.clmpeTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmpeTipo.FillWeight = 140F;
            this.clmpeTipo.HeaderText = "Tipo";
            this.clmpeTipo.Name = "clmpeTipo";
            this.clmpeTipo.ReadOnly = true;
            this.clmpeTipo.Width = 140;
            // 
            // clmpeId
            // 
            this.clmpeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmpeId.HeaderText = "Id";
            this.clmpeId.Name = "clmpeId";
            this.clmpeId.ReadOnly = true;
            // 
            // clmpeRecibido
            // 
            this.clmpeRecibido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmpeRecibido.FillWeight = 15.46391F;
            this.clmpeRecibido.HeaderText = "Hora Recibido";
            this.clmpeRecibido.Name = "clmpeRecibido";
            this.clmpeRecibido.ReadOnly = true;
            // 
            // clmpeSalida
            // 
            this.clmpeSalida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmpeSalida.FillWeight = 15.46391F;
            this.clmpeSalida.HeaderText = "Hora Salida";
            this.clmpeSalida.Name = "clmpeSalida";
            this.clmpeSalida.ReadOnly = true;
            // 
            // clmvTipo
            // 
            this.clmvTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmvTipo.HeaderText = "Tipo";
            this.clmvTipo.Name = "clmvTipo";
            this.clmvTipo.ReadOnly = true;
            // 
            // clmvId
            // 
            this.clmvId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmvId.HeaderText = "Id";
            this.clmvId.Name = "clmvId";
            this.clmvId.ReadOnly = true;
            this.clmvId.Width = 120;
            // 
            // clmvNombre
            // 
            this.clmvNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmvNombre.HeaderText = "Nombre";
            this.clmvNombre.Name = "clmvNombre";
            this.clmvNombre.ReadOnly = true;
            // 
            // clmvCategoria
            // 
            this.clmvCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmvCategoria.HeaderText = "Categoría";
            this.clmvCategoria.Name = "clmvCategoria";
            this.clmvCategoria.ReadOnly = true;
            // 
            // clmvDescripcion
            // 
            this.clmvDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmvDescripcion.HeaderText = "Descripción";
            this.clmvDescripcion.Name = "clmvDescripcion";
            this.clmvDescripcion.ReadOnly = true;
            // 
            // clmvCantidad
            // 
            this.clmvCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmvCantidad.HeaderText = "Cantidad";
            this.clmvCantidad.Name = "clmvCantidad";
            this.clmvCantidad.ReadOnly = true;
            // 
            // WindowBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Constructor";
            this.tabControl.ResumeLayout(false);
            this.tpgConsultaServicios.ResumeLayout(false);
            this.tpgConsultaServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaServicio)).EndInit();
            this.tpgAntencionServicio.ResumeLayout(false);
            this.pnlObservaciones.ResumeLayout(false);
            this.pnlObservaciones.PerformLayout();
            this.pnlServicio.ResumeLayout(false);
            this.pnlServicio.PerformLayout();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.tpgCarritoCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCompras)).EndInit();
            this.tpgBodega.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.pnlSalida.ResumeLayout(false);
            this.pnlSalida.PerformLayout();
            this.pnlTitulo2.ResumeLayout(false);
            this.pnlTitulo2.PerformLayout();
            this.pnlTitulo1.ResumeLayout(false);
            this.pnlTitulo1.PerformLayout();
            this.pnlRecibido.ResumeLayout(false);
            this.pnlRecibido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpgAntencionServicio;
        private System.Windows.Forms.Label lblNombreConstructorL;
        private System.Windows.Forms.Label lblCodigoConstructorL;
        private System.Windows.Forms.TabPage tpgBodega;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TabPage tpgConsultaServicios;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtBuscarServicio;
        private System.Windows.Forms.DataGridView dgvConsultaServicio;
        private System.Windows.Forms.Panel pnlRecibido;
        private System.Windows.Forms.Button btoRecibido;
        private System.Windows.Forms.DateTimePicker dtpRecibido;
        private System.Windows.Forms.Label lblRecibido;
        private System.Windows.Forms.Panel pnlTitulo1;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Panel pnlSalida;
        private System.Windows.Forms.Button btoSalida;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Panel pnlTitulo2;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Button btoLogOut;
        private System.Windows.Forms.Button btoNuevaOrden;
        private System.Windows.Forms.Button btoRealizarCompra;
        private System.Windows.Forms.Label lblCedulaCliente;
        private System.Windows.Forms.Label lblTotalL;
        private System.Windows.Forms.Label lblIVAL;
        private System.Windows.Forms.Label lblSubtotalL;
        private System.Windows.Forms.Label lblNombreConstructorT;
        private System.Windows.Forms.Label lblCodigoConstructorT;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Label lblTotalT;
        private System.Windows.Forms.Label lblIVAT;
        private System.Windows.Forms.Label lblColon1;
        private System.Windows.Forms.Label lblSubtotalT;
        private System.Windows.Forms.Label lblColon2;
        private System.Windows.Forms.TabPage tpgCarritoCompras;
        private System.Windows.Forms.Panel pnlServicio;
        private System.Windows.Forms.Label lblCantidadServicio;
        private System.Windows.Forms.Button btoAgregarCarritoServicio;
        private System.Windows.Forms.TextBox txtCantidadServicio;
        private System.Windows.Forms.Label lblCodigoServicio;
        private System.Windows.Forms.TextBox txtCodigoServicio;
        private System.Windows.Forms.Label lblNombreServicioT;
        private System.Windows.Forms.Button btoBuscarServicio;
        private System.Windows.Forms.Label lblNombreServicioL;
        private System.Windows.Forms.Panel pnlObservaciones;
        private System.Windows.Forms.Button btoEliminar;
        private System.Windows.Forms.DataGridView dgvCarritoCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpeTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpeRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpeSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvCantidad;
    }
}