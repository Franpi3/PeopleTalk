namespace Servidor
{
    partial class Servidor_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidor_Chat));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.legalidadYPrivacidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTerms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCopyRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btUsuarios = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btEvents = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 30);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(765, 344);
            this.listBox1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legalidadYPrivacidadToolStripMenuItem,
            this.tsAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(904, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // legalidadYPrivacidadToolStripMenuItem
            // 
            this.legalidadYPrivacidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTerms,
            this.tsPolicy,
            this.tsCopyRight});
            this.legalidadYPrivacidadToolStripMenuItem.Name = "legalidadYPrivacidadToolStripMenuItem";
            this.legalidadYPrivacidadToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.legalidadYPrivacidadToolStripMenuItem.Text = "Legalidad y Privacidad";
            // 
            // tsTerms
            // 
            this.tsTerms.Name = "tsTerms";
            this.tsTerms.Size = new System.Drawing.Size(248, 26);
            this.tsTerms.Text = "Términos y Condiciones";
            this.tsTerms.Click += new System.EventHandler(this.tsTerms_Click);
            // 
            // tsPolicy
            // 
            this.tsPolicy.Name = "tsPolicy";
            this.tsPolicy.Size = new System.Drawing.Size(248, 26);
            this.tsPolicy.Text = "Política de Privacidad";
            this.tsPolicy.Click += new System.EventHandler(this.tsPolicy_Click);
            // 
            // tsCopyRight
            // 
            this.tsCopyRight.Name = "tsCopyRight";
            this.tsCopyRight.Size = new System.Drawing.Size(248, 26);
            this.tsCopyRight.Text = "CopyRight";
            this.tsCopyRight.Click += new System.EventHandler(this.tsCopyRight_Click);
            // 
            // tsAcercaDe
            // 
            this.tsAcercaDe.Name = "tsAcercaDe";
            this.tsAcercaDe.Size = new System.Drawing.Size(89, 24);
            this.tsAcercaDe.Text = "Acerca de";
            this.tsAcercaDe.Click += new System.EventHandler(this.tsAcercaDe_Click);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.SystemColors.Window;
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.Color.Maroon;
            this.txtIP.Location = new System.Drawing.Point(773, 7);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(133, 16);
            this.txtIP.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(672, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 16);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "IP Servidor:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btUsuarios);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btEvents);
            this.panel1.Location = new System.Drawing.Point(774, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 343);
            this.panel1.TabIndex = 17;
            // 
            // btUsuarios
            // 
            this.btUsuarios.Location = new System.Drawing.Point(11, 12);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.Size = new System.Drawing.Size(90, 50);
            this.btUsuarios.TabIndex = 17;
            this.btUsuarios.Text = "Gestión Usuarios";
            this.btUsuarios.UseVisualStyleBackColor = true;
            this.btUsuarios.Click += new System.EventHandler(this.btUsuarios_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(11, 152);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(90, 50);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Salir";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btEvents
            // 
            this.btEvents.Location = new System.Drawing.Point(11, 83);
            this.btEvents.Name = "btEvents";
            this.btEvents.Size = new System.Drawing.Size(90, 50);
            this.btEvents.TabIndex = 0;
            this.btEvents.Text = "Eventos Servidor";
            this.btEvents.UseVisualStyleBackColor = true;
            this.btEvents.Click += new System.EventHandler(this.tsEvents_Click);
            // 
            // Servidor_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(922, 442);
            this.MinimumSize = new System.Drawing.Size(922, 442);
            this.Name = "Servidor_Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleTalk Servidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Servidor_Chat_FormClosing);
            this.Load += new System.EventHandler(this.Servidor_Chat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem legalidadYPrivacidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTerms;
        private System.Windows.Forms.ToolStripMenuItem tsPolicy;
        private System.Windows.Forms.ToolStripMenuItem tsCopyRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEvents;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btUsuarios;
    }
}

