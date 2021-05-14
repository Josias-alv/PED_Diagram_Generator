namespace Generador_Diagramas
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.btnaceptar = new FontAwesome.Sharp.IconButton();
            this.btnCambiarcontra = new FontAwesome.Sharp.IconButton();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhistorial = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnaceptar.FlatAppearance.BorderSize = 0;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnaceptar.IconColor = System.Drawing.Color.White;
            this.btnaceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnaceptar.IconSize = 36;
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaceptar.Location = new System.Drawing.Point(691, 335);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(237, 61);
            this.btnaceptar.TabIndex = 28;
            this.btnaceptar.Text = "Cerrar Cuenta";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnCambiarcontra
            // 
            this.btnCambiarcontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCambiarcontra.FlatAppearance.BorderSize = 0;
            this.btnCambiarcontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarcontra.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarcontra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCambiarcontra.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnCambiarcontra.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCambiarcontra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarcontra.IconSize = 36;
            this.btnCambiarcontra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarcontra.Location = new System.Drawing.Point(691, 243);
            this.btnCambiarcontra.Name = "btnCambiarcontra";
            this.btnCambiarcontra.Size = new System.Drawing.Size(237, 61);
            this.btnCambiarcontra.TabIndex = 29;
            this.btnCambiarcontra.Text = "Cambiar Contraseña";
            this.btnCambiarcontra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarcontra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarcontra.UseVisualStyleBackColor = false;
            this.btnCambiarcontra.Click += new System.EventHandler(this.btnCambiarcontra_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtusuario.Font = new System.Drawing.Font("Comfortaa", 14.25F);
            this.txtusuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtusuario.Location = new System.Drawing.Point(34, 165);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(335, 46);
            this.txtusuario.TabIndex = 40;
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtfecha.Font = new System.Drawing.Font("Comfortaa", 14.25F);
            this.txtfecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtfecha.Location = new System.Drawing.Point(34, 269);
            this.txtfecha.Multiline = true;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(335, 46);
            this.txtfecha.TabIndex = 42;
            // 
            // txtestado
            // 
            this.txtestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtestado.Font = new System.Drawing.Font("Comfortaa", 14.25F);
            this.txtestado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtestado.Location = new System.Drawing.Point(34, 361);
            this.txtestado.Multiline = true;
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(335, 46);
            this.txtestado.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(29, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 44;
            this.label2.Text = "Usuario: (Correo)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(29, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Fecha de Ingreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(29, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 47;
            this.label3.Text = "Estado Activo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(378, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 44);
            this.label4.TabIndex = 48;
            this.label4.Text = "Configuracion";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(898, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 100);
            this.panel1.TabIndex = 50;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnhistorial
            // 
            this.btnhistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnhistorial.FlatAppearance.BorderSize = 0;
            this.btnhistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistorial.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistorial.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnhistorial.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.btnhistorial.IconColor = System.Drawing.Color.Gainsboro;
            this.btnhistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhistorial.IconSize = 36;
            this.btnhistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhistorial.Location = new System.Drawing.Point(691, 154);
            this.btnhistorial.Name = "btnhistorial";
            this.btnhistorial.Size = new System.Drawing.Size(237, 61);
            this.btnhistorial.TabIndex = 51;
            this.btnhistorial.Text = "Historial de Diagramas";
            this.btnhistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhistorial.UseVisualStyleBackColor = false;
            this.btnhistorial.Click += new System.EventHandler(this.btnhistorial_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(963, 515);
            this.Controls.Add(this.btnhistorial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.btnCambiarcontra);
            this.Controls.Add(this.btnaceptar);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnaceptar;
        private FontAwesome.Sharp.IconButton btnCambiarcontra;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnhistorial;
    }
}