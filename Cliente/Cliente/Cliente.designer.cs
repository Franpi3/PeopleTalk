namespace Cliente
{
    partial class Cliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.lbTitulo1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtChatName = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.panelChatear = new System.Windows.Forms.Panel();
            this.TermsConditions = new System.Windows.Forms.Label();
            this.ckCondiciones = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.Info = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelChat = new System.Windows.Forms.Panel();
            this.lbMensajes = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTerms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCopyRight = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChatear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChat.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo1
            // 
            this.lbTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo1.Location = new System.Drawing.Point(35, 55);
            this.lbTitulo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo1.Name = "lbTitulo1";
            this.lbTitulo1.Size = new System.Drawing.Size(121, 29);
            this.lbTitulo1.TabIndex = 3;
            this.lbTitulo1.Text = "Usuario";
            this.lbTitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(105, 46);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(463, 196);
            this.listBox1.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(36, 79);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(133, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChatName
            // 
            this.txtChatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChatName.Location = new System.Drawing.Point(36, 152);
            this.txtChatName.Margin = new System.Windows.Forms.Padding(4);
            this.txtChatName.Name = "txtChatName";
            this.txtChatName.Size = new System.Drawing.Size(133, 22);
            this.txtChatName.TabIndex = 3;
            this.txtChatName.Text = "Grupo1";
            this.txtChatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(347, 234);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(212, 38);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // panelChatear
            // 
            this.panelChatear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelChatear.Controls.Add(this.TermsConditions);
            this.panelChatear.Controls.Add(this.ckCondiciones);
            this.panelChatear.Controls.Add(this.pictureBox1);
            this.panelChatear.Controls.Add(this.label2);
            this.panelChatear.Controls.Add(this.label7);
            this.panelChatear.Controls.Add(this.label6);
            this.panelChatear.Controls.Add(this.txtPassword);
            this.panelChatear.Controls.Add(this.txtIP);
            this.panelChatear.Controls.Add(this.btnConectar);
            this.panelChatear.Controls.Add(this.txtUsuario);
            this.panelChatear.Controls.Add(this.txtChatName);
            this.panelChatear.Controls.Add(this.lbTitulo1);
            this.panelChatear.Location = new System.Drawing.Point(12, 31);
            this.panelChatear.Margin = new System.Windows.Forms.Padding(4);
            this.panelChatear.Name = "panelChatear";
            this.panelChatear.Size = new System.Drawing.Size(577, 338);
            this.panelChatear.TabIndex = 11;
            // 
            // TermsConditions
            // 
            this.TermsConditions.AutoSize = true;
            this.TermsConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermsConditions.Location = new System.Drawing.Point(60, 245);
            this.TermsConditions.Name = "TermsConditions";
            this.TermsConditions.Size = new System.Drawing.Size(227, 16);
            this.TermsConditions.TabIndex = 20;
            this.TermsConditions.Text = "Acepto Términos y Condiciones";
            this.TermsConditions.Click += new System.EventHandler(this.TermsConditions_Click);
            // 
            // ckCondiciones
            // 
            this.ckCondiciones.AutoSize = true;
            this.ckCondiciones.Location = new System.Drawing.Point(36, 245);
            this.ckCondiciones.Name = "ckCondiciones";
            this.ckCondiciones.Size = new System.Drawing.Size(18, 17);
            this.ckCondiciones.TabIndex = 5;
            this.ckCondiciones.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "IP Servidor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre Chat";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Contraseña";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(186, 79);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(133, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(187, 152);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(133, 22);
            this.txtIP.TabIndex = 4;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(105, 250);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensaje.MaxLength = 40;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(355, 22);
            this.txtMensaje.TabIndex = 6;
            this.txtMensaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensaje_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(468, 249);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 27);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.ItemHeight = 16;
            this.lbUsuarios.Location = new System.Drawing.Point(5, 46);
            this.lbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(91, 228);
            this.lbUsuarios.TabIndex = 12;
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.Navy;
            this.Info.Location = new System.Drawing.Point(181, 7);
            this.Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(387, 34);
            this.Info.TabIndex = 13;
            this.Info.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Usuarios";
            // 
            // panelChat
            // 
            this.panelChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelChat.Controls.Add(this.lbMensajes);
            this.panelChat.Controls.Add(this.lbUsuarios);
            this.panelChat.Controls.Add(this.label3);
            this.panelChat.Controls.Add(this.listBox1);
            this.panelChat.Controls.Add(this.Info);
            this.panelChat.Controls.Add(this.btnEnviar);
            this.panelChat.Controls.Add(this.txtMensaje);
            this.panelChat.Location = new System.Drawing.Point(12, 65);
            this.panelChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(577, 289);
            this.panelChat.TabIndex = 15;
            // 
            // lbMensajes
            // 
            this.lbMensajes.AutoSize = true;
            this.lbMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajes.Location = new System.Drawing.Point(107, 21);
            this.lbMensajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMensajes.Name = "lbMensajes";
            this.lbMensajes.Size = new System.Drawing.Size(68, 17);
            this.lbMensajes.TabIndex = 15;
            this.lbMensajes.Text = "Mensajes";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(419, 31);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(171, 30);
            this.btnDesconectar.TabIndex = 16;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.acerdaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(604, 30);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTerms,
            this.tsPolicy,
            this.tsCopyRight});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.toolStripMenuItem1.Text = "Legalidad y Privacidad";
            // 
            // tsTerms
            // 
            this.tsTerms.Name = "tsTerms";
            this.tsTerms.Size = new System.Drawing.Size(248, 26);
            this.tsTerms.Text = "Términos y Condiciones";
            this.tsTerms.Click += new System.EventHandler(this.TermsConditions_Click);
            // 
            // tsPolicy
            // 
            this.tsPolicy.Name = "tsPolicy";
            this.tsPolicy.Size = new System.Drawing.Size(248, 26);
            this.tsPolicy.Text = "Política Privacidad";
            this.tsPolicy.Click += new System.EventHandler(this.tsPolicy_Click);
            // 
            // tsCopyRight
            // 
            this.tsCopyRight.Name = "tsCopyRight";
            this.tsCopyRight.Size = new System.Drawing.Size(248, 26);
            this.tsCopyRight.Text = "CopyRight";
            this.tsCopyRight.Click += new System.EventHandler(this.tsCopyRight_Click);
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.acerdaDeToolStripMenuItem.Text = "Acerca de";
            this.acerdaDeToolStripMenuItem.Click += new System.EventHandler(this.acerdaDeToolStripMenuItem_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(604, 378);
            this.Controls.Add(this.panelChatear);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleTalk Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelChatear.ResumeLayout(false);
            this.panelChatear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChat.ResumeLayout(false);
            this.panelChat.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtChatName;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Panel panelChatear;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Label lbMensajes;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckCondiciones;
        private System.Windows.Forms.Label TermsConditions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsTerms;
        private System.Windows.Forms.ToolStripMenuItem tsPolicy;
        private System.Windows.Forms.ToolStripMenuItem tsCopyRight;
    }
}

