using System.Windows.Forms;

namespace Servidor
{
    partial class fmAcercade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAcercade));
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.gbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen.Image")));
            this.pbImagen.Location = new System.Drawing.Point(34, 20);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(225, 183);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 30F);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(16, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyecto final";
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAceptar.Font = new System.Drawing.Font("Rockwell", 16F);
            this.btAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAceptar.Location = new System.Drawing.Point(381, 243);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(110, 31);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbNombre.Location = new System.Drawing.Point(13, 23);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(201, 21);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Francisco José Galvañ Pavía";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "DAM 2º Q";
            // 
            // gbInformacion
            // 
            this.gbInformacion.BackColor = System.Drawing.Color.Honeydew;
            this.gbInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInformacion.Controls.Add(this.lbNombre);
            this.gbInformacion.Controls.Add(this.label2);
            this.gbInformacion.Location = new System.Drawing.Point(295, 20);
            this.gbInformacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInformacion.Size = new System.Drawing.Size(274, 92);
            this.gbInformacion.TabIndex = 5;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Alumno";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(295, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 62);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chat Multiusuario\r\nen Visual Studio con";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // fmAcercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(595, 312);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmAcercade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbImagen;
        private Label label1;
        private Button btAceptar;
        private Label lbNombre;
        private Label label2;
        private GroupBox gbInformacion;
        private Label label3;
    }
}