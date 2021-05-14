namespace Generador_Diagramas
{
    partial class FormCambioPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambioPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCambiarcontra = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnuvacontraconfirm = new System.Windows.Forms.TextBox();
            this.txtnuevacontra = new System.Windows.Forms.TextBox();
            this.txtantiguacontra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 111);
            this.panel1.TabIndex = 55;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(673, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(188, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 44);
            this.label4.TabIndex = 49;
            this.label4.Text = "Cambio de Contraseña";
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
            this.btnCambiarcontra.Location = new System.Drawing.Point(221, 506);
            this.btnCambiarcontra.Name = "btnCambiarcontra";
            this.btnCambiarcontra.Size = new System.Drawing.Size(249, 61);
            this.btnCambiarcontra.TabIndex = 54;
            this.btnCambiarcontra.Text = "Cambiar Contraseña";
            this.btnCambiarcontra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarcontra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarcontra.UseVisualStyleBackColor = false;
            this.btnCambiarcontra.Click += new System.EventHandler(this.btnCambiarcontra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(191, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 30);
            this.label3.TabIndex = 53;
            this.label3.Text = "Confirmar Nueva Contraseña :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(236, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nueva Contraseña :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(236, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 30);
            this.label2.TabIndex = 46;
            this.label2.Text = "Antigua Constraseña :";
            // 
            // txtnuvacontraconfirm
            // 
            this.txtnuvacontraconfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtnuvacontraconfirm.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnuvacontraconfirm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtnuvacontraconfirm.Location = new System.Drawing.Point(90, 424);
            this.txtnuvacontraconfirm.Name = "txtnuvacontraconfirm";
            this.txtnuvacontraconfirm.Size = new System.Drawing.Size(544, 40);
            this.txtnuvacontraconfirm.TabIndex = 56;
            this.txtnuvacontraconfirm.UseSystemPasswordChar = true;
            // 
            // txtnuevacontra
            // 
            this.txtnuevacontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtnuevacontra.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnuevacontra.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtnuevacontra.Location = new System.Drawing.Point(90, 297);
            this.txtnuevacontra.Name = "txtnuevacontra";
            this.txtnuevacontra.Size = new System.Drawing.Size(544, 40);
            this.txtnuevacontra.TabIndex = 57;
            this.txtnuevacontra.UseSystemPasswordChar = true;
            // 
            // txtantiguacontra
            // 
            this.txtantiguacontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtantiguacontra.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtantiguacontra.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtantiguacontra.Location = new System.Drawing.Point(90, 179);
            this.txtantiguacontra.Name = "txtantiguacontra";
            this.txtantiguacontra.Size = new System.Drawing.Size(544, 40);
            this.txtantiguacontra.TabIndex = 58;
            this.txtantiguacontra.UseSystemPasswordChar = true;
            // 
            // FormCambioPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(737, 607);
            this.Controls.Add(this.txtantiguacontra);
            this.Controls.Add(this.txtnuevacontra);
            this.Controls.Add(this.txtnuvacontraconfirm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCambiarcontra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormCambioPassword";
            this.Text = "FormCambioPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnCambiarcontra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtnuvacontraconfirm;
        private System.Windows.Forms.TextBox txtnuevacontra;
        private System.Windows.Forms.TextBox txtantiguacontra;
    }
}