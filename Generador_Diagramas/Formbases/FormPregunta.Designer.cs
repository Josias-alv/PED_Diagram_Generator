namespace Generador_Diagramas.Formbases
{
    partial class FormPregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregunta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBTITULO = new System.Windows.Forms.Label();
            this.btnaceptar = new FontAwesome.Sharp.IconButton();
            this.btncacelar = new FontAwesome.Sharp.IconButton();
            this.LBCONTENIDO = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LBTITULO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 273);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LBTITULO
            // 
            this.LBTITULO.Font = new System.Drawing.Font("Comfortaa", 16.25F);
            this.LBTITULO.ForeColor = System.Drawing.Color.White;
            this.LBTITULO.Location = new System.Drawing.Point(12, 199);
            this.LBTITULO.Name = "LBTITULO";
            this.LBTITULO.Size = new System.Drawing.Size(509, 53);
            this.LBTITULO.TabIndex = 7;
            this.LBTITULO.Text = "TITULO";
            this.LBTITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnaceptar.FlatAppearance.BorderSize = 0;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnaceptar.IconColor = System.Drawing.Color.White;
            this.btnaceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnaceptar.IconSize = 36;
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaceptar.Location = new System.Drawing.Point(18, 497);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(177, 61);
            this.btnaceptar.TabIndex = 23;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncacelar
            // 
            this.btncacelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btncacelar.FlatAppearance.BorderSize = 0;
            this.btncacelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncacelar.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncacelar.ForeColor = System.Drawing.Color.White;
            this.btncacelar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btncacelar.IconColor = System.Drawing.Color.White;
            this.btncacelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncacelar.IconSize = 36;
            this.btncacelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncacelar.Location = new System.Drawing.Point(344, 497);
            this.btncacelar.Name = "btncacelar";
            this.btncacelar.Size = new System.Drawing.Size(177, 61);
            this.btncacelar.TabIndex = 24;
            this.btncacelar.Text = "Cancelar";
            this.btncacelar.UseVisualStyleBackColor = false;
            this.btncacelar.Click += new System.EventHandler(this.btncacelar_Click);
            // 
            // LBCONTENIDO
            // 
            this.LBCONTENIDO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.LBCONTENIDO.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCONTENIDO.ForeColor = System.Drawing.Color.Black;
            this.LBCONTENIDO.Location = new System.Drawing.Point(14, 290);
            this.LBCONTENIDO.Name = "LBCONTENIDO";
            this.LBCONTENIDO.Size = new System.Drawing.Size(507, 198);
            this.LBCONTENIDO.TabIndex = 25;
            this.LBCONTENIDO.Text = "CONTENIDO";
            this.LBCONTENIDO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 570);
            this.Controls.Add(this.LBCONTENIDO);
            this.Controls.Add(this.btncacelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.panel1);
            this.Name = "FormPregunta";
            this.Text = "FormPregunta";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBTITULO;
        private FontAwesome.Sharp.IconButton btnaceptar;
        private FontAwesome.Sharp.IconButton btncacelar;
        private System.Windows.Forms.Label LBCONTENIDO;
    }
}