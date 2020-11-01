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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpInicia
            // 
            this.dtpInicia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpInicia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInicia.Location = new System.Drawing.Point(150, 88);
            this.dtpInicia.Name = "dtpInicia";
            this.dtpInicia.Size = new System.Drawing.Size(110, 24);
            this.dtpInicia.TabIndex = 0;
            this.dtpInicia.Value = new System.DateTime(2020, 11, 1, 14, 32, 50, 0);
            // 
            // lblInicia
            // 
            this.lblInicia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInicia.AutoSize = true;
            this.lblInicia.Location = new System.Drawing.Point(42, 91);
            this.lblInicia.Name = "lblInicia";
            this.lblInicia.Size = new System.Drawing.Size(82, 18);
            this.lblInicia.TabIndex = 1;
            this.lblInicia.Text = "Hora inicia:";
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarInicio.Image = global::Presentation.Properties.Resources.clock_24px;
            this.btnAgregarInicio.Location = new System.Drawing.Point(274, 86);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(110, 32);
            this.btnAgregarInicio.TabIndex = 2;
            this.btnAgregarInicio.Text = "Agregar";
            this.btnAgregarInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFin
            // 
            this.btnAgregarFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarFin.Image = global::Presentation.Properties.Resources.clock_24px;
            this.btnAgregarFin.Location = new System.Drawing.Point(274, 136);
            this.btnAgregarFin.Name = "btnAgregarFin";
            this.btnAgregarFin.Size = new System.Drawing.Size(110, 32);
            this.btnAgregarFin.TabIndex = 5;
            this.btnAgregarFin.Text = "Agregar";
            this.btnAgregarFin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarFin.UseVisualStyleBackColor = true;
            // 
            // lblFinaliza
            // 
            this.lblFinaliza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFinaliza.AutoSize = true;
            this.lblFinaliza.Location = new System.Drawing.Point(42, 141);
            this.lblFinaliza.Name = "lblFinaliza";
            this.lblFinaliza.Size = new System.Drawing.Size(94, 18);
            this.lblFinaliza.TabIndex = 4;
            this.lblFinaliza.Text = "Hora finaliza:";
            // 
            // dtpFinaliza
            // 
            this.dtpFinaliza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFinaliza.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinaliza.Location = new System.Drawing.Point(150, 138);
            this.dtpFinaliza.Name = "dtpFinaliza";
            this.dtpFinaliza.Size = new System.Drawing.Size(110, 24);
            this.dtpFinaliza.TabIndex = 3;
            this.dtpFinaliza.Value = new System.DateTime(2020, 11, 1, 14, 32, 50, 0);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DarkMagenta;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(410, 50);
            this.pnlTitulo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(73, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 25);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "ESTADO TRANSPORTE";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindowCarrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 201);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.btnAgregarFin);
            this.Controls.Add(this.lblFinaliza);
            this.Controls.Add(this.dtpFinaliza);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.lblInicia);
            this.Controls.Add(this.dtpInicia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowCarrier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transportista";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicia;
        private System.Windows.Forms.Label lblInicia;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnAgregarFin;
        private System.Windows.Forms.Label lblFinaliza;
        private System.Windows.Forms.DateTimePicker dtpFinaliza;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}