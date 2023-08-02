namespace WindowsFormsApp2
{
    partial class DatosPersonales
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.LBLNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LBLEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.LBLDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.LBLResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLApellido
            // 
            this.LBLApellido.AutoSize = true;
            this.LBLApellido.Location = new System.Drawing.Point(45, 31);
            this.LBLApellido.Name = "LBLApellido";
            this.LBLApellido.Size = new System.Drawing.Size(59, 13);
            this.LBLApellido.TabIndex = 0;
            this.LBLApellido.Text = "APELLIDO\r\n";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(117, 29);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(292, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.Location = new System.Drawing.Point(45, 62);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(54, 13);
            this.LBLNombre.TabIndex = 2;
            this.LBLNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(117, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // LBLEdad
            // 
            this.LBLEdad.AutoSize = true;
            this.LBLEdad.Location = new System.Drawing.Point(45, 97);
            this.LBLEdad.Name = "LBLEdad";
            this.LBLEdad.Size = new System.Drawing.Size(37, 13);
            this.LBLEdad.TabIndex = 4;
            this.LBLEdad.Text = "EDAD";
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Location = new System.Drawing.Point(117, 95);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(59, 20);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // LBLDireccion
            // 
            this.LBLDireccion.AutoSize = true;
            this.LBLDireccion.Location = new System.Drawing.Point(45, 130);
            this.LBLDireccion.Name = "LBLDireccion";
            this.LBLDireccion.Size = new System.Drawing.Size(66, 13);
            this.LBLDireccion.TabIndex = 6;
            this.LBLDireccion.Text = "DIRECCION";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(117, 128);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(291, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // LBLResultado
            // 
            this.LBLResultado.AutoSize = true;
            this.LBLResultado.Location = new System.Drawing.Point(45, 193);
            this.LBLResultado.Name = "LBLResultado";
            this.LBLResultado.Size = new System.Drawing.Size(73, 13);
            this.LBLResultado.TabIndex = 8;
            this.LBLResultado.Text = "RESULTADO";
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResultado.Location = new System.Drawing.Point(48, 209);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(361, 115);
            this.txtResultado.TabIndex = 9;
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNAceptar.Location = new System.Drawing.Point(117, 350);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(72, 23);
            this.BTNAceptar.TabIndex = 10;
            this.BTNAceptar.Text = "Aceptar";
            this.BTNAceptar.UseVisualStyleBackColor = true;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNCancelar.Location = new System.Drawing.Point(241, 350);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(74, 23);
            this.BTNCancelar.TabIndex = 11;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // DatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(532, 385);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNAceptar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.LBLResultado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.LBLDireccion);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.LBLEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LBLNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.LBLApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DatosPersonales";
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LBLEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label LBLDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label LBLResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.Button BTNCancelar;
    }
}

