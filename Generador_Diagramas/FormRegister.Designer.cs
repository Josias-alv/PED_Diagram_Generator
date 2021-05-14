namespace Generador_Diagramas
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.label6 = new System.Windows.Forms.Label();
            this.btnregister = new FontAwesome.Sharp.IconButton();
            this.txtpasregister = new System.Windows.Forms.TextBox();
            this.txtuserregister = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpasconfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(207, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 30);
            this.label6.TabIndex = 37;
            this.label6.Text = "Registrate";
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnregister.FlatAppearance.BorderSize = 0;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnregister.IconColor = System.Drawing.Color.White;
            this.btnregister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregister.IconSize = 36;
            this.btnregister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregister.Location = new System.Drawing.Point(116, 392);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(283, 61);
            this.btnregister.TabIndex = 36;
            this.btnregister.Text = "Registrarse";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // txtpasregister
            // 
            this.txtpasregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtpasregister.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.txtpasregister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtpasregister.Location = new System.Drawing.Point(95, 229);
            this.txtpasregister.Multiline = true;
            this.txtpasregister.Name = "txtpasregister";
            this.txtpasregister.Size = new System.Drawing.Size(335, 39);
            this.txtpasregister.TabIndex = 35;
            this.txtpasregister.UseSystemPasswordChar = true;
            // 
            // txtuserregister
            // 
            this.txtuserregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtuserregister.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserregister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtuserregister.Location = new System.Drawing.Point(95, 140);
            this.txtuserregister.Multiline = true;
            this.txtuserregister.Name = "txtuserregister";
            this.txtuserregister.Size = new System.Drawing.Size(335, 42);
            this.txtuserregister.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(191, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(170, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Usuario: (Correo)";
            // 
            // txtpasconfirm
            // 
            this.txtpasconfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtpasconfirm.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.txtpasconfirm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtpasconfirm.Location = new System.Drawing.Point(95, 330);
            this.txtpasconfirm.Multiline = true;
            this.txtpasconfirm.Name = "txtpasconfirm";
            this.txtpasconfirm.Size = new System.Drawing.Size(335, 39);
            this.txtpasconfirm.TabIndex = 39;
            this.txtpasconfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(146, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "Confirmar Contraseña:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(462, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(524, 484);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtpasconfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtpasregister);
            this.Controls.Add(this.txtuserregister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnregister;
        private System.Windows.Forms.TextBox txtpasregister;
        private System.Windows.Forms.TextBox txtuserregister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpasconfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}