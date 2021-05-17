namespace Generador_Diagramas
{
    partial class FormEditDiagram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditDiagram));
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInvocarForms = new System.Windows.Forms.Panel();
            this.PanelDIAGRAM = new System.Windows.Forms.Panel();
            this.DiagramaVer = new MindFusion.Diagramming.WinForms.DiagramView();
            this.diagram1 = new MindFusion.Diagramming.Diagram();
            this.panelAAAA = new System.Windows.Forms.Panel();
            this.pANELproperties = new System.Windows.Forms.Panel();
            this.GridPropiedades = new System.Windows.Forms.PropertyGrid();
            this.panelfig = new System.Windows.Forms.Panel();
            this.TabCTR = new System.Windows.Forms.TabControl();
            this.Figuras = new System.Windows.Forms.TabPage();
            this.lstNODOList = new System.Windows.Forms.ListBox();
            this.Conectores = new System.Windows.Forms.TabPage();
            this.lstFlechasConectors = new System.Windows.Forms.ListBox();
            this.BTNELIMINAR = new FontAwesome.Sharp.IconButton();
            this.BTNGUARDAR = new FontAwesome.Sharp.IconButton();
            this.GUARDARDIALOG = new System.Windows.Forms.SaveFileDialog();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelInvocarForms.SuspendLayout();
            this.PanelDIAGRAM.SuspendLayout();
            this.panelAAAA.SuspendLayout();
            this.pANELproperties.SuspendLayout();
            this.panelfig.SuspendLayout();
            this.TabCTR.SuspendLayout();
            this.Figuras.SuspendLayout();
            this.Conectores.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.paneltop.Controls.Add(this.pictureBox2);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1475, 50);
            this.paneltop.TabIndex = 0;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1413, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtnombre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panelInvocarForms);
            this.panel2.Controls.Add(this.BTNELIMINAR);
            this.panel2.Controls.Add(this.BTNGUARDAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1475, 844);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(1156, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 44);
            this.label4.TabIndex = 50;
            this.label4.Text = "Editar Diagrama";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtnombre.Font = new System.Drawing.Font("Comfortaa", 14.25F);
            this.txtnombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtnombre.Location = new System.Drawing.Point(1113, 283);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(335, 102);
            this.txtnombre.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(1117, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre Archivo:";
            // 
            // panelInvocarForms
            // 
            this.panelInvocarForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelInvocarForms.Controls.Add(this.PanelDIAGRAM);
            this.panelInvocarForms.Controls.Add(this.panelAAAA);
            this.panelInvocarForms.Location = new System.Drawing.Point(12, 17);
            this.panelInvocarForms.Name = "panelInvocarForms";
            this.panelInvocarForms.Size = new System.Drawing.Size(1075, 820);
            this.panelInvocarForms.TabIndex = 23;
            // 
            // PanelDIAGRAM
            // 
            this.PanelDIAGRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PanelDIAGRAM.Controls.Add(this.DiagramaVer);
            this.PanelDIAGRAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDIAGRAM.Location = new System.Drawing.Point(345, 0);
            this.PanelDIAGRAM.Name = "PanelDIAGRAM";
            this.PanelDIAGRAM.Size = new System.Drawing.Size(730, 820);
            this.PanelDIAGRAM.TabIndex = 11;
            // 
            // DiagramaVer
            // 
            this.DiagramaVer.AllowDrop = true;
            this.DiagramaVer.Behavior = MindFusion.Diagramming.Behavior.DrawLinks;
            this.DiagramaVer.Diagram = this.diagram1;
            this.DiagramaVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiagramaVer.LicenseKey = null;
            this.DiagramaVer.Location = new System.Drawing.Point(0, 0);
            this.DiagramaVer.Name = "DiagramaVer";
            this.DiagramaVer.Size = new System.Drawing.Size(730, 820);
            this.DiagramaVer.TabIndex = 8;
            this.DiagramaVer.Text = "DiagramaVer";
            this.DiagramaVer.DragDrop += new System.Windows.Forms.DragEventHandler(this.DiagramaVer_DragDrop);
            this.DiagramaVer.DragOver += new System.Windows.Forms.DragEventHandler(this.DiagramaVer_DragOver);
            // 
            // diagram1
            // 
            this.diagram1.TouchThreshold = 0F;
            this.diagram1.NodeClicked += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this.diagram1_NodeClicked);
            this.diagram1.NodeDeactivated += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this.diagram1_NodeDeactivated);
            // 
            // panelAAAA
            // 
            this.panelAAAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelAAAA.Controls.Add(this.pANELproperties);
            this.panelAAAA.Controls.Add(this.panelfig);
            this.panelAAAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAAAA.Location = new System.Drawing.Point(0, 0);
            this.panelAAAA.Name = "panelAAAA";
            this.panelAAAA.Size = new System.Drawing.Size(345, 820);
            this.panelAAAA.TabIndex = 10;
            // 
            // pANELproperties
            // 
            this.pANELproperties.Controls.Add(this.GridPropiedades);
            this.pANELproperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pANELproperties.Location = new System.Drawing.Point(0, 414);
            this.pANELproperties.Name = "pANELproperties";
            this.pANELproperties.Size = new System.Drawing.Size(345, 406);
            this.pANELproperties.TabIndex = 12;
            // 
            // GridPropiedades
            // 
            this.GridPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPropiedades.Location = new System.Drawing.Point(0, 0);
            this.GridPropiedades.Name = "GridPropiedades";
            this.GridPropiedades.Size = new System.Drawing.Size(345, 406);
            this.GridPropiedades.TabIndex = 1;
            this.GridPropiedades.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.GridPropiedades_PropertyValueChanged);
            // 
            // panelfig
            // 
            this.panelfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelfig.Controls.Add(this.TabCTR);
            this.panelfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelfig.Location = new System.Drawing.Point(0, 0);
            this.panelfig.Name = "panelfig";
            this.panelfig.Size = new System.Drawing.Size(345, 414);
            this.panelfig.TabIndex = 9;
            // 
            // TabCTR
            // 
            this.TabCTR.Controls.Add(this.Figuras);
            this.TabCTR.Controls.Add(this.Conectores);
            this.TabCTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCTR.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCTR.Location = new System.Drawing.Point(0, 0);
            this.TabCTR.Name = "TabCTR";
            this.TabCTR.SelectedIndex = 0;
            this.TabCTR.Size = new System.Drawing.Size(345, 414);
            this.TabCTR.TabIndex = 1;
            // 
            // Figuras
            // 
            this.Figuras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Figuras.Controls.Add(this.lstNODOList);
            this.Figuras.Location = new System.Drawing.Point(4, 30);
            this.Figuras.Name = "Figuras";
            this.Figuras.Padding = new System.Windows.Forms.Padding(3);
            this.Figuras.Size = new System.Drawing.Size(337, 380);
            this.Figuras.TabIndex = 0;
            this.Figuras.Text = "Figuras";
            // 
            // lstNODOList
            // 
            this.lstNODOList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNODOList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNODOList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstNODOList.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNODOList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstNODOList.Location = new System.Drawing.Point(3, 3);
            this.lstNODOList.Name = "lstNODOList";
            this.lstNODOList.Size = new System.Drawing.Size(331, 374);
            this.lstNODOList.Sorted = true;
            this.lstNODOList.TabIndex = 8;
            this.lstNODOList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstNODOList_DrawItem);
            this.lstNODOList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstNODOList_MeasureItem);
            this.lstNODOList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstNODOList_MouseDown);
            // 
            // Conectores
            // 
            this.Conectores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Conectores.Controls.Add(this.lstFlechasConectors);
            this.Conectores.Location = new System.Drawing.Point(4, 30);
            this.Conectores.Name = "Conectores";
            this.Conectores.Padding = new System.Windows.Forms.Padding(3);
            this.Conectores.Size = new System.Drawing.Size(337, 380);
            this.Conectores.TabIndex = 1;
            this.Conectores.Text = "Flechas";
            // 
            // lstFlechasConectors
            // 
            this.lstFlechasConectors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFlechasConectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFlechasConectors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstFlechasConectors.Location = new System.Drawing.Point(3, 3);
            this.lstFlechasConectors.Name = "lstFlechasConectors";
            this.lstFlechasConectors.Size = new System.Drawing.Size(331, 374);
            this.lstFlechasConectors.TabIndex = 4;
            this.lstFlechasConectors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstFlechasConectors_DrawItem);
            this.lstFlechasConectors.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstFlechasConectors_MeasureItem);
            this.lstFlechasConectors.SelectedIndexChanged += new System.EventHandler(this.lstFlechasConectors_SelectedIndexChanged);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BTNELIMINAR.FlatAppearance.BorderSize = 0;
            this.BTNELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNELIMINAR.IconChar = FontAwesome.Sharp.IconChar.File;
            this.BTNELIMINAR.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNELIMINAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNELIMINAR.IconSize = 36;
            this.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.Location = new System.Drawing.Point(1164, 550);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(215, 61);
            this.BTNELIMINAR.TabIndex = 21;
            this.BTNELIMINAR.Text = "Eliminar Componente";
            this.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BTNGUARDAR.FlatAppearance.BorderSize = 0;
            this.BTNGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNGUARDAR.IconChar = FontAwesome.Sharp.IconChar.File;
            this.BTNGUARDAR.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNGUARDAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNGUARDAR.IconSize = 36;
            this.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Location = new System.Drawing.Point(1164, 431);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(215, 61);
            this.BTNGUARDAR.TabIndex = 20;
            this.BTNGUARDAR.Text = "Guardar Diagrama";
            this.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // FormEditDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1475, 894);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paneltop);
            this.Name = "FormEditDiagram";
            this.Text = "FormEditDiagram";
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelInvocarForms.ResumeLayout(false);
            this.PanelDIAGRAM.ResumeLayout(false);
            this.panelAAAA.ResumeLayout(false);
            this.pANELproperties.ResumeLayout(false);
            this.panelfig.ResumeLayout(false);
            this.TabCTR.ResumeLayout(false);
            this.Figuras.ResumeLayout(false);
            this.Conectores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BTNELIMINAR;
        private FontAwesome.Sharp.IconButton BTNGUARDAR;
        private System.Windows.Forms.Panel panelInvocarForms;
        private System.Windows.Forms.Panel PanelDIAGRAM;
        public MindFusion.Diagramming.WinForms.DiagramView DiagramaVer;
        private MindFusion.Diagramming.Diagram diagram1;
        private System.Windows.Forms.Panel panelAAAA;
        private System.Windows.Forms.Panel pANELproperties;
        public System.Windows.Forms.PropertyGrid GridPropiedades;
        private System.Windows.Forms.Panel panelfig;
        public System.Windows.Forms.TabControl TabCTR;
        public System.Windows.Forms.TabPage Figuras;
        public System.Windows.Forms.ListBox lstNODOList;
        public System.Windows.Forms.TabPage Conectores;
        public System.Windows.Forms.ListBox lstFlechasConectors;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog GUARDARDIALOG;
    }
}