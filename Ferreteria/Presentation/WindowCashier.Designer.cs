namespace Presentation
{
    partial class WindowCashier
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.clmpPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpCedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnGenerarFacturaCompleta = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnGenerarFacturaProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmpPedido,
            this.clmpTipo,
            this.clmpId,
            this.clmpCedulaCliente,
            this.clmpPrecioTotal});
            this.dgvPedidos.Location = new System.Drawing.Point(0, 53);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(838, 388);
            this.dgvPedidos.TabIndex = 15;
            // 
            // clmpPedido
            // 
            this.clmpPedido.HeaderText = "Pedido";
            this.clmpPedido.Name = "clmpPedido";
            this.clmpPedido.ReadOnly = true;
            this.clmpPedido.Visible = false;
            // 
            // clmpTipo
            // 
            this.clmpTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmpTipo.HeaderText = "Tipo";
            this.clmpTipo.Name = "clmpTipo";
            this.clmpTipo.ReadOnly = true;
            // 
            // clmpId
            // 
            this.clmpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmpId.HeaderText = "Id";
            this.clmpId.Name = "clmpId";
            this.clmpId.ReadOnly = true;
            // 
            // clmpCedulaCliente
            // 
            this.clmpCedulaCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmpCedulaCliente.HeaderText = "Cédula Cliente";
            this.clmpCedulaCliente.Name = "clmpCedulaCliente";
            this.clmpCedulaCliente.ReadOnly = true;
            // 
            // clmpPrecioTotal
            // 
            this.clmpPrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmpPrecioTotal.HeaderText = "Precio Total";
            this.clmpPrecioTotal.Name = "clmpPrecioTotal";
            this.clmpPrecioTotal.ReadOnly = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = global::Presentation.Properties.Resources.logout_rounded_left_24px;
            this.btnLogOut.Location = new System.Drawing.Point(13, 13);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(151, 32);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnGenerarFacturaCompleta
            // 
            this.btnGenerarFacturaCompleta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerarFacturaCompleta.Image = global::Presentation.Properties.Resources.receipt_24px;
            this.btnGenerarFacturaCompleta.Location = new System.Drawing.Point(410, 13);
            this.btnGenerarFacturaCompleta.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarFacturaCompleta.Name = "btnGenerarFacturaCompleta";
            this.btnGenerarFacturaCompleta.Size = new System.Drawing.Size(230, 32);
            this.btnGenerarFacturaCompleta.TabIndex = 16;
            this.btnGenerarFacturaCompleta.Text = "Generar Factura Completa";
            this.btnGenerarFacturaCompleta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarFacturaCompleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarFacturaCompleta.UseVisualStyleBackColor = true;
            this.btnGenerarFacturaCompleta.Click += new System.EventHandler(this.btnGenerarFacturaCompleta_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(706, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(120, 24);
            this.dtpFecha.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(647, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 18);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnGenerarFacturaProductos
            // 
            this.btnGenerarFacturaProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerarFacturaProductos.Image = global::Presentation.Properties.Resources.receipt_24px;
            this.btnGenerarFacturaProductos.Location = new System.Drawing.Point(172, 13);
            this.btnGenerarFacturaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarFacturaProductos.Name = "btnGenerarFacturaProductos";
            this.btnGenerarFacturaProductos.Size = new System.Drawing.Size(230, 32);
            this.btnGenerarFacturaProductos.TabIndex = 20;
            this.btnGenerarFacturaProductos.Text = "Generar Factura Productos";
            this.btnGenerarFacturaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarFacturaProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarFacturaProductos.UseVisualStyleBackColor = true;
            this.btnGenerarFacturaProductos.Click += new System.EventHandler(this.btnGenerarFacturaProductos_Click);
            // 
            // WindowCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.ControlBox = false;
            this.Controls.Add(this.btnGenerarFacturaProductos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnGenerarFacturaCompleta);
            this.Controls.Add(this.dgvPedidos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cajero";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarFacturaCompleta;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpCedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpPrecioTotal;
        private System.Windows.Forms.Button btnGenerarFacturaProductos;
    }
}