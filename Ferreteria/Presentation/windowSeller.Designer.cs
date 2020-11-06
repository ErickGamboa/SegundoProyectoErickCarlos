﻿namespace Presentation
{
    partial class WindowSeller
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
            this.tpgConsultaProductos = new System.Windows.Forms.TabPage();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.cboCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.dgvConsultaProducto = new System.Windows.Forms.DataGridView();
            this.tpgConsultaServicios = new System.Windows.Forms.TabPage();
            this.txtBuscarServicio = new System.Windows.Forms.TextBox();
            this.cboCategoriaServicio = new System.Windows.Forms.ComboBox();
            this.dgvConsultaServicio = new System.Windows.Forms.DataGridView();
            this.tpgTomarOrden = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlServicio = new System.Windows.Forms.Panel();
            this.lblCantidadServicio = new System.Windows.Forms.Label();
            this.btnAgregarCarritoServicio = new System.Windows.Forms.Button();
            this.txtCantidadServicio = new System.Windows.Forms.TextBox();
            this.lblCodigoServicio = new System.Windows.Forms.Label();
            this.txtCodigoServicio = new System.Windows.Forms.TextBox();
            this.lblNombreServicioT = new System.Windows.Forms.Label();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.lblNombreServicioL = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarCarritoProducto = new System.Windows.Forms.Button();
            this.lblNombreProductoT = new System.Windows.Forms.Label();
            this.lblNombreProductoL = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.btnRealizarCompra = new System.Windows.Forms.Button();
            this.lblTotalT = new System.Windows.Forms.Label();
            this.lblSubtotalT = new System.Windows.Forms.Label();
            this.lblColon2 = new System.Windows.Forms.Label();
            this.lblIVAT = new System.Windows.Forms.Label();
            this.lblColon1 = new System.Windows.Forms.Label();
            this.lblTotalL = new System.Windows.Forms.Label();
            this.lblIVAL = new System.Windows.Forms.Label();
            this.lblSubtotalL = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.lblCedulaCliente = new System.Windows.Forms.Label();
            this.lblNombreVendedorT = new System.Windows.Forms.Label();
            this.lblNombreVendedorL = new System.Windows.Forms.Label();
            this.lblCodigoVendedorT = new System.Windows.Forms.Label();
            this.lblCodigoVendedorL = new System.Windows.Forms.Label();
            this.tpgCarritoCompras = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCarritoCompras = new System.Windows.Forms.DataGridView();
            this.btnNuevaOrden = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpgConsultaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProducto)).BeginInit();
            this.tpgConsultaServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaServicio)).BeginInit();
            this.tpgTomarOrden.SuspendLayout();
            this.pnlServicio.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            this.tpgCarritoCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpgConsultaProductos);
            this.tabControl.Controls.Add(this.tpgConsultaServicios);
            this.tabControl.Controls.Add(this.tpgTomarOrden);
            this.tabControl.Controls.Add(this.tpgCarritoCompras);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(838, 441);
            this.tabControl.TabIndex = 0;
            // 
            // tpgConsultaProductos
            // 
            this.tpgConsultaProductos.BackColor = System.Drawing.SystemColors.Control;
            this.tpgConsultaProductos.Controls.Add(this.txtBuscarProducto);
            this.tpgConsultaProductos.Controls.Add(this.cboCategoriaProducto);
            this.tpgConsultaProductos.Controls.Add(this.dgvConsultaProducto);
            this.tpgConsultaProductos.Location = new System.Drawing.Point(4, 27);
            this.tpgConsultaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.tpgConsultaProductos.Name = "tpgConsultaProductos";
            this.tpgConsultaProductos.Padding = new System.Windows.Forms.Padding(4);
            this.tpgConsultaProductos.Size = new System.Drawing.Size(830, 410);
            this.tpgConsultaProductos.TabIndex = 0;
            this.tpgConsultaProductos.Text = "Consultar Productos";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarProducto.Location = new System.Drawing.Point(130, 8);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(340, 24);
            this.txtBuscarProducto.TabIndex = 15;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            this.txtBuscarProducto.Enter += new System.EventHandler(this.txtBuscarProducto_Enter);
            this.txtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProducto_KeyPress);
            this.txtBuscarProducto.Leave += new System.EventHandler(this.txtBuscarProducto_Leave);
            // 
            // cboCategoriaProducto
            // 
            this.cboCategoriaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaProducto.FormattingEnabled = true;
            this.cboCategoriaProducto.Location = new System.Drawing.Point(622, 7);
            this.cboCategoriaProducto.Name = "cboCategoriaProducto";
            this.cboCategoriaProducto.Size = new System.Drawing.Size(200, 26);
            this.cboCategoriaProducto.TabIndex = 14;
            this.cboCategoriaProducto.SelectionChangeCommitted += new System.EventHandler(this.cboCategoriaProducto_SelectionChangeCommitted);
            // 
            // dgvConsultaProducto
            // 
            this.dgvConsultaProducto.AllowUserToAddRows = false;
            this.dgvConsultaProducto.AllowUserToDeleteRows = false;
            this.dgvConsultaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConsultaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaProducto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvConsultaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaProducto.Location = new System.Drawing.Point(0, 40);
            this.dgvConsultaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultaProducto.Name = "dgvConsultaProducto";
            this.dgvConsultaProducto.ReadOnly = true;
            this.dgvConsultaProducto.RowHeadersVisible = false;
            this.dgvConsultaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaProducto.Size = new System.Drawing.Size(830, 370);
            this.dgvConsultaProducto.TabIndex = 13;
            // 
            // tpgConsultaServicios
            // 
            this.tpgConsultaServicios.BackColor = System.Drawing.SystemColors.Control;
            this.tpgConsultaServicios.Controls.Add(this.txtBuscarServicio);
            this.tpgConsultaServicios.Controls.Add(this.cboCategoriaServicio);
            this.tpgConsultaServicios.Controls.Add(this.dgvConsultaServicio);
            this.tpgConsultaServicios.Location = new System.Drawing.Point(4, 27);
            this.tpgConsultaServicios.Name = "tpgConsultaServicios";
            this.tpgConsultaServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tpgConsultaServicios.Size = new System.Drawing.Size(830, 410);
            this.tpgConsultaServicios.TabIndex = 2;
            this.tpgConsultaServicios.Text = "Consultar Servicios";
            // 
            // txtBuscarServicio
            // 
            this.txtBuscarServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarServicio.Location = new System.Drawing.Point(130, 8);
            this.txtBuscarServicio.Name = "txtBuscarServicio";
            this.txtBuscarServicio.Size = new System.Drawing.Size(340, 24);
            this.txtBuscarServicio.TabIndex = 2;
            this.txtBuscarServicio.TextChanged += new System.EventHandler(this.txtBuscarServicio_TextChanged);
            this.txtBuscarServicio.Enter += new System.EventHandler(this.txtBuscarServicio_Enter);
            this.txtBuscarServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarServicio_KeyPress);
            this.txtBuscarServicio.Leave += new System.EventHandler(this.txtBuscarServicio_Leave);
            // 
            // cboCategoriaServicio
            // 
            this.cboCategoriaServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoriaServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaServicio.FormattingEnabled = true;
            this.cboCategoriaServicio.Location = new System.Drawing.Point(622, 7);
            this.cboCategoriaServicio.Name = "cboCategoriaServicio";
            this.cboCategoriaServicio.Size = new System.Drawing.Size(200, 26);
            this.cboCategoriaServicio.TabIndex = 1;
            this.cboCategoriaServicio.SelectionChangeCommitted += new System.EventHandler(this.cboCategoriaServicio_SelectionChangeCommitted);
            // 
            // dgvConsultaServicio
            // 
            this.dgvConsultaServicio.AllowUserToAddRows = false;
            this.dgvConsultaServicio.AllowUserToDeleteRows = false;
            this.dgvConsultaServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConsultaServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaServicio.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvConsultaServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaServicio.Location = new System.Drawing.Point(0, 39);
            this.dgvConsultaServicio.Name = "dgvConsultaServicio";
            this.dgvConsultaServicio.ReadOnly = true;
            this.dgvConsultaServicio.RowHeadersVisible = false;
            this.dgvConsultaServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaServicio.Size = new System.Drawing.Size(830, 371);
            this.dgvConsultaServicio.TabIndex = 0;
            // 
            // tpgTomarOrden
            // 
            this.tpgTomarOrden.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgTomarOrden.Controls.Add(this.btnNuevaOrden);
            this.tpgTomarOrden.Controls.Add(this.btnLogOut);
            this.tpgTomarOrden.Controls.Add(this.pnlServicio);
            this.tpgTomarOrden.Controls.Add(this.pnlProducto);
            this.tpgTomarOrden.Controls.Add(this.pnlInformacion);
            this.tpgTomarOrden.Location = new System.Drawing.Point(4, 27);
            this.tpgTomarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.tpgTomarOrden.Name = "tpgTomarOrden";
            this.tpgTomarOrden.Padding = new System.Windows.Forms.Padding(4);
            this.tpgTomarOrden.Size = new System.Drawing.Size(830, 410);
            this.tpgTomarOrden.TabIndex = 1;
            this.tpgTomarOrden.Text = "Tomar Orden";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = global::Presentation.Properties.Resources.logout_rounded_left_24px;
            this.btnLogOut.Location = new System.Drawing.Point(20, 20);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(190, 32);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btoLogOut_Click);
            // 
            // pnlServicio
            // 
            this.pnlServicio.BackColor = System.Drawing.SystemColors.Control;
            this.pnlServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServicio.Controls.Add(this.lblCantidadServicio);
            this.pnlServicio.Controls.Add(this.btnAgregarCarritoServicio);
            this.pnlServicio.Controls.Add(this.txtCantidadServicio);
            this.pnlServicio.Controls.Add(this.lblCodigoServicio);
            this.pnlServicio.Controls.Add(this.txtCodigoServicio);
            this.pnlServicio.Controls.Add(this.lblNombreServicioT);
            this.pnlServicio.Controls.Add(this.btnBuscarServicio);
            this.pnlServicio.Controls.Add(this.lblNombreServicioL);
            this.pnlServicio.Location = new System.Drawing.Point(425, 215);
            this.pnlServicio.Name = "pnlServicio";
            this.pnlServicio.Size = new System.Drawing.Size(385, 175);
            this.pnlServicio.TabIndex = 2;
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
            // btnAgregarCarritoServicio
            // 
            this.btnAgregarCarritoServicio.Image = global::Presentation.Properties.Resources.add_shopping_cart_24px;
            this.btnAgregarCarritoServicio.Location = new System.Drawing.Point(106, 130);
            this.btnAgregarCarritoServicio.Name = "btnAgregarCarritoServicio";
            this.btnAgregarCarritoServicio.Size = new System.Drawing.Size(170, 32);
            this.btnAgregarCarritoServicio.TabIndex = 20;
            this.btnAgregarCarritoServicio.Text = "Agregar al Carrito";
            this.btnAgregarCarritoServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCarritoServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCarritoServicio.UseVisualStyleBackColor = true;
            this.btnAgregarCarritoServicio.Click += new System.EventHandler(this.btoAgregarCarritoServicio_Click);
            // 
            // txtCantidadServicio
            // 
            this.txtCantidadServicio.Location = new System.Drawing.Point(160, 87);
            this.txtCantidadServicio.Name = "txtCantidadServicio";
            this.txtCantidadServicio.Size = new System.Drawing.Size(160, 24);
            this.txtCantidadServicio.TabIndex = 26;
            this.txtCantidadServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadServicio_KeyPress);
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
            this.txtCodigoServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoServicio_KeyPress);
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
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Image = global::Presentation.Properties.Resources.search_24px;
            this.btnBuscarServicio.Location = new System.Drawing.Point(332, 13);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarServicio.TabIndex = 21;
            this.btnBuscarServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
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
            // pnlProducto
            // 
            this.pnlProducto.BackColor = System.Drawing.SystemColors.Control;
            this.pnlProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducto.Controls.Add(this.lblCantidadProducto);
            this.pnlProducto.Controls.Add(this.txtCantidadProducto);
            this.pnlProducto.Controls.Add(this.btnAgregarCarritoProducto);
            this.pnlProducto.Controls.Add(this.lblNombreProductoT);
            this.pnlProducto.Controls.Add(this.lblNombreProductoL);
            this.pnlProducto.Controls.Add(this.btnBuscarProducto);
            this.pnlProducto.Controls.Add(this.txtCodigoProducto);
            this.pnlProducto.Controls.Add(this.lblCodigoProducto);
            this.pnlProducto.Location = new System.Drawing.Point(425, 20);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(385, 175);
            this.pnlProducto.TabIndex = 1;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Location = new System.Drawing.Point(20, 90);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(70, 18);
            this.lblCantidadProducto.TabIndex = 19;
            this.lblCantidadProducto.Text = "Cantidad:";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(160, 87);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(160, 24);
            this.txtCantidadProducto.TabIndex = 18;
            this.txtCantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadProducto_KeyPress);
            // 
            // btnAgregarCarritoProducto
            // 
            this.btnAgregarCarritoProducto.Image = global::Presentation.Properties.Resources.add_shopping_cart_24px;
            this.btnAgregarCarritoProducto.Location = new System.Drawing.Point(106, 130);
            this.btnAgregarCarritoProducto.Name = "btnAgregarCarritoProducto";
            this.btnAgregarCarritoProducto.Size = new System.Drawing.Size(170, 32);
            this.btnAgregarCarritoProducto.TabIndex = 15;
            this.btnAgregarCarritoProducto.Text = "Agregar al Carrito";
            this.btnAgregarCarritoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCarritoProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCarritoProducto.UseVisualStyleBackColor = true;
            this.btnAgregarCarritoProducto.Click += new System.EventHandler(this.btoAgregarCarritoProducto_Click);
            // 
            // lblNombreProductoT
            // 
            this.lblNombreProductoT.AutoSize = true;
            this.lblNombreProductoT.Location = new System.Drawing.Point(157, 55);
            this.lblNombreProductoT.Name = "lblNombreProductoT";
            this.lblNombreProductoT.Size = new System.Drawing.Size(127, 18);
            this.lblNombreProductoT.TabIndex = 17;
            this.lblNombreProductoT.Text = "Nombre Producto";
            // 
            // lblNombreProductoL
            // 
            this.lblNombreProductoL.AutoSize = true;
            this.lblNombreProductoL.Location = new System.Drawing.Point(20, 55);
            this.lblNombreProductoL.Name = "lblNombreProductoL";
            this.lblNombreProductoL.Size = new System.Drawing.Size(131, 18);
            this.lblNombreProductoL.TabIndex = 16;
            this.lblNombreProductoL.Text = "Nombre Producto:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::Presentation.Properties.Resources.search_24px;
            this.btnBuscarProducto.Location = new System.Drawing.Point(332, 13);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarProducto.TabIndex = 15;
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(160, 17);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(160, 24);
            this.txtCodigoProducto.TabIndex = 15;
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(20, 20);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(125, 18);
            this.lblCodigoProducto.TabIndex = 15;
            this.lblCodigoProducto.Text = "Código Producto:";
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.btnRealizarCompra);
            this.pnlInformacion.Controls.Add(this.lblTotalT);
            this.pnlInformacion.Controls.Add(this.lblSubtotalT);
            this.pnlInformacion.Controls.Add(this.lblColon2);
            this.pnlInformacion.Controls.Add(this.lblIVAT);
            this.pnlInformacion.Controls.Add(this.lblColon1);
            this.pnlInformacion.Controls.Add(this.lblTotalL);
            this.pnlInformacion.Controls.Add(this.lblIVAL);
            this.pnlInformacion.Controls.Add(this.lblSubtotalL);
            this.pnlInformacion.Controls.Add(this.txtCedulaCliente);
            this.pnlInformacion.Controls.Add(this.lblCedulaCliente);
            this.pnlInformacion.Controls.Add(this.lblNombreVendedorT);
            this.pnlInformacion.Controls.Add(this.lblNombreVendedorL);
            this.pnlInformacion.Controls.Add(this.lblCodigoVendedorT);
            this.pnlInformacion.Controls.Add(this.lblCodigoVendedorL);
            this.pnlInformacion.Location = new System.Drawing.Point(20, 60);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(385, 330);
            this.pnlInformacion.TabIndex = 0;
            // 
            // btnRealizarCompra
            // 
            this.btnRealizarCompra.Image = global::Presentation.Properties.Resources.buy_24px;
            this.btnRealizarCompra.Location = new System.Drawing.Point(106, 285);
            this.btnRealizarCompra.Name = "btnRealizarCompra";
            this.btnRealizarCompra.Size = new System.Drawing.Size(170, 32);
            this.btnRealizarCompra.TabIndex = 14;
            this.btnRealizarCompra.Text = "Realizar Compra";
            this.btnRealizarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRealizarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealizarCompra.UseVisualStyleBackColor = true;
            this.btnRealizarCompra.Click += new System.EventHandler(this.btoRealizarCompra_Click);
            // 
            // lblTotalT
            // 
            this.lblTotalT.AutoSize = true;
            this.lblTotalT.Location = new System.Drawing.Point(183, 230);
            this.lblTotalT.Name = "lblTotalT";
            this.lblTotalT.Size = new System.Drawing.Size(36, 18);
            this.lblTotalT.TabIndex = 13;
            this.lblTotalT.Text = "0.00";
            // 
            // lblSubtotalT
            // 
            this.lblSubtotalT.AutoSize = true;
            this.lblSubtotalT.Location = new System.Drawing.Point(183, 150);
            this.lblSubtotalT.Name = "lblSubtotalT";
            this.lblSubtotalT.Size = new System.Drawing.Size(36, 18);
            this.lblSubtotalT.TabIndex = 12;
            this.lblSubtotalT.Text = "0.00";
            // 
            // lblColon2
            // 
            this.lblColon2.AutoSize = true;
            this.lblColon2.Location = new System.Drawing.Point(158, 230);
            this.lblColon2.Name = "lblColon2";
            this.lblColon2.Size = new System.Drawing.Size(19, 18);
            this.lblColon2.TabIndex = 11;
            this.lblColon2.Text = "₡";
            // 
            // lblIVAT
            // 
            this.lblIVAT.AutoSize = true;
            this.lblIVAT.Location = new System.Drawing.Point(183, 190);
            this.lblIVAT.Name = "lblIVAT";
            this.lblIVAT.Size = new System.Drawing.Size(37, 18);
            this.lblIVAT.TabIndex = 10;
            this.lblIVAT.Text = "13%";
            // 
            // lblColon1
            // 
            this.lblColon1.AutoSize = true;
            this.lblColon1.Location = new System.Drawing.Point(159, 150);
            this.lblColon1.Name = "lblColon1";
            this.lblColon1.Size = new System.Drawing.Size(19, 18);
            this.lblColon1.TabIndex = 9;
            this.lblColon1.Text = "₡";
            // 
            // lblTotalL
            // 
            this.lblTotalL.AutoSize = true;
            this.lblTotalL.Location = new System.Drawing.Point(20, 230);
            this.lblTotalL.Name = "lblTotalL";
            this.lblTotalL.Size = new System.Drawing.Size(45, 18);
            this.lblTotalL.TabIndex = 8;
            this.lblTotalL.Text = "Total:";
            // 
            // lblIVAL
            // 
            this.lblIVAL.AutoSize = true;
            this.lblIVAL.Location = new System.Drawing.Point(20, 190);
            this.lblIVAL.Name = "lblIVAL";
            this.lblIVAL.Size = new System.Drawing.Size(33, 18);
            this.lblIVAL.TabIndex = 7;
            this.lblIVAL.Text = "IVA:";
            // 
            // lblSubtotalL
            // 
            this.lblSubtotalL.AutoSize = true;
            this.lblSubtotalL.Location = new System.Drawing.Point(20, 150);
            this.lblSubtotalL.Name = "lblSubtotalL";
            this.lblSubtotalL.Size = new System.Drawing.Size(66, 18);
            this.lblSubtotalL.TabIndex = 6;
            this.lblSubtotalL.Text = "Subtotal:";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Location = new System.Drawing.Point(162, 110);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(202, 24);
            this.txtCedulaCliente.TabIndex = 5;
            this.txtCedulaCliente.Enter += new System.EventHandler(this.txtCedulaCliente_Enter);
            this.txtCedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaCliente_KeyPress);
            this.txtCedulaCliente.Leave += new System.EventHandler(this.txtCedulaCliente_Leave);
            // 
            // lblCedulaCliente
            // 
            this.lblCedulaCliente.AutoSize = true;
            this.lblCedulaCliente.Location = new System.Drawing.Point(20, 110);
            this.lblCedulaCliente.Name = "lblCedulaCliente";
            this.lblCedulaCliente.Size = new System.Drawing.Size(107, 18);
            this.lblCedulaCliente.TabIndex = 4;
            this.lblCedulaCliente.Text = "Cédula Cliente:";
            // 
            // lblNombreVendedorT
            // 
            this.lblNombreVendedorT.AutoSize = true;
            this.lblNombreVendedorT.Location = new System.Drawing.Point(159, 70);
            this.lblNombreVendedorT.Name = "lblNombreVendedorT";
            this.lblNombreVendedorT.Size = new System.Drawing.Size(129, 18);
            this.lblNombreVendedorT.TabIndex = 3;
            this.lblNombreVendedorT.Text = "Nombre Vendedor";
            // 
            // lblNombreVendedorL
            // 
            this.lblNombreVendedorL.AutoSize = true;
            this.lblNombreVendedorL.Location = new System.Drawing.Point(20, 70);
            this.lblNombreVendedorL.Name = "lblNombreVendedorL";
            this.lblNombreVendedorL.Size = new System.Drawing.Size(133, 18);
            this.lblNombreVendedorL.TabIndex = 2;
            this.lblNombreVendedorL.Text = "Nombre Vendedor:";
            // 
            // lblCodigoVendedorT
            // 
            this.lblCodigoVendedorT.AutoSize = true;
            this.lblCodigoVendedorT.Location = new System.Drawing.Point(159, 30);
            this.lblCodigoVendedorT.Name = "lblCodigoVendedorT";
            this.lblCodigoVendedorT.Size = new System.Drawing.Size(67, 18);
            this.lblCodigoVendedorT.TabIndex = 1;
            this.lblCodigoVendedorT.Text = "VEN-000";
            // 
            // lblCodigoVendedorL
            // 
            this.lblCodigoVendedorL.AutoSize = true;
            this.lblCodigoVendedorL.Location = new System.Drawing.Point(20, 30);
            this.lblCodigoVendedorL.Name = "lblCodigoVendedorL";
            this.lblCodigoVendedorL.Size = new System.Drawing.Size(127, 18);
            this.lblCodigoVendedorL.TabIndex = 0;
            this.lblCodigoVendedorL.Text = "Código Vendedor:";
            // 
            // tpgCarritoCompras
            // 
            this.tpgCarritoCompras.BackColor = System.Drawing.SystemColors.Control;
            this.tpgCarritoCompras.Controls.Add(this.btnEliminar);
            this.tpgCarritoCompras.Controls.Add(this.dgvCarritoCompras);
            this.tpgCarritoCompras.Location = new System.Drawing.Point(4, 27);
            this.tpgCarritoCompras.Name = "tpgCarritoCompras";
            this.tpgCarritoCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCarritoCompras.Size = new System.Drawing.Size(830, 410);
            this.tpgCarritoCompras.TabIndex = 3;
            this.tpgCarritoCompras.Text = "Ver Carrito de Compras";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Presentation.Properties.Resources.clear_shopping_cart_24px;
            this.btnEliminar.Location = new System.Drawing.Point(592, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(230, 32);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Producto/Servicio";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.dgvCarritoCompras.TabIndex = 0;
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.Image = global::Presentation.Properties.Resources.shopping_cart_24px;
            this.btnNuevaOrden.Location = new System.Drawing.Point(215, 20);
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.Size = new System.Drawing.Size(190, 32);
            this.btnNuevaOrden.TabIndex = 17;
            this.btnNuevaOrden.Text = "Nueva Orden";
            this.btnNuevaOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaOrden.UseVisualStyleBackColor = true;
            this.btnNuevaOrden.Click += new System.EventHandler(this.btnNuevaOrden_Click);
            // 
            // WindowSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vendedor";
            this.tabControl.ResumeLayout(false);
            this.tpgConsultaProductos.ResumeLayout(false);
            this.tpgConsultaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProducto)).EndInit();
            this.tpgConsultaServicios.ResumeLayout(false);
            this.tpgConsultaServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaServicio)).EndInit();
            this.tpgTomarOrden.ResumeLayout(false);
            this.pnlServicio.ResumeLayout(false);
            this.pnlServicio.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.tpgCarritoCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpgConsultaProductos;
        private System.Windows.Forms.TabPage tpgTomarOrden;
        private System.Windows.Forms.DataGridView dgvConsultaProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.ComboBox cboCategoriaProducto;
        private System.Windows.Forms.TabPage tpgConsultaServicios;
        private System.Windows.Forms.TabPage tpgCarritoCompras;
        private System.Windows.Forms.DataGridView dgvConsultaServicio;
        private System.Windows.Forms.TextBox txtBuscarServicio;
        private System.Windows.Forms.ComboBox cboCategoriaServicio;
        private System.Windows.Forms.DataGridView dgvCarritoCompras;
        private System.Windows.Forms.Panel pnlServicio;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label lblCodigoVendedorL;
        private System.Windows.Forms.Label lblTotalT;
        private System.Windows.Forms.Label lblSubtotalT;
        private System.Windows.Forms.Label lblColon2;
        private System.Windows.Forms.Label lblIVAT;
        private System.Windows.Forms.Label lblColon1;
        private System.Windows.Forms.Label lblTotalL;
        private System.Windows.Forms.Label lblIVAL;
        private System.Windows.Forms.Label lblSubtotalL;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Label lblCedulaCliente;
        private System.Windows.Forms.Label lblNombreVendedorT;
        private System.Windows.Forms.Label lblNombreVendedorL;
        private System.Windows.Forms.Label lblCodigoVendedorT;
        private System.Windows.Forms.Button btnRealizarCompra;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Button btnAgregarCarritoProducto;
        private System.Windows.Forms.Label lblNombreProductoT;
        private System.Windows.Forms.Label lblNombreProductoL;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label lblCantidadServicio;
        private System.Windows.Forms.Button btnAgregarCarritoServicio;
        private System.Windows.Forms.TextBox txtCantidadServicio;
        private System.Windows.Forms.Label lblCodigoServicio;
        private System.Windows.Forms.TextBox txtCodigoServicio;
        private System.Windows.Forms.Label lblNombreServicioT;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.Label lblNombreServicioL;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnNuevaOrden;
    }
}