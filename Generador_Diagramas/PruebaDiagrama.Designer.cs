namespace Generador_Diagramas
{
    partial class PruebaDiagrama
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
            this.components = new System.ComponentModel.Container();
            this.DiagramaVer = new MindFusion.Diagramming.WinForms.DiagramView();
            this.Diagrama = new MindFusion.Diagramming.Diagram();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabCTR = new System.Windows.Forms.TabControl();
            this.Figuras = new System.Windows.Forms.TabPage();
            this.lstNODOList = new System.Windows.Forms.ListBox();
            this.Conectores = new System.Windows.Forms.TabPage();
            this.lstFlechasConectors = new System.Windows.Forms.ListBox();
            this.CBMTipoFlechaConectors = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridPropiedades = new System.Windows.Forms.PropertyGrid();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.hidden = new MindFusion.Diagramming.Diagram();
            this.ContextMenu = new System.Windows.Forms.ContextMenu();
            this._menuItemDelete = new System.Windows.Forms.MenuItem();
            this._mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this._menuItemFile = new System.Windows.Forms.MenuItem();
            this._menuItemNew = new System.Windows.Forms.MenuItem();
            this._menuItemOpen = new System.Windows.Forms.MenuItem();
            this._menuItemSave = new System.Windows.Forms.MenuItem();
            this._menuEdit = new System.Windows.Forms.MenuItem();
            this._menuUndo = new System.Windows.Forms.MenuItem();
            this._menuRedo = new System.Windows.Forms.MenuItem();
            this._menuItemTools = new System.Windows.Forms.MenuItem();
            this._menuItempdf = new System.Windows.Forms.MenuItem();
            this.menuItemsvg = new System.Windows.Forms.MenuItem();
            this.menuItempng = new System.Windows.Forms.MenuItem();
            this.menuItemimprimir = new System.Windows.Forms.MenuItem();
            this._menuItemHelp = new System.Windows.Forms.MenuItem();
            this._menuItemAbout = new System.Windows.Forms.MenuItem();
            this.panel1.SuspendLayout();
            this.TabCTR.SuspendLayout();
            this.Figuras.SuspendLayout();
            this.Conectores.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiagramaVer
            // 
            this.DiagramaVer.AllowDrop = true;
            this.DiagramaVer.Behavior = MindFusion.Diagramming.Behavior.DrawLinks;
            this.DiagramaVer.Diagram = this.Diagrama;
            this.DiagramaVer.Dock = System.Windows.Forms.DockStyle.Right;
            this.DiagramaVer.LicenseKey = null;
            this.DiagramaVer.Location = new System.Drawing.Point(379, 0);
            this.DiagramaVer.Name = "DiagramaVer";
            this.DiagramaVer.Size = new System.Drawing.Size(702, 777);
            this.DiagramaVer.TabIndex = 7;
            this.DiagramaVer.Text = "DiagramaVer";
            this.DiagramaVer.DragDrop += new System.Windows.Forms.DragEventHandler(this.DiagramaVer_DragDrop);
            this.DiagramaVer.DragOver += new System.Windows.Forms.DragEventHandler(this.DiagramaVer_DragOver);
            // 
            // Diagrama
            // 
            this.Diagrama.TouchThreshold = 0F;
            this.Diagrama.LinkClicked += new System.EventHandler<MindFusion.Diagramming.LinkEventArgs>(this.Diagrama_LinkClicked);
            this.Diagrama.NodeActivated += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this.Diagrama_NodeActivated);
            this.Diagrama.NodeClicked += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this.Diagrama_NodeClicked);
            this.Diagrama.NodeDeactivated += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this.Diagrama_NodeDeactivated);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabCTR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 490);
            this.panel1.TabIndex = 2;
            // 
            // TabCTR
            // 
            this.TabCTR.Controls.Add(this.Figuras);
            this.TabCTR.Controls.Add(this.Conectores);
            this.TabCTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCTR.Location = new System.Drawing.Point(0, 0);
            this.TabCTR.Name = "TabCTR";
            this.TabCTR.SelectedIndex = 0;
            this.TabCTR.Size = new System.Drawing.Size(379, 490);
            this.TabCTR.TabIndex = 0;
            // 
            // Figuras
            // 
            this.Figuras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Figuras.Controls.Add(this.lstNODOList);
            this.Figuras.Location = new System.Drawing.Point(4, 22);
            this.Figuras.Name = "Figuras";
            this.Figuras.Padding = new System.Windows.Forms.Padding(3);
            this.Figuras.Size = new System.Drawing.Size(371, 464);
            this.Figuras.TabIndex = 0;
            this.Figuras.Text = "Figuras";
            // 
            // lstNODOList
            // 
            this.lstNODOList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNODOList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNODOList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstNODOList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstNODOList.Location = new System.Drawing.Point(3, 3);
            this.lstNODOList.Name = "lstNODOList";
            this.lstNODOList.Size = new System.Drawing.Size(365, 458);
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
            this.Conectores.Controls.Add(this.CBMTipoFlechaConectors);
            this.Conectores.Location = new System.Drawing.Point(4, 22);
            this.Conectores.Name = "Conectores";
            this.Conectores.Padding = new System.Windows.Forms.Padding(3);
            this.Conectores.Size = new System.Drawing.Size(371, 464);
            this.Conectores.TabIndex = 1;
            this.Conectores.Text = "Conectores";
            // 
            // lstFlechasConectors
            // 
            this.lstFlechasConectors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFlechasConectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFlechasConectors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstFlechasConectors.Location = new System.Drawing.Point(3, 3);
            this.lstFlechasConectors.Name = "lstFlechasConectors";
            this.lstFlechasConectors.Size = new System.Drawing.Size(365, 437);
            this.lstFlechasConectors.TabIndex = 4;
            this.lstFlechasConectors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstFlechasConectors_DrawItem);
            this.lstFlechasConectors.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstFlechasConectors_MeasureItem);
            this.lstFlechasConectors.SelectedIndexChanged += new System.EventHandler(this.lstFlechasConectors_SelectedIndexChanged);
            // 
            // CBMTipoFlechaConectors
            // 
            this.CBMTipoFlechaConectors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CBMTipoFlechaConectors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMTipoFlechaConectors.Items.AddRange(new object[] {
            "Linea Recta",
            "Linea Curva",
            "Linea Perpendicular"});
            this.CBMTipoFlechaConectors.Location = new System.Drawing.Point(3, 440);
            this.CBMTipoFlechaConectors.Name = "CBMTipoFlechaConectors";
            this.CBMTipoFlechaConectors.Size = new System.Drawing.Size(365, 21);
            this.CBMTipoFlechaConectors.TabIndex = 3;
            this.CBMTipoFlechaConectors.SelectedValueChanged += new System.EventHandler(this.CBMTipoFlechaConectors_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GridPropiedades);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 281);
            this.panel2.TabIndex = 3;
            // 
            // GridPropiedades
            // 
            this.GridPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPropiedades.Location = new System.Drawing.Point(0, 0);
            this.GridPropiedades.Name = "GridPropiedades";
            this.GridPropiedades.Size = new System.Drawing.Size(379, 281);
            this.GridPropiedades.TabIndex = 0;
            this.GridPropiedades.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropiedadEditChange);
            // 
            // hidden
            // 
            this.hidden.BackBrush = new MindFusion.Drawing.SolidBrush("#FFFFFFFF");
            this.hidden.LinkBaseShapeSize = 12F;
            this.hidden.LinkHeadShapeSize = 12F;
            this.hidden.LinkIntermediateShapeSize = 12F;
            this.hidden.MeasureUnit = MindFusion.Diagramming.MeasureUnit.Pixel;
            this.hidden.RoutingOptions.GridSize = 16F;
            this.hidden.RoutingOptions.NodeVicinitySize = 48F;
            this.hidden.SelectAfterCreate = false;
            this.hidden.ShapeNodeStyle.Brush = new MindFusion.Drawing.SolidBrush("#FF00BFFF");
            this.hidden.TouchThreshold = 0F;
            // 
            // ContextMenu
            // 
            this.ContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuItemDelete});
            // 
            // _menuItemDelete
            // 
            this._menuItemDelete.Index = 0;
            this._menuItemDelete.Text = "Delete";
            this._menuItemDelete.Click += new System.EventHandler(this.Delete);
            // 
            // _mainMenu
            // 
            this._mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuItemFile,
            this._menuEdit,
            this._menuItemTools,
            this._menuItemHelp});
            // 
            // _menuItemFile
            // 
            this._menuItemFile.Index = 0;
            this._menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuItemNew,
            this._menuItemOpen,
            this._menuItemSave});
            this._menuItemFile.Text = "&Archivo";
            // 
            // _menuItemNew
            // 
            this._menuItemNew.Index = 0;
            this._menuItemNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this._menuItemNew.Text = "&Nuevo";
            this._menuItemNew.Click += new System.EventHandler(this._menuItemNew_Click);
            // 
            // _menuItemOpen
            // 
            this._menuItemOpen.Index = 1;
            this._menuItemOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this._menuItemOpen.Text = "&Abrir";
            this._menuItemOpen.Click += new System.EventHandler(this._menuItemOpen_Click);
            // 
            // _menuItemSave
            // 
            this._menuItemSave.Index = 2;
            this._menuItemSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this._menuItemSave.Text = "&Guardar";
            this._menuItemSave.Click += new System.EventHandler(this._menuItemSave_Click);
            // 
            // _menuEdit
            // 
            this._menuEdit.Index = 1;
            this._menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuUndo,
            this._menuRedo});
            this._menuEdit.Text = "&Editar";
            this._menuEdit.Popup += new System.EventHandler(this.CTRZ_CRTX);
            // 
            // _menuUndo
            // 
            this._menuUndo.Index = 0;
            this._menuUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this._menuUndo.Text = "&Deshacer";
            this._menuUndo.Click += new System.EventHandler(this._menuUndo_Click);
            // 
            // _menuRedo
            // 
            this._menuRedo.Index = 1;
            this._menuRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this._menuRedo.Text = "&Rehacer";
            this._menuRedo.Click += new System.EventHandler(this._menuRedo_Click);
            // 
            // _menuItemTools
            // 
            this._menuItemTools.Index = 2;
            this._menuItemTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuItempdf,
            this.menuItemsvg,
            this.menuItempng,
            this.menuItemimprimir});
            this._menuItemTools.Text = "&Convertir";
            // 
            // _menuItempdf
            // 
            this._menuItempdf.Index = 0;
            this._menuItempdf.Text = "&PDF";
            this._menuItempdf.Click += new System.EventHandler(this._menuItempdf_Click);
            // 
            // menuItemsvg
            // 
            this.menuItemsvg.Index = 1;
            this.menuItemsvg.Text = "&SVG";
            this.menuItemsvg.Click += new System.EventHandler(this.menuItemsvg_Click);
            // 
            // menuItempng
            // 
            this.menuItempng.Index = 2;
            this.menuItempng.Text = "&PNG";
            this.menuItempng.Click += new System.EventHandler(this.menuItempng_Click);
            // 
            // menuItemimprimir
            // 
            this.menuItemimprimir.Index = 3;
            this.menuItemimprimir.Text = "&Imprimir";
            this.menuItemimprimir.Click += new System.EventHandler(this.menuItemimprimir_Click);
            // 
            // _menuItemHelp
            // 
            this._menuItemHelp.Index = 3;
            this._menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuItemAbout});
            this._menuItemHelp.Text = "&Ayuda";
            // 
            // _menuItemAbout
            // 
            this._menuItemAbout.Index = 0;
            this._menuItemAbout.Text = "&Acerca de Diagramonus";
            // 
            // PruebaDiagrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1081, 777);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DiagramaVer);
            this.Menu = this._mainMenu;
            this.Name = "PruebaDiagrama";
            this.Text = "PruebaDiagrama";
            this.panel1.ResumeLayout(false);
            this.TabCTR.ResumeLayout(false);
            this.Figuras.ResumeLayout(false);
            this.Conectores.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public MindFusion.Diagramming.Diagram Diagrama;
        public MindFusion.Diagramming.Diagram hidden;
        public System.Windows.Forms.OpenFileDialog OpenDialog;
        public System.Windows.Forms.SaveFileDialog SaveDialog;
        public System.Windows.Forms.ContextMenu ContextMenu;
        public MindFusion.Diagramming.WinForms.DiagramView DiagramaVer;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TabControl TabCTR;
        public System.Windows.Forms.TabPage Figuras;
        public System.Windows.Forms.TabPage Conectores;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListBox lstFlechasConectors;
        public System.Windows.Forms.ComboBox CBMTipoFlechaConectors;
        public System.Windows.Forms.PropertyGrid GridPropiedades;
        public System.Windows.Forms.ListBox lstNODOList;
        public System.Windows.Forms.MenuItem _menuItemDelete;
        public System.Windows.Forms.MainMenu _mainMenu;
        public System.Windows.Forms.MenuItem _menuItemFile;
        public System.Windows.Forms.MenuItem _menuItemNew;
        public System.Windows.Forms.MenuItem _menuItemOpen;
        public System.Windows.Forms.MenuItem _menuItemSave;
        public System.Windows.Forms.MenuItem _menuEdit;
        public System.Windows.Forms.MenuItem _menuUndo;
        public System.Windows.Forms.MenuItem _menuRedo;
        public System.Windows.Forms.MenuItem _menuItemTools;
        public System.Windows.Forms.MenuItem _menuItempdf;
        public System.Windows.Forms.MenuItem _menuItemHelp;
        public System.Windows.Forms.MenuItem _menuItemAbout;
        public System.Windows.Forms.MenuItem menuItemsvg;
        public System.Windows.Forms.MenuItem menuItempng;
        public System.Windows.Forms.MenuItem menuItemimprimir;
    }
}