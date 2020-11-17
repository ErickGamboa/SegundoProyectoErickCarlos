namespace Presentation
{
    partial class WindowCarrier
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
            this.dtpInicia = new System.Windows.Forms.DateTimePicker();
            this.lblInicia = new System.Windows.Forms.Label();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.btnAgregarFin = new System.Windows.Forms.Button();
            this.lblFinaliza = new System.Windows.Forms.Label();
            this.dtpFinaliza = new System.Windows.Forms.DateTimePicker();
            this.pnlFinaliza = new System.Windows.Forms.Panel();
            this.pnlInicia = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dgvTransportes = new System.Windows.Forms.DataGridView();
            this.clmpePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpeTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpeInicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpeFinaliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpgTransporte = new System.Windows.Forms.TabPage();
            this.tpgBodega = new System.Windows.Forms.TabPage();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.clmvTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpeRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpeSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlFinaliza.SuspendLayout();
            this.pnlInicia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tpgTransporte.SuspendLayout();
            this.tpgBodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.pnlSalida.SuspendLayout();
            this.pnlTitulo2.SuspendLayout();
            this.pnlTitulo1.SuspendLayout();
            this.pnlRecibido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpInicia
            // 
            this.dtpInicia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpInicia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInicia.Location = new System.Drawing.Point(98, 14);
            this.dtpInicia.Name = "dtpInicia";
            this.dtpInicia.Size = new System.Drawing.Size(110, 24);
            this.dtpInicia.TabIndex = 0;
            this.dtpInicia.Value = new System.DateTime(2020, 11, 1, 14, 32, 50, 0);
            // 
            // lblInicia
            // 
            this.lblInicia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInicia.AutoSize = true;
            this.lblInicia.Location = new System.Drawing.Point(10, 17);
            this.lblInicia.Name = "lblInicia";
            this.lblInicia.Size = new System.Drawing.Size(82, 18);
            this.lblInicia.TabIndex = 1;
            this.lblInicia.Text = "Hora inicia:";
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarInicio.Image = global::Presentation.Properties.Resources.clock_24px;
            this.btnAgregarInicio.Location = new System.Drawing.Point(214, 10);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(100, 32);
            this.btnAgregarInicio.TabIndex = 2;
            this.btnAgregarInicio.Text = "Agregar";
            this.btnAgregarInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // btnAgregarFin
            // 
            this.btnAgregarFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarFin.Image = global::Presentation.Properties.Resources.clock_24px;
            this.btnAgregarFin.Location = new System.Drawing.Point(226, 10);
            this.btnAgregarFin.Name = "btnAgregarFin";
            this.btnAgregarFin.Size = new System.Drawing.Size(100, 32);
            this.btnAgregarFin.TabIndex = 5;
            this.btnAgregarFin.Text = "Agregar";
            this.btnAgregarFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarFin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarFin.UseVisualStyleBackColor = true;
            this.btnAgregarFin.Click += new System.EventHandler(this.btnAgregarFin_Click);
            // 
            // lblFinaliza
            // 
            this.lblFinaliza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFinaliza.AutoSize = true;
            this.lblFinaliza.Location = new System.Drawing.Point(10, 17);
            this.lblFinaliza.Name = "lblFinaliza";
            this.lblFinaliza.Size = new System.Drawing.Size(94, 18);
            this.lblFinaliza.TabIndex = 4;
            this.lblFinaliza.Text = "Hora finaliza:";
            // 
            // dtpFinaliza
            // 
            this.dtpFinaliza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFinaliza.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinaliza.Location = new System.Drawing.Point(110, 14);
            this.dtpFinaliza.Name = "dtpFinaliza";
            this.dtpFinaliza.Size = new System.Drawing.Size(110, 24);
            this.dtpFinaliza.TabIndex = 3;
            this.dtpFinaliza.Value = new System.DateTime(2020, 11, 1, 14, 32, 50, 0);
            // 
            // pnlFinaliza
            // 
            this.pnlFinaliza.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFinaliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFinaliza.Controls.Add(this.dtpFinaliza);
            this.pnlFinaliza.Controls.Add(this.lblFinaliza);
            this.pnlFinaliza.Controls.Add(this.btnAgregarFin);
            this.pnlFinaliza.Location = new System.Drawing.Point(482, 6);
            this.pnlFinaliza.Name = "pnlFinaliza";
            this.pnlFinaliza.Size = new System.Drawing.Size(340, 46);
            this.pnlFinaliza.TabIndex = 7;
            // 
            // pnlInicia
            // 
            this.pnlInicia.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInicia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInicia.Controls.Add(this.lblInicia);
            this.pnlInicia.Controls.Add(this.dtpInicia);
            this.pnlInicia.Controls.Add(this.btnAgregarInicio);
            this.pnlInicia.Location = new System.Drawing.Point(146, 6);
            this.pnlInicia.Name = "pnlInicia";
            this.pnlInicia.Size = new System.Drawing.Size(330, 46);
            this.pnlInicia.TabIndex = 8;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogOut.Image = global::Presentation.Properties.Resources.logout_rounded_left_24px;
            this.btnLogOut.Location = new System.Drawing.Point(8, 6);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(132, 46);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dgvTransportes
            // 
            this.dgvTransportes.AllowUserToAddRows = false;
            this.dgvTransportes.AllowUserToDeleteRows = false;
            this.dgvTransportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransportes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmpePedido,
            this.clmpeTipo,
            this.clmpeId,
            this.clmpeInicia,
            this.clmpeFinaliza});
            this.dgvTransportes.Location = new System.Drawing.Point(8, 58);
            this.dgvTransportes.Name = "dgvTransportes";
            this.dgvTransportes.ReadOnly = true;
            this.dgvTransportes.RowHeadersVisible = false;
            this.dgvTransportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransportes.Size = new System.Drawing.Size(814, 344);
            this.dgvTransportes.TabIndex = 9;
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
            // clmpeInicia
            // 
            this.clmpeInicia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmpeInicia.FillWeight = 15.46391F;
            this.clmpeInicia.HeaderText = "Hora Inicia";
            this.clmpeInicia.Name = "clmpeInicia";
            this.clmpeInicia.ReadOnly = true;
            // 
            // clmpeFinaliza
            // 
            this.clmpeFinaliza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmpeFinaliza.FillWeight = 15.46391F;
            this.clmpeFinaliza.HeaderText = "Hora Finaliza";
            this.clmpeFinaliza.Name = "clmpeFinaliza";
            this.clmpeFinaliza.ReadOnly = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpgTransporte);
            this.tabControl.Controls.Add(this.tpgBodega);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(838, 441);
            this.tabControl.TabIndex = 10;
            // 
            // tpgTransporte
            // 
            this.tpgTransporte.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgTransporte.Controls.Add(this.dgvTransportes);
            this.tpgTransporte.Controls.Add(this.pnlFinaliza);
            this.tpgTransporte.Controls.Add(this.btnLogOut);
            this.tpgTransporte.Controls.Add(this.pnlInicia);
            this.tpgTransporte.Location = new System.Drawing.Point(4, 27);
            this.tpgTransporte.Name = "tpgTransporte";
            this.tpgTransporte.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTransporte.Size = new System.Drawing.Size(830, 410);
            this.tpgTransporte.TabIndex = 3;
            this.tpgTransporte.Text = "Transporte";
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
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(830, 137);
            this.dgvVentas.TabIndex = 5;
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
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.clmpeRecibido,
            this.clmpeSalida});
            this.dgvPedidos.Location = new System.Drawing.Point(0, 100);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(830, 129);
            this.dgvPedidos.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Pedido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.FillWeight = 140F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 140;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.HeaderText = "Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
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
            // WindowCarrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowCarrier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transportista";
            this.pnlFinaliza.ResumeLayout(false);
            this.pnlFinaliza.PerformLayout();
            this.pnlInicia.ResumeLayout(false);
            this.pnlInicia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tpgTransporte.ResumeLayout(false);
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

        private System.Windows.Forms.DateTimePicker dtpInicia;
        private System.Windows.Forms.Label lblInicia;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnAgregarFin;
        private System.Windows.Forms.Label lblFinaliza;
        private System.Windows.Forms.DateTimePicker dtpFinaliza;
        private System.Windows.Forms.Panel pnlFinaliza;
        private System.Windows.Forms.Panel pnlInicia;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dgvTransportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpeTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpeInicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpeFinaliza;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpgTransporte;
        private System.Windows.Forms.TabPage tpgBodega;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvCantidad;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpeRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpeSalida;
        private System.Windows.Forms.Panel pnlSalida;
        private System.Windows.Forms.Button btoSalida;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Panel pnlTitulo2;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Panel pnlTitulo1;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Panel pnlRecibido;
        private System.Windows.Forms.Button btoRecibido;
        private System.Windows.Forms.DateTimePicker dtpRecibido;
        private System.Windows.Forms.Label lblRecibido;
    }
}