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
            this.pnlFinaliza.SuspendLayout();
            this.pnlInicia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).BeginInit();
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
            this.pnlFinaliza.Location = new System.Drawing.Point(486, 12);
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
            this.pnlInicia.Location = new System.Drawing.Point(150, 12);
            this.pnlInicia.Name = "pnlInicia";
            this.pnlInicia.Size = new System.Drawing.Size(330, 46);
            this.pnlInicia.TabIndex = 8;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogOut.Image = global::Presentation.Properties.Resources.logout_rounded_left_24px;
            this.btnLogOut.Location = new System.Drawing.Point(12, 12);
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
            this.dgvTransportes.Location = new System.Drawing.Point(12, 64);
            this.dgvTransportes.Name = "dgvTransportes";
            this.dgvTransportes.ReadOnly = true;
            this.dgvTransportes.RowHeadersVisible = false;
            this.dgvTransportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransportes.Size = new System.Drawing.Size(814, 365);
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
            // WindowCarrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.ControlBox = false;
            this.Controls.Add(this.dgvTransportes);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pnlInicia);
            this.Controls.Add(this.pnlFinaliza);
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
    }
}