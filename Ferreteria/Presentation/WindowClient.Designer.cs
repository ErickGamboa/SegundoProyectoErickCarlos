namespace Presentation
{
    partial class WindowClient
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
            this.tpgRealizarPedido = new System.Windows.Forms.TabPage();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarCarritoProducto = new System.Windows.Forms.Button();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.pnlCostos = new System.Windows.Forms.Panel();
            this.lblSubtotalL = new System.Windows.Forms.Label();
            this.lblIVAL = new System.Windows.Forms.Label();
            this.lblTotalL = new System.Windows.Forms.Label();
            this.lblColon1 = new System.Windows.Forms.Label();
            this.lblIVAT = new System.Windows.Forms.Label();
            this.lblColon2 = new System.Windows.Forms.Label();
            this.lblTotalT = new System.Windows.Forms.Label();
            this.lblSubtotalT = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRealizarCompra = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCedulaCliente = new System.Windows.Forms.Label();
            this.lblNombreVendedorL = new System.Windows.Forms.Label();
            this.tpgCarritoCompras = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCarritoCompras = new System.Windows.Forms.DataGridView();
            this.cboCategoríaProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboNombreProducto = new System.Windows.Forms.ComboBox();
            this.lblPrecioUnidadProductoL = new System.Windows.Forms.Label();
            this.lblColon3 = new System.Windows.Forms.Label();
            this.lblPrecioUnidadProductoT = new System.Windows.Forms.Label();
            this.lblTotalProductoL = new System.Windows.Forms.Label();
            this.lblColon4 = new System.Windows.Forms.Label();
            this.lblTotalProductoT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblColon6 = new System.Windows.Forms.Label();
            this.lblTotalServicioT = new System.Windows.Forms.Label();
            this.lblTotalServicioL = new System.Windows.Forms.Label();
            this.lblColon5 = new System.Windows.Forms.Label();
            this.lblPrecioUnidadServicioT = new System.Windows.Forms.Label();
            this.lblPrecioUnidadServicioL = new System.Windows.Forms.Label();
            this.cboNombreServicio = new System.Windows.Forms.ComboBox();
            this.lblServicios = new System.Windows.Forms.Label();
            this.cboCategoriaServicio = new System.Windows.Forms.ComboBox();
            this.lblCantidadServicio = new System.Windows.Forms.Label();
            this.txtCantidadServicio = new System.Windows.Forms.TextBox();
            this.btnAgregarCarritoServicio = new System.Windows.Forms.Button();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.lblCategoriaServicio = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpgRealizarPedido.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            this.pnlCostos.SuspendLayout();
            this.tpgCarritoCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCompras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpgRealizarPedido);
            this.tabControl.Controls.Add(this.tpgCarritoCompras);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(838, 441);
            this.tabControl.TabIndex = 1;
            // 
            // tpgRealizarPedido
            // 
            this.tpgRealizarPedido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgRealizarPedido.Controls.Add(this.panel1);
            this.tpgRealizarPedido.Controls.Add(this.pnlProducto);
            this.tpgRealizarPedido.Controls.Add(this.pnlInformacion);
            this.tpgRealizarPedido.Location = new System.Drawing.Point(4, 27);
            this.tpgRealizarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.tpgRealizarPedido.Name = "tpgRealizarPedido";
            this.tpgRealizarPedido.Padding = new System.Windows.Forms.Padding(4);
            this.tpgRealizarPedido.Size = new System.Drawing.Size(830, 410);
            this.tpgRealizarPedido.TabIndex = 1;
            this.tpgRealizarPedido.Text = "Realizar Pedido";
            // 
            // pnlProducto
            // 
            this.pnlProducto.BackColor = System.Drawing.SystemColors.Control;
            this.pnlProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducto.Controls.Add(this.lblColon4);
            this.pnlProducto.Controls.Add(this.lblTotalProductoT);
            this.pnlProducto.Controls.Add(this.lblTotalProductoL);
            this.pnlProducto.Controls.Add(this.lblColon3);
            this.pnlProducto.Controls.Add(this.lblPrecioUnidadProductoT);
            this.pnlProducto.Controls.Add(this.lblPrecioUnidadProductoL);
            this.pnlProducto.Controls.Add(this.cboNombreProducto);
            this.pnlProducto.Controls.Add(this.lblProducto);
            this.pnlProducto.Controls.Add(this.cboCategoríaProducto);
            this.pnlProducto.Controls.Add(this.lblCantidadProducto);
            this.pnlProducto.Controls.Add(this.txtCantidadProducto);
            this.pnlProducto.Controls.Add(this.btnAgregarCarritoProducto);
            this.pnlProducto.Controls.Add(this.lblNombreProducto);
            this.pnlProducto.Controls.Add(this.lblCodigoProducto);
            this.pnlProducto.Location = new System.Drawing.Point(10, 160);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(400, 242);
            this.pnlProducto.TabIndex = 1;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Location = new System.Drawing.Point(220, 125);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(70, 18);
            this.lblCantidadProducto.TabIndex = 19;
            this.lblCantidadProducto.Text = "Cantidad:";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(304, 122);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(75, 24);
            this.txtCantidadProducto.TabIndex = 18;
            // 
            // btnAgregarCarritoProducto
            // 
            this.btnAgregarCarritoProducto.Image = global::Presentation.Properties.Resources.add_shopping_cart_24px;
            this.btnAgregarCarritoProducto.Location = new System.Drawing.Point(106, 190);
            this.btnAgregarCarritoProducto.Name = "btnAgregarCarritoProducto";
            this.btnAgregarCarritoProducto.Size = new System.Drawing.Size(170, 32);
            this.btnAgregarCarritoProducto.TabIndex = 15;
            this.btnAgregarCarritoProducto.Text = "Agregar al Carrito";
            this.btnAgregarCarritoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCarritoProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCarritoProducto.UseVisualStyleBackColor = true;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(20, 90);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(66, 18);
            this.lblNombreProducto.TabIndex = 16;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(20, 55);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(76, 18);
            this.lblCodigoProducto.TabIndex = 15;
            this.lblCodigoProducto.Text = "Categoría:";
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.pnlCostos);
            this.pnlInformacion.Controls.Add(this.txtApellido);
            this.pnlInformacion.Controls.Add(this.lblApellido);
            this.pnlInformacion.Controls.Add(this.txtCedula);
            this.pnlInformacion.Controls.Add(this.btnLogOut);
            this.pnlInformacion.Controls.Add(this.btnRealizarCompra);
            this.pnlInformacion.Controls.Add(this.txtNombre);
            this.pnlInformacion.Controls.Add(this.lblCedulaCliente);
            this.pnlInformacion.Controls.Add(this.lblNombreVendedorL);
            this.pnlInformacion.Location = new System.Drawing.Point(10, 10);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(810, 140);
            this.pnlInformacion.TabIndex = 0;
            // 
            // pnlCostos
            // 
            this.pnlCostos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCostos.Controls.Add(this.lblSubtotalL);
            this.pnlCostos.Controls.Add(this.lblIVAL);
            this.pnlCostos.Controls.Add(this.lblTotalL);
            this.pnlCostos.Controls.Add(this.lblColon1);
            this.pnlCostos.Controls.Add(this.lblIVAT);
            this.pnlCostos.Controls.Add(this.lblColon2);
            this.pnlCostos.Controls.Add(this.lblTotalT);
            this.pnlCostos.Controls.Add(this.lblSubtotalT);
            this.pnlCostos.Location = new System.Drawing.Point(194, 45);
            this.pnlCostos.Name = "pnlCostos";
            this.pnlCostos.Size = new System.Drawing.Size(420, 40);
            this.pnlCostos.TabIndex = 20;
            // 
            // lblSubtotalL
            // 
            this.lblSubtotalL.AutoSize = true;
            this.lblSubtotalL.Location = new System.Drawing.Point(10, 10);
            this.lblSubtotalL.Name = "lblSubtotalL";
            this.lblSubtotalL.Size = new System.Drawing.Size(66, 18);
            this.lblSubtotalL.TabIndex = 6;
            this.lblSubtotalL.Text = "Subtotal:";
            // 
            // lblIVAL
            // 
            this.lblIVAL.AutoSize = true;
            this.lblIVAL.Location = new System.Drawing.Point(189, 10);
            this.lblIVAL.Name = "lblIVAL";
            this.lblIVAL.Size = new System.Drawing.Size(33, 18);
            this.lblIVAL.TabIndex = 7;
            this.lblIVAL.Text = "IVA:";
            // 
            // lblTotalL
            // 
            this.lblTotalL.AutoSize = true;
            this.lblTotalL.Location = new System.Drawing.Point(261, 10);
            this.lblTotalL.Name = "lblTotalL";
            this.lblTotalL.Size = new System.Drawing.Size(45, 18);
            this.lblTotalL.TabIndex = 8;
            this.lblTotalL.Text = "Total:";
            // 
            // lblColon1
            // 
            this.lblColon1.AutoSize = true;
            this.lblColon1.Location = new System.Drawing.Point(82, 10);
            this.lblColon1.Name = "lblColon1";
            this.lblColon1.Size = new System.Drawing.Size(19, 18);
            this.lblColon1.TabIndex = 9;
            this.lblColon1.Text = "₡";
            // 
            // lblIVAT
            // 
            this.lblIVAT.AutoSize = true;
            this.lblIVAT.Location = new System.Drawing.Point(218, 10);
            this.lblIVAT.Name = "lblIVAT";
            this.lblIVAT.Size = new System.Drawing.Size(37, 18);
            this.lblIVAT.TabIndex = 10;
            this.lblIVAT.Text = "13%";
            // 
            // lblColon2
            // 
            this.lblColon2.AutoSize = true;
            this.lblColon2.Location = new System.Drawing.Point(312, 10);
            this.lblColon2.Name = "lblColon2";
            this.lblColon2.Size = new System.Drawing.Size(19, 18);
            this.lblColon2.TabIndex = 11;
            this.lblColon2.Text = "₡";
            // 
            // lblTotalT
            // 
            this.lblTotalT.AutoSize = true;
            this.lblTotalT.Location = new System.Drawing.Point(337, 10);
            this.lblTotalT.Name = "lblTotalT";
            this.lblTotalT.Size = new System.Drawing.Size(36, 18);
            this.lblTotalT.TabIndex = 13;
            this.lblTotalT.Text = "0.00";
            // 
            // lblSubtotalT
            // 
            this.lblSubtotalT.AutoSize = true;
            this.lblSubtotalT.Location = new System.Drawing.Point(107, 10);
            this.lblSubtotalT.Name = "lblSubtotalT";
            this.lblSubtotalT.Size = new System.Drawing.Size(36, 18);
            this.lblSubtotalT.TabIndex = 12;
            this.lblSubtotalT.Text = "0.00";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(609, 10);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(190, 24);
            this.txtApellido.TabIndex = 19;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(522, 13);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(81, 18);
            this.lblApellido.TabIndex = 18;
            this.lblApellido.Text = "Apellido(s):";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(74, 10);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(158, 24);
            this.txtCedula.TabIndex = 17;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = global::Presentation.Properties.Resources.logout_rounded_left_24px;
            this.btnLogOut.Location = new System.Drawing.Point(194, 95);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(205, 32);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Salir";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnRealizarCompra
            // 
            this.btnRealizarCompra.Image = global::Presentation.Properties.Resources.buy_24px;
            this.btnRealizarCompra.Location = new System.Drawing.Point(409, 95);
            this.btnRealizarCompra.Name = "btnRealizarCompra";
            this.btnRealizarCompra.Size = new System.Drawing.Size(205, 32);
            this.btnRealizarCompra.TabIndex = 14;
            this.btnRealizarCompra.Text = "Realizar Compra";
            this.btnRealizarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRealizarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealizarCompra.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(318, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 24);
            this.txtNombre.TabIndex = 5;
            // 
            // lblCedulaCliente
            // 
            this.lblCedulaCliente.AutoSize = true;
            this.lblCedulaCliente.Location = new System.Drawing.Point(10, 13);
            this.lblCedulaCliente.Name = "lblCedulaCliente";
            this.lblCedulaCliente.Size = new System.Drawing.Size(58, 18);
            this.lblCedulaCliente.TabIndex = 4;
            this.lblCedulaCliente.Text = "Cédula:";
            // 
            // lblNombreVendedorL
            // 
            this.lblNombreVendedorL.AutoSize = true;
            this.lblNombreVendedorL.Location = new System.Drawing.Point(246, 13);
            this.lblNombreVendedorL.Name = "lblNombreVendedorL";
            this.lblNombreVendedorL.Size = new System.Drawing.Size(66, 18);
            this.lblNombreVendedorL.TabIndex = 2;
            this.lblNombreVendedorL.Text = "Nombre:";
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
            // cboCategoríaProducto
            // 
            this.cboCategoríaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoríaProducto.FormattingEnabled = true;
            this.cboCategoríaProducto.Location = new System.Drawing.Point(134, 51);
            this.cboCategoríaProducto.Name = "cboCategoríaProducto";
            this.cboCategoríaProducto.Size = new System.Drawing.Size(245, 26);
            this.cboCategoríaProducto.TabIndex = 20;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(147, 10);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(104, 24);
            this.lblProducto.TabIndex = 21;
            this.lblProducto.Text = "Productos";
            // 
            // cboNombreProducto
            // 
            this.cboNombreProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreProducto.FormattingEnabled = true;
            this.cboNombreProducto.Location = new System.Drawing.Point(134, 86);
            this.cboNombreProducto.Name = "cboNombreProducto";
            this.cboNombreProducto.Size = new System.Drawing.Size(245, 26);
            this.cboNombreProducto.TabIndex = 22;
            // 
            // lblPrecioUnidadProductoL
            // 
            this.lblPrecioUnidadProductoL.AutoSize = true;
            this.lblPrecioUnidadProductoL.Location = new System.Drawing.Point(20, 125);
            this.lblPrecioUnidadProductoL.Name = "lblPrecioUnidadProductoL";
            this.lblPrecioUnidadProductoL.Size = new System.Drawing.Size(105, 18);
            this.lblPrecioUnidadProductoL.TabIndex = 23;
            this.lblPrecioUnidadProductoL.Text = "Precio Unidad:";
            // 
            // lblColon3
            // 
            this.lblColon3.AutoSize = true;
            this.lblColon3.Location = new System.Drawing.Point(131, 125);
            this.lblColon3.Name = "lblColon3";
            this.lblColon3.Size = new System.Drawing.Size(19, 18);
            this.lblColon3.TabIndex = 14;
            this.lblColon3.Text = "₡";
            // 
            // lblPrecioUnidadProductoT
            // 
            this.lblPrecioUnidadProductoT.AutoSize = true;
            this.lblPrecioUnidadProductoT.Location = new System.Drawing.Point(156, 125);
            this.lblPrecioUnidadProductoT.Name = "lblPrecioUnidadProductoT";
            this.lblPrecioUnidadProductoT.Size = new System.Drawing.Size(36, 18);
            this.lblPrecioUnidadProductoT.TabIndex = 15;
            this.lblPrecioUnidadProductoT.Text = "0.00";
            // 
            // lblTotalProductoL
            // 
            this.lblTotalProductoL.AutoSize = true;
            this.lblTotalProductoL.Location = new System.Drawing.Point(20, 158);
            this.lblTotalProductoL.Name = "lblTotalProductoL";
            this.lblTotalProductoL.Size = new System.Drawing.Size(45, 18);
            this.lblTotalProductoL.TabIndex = 24;
            this.lblTotalProductoL.Text = "Total:";
            // 
            // lblColon4
            // 
            this.lblColon4.AutoSize = true;
            this.lblColon4.Location = new System.Drawing.Point(131, 158);
            this.lblColon4.Name = "lblColon4";
            this.lblColon4.Size = new System.Drawing.Size(19, 18);
            this.lblColon4.TabIndex = 25;
            this.lblColon4.Text = "₡";
            // 
            // lblTotalProductoT
            // 
            this.lblTotalProductoT.AutoSize = true;
            this.lblTotalProductoT.Location = new System.Drawing.Point(156, 158);
            this.lblTotalProductoT.Name = "lblTotalProductoT";
            this.lblTotalProductoT.Size = new System.Drawing.Size(36, 18);
            this.lblTotalProductoT.TabIndex = 26;
            this.lblTotalProductoT.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblColon6);
            this.panel1.Controls.Add(this.lblTotalServicioT);
            this.panel1.Controls.Add(this.lblTotalServicioL);
            this.panel1.Controls.Add(this.lblColon5);
            this.panel1.Controls.Add(this.lblPrecioUnidadServicioT);
            this.panel1.Controls.Add(this.lblPrecioUnidadServicioL);
            this.panel1.Controls.Add(this.cboNombreServicio);
            this.panel1.Controls.Add(this.lblServicios);
            this.panel1.Controls.Add(this.cboCategoriaServicio);
            this.panel1.Controls.Add(this.lblCantidadServicio);
            this.panel1.Controls.Add(this.txtCantidadServicio);
            this.panel1.Controls.Add(this.btnAgregarCarritoServicio);
            this.panel1.Controls.Add(this.lblNombreServicio);
            this.panel1.Controls.Add(this.lblCategoriaServicio);
            this.panel1.Location = new System.Drawing.Point(420, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 242);
            this.panel1.TabIndex = 27;
            // 
            // lblColon6
            // 
            this.lblColon6.AutoSize = true;
            this.lblColon6.Location = new System.Drawing.Point(131, 158);
            this.lblColon6.Name = "lblColon6";
            this.lblColon6.Size = new System.Drawing.Size(19, 18);
            this.lblColon6.TabIndex = 25;
            this.lblColon6.Text = "₡";
            // 
            // lblTotalServicioT
            // 
            this.lblTotalServicioT.AutoSize = true;
            this.lblTotalServicioT.Location = new System.Drawing.Point(156, 158);
            this.lblTotalServicioT.Name = "lblTotalServicioT";
            this.lblTotalServicioT.Size = new System.Drawing.Size(36, 18);
            this.lblTotalServicioT.TabIndex = 26;
            this.lblTotalServicioT.Text = "0.00";
            // 
            // lblTotalServicioL
            // 
            this.lblTotalServicioL.AutoSize = true;
            this.lblTotalServicioL.Location = new System.Drawing.Point(20, 158);
            this.lblTotalServicioL.Name = "lblTotalServicioL";
            this.lblTotalServicioL.Size = new System.Drawing.Size(45, 18);
            this.lblTotalServicioL.TabIndex = 24;
            this.lblTotalServicioL.Text = "Total:";
            // 
            // lblColon5
            // 
            this.lblColon5.AutoSize = true;
            this.lblColon5.Location = new System.Drawing.Point(131, 125);
            this.lblColon5.Name = "lblColon5";
            this.lblColon5.Size = new System.Drawing.Size(19, 18);
            this.lblColon5.TabIndex = 14;
            this.lblColon5.Text = "₡";
            // 
            // lblPrecioUnidadServicioT
            // 
            this.lblPrecioUnidadServicioT.AutoSize = true;
            this.lblPrecioUnidadServicioT.Location = new System.Drawing.Point(156, 125);
            this.lblPrecioUnidadServicioT.Name = "lblPrecioUnidadServicioT";
            this.lblPrecioUnidadServicioT.Size = new System.Drawing.Size(36, 18);
            this.lblPrecioUnidadServicioT.TabIndex = 15;
            this.lblPrecioUnidadServicioT.Text = "0.00";
            // 
            // lblPrecioUnidadServicioL
            // 
            this.lblPrecioUnidadServicioL.AutoSize = true;
            this.lblPrecioUnidadServicioL.Location = new System.Drawing.Point(20, 125);
            this.lblPrecioUnidadServicioL.Name = "lblPrecioUnidadServicioL";
            this.lblPrecioUnidadServicioL.Size = new System.Drawing.Size(105, 18);
            this.lblPrecioUnidadServicioL.TabIndex = 23;
            this.lblPrecioUnidadServicioL.Text = "Precio Unidad:";
            // 
            // cboNombreServicio
            // 
            this.cboNombreServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreServicio.FormattingEnabled = true;
            this.cboNombreServicio.Location = new System.Drawing.Point(134, 86);
            this.cboNombreServicio.Name = "cboNombreServicio";
            this.cboNombreServicio.Size = new System.Drawing.Size(245, 26);
            this.cboNombreServicio.TabIndex = 22;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicios.Location = new System.Drawing.Point(152, 10);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(95, 24);
            this.lblServicios.TabIndex = 21;
            this.lblServicios.Text = "Servicios";
            // 
            // cboCategoriaServicio
            // 
            this.cboCategoriaServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaServicio.FormattingEnabled = true;
            this.cboCategoriaServicio.Location = new System.Drawing.Point(134, 51);
            this.cboCategoriaServicio.Name = "cboCategoriaServicio";
            this.cboCategoriaServicio.Size = new System.Drawing.Size(245, 26);
            this.cboCategoriaServicio.TabIndex = 20;
            // 
            // lblCantidadServicio
            // 
            this.lblCantidadServicio.AutoSize = true;
            this.lblCantidadServicio.Location = new System.Drawing.Point(220, 125);
            this.lblCantidadServicio.Name = "lblCantidadServicio";
            this.lblCantidadServicio.Size = new System.Drawing.Size(70, 18);
            this.lblCantidadServicio.TabIndex = 19;
            this.lblCantidadServicio.Text = "Cantidad:";
            // 
            // txtCantidadServicio
            // 
            this.txtCantidadServicio.Location = new System.Drawing.Point(304, 122);
            this.txtCantidadServicio.Name = "txtCantidadServicio";
            this.txtCantidadServicio.Size = new System.Drawing.Size(75, 24);
            this.txtCantidadServicio.TabIndex = 18;
            // 
            // btnAgregarCarritoServicio
            // 
            this.btnAgregarCarritoServicio.Image = global::Presentation.Properties.Resources.add_shopping_cart_24px;
            this.btnAgregarCarritoServicio.Location = new System.Drawing.Point(106, 190);
            this.btnAgregarCarritoServicio.Name = "btnAgregarCarritoServicio";
            this.btnAgregarCarritoServicio.Size = new System.Drawing.Size(170, 32);
            this.btnAgregarCarritoServicio.TabIndex = 15;
            this.btnAgregarCarritoServicio.Text = "Agregar al Carrito";
            this.btnAgregarCarritoServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCarritoServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCarritoServicio.UseVisualStyleBackColor = true;
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Location = new System.Drawing.Point(20, 90);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(66, 18);
            this.lblNombreServicio.TabIndex = 16;
            this.lblNombreServicio.Text = "Nombre:";
            // 
            // lblCategoriaServicio
            // 
            this.lblCategoriaServicio.AutoSize = true;
            this.lblCategoriaServicio.Location = new System.Drawing.Point(20, 55);
            this.lblCategoriaServicio.Name = "lblCategoriaServicio";
            this.lblCategoriaServicio.Size = new System.Drawing.Size(76, 18);
            this.lblCategoriaServicio.TabIndex = 15;
            this.lblCategoriaServicio.Text = "Categoría:";
            // 
            // WindowClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.tabControl.ResumeLayout(false);
            this.tpgRealizarPedido.ResumeLayout(false);
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.pnlCostos.ResumeLayout(false);
            this.pnlCostos.PerformLayout();
            this.tpgCarritoCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCompras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpgRealizarPedido;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Button btnAgregarCarritoProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Button btnRealizarCompra;
        private System.Windows.Forms.Label lblTotalT;
        private System.Windows.Forms.Label lblSubtotalT;
        private System.Windows.Forms.Label lblColon2;
        private System.Windows.Forms.Label lblIVAT;
        private System.Windows.Forms.Label lblColon1;
        private System.Windows.Forms.Label lblTotalL;
        private System.Windows.Forms.Label lblIVAL;
        private System.Windows.Forms.Label lblSubtotalL;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCedulaCliente;
        private System.Windows.Forms.Label lblNombreVendedorL;
        private System.Windows.Forms.TabPage tpgCarritoCompras;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCarritoCompras;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel pnlCostos;
        private System.Windows.Forms.Label lblColon3;
        private System.Windows.Forms.Label lblPrecioUnidadProductoT;
        private System.Windows.Forms.Label lblPrecioUnidadProductoL;
        private System.Windows.Forms.ComboBox cboNombreProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboCategoríaProducto;
        private System.Windows.Forms.Label lblTotalProductoL;
        private System.Windows.Forms.Label lblColon4;
        private System.Windows.Forms.Label lblTotalProductoT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblColon6;
        private System.Windows.Forms.Label lblTotalServicioT;
        private System.Windows.Forms.Label lblTotalServicioL;
        private System.Windows.Forms.Label lblColon5;
        private System.Windows.Forms.Label lblPrecioUnidadServicioT;
        private System.Windows.Forms.Label lblPrecioUnidadServicioL;
        private System.Windows.Forms.ComboBox cboNombreServicio;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.ComboBox cboCategoriaServicio;
        private System.Windows.Forms.Label lblCantidadServicio;
        private System.Windows.Forms.TextBox txtCantidadServicio;
        private System.Windows.Forms.Button btnAgregarCarritoServicio;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.Label lblCategoriaServicio;
    }
}