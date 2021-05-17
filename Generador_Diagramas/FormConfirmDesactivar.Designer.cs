namespace Generador_Diagramas
{
    partial class FormConfirmDesactivar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirmDesactivar));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnaceptar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnuevacontra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(678, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.btnaceptar.Location = new System.Drawing.Point(244, 335);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(237, 61);
            this.btnaceptar.TabIndex = 51;
            this.btnaceptar.Text = "Cerrar Cuenta";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(81, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(564, 44);
            this.label4.TabIndex = 52;
            this.label4.Text = "Por Favor Confirme Con su Contraseña";
            // 
            // txtnuevacontra
            // 
            this.txtnuevacontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtnuevacontra.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnuevacontra.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtnuevacontra.Location = new System.Drawing.Point(89, 215);
            this.txtnuevacontra.Name = "txtnuevacontra";
            this.txtnuevacontra.Size = new System.Drawing.Size(544, 40);
            this.txtnuevacontra.TabIndex = 58;
            this.txtnuevacontra.UseSystemPasswordChar = true;
            // 
            // FormConfirmDesactivar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(742, 455);
            this.Controls.Add(this.txtnuevacontra);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormConfirmDesactivar";
            this.Text = "FormConfirmDesactivar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnaceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnuevacontra;
    }
}