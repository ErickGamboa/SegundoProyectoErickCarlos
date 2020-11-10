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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.clmpPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpCedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // btnLogOut
            // 
            this.btnLogOut.Image = global::Presentation.Properties.Resources.logout_rounded_left_24px;
            this.btnLogOut.Location = new System.Drawing.Point(13, 13);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(180, 32);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerarFactura.Image = global::Presentation.Properties.Resources.receipt_24px;
            this.btnGenerarFactura.Location = new System.Drawing.Point(329, 13);
            this.btnGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(180, 32);
            this.btnGenerarFactura.TabIndex = 16;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
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
            // WindowCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.ControlBox = false;
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnGenerarFactura);
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

        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpCedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpPrecioTotal;
    }
}