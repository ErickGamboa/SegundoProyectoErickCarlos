namespace Presentation
{
    partial class WindowRegister
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
            this.cbxTipoUsuReg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreReg = new System.Windows.Forms.TextBox();
            this.TxtContraReg = new System.Windows.Forms.TextBox();
            this.BtnVolverLogin = new System.Windows.Forms.Button();
            this.btnRegistrarReg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedulaReg = new System.Windows.Forms.TextBox();
            this.lblMensajeRegistrar = new System.Windows.Forms.Label();
            this.lblEjemploCed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxTipoUsuReg
            // 
            this.cbxTipoUsuReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoUsuReg.FormattingEnabled = true;
            this.cbxTipoUsuReg.Items.AddRange(new object[] {
            "Conductor",
            "Constructor",
            "Vendedor",
            "Cajero",
            "Administrador"});
            this.cbxTipoUsuReg.Location = new System.Drawing.Point(94, 194);
            this.cbxTipoUsuReg.Name = "cbxTipoUsuReg";
            this.cbxTipoUsuReg.Size = new System.Drawing.Size(121, 24);
            this.cbxTipoUsuReg.TabIndex = 0;
            this.cbxTipoUsuReg.Text = "Tipo de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txtNombreReg
            // 
            this.txtNombreReg.Location = new System.Drawing.Point(214, 44);
            this.txtNombreReg.Name = "txtNombreReg";
            this.txtNombreReg.Size = new System.Drawing.Size(147, 20);
            this.txtNombreReg.TabIndex = 3;
            // 
            // TxtContraReg
            // 
            this.TxtContraReg.Location = new System.Drawing.Point(214, 136);
            this.TxtContraReg.Name = "TxtContraReg";
            this.TxtContraReg.PasswordChar = '*';
            this.TxtContraReg.Size = new System.Drawing.Size(147, 20);
            this.TxtContraReg.TabIndex = 4;
            // 
            // BtnVolverLogin
            // 
            this.BtnVolverLogin.Location = new System.Drawing.Point(369, 251);
            this.BtnVolverLogin.Name = "BtnVolverLogin";
            this.BtnVolverLogin.Size = new System.Drawing.Size(82, 23);
            this.BtnVolverLogin.TabIndex = 5;
            this.BtnVolverLogin.Text = "Volver al login";
            this.BtnVolverLogin.UseVisualStyleBackColor = true;
            this.BtnVolverLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarReg
            // 
            this.btnRegistrarReg.Location = new System.Drawing.Point(286, 195);
            this.btnRegistrarReg.Name = "btnRegistrarReg";
            this.btnRegistrarReg.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarReg.TabIndex = 6;
            this.btnRegistrarReg.Text = "Registrar";
            this.btnRegistrarReg.UseVisualStyleBackColor = true;
            this.btnRegistrarReg.Click += new System.EventHandler(this.btnRegistrarReg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cédula";
            // 
            // txtCedulaReg
            // 
            this.txtCedulaReg.Location = new System.Drawing.Point(214, 91);
            this.txtCedulaReg.Name = "txtCedulaReg";
            this.txtCedulaReg.Size = new System.Drawing.Size(147, 20);
            this.txtCedulaReg.TabIndex = 8;
            // 
            // lblMensajeRegistrar
            // 
            this.lblMensajeRegistrar.AutoSize = true;
            this.lblMensajeRegistrar.Location = new System.Drawing.Point(91, 251);
            this.lblMensajeRegistrar.Name = "lblMensajeRegistrar";
            this.lblMensajeRegistrar.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeRegistrar.TabIndex = 9;
            // 
            // lblEjemploCed
            // 
            this.lblEjemploCed.AutoSize = true;
            this.lblEjemploCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemploCed.Location = new System.Drawing.Point(229, 114);
            this.lblEjemploCed.Name = "lblEjemploCed";
            this.lblEjemploCed.Size = new System.Drawing.Size(0, 13);
            this.lblEjemploCed.TabIndex = 10;
            // 
            // WindowRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 286);
            this.Controls.Add(this.lblEjemploCed);
            this.Controls.Add(this.lblMensajeRegistrar);
            this.Controls.Add(this.txtCedulaReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrarReg);
            this.Controls.Add(this.BtnVolverLogin);
            this.Controls.Add(this.TxtContraReg);
            this.Controls.Add(this.txtNombreReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTipoUsuReg);
            this.Name = "WindowRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoUsuReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreReg;
        private System.Windows.Forms.TextBox TxtContraReg;
        private System.Windows.Forms.Button BtnVolverLogin;
        private System.Windows.Forms.Button btnRegistrarReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedulaReg;
        private System.Windows.Forms.Label lblMensajeRegistrar;
        private System.Windows.Forms.Label lblEjemploCed;
    }
}