namespace Generador_Diagramas
{
    partial class FormHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbAllDiagrams = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.btnrefreshtodos = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GRIDDIAGRAMALL = new System.Windows.Forms.DataGridView();
            this.VER = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbActivo = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BTNREFRESHACT = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GRID_ACTIVO = new System.Windows.Forms.DataGridView();
            this.VERACT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DESACTIVAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbInactivos = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.btnRefreshdeact = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Grid_Desactivado = new System.Windows.Forms.DataGridView();
            this.VERDEACT = new System.Windows.Forms.DataGridViewImageColumn();
            this.ACTIVAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbAllDiagrams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDDIAGRAMALL)).BeginInit();
            this.tbActivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_ACTIVO)).BeginInit();
            this.tbInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Desactivado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 85);
            this.panel1.TabIndex = 51;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1001, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(368, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 44);
            this.label4.TabIndex = 48;
            this.label4.Text = "Historial de Diagramas";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbAllDiagrams);
            this.tabControl1.Controls.Add(this.tbActivo);
            this.tabControl1.Controls.Add(this.tbInactivos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 517);
            this.tabControl1.TabIndex = 98;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tbAllDiagrams
            // 
            this.tbAllDiagrams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbAllDiagrams.Controls.Add(this.label16);
            this.tbAllDiagrams.Controls.Add(this.btnrefreshtodos);
            this.tbAllDiagrams.Controls.Add(this.label5);
            this.tbAllDiagrams.Controls.Add(this.label3);
            this.tbAllDiagrams.Controls.Add(this.label2);
            this.tbAllDiagrams.Controls.Add(this.label1);
            this.tbAllDiagrams.Controls.Add(this.GRIDDIAGRAMALL);
            this.tbAllDiagrams.Location = new System.Drawing.Point(4, 28);
            this.tbAllDiagrams.Name = "tbAllDiagrams";
            this.tbAllDiagrams.Padding = new System.Windows.Forms.Padding(3);
            this.tbAllDiagrams.Size = new System.Drawing.Size(1058, 485);
            this.tbAllDiagrams.TabIndex = 0;
            this.tbAllDiagrams.Text = "Todos Los Diagramas";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(682, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 19);
            this.label16.TabIndex = 49;
            this.label16.Text = "Ultima Edicion";
            // 
            // btnrefreshtodos
            // 
            this.btnrefreshtodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnrefreshtodos.FlatAppearance.BorderSize = 0;
            this.btnrefreshtodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefreshtodos.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefreshtodos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnrefreshtodos.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnrefreshtodos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnrefreshtodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnrefreshtodos.IconSize = 36;
            this.btnrefreshtodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefreshtodos.Location = new System.Drawing.Point(907, 15);
            this.btnrefreshtodos.Name = "btnrefreshtodos";
            this.btnrefreshtodos.Size = new System.Drawing.Size(132, 61);
            this.btnrefreshtodos.TabIndex = 48;
            this.btnrefreshtodos.Text = "Refresh";
            this.btnrefreshtodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefreshtodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrefreshtodos.UseVisualStyleBackColor = false;
            this.btnrefreshtodos.Click += new System.EventHandler(this.btnrefreshtodos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(914, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(454, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Fecha de Creacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(230, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ruta de Guardado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(36, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nombre";
            // 
            // GRIDDIAGRAMALL
            // 
            this.GRIDDIAGRAMALL.AllowUserToAddRows = false;
            this.GRIDDIAGRAMALL.AllowUserToDeleteRows = false;
            this.GRIDDIAGRAMALL.AllowUserToOrderColumns = true;
            this.GRIDDIAGRAMALL.AllowUserToResizeColumns = false;
            this.GRIDDIAGRAMALL.AllowUserToResizeRows = false;
            this.GRIDDIAGRAMALL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRIDDIAGRAMALL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRIDDIAGRAMALL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GRIDDIAGRAMALL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GRIDDIAGRAMALL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GRIDDIAGRAMALL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRIDDIAGRAMALL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDDIAGRAMALL.ColumnHeadersVisible = false;
            this.GRIDDIAGRAMALL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VER});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRIDDIAGRAMALL.DefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDDIAGRAMALL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GRIDDIAGRAMALL.Location = new System.Drawing.Point(3, 126);
            this.GRIDDIAGRAMALL.Name = "GRIDDIAGRAMALL";
            this.GRIDDIAGRAMALL.ReadOnly = true;
            this.GRIDDIAGRAMALL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRIDDIAGRAMALL.RowHeadersVisible = false;
            this.GRIDDIAGRAMALL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GRIDDIAGRAMALL.Size = new System.Drawing.Size(1052, 356);
            this.GRIDDIAGRAMALL.TabIndex = 43;
            this.GRIDDIAGRAMALL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDDIAGRAMALL_CellContentClick);
            // 
            // VER
            // 
            this.VER.HeaderText = "VER";
            this.VER.Image = ((System.Drawing.Image)(resources.GetObject("VER.Image")));
            this.VER.Name = "VER";
            this.VER.ReadOnly = true;
            // 
            // tbActivo
            // 
            this.tbActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbActivo.Controls.Add(this.label17);
            this.tbActivo.Controls.Add(this.label10);
            this.tbActivo.Controls.Add(this.BTNREFRESHACT);
            this.tbActivo.Controls.Add(this.label6);
            this.tbActivo.Controls.Add(this.label7);
            this.tbActivo.Controls.Add(this.label8);
            this.tbActivo.Controls.Add(this.label9);
            this.tbActivo.Controls.Add(this.GRID_ACTIVO);
            this.tbActivo.Location = new System.Drawing.Point(4, 28);
            this.tbActivo.Name = "tbActivo";
            this.tbActivo.Padding = new System.Windows.Forms.Padding(3);
            this.tbActivo.Size = new System.Drawing.Size(1058, 485);
            this.tbActivo.TabIndex = 1;
            this.tbActivo.Text = "Diagramas Activos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(579, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 19);
            this.label17.TabIndex = 55;
            this.label17.Text = "Ultima Edicion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(932, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 54;
            this.label10.Text = "Desactivar";
            // 
            // BTNREFRESHACT
            // 
            this.BTNREFRESHACT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTNREFRESHACT.FlatAppearance.BorderSize = 0;
            this.BTNREFRESHACT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNREFRESHACT.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREFRESHACT.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNREFRESHACT.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.BTNREFRESHACT.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNREFRESHACT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNREFRESHACT.IconSize = 36;
            this.BTNREFRESHACT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNREFRESHACT.Location = new System.Drawing.Point(902, 17);
            this.BTNREFRESHACT.Name = "BTNREFRESHACT";
            this.BTNREFRESHACT.Size = new System.Drawing.Size(132, 61);
            this.BTNREFRESHACT.TabIndex = 53;
            this.BTNREFRESHACT.Text = "Refresh";
            this.BTNREFRESHACT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNREFRESHACT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNREFRESHACT.UseVisualStyleBackColor = false;
            this.BTNREFRESHACT.Click += new System.EventHandler(this.BTNREFRESHACT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(783, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ver";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(368, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Fecha de Creacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(191, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Ruta de Guardado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(40, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "Nombre";
            // 
            // GRID_ACTIVO
            // 
            this.GRID_ACTIVO.AllowUserToAddRows = false;
            this.GRID_ACTIVO.AllowUserToDeleteRows = false;
            this.GRID_ACTIVO.AllowUserToOrderColumns = true;
            this.GRID_ACTIVO.AllowUserToResizeColumns = false;
            this.GRID_ACTIVO.AllowUserToResizeRows = false;
            this.GRID_ACTIVO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRID_ACTIVO.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRID_ACTIVO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GRID_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GRID_ACTIVO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GRID_ACTIVO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRID_ACTIVO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_ACTIVO.ColumnHeadersVisible = false;
            this.GRID_ACTIVO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VERACT,
            this.DESACTIVAR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_ACTIVO.DefaultCellStyle = dataGridViewCellStyle2;
            this.GRID_ACTIVO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GRID_ACTIVO.Location = new System.Drawing.Point(3, 126);
            this.GRID_ACTIVO.Name = "GRID_ACTIVO";
            this.GRID_ACTIVO.ReadOnly = true;
            this.GRID_ACTIVO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRID_ACTIVO.RowHeadersVisible = false;
            this.GRID_ACTIVO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GRID_ACTIVO.Size = new System.Drawing.Size(1052, 356);
            this.GRID_ACTIVO.TabIndex = 48;
            this.GRID_ACTIVO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_ACTIVO_CellContentClick);
            // 
            // VERACT
            // 
            this.VERACT.HeaderText = "VER";
            this.VERACT.Image = ((System.Drawing.Image)(resources.GetObject("VERACT.Image")));
            this.VERACT.Name = "VERACT";
            this.VERACT.ReadOnly = true;
            // 
            // DESACTIVAR
            // 
            this.DESACTIVAR.HeaderText = "DESACTIVAR";
            this.DESACTIVAR.Image = ((System.Drawing.Image)(resources.GetObject("DESACTIVAR.Image")));
            this.DESACTIVAR.Name = "DESACTIVAR";
            this.DESACTIVAR.ReadOnly = true;
            // 
            // tbInactivos
            // 
            this.tbInactivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbInactivos.Controls.Add(this.label18);
            this.tbInactivos.Controls.Add(this.btnRefreshdeact);
            this.tbInactivos.Controls.Add(this.label11);
            this.tbInactivos.Controls.Add(this.label12);
            this.tbInactivos.Controls.Add(this.label13);
            this.tbInactivos.Controls.Add(this.label14);
            this.tbInactivos.Controls.Add(this.label15);
            this.tbInactivos.Controls.Add(this.Grid_Desactivado);
            this.tbInactivos.Location = new System.Drawing.Point(4, 28);
            this.tbInactivos.Name = "tbInactivos";
            this.tbInactivos.Size = new System.Drawing.Size(1058, 485);
            this.tbInactivos.TabIndex = 2;
            this.tbInactivos.Text = "Diagramas Inactivos";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(571, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 19);
            this.label18.TabIndex = 62;
            this.label18.Text = "Ultima Edicion";
            // 
            // btnRefreshdeact
            // 
            this.btnRefreshdeact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRefreshdeact.FlatAppearance.BorderSize = 0;
            this.btnRefreshdeact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshdeact.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshdeact.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRefreshdeact.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnRefreshdeact.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRefreshdeact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshdeact.IconSize = 36;
            this.btnRefreshdeact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshdeact.Location = new System.Drawing.Point(891, 17);
            this.btnRefreshdeact.Name = "btnRefreshdeact";
            this.btnRefreshdeact.Size = new System.Drawing.Size(132, 61);
            this.btnRefreshdeact.TabIndex = 61;
            this.btnRefreshdeact.Text = "Refresh";
            this.btnRefreshdeact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshdeact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshdeact.UseVisualStyleBackColor = false;
            this.btnRefreshdeact.Click += new System.EventHandler(this.btnRefreshdeact_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(937, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 60;
            this.label11.Text = "Activar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(782, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 19);
            this.label12.TabIndex = 59;
            this.label12.Text = "Ver";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(368, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 19);
            this.label13.TabIndex = 58;
            this.label13.Text = "Fecha de Creacion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(164, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 19);
            this.label14.TabIndex = 57;
            this.label14.Text = "Ruta de Guardado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(39, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 19);
            this.label15.TabIndex = 56;
            this.label15.Text = "Nombre";
            // 
            // Grid_Desactivado
            // 
            this.Grid_Desactivado.AllowUserToAddRows = false;
            this.Grid_Desactivado.AllowUserToDeleteRows = false;
            this.Grid_Desactivado.AllowUserToOrderColumns = true;
            this.Grid_Desactivado.AllowUserToResizeColumns = false;
            this.Grid_Desactivado.AllowUserToResizeRows = false;
            this.Grid_Desactivado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Desactivado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_Desactivado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Grid_Desactivado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid_Desactivado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Grid_Desactivado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid_Desactivado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Desactivado.ColumnHeadersVisible = false;
            this.Grid_Desactivado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VERDEACT,
            this.ACTIVAR});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Desactivado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_Desactivado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grid_Desactivado.Location = new System.Drawing.Point(0, 129);
            this.Grid_Desactivado.Name = "Grid_Desactivado";
            this.Grid_Desactivado.ReadOnly = true;
            this.Grid_Desactivado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid_Desactivado.RowHeadersVisible = false;
            this.Grid_Desactivado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid_Desactivado.Size = new System.Drawing.Size(1058, 356);
            this.Grid_Desactivado.TabIndex = 55;
            this.Grid_Desactivado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Desactivado_CellContentClick);
            // 
            // VERDEACT
            // 
            this.VERDEACT.HeaderText = "VER";
            this.VERDEACT.Image = ((System.Drawing.Image)(resources.GetObject("VERDEACT.Image")));
            this.VERDEACT.Name = "VERDEACT";
            this.VERDEACT.ReadOnly = true;
            // 
            // ACTIVAR
            // 
            this.ACTIVAR.HeaderText = "ACTIVAR";
            this.ACTIVAR.Image = ((System.Drawing.Image)(resources.GetObject("ACTIVAR.Image")));
            this.ACTIVAR.Name = "ACTIVAR";
            this.ACTIVAR.ReadOnly = true;
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1066, 630);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FormHistorial";
            this.Text = "FormHistorial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbAllDiagrams.ResumeLayout(false);
            this.tbAllDiagrams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDDIAGRAMALL)).EndInit();
            this.tbActivo.ResumeLayout(false);
            this.tbActivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_ACTIVO)).EndInit();
            this.tbInactivos.ResumeLayout(false);
            this.tbInactivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Desactivado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbAllDiagrams;
        private System.Windows.Forms.TabPage tbActivo;
        private System.Windows.Forms.TabPage tbInactivos;
        private System.Windows.Forms.DataGridView GRIDDIAGRAMALL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn VER;
        private FontAwesome.Sharp.IconButton btnrefreshtodos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView GRID_ACTIVO;
        private FontAwesome.Sharp.IconButton BTNREFRESHACT;
        private System.Windows.Forms.DataGridViewImageColumn VERACT;
        private System.Windows.Forms.DataGridViewImageColumn DESACTIVAR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView Grid_Desactivado;
        private FontAwesome.Sharp.IconButton btnRefreshdeact;
        private System.Windows.Forms.DataGridViewImageColumn VERDEACT;
        private System.Windows.Forms.DataGridViewImageColumn ACTIVAR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}