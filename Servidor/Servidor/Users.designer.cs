namespace Servidor
{
    partial class fmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmUsers));
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.cbDelegacion = new System.Windows.Forms.ComboBox();
            this.cbSede = new System.Windows.Forms.ComboBox();
            this.tbFecha = new System.Windows.Forms.DateTimePicker();
            this.pNuevoModificarEliminar = new System.Windows.Forms.Panel();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.pGuardarActualizarCancelarSalir = new System.Windows.Forms.Panel();
            this.btSalir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbDelegacion = new System.Windows.Forms.TextBox();
            this.tbSede = new System.Windows.Forms.TextBox();
            this.pDatos = new System.Windows.Forms.Panel();
            this.pbOjo = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbContrasenya = new System.Windows.Forms.TextBox();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pNuevoModificarEliminar.SuspendLayout();
            this.pGuardarActualizarCancelarSalir.SuspendLayout();
            this.pDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOjo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.ItemHeight = 16;
            this.lbUsuarios.Location = new System.Drawing.Point(12, 12);
            this.lbUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(275, 484);
            this.lbUsuarios.TabIndex = 0;
            this.lbUsuarios.SelectedIndexChanged += new System.EventHandler(this.lbUsuarios_SelectedIndexChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(167, 11);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(60, 22);
            this.tbCodigo.TabIndex = 1;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(167, 87);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(117, 22);
            this.tbDNI.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(167, 49);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(205, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(167, 163);
            this.cbPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(205, 24);
            this.cbPais.TabIndex = 4;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(167, 203);
            this.cbCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(205, 24);
            this.cbCiudad.TabIndex = 5;
            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.cbCiudad_SelectedIndexChanged);
            // 
            // cbDelegacion
            // 
            this.cbDelegacion.FormattingEnabled = true;
            this.cbDelegacion.Location = new System.Drawing.Point(167, 243);
            this.cbDelegacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDelegacion.Name = "cbDelegacion";
            this.cbDelegacion.Size = new System.Drawing.Size(205, 24);
            this.cbDelegacion.TabIndex = 6;
            this.cbDelegacion.SelectedIndexChanged += new System.EventHandler(this.cbDelegacion_SelectedIndexChanged);
            // 
            // cbSede
            // 
            this.cbSede.FormattingEnabled = true;
            this.cbSede.Location = new System.Drawing.Point(167, 283);
            this.cbSede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSede.Name = "cbSede";
            this.cbSede.Size = new System.Drawing.Size(205, 24);
            this.cbSede.TabIndex = 7;
            this.cbSede.SelectedIndexChanged += new System.EventHandler(this.cbSede_SelectedIndexChanged);
            // 
            // tbFecha
            // 
            this.tbFecha.CustomFormat = "";
            this.tbFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbFecha.Location = new System.Drawing.Point(167, 125);
            this.tbFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(205, 22);
            this.tbFecha.TabIndex = 3;
            // 
            // pNuevoModificarEliminar
            // 
            this.pNuevoModificarEliminar.Controls.Add(this.btEliminar);
            this.pNuevoModificarEliminar.Controls.Add(this.btModificar);
            this.pNuevoModificarEliminar.Controls.Add(this.btNuevo);
            this.pNuevoModificarEliminar.Location = new System.Drawing.Point(706, 32);
            this.pNuevoModificarEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pNuevoModificarEliminar.Name = "pNuevoModificarEliminar";
            this.pNuevoModificarEliminar.Size = new System.Drawing.Size(125, 187);
            this.pNuevoModificarEliminar.TabIndex = 9;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(16, 134);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(90, 40);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(16, 75);
            this.btModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(90, 40);
            this.btModificar.TabIndex = 1;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(16, 14);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(90, 40);
            this.btNuevo.TabIndex = 0;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // pGuardarActualizarCancelarSalir
            // 
            this.pGuardarActualizarCancelarSalir.Controls.Add(this.btSalir);
            this.pGuardarActualizarCancelarSalir.Controls.Add(this.btCancelar);
            this.pGuardarActualizarCancelarSalir.Controls.Add(this.btActualizar);
            this.pGuardarActualizarCancelarSalir.Controls.Add(this.btGuardar);
            this.pGuardarActualizarCancelarSalir.Location = new System.Drawing.Point(706, 232);
            this.pGuardarActualizarCancelarSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pGuardarActualizarCancelarSalir.Name = "pGuardarActualizarCancelarSalir";
            this.pGuardarActualizarCancelarSalir.Size = new System.Drawing.Size(125, 245);
            this.pGuardarActualizarCancelarSalir.TabIndex = 10;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(16, 192);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(90, 40);
            this.btSalir.TabIndex = 13;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(16, 133);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(90, 40);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(16, 69);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(90, 40);
            this.btActualizar.TabIndex = 1;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(16, 4);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(90, 40);
            this.btGuardar.TabIndex = 11;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(167, 399);
            this.tbObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(205, 46);
            this.tbObservaciones.TabIndex = 10;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(109, 203);
            this.tbPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(33, 22);
            this.tbPais.TabIndex = 12;
            this.tbPais.Visible = false;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(109, 243);
            this.tbCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(33, 22);
            this.tbCiudad.TabIndex = 13;
            this.tbCiudad.Visible = false;
            // 
            // tbDelegacion
            // 
            this.tbDelegacion.Location = new System.Drawing.Point(109, 282);
            this.tbDelegacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDelegacion.Name = "tbDelegacion";
            this.tbDelegacion.Size = new System.Drawing.Size(34, 22);
            this.tbDelegacion.TabIndex = 14;
            this.tbDelegacion.Visible = false;
            // 
            // tbSede
            // 
            this.tbSede.Location = new System.Drawing.Point(109, 323);
            this.tbSede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSede.Name = "tbSede";
            this.tbSede.Size = new System.Drawing.Size(33, 22);
            this.tbSede.TabIndex = 15;
            this.tbSede.Visible = false;
            // 
            // pDatos
            // 
            this.pDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDatos.Controls.Add(this.pbOjo);
            this.pDatos.Controls.Add(this.label12);
            this.pDatos.Controls.Add(this.label11);
            this.pDatos.Controls.Add(this.tbContrasenya);
            this.pDatos.Controls.Add(this.tbNick);
            this.pDatos.Controls.Add(this.label10);
            this.pDatos.Controls.Add(this.label9);
            this.pDatos.Controls.Add(this.label8);
            this.pDatos.Controls.Add(this.label7);
            this.pDatos.Controls.Add(this.label6);
            this.pDatos.Controls.Add(this.label5);
            this.pDatos.Controls.Add(this.label4);
            this.pDatos.Controls.Add(this.label3);
            this.pDatos.Controls.Add(this.label2);
            this.pDatos.Controls.Add(this.label1);
            this.pDatos.Controls.Add(this.tbObservaciones);
            this.pDatos.Controls.Add(this.tbSede);
            this.pDatos.Controls.Add(this.tbCodigo);
            this.pDatos.Controls.Add(this.tbDelegacion);
            this.pDatos.Controls.Add(this.tbNombre);
            this.pDatos.Controls.Add(this.cbSede);
            this.pDatos.Controls.Add(this.tbCiudad);
            this.pDatos.Controls.Add(this.tbDNI);
            this.pDatos.Controls.Add(this.tbPais);
            this.pDatos.Controls.Add(this.cbDelegacion);
            this.pDatos.Controls.Add(this.cbPais);
            this.pDatos.Controls.Add(this.tbFecha);
            this.pDatos.Controls.Add(this.cbCiudad);
            this.pDatos.Location = new System.Drawing.Point(293, 12);
            this.pDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDatos.Name = "pDatos";
            this.pDatos.Size = new System.Drawing.Size(407, 481);
            this.pDatos.TabIndex = 16;
            // 
            // pbOjo
            // 
            this.pbOjo.Image = global::Servidor.Properties.Resources.ojo;
            this.pbOjo.Location = new System.Drawing.Point(347, 361);
            this.pbOjo.Name = "pbOjo";
            this.pbOjo.Size = new System.Drawing.Size(24, 22);
            this.pbOjo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOjo.TabIndex = 29;
            this.pbOjo.TabStop = false;
            this.pbOjo.Click += new System.EventHandler(this.pbOjo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 453);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(274, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "* Los campos con asterisco son obligatorios.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Observaciones";
            // 
            // tbContrasenya
            // 
            this.tbContrasenya.Location = new System.Drawing.Point(167, 361);
            this.tbContrasenya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContrasenya.Name = "tbContrasenya";
            this.tbContrasenya.Size = new System.Drawing.Size(174, 22);
            this.tbContrasenya.TabIndex = 9;
            this.tbContrasenya.UseSystemPasswordChar = true;
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(167, 323);
            this.tbNick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(205, 22);
            this.tbNick.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "*Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "*Fecha de Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "*Nick";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "*Sede";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "*Delegación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "*Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "*Pais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "*DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "*Nombre Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "*Código";
            // 
            // fmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 504);
            this.Controls.Add(this.pGuardarActualizarCancelarSalir);
            this.Controls.Add(this.pNuevoModificarEliminar);
            this.Controls.Add(this.pDatos);
            this.Controls.Add(this.lbUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(864, 551);
            this.MinimumSize = new System.Drawing.Size(864, 551);
            this.Name = "fmUsers";
            this.Text = "Mantenimiento de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.fmUsuarios_Load);
            this.pNuevoModificarEliminar.ResumeLayout(false);
            this.pGuardarActualizarCancelarSalir.ResumeLayout(false);
            this.pDatos.ResumeLayout(false);
            this.pDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOjo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.ComboBox cbDelegacion;
        private System.Windows.Forms.ComboBox cbSede;
        private System.Windows.Forms.DateTimePicker tbFecha;
        private System.Windows.Forms.Panel pNuevoModificarEliminar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Panel pGuardarActualizarCancelarSalir;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbDelegacion;
        private System.Windows.Forms.TextBox tbSede;
        private System.Windows.Forms.Panel pDatos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbContrasenya;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbOjo;
    }
}