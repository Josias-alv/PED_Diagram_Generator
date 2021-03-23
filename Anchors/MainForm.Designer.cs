//
// Copyright (c) 2012, MindFusion LLC - Bulgaria.
//


namespace MindFusion.Diagramming.WinForms.Samples.CS.Anchors
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.icon = new System.Windows.Forms.PictureBox();
			this.diagram = new MindFusion.Diagramming.Diagram();
			this.diagramView = new MindFusion.Diagramming.WinForms.DiagramView();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(628, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 200);
			this.label1.TabIndex = 1;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// radioButton1
			// 
			this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(651, 259);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(51, 17);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Node";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(651, 282);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(66, 17);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.Text = "Decision";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(648, 240);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Box shape";
			// 
			// sfd
			// 
			this.sfd.FileName = "doc1";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(656, 377);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 24);
			this.button1.TabIndex = 5;
			this.button1.Text = "Load";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(656, 407);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 24);
			this.button2.TabIndex = 6;
			this.button2.Text = "Save";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// icon
			// 
			this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
			this.icon.Location = new System.Drawing.Point(672, 500);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(100, 50);
			this.icon.TabIndex = 15;
			this.icon.TabStop = false;
			this.icon.Visible = false;
			// 
			// diagram
			// 
			this.diagram.AlignToGrid = false;
			this.diagram.AllowSelfLoops = false;
			this.diagram.BackBrush = new MindFusion.Drawing.SolidBrush("#FFE0E0E0");
			this.diagram.DiagramStyle.ShadowBrush = new MindFusion.Drawing.SolidBrush("#96BEBEBE");
			this.diagram.LinkSegments = ((short)(3));
			this.diagram.LinkShape = MindFusion.Diagramming.LinkShape.Cascading;
			this.diagram.RouteLinks = true;
			this.diagram.SelectAfterCreate = false;
			this.diagram.ShapeHandlesStyle = MindFusion.Diagramming.HandlesStyle.DashFrame;
			this.diagram.SnapToAnchor = MindFusion.Diagramming.SnapToAnchor.OnCreateOrModify;
			this.diagram.NodeCreated += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this.diagram_NodeCreated);
			this.diagram.DrawAnchorPoint += new System.EventHandler<MindFusion.Diagramming.DrawAnchorPointEventArgs>(this.diagram_DrawAnchorPoint);
			// 
			// diagramView
			// 
			this.diagramView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.diagramView.Diagram = this.diagram;
			this.diagramView.Location = new System.Drawing.Point(0, 0);
			this.diagramView.Name = "diagramView";
			this.diagramView.Size = new System.Drawing.Size(616, 563);
			this.diagramView.TabIndex = 0;
			this.diagramView.Text = "diagramView1";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.diagramView);
			this.Controls.Add(this.icon);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MindFusion.Diagramming Sample: Anchor Points";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox icon;
		private Diagram diagram;
		private DiagramView diagramView;
	}
}
