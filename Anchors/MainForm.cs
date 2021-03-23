//
// Copyright (c) 2012, MindFusion LLC - Bulgaria.
//

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using MindFusion.Diagramming;
using MindFusion.Diagramming.WinForms;
using MindFusion.Drawing;


namespace MindFusion.Diagramming.WinForms.Samples.CS.Anchors
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			diagram.NodeEffects.Add(new GlassEffect());
			diagram.NodeEffects.Add(new AeroEffect());

			diagram.ShapeNodeStyle.Brush = new LinearGradientBrush(
                Color.FromArgb(102, 154, 204), Color.FromArgb(0, 52, 102), 30);
            diagram.DiagramLinkStyle.Stroke = new MindFusion.Drawing.SolidBrush(Color.FromArgb(100, 100, 100));
            diagram.DiagramLinkStyle.HeadStroke = new MindFusion.Drawing.SolidBrush(Color.FromArgb(100, 100, 100));
            diagram.BackBrush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(224, 233, 233));
			ShapeNode pb1, pb2, pb3, pb4, decb1, decb2;

			apat1 = new AnchorPattern(new AnchorPoint[]
				{
					new AnchorPoint(50, 0, true, true),
					new AnchorPoint(100, 50, true, true),
					new AnchorPoint(50, 100, true, true),
					new AnchorPoint(0, 50, true, true)
				});

			apat2 = new AnchorPattern(new AnchorPoint[]
				{
					new AnchorPoint(10, 0, true, false, MarkStyle.Circle, Color.RoyalBlue),
					new AnchorPoint(50, 0, true, false, MarkStyle.Circle, Color.Blue),
					new AnchorPoint(90, 0, true, false, MarkStyle.Circle, Color.Firebrick),
					new AnchorPoint(10, 100, false, true, MarkStyle.Rectangle),
					new AnchorPoint(50, 100, false, true, MarkStyle.Rectangle),
					new AnchorPoint(90, 100, false, true, MarkStyle.Rectangle),
					new AnchorPoint(0, 50, true, true, MarkStyle.Custom)
				});

			pb1 = new ShapeNode(diagram);
			pb1.Bounds = new RectangleF(10, 7, 25, 18);
			pb1.Shape = Shapes.Ellipse;
			pb1.Text = "Start";
			pb1.AnchorPattern = apat1;
			diagram.Nodes.Add(pb1);

			pb2 = new ShapeNode(diagram);
			pb2.Bounds = new RectangleF(20, 75, 25, 18);
			pb2.Text = "node 1";
			pb2.AnchorPattern = apat2;
			diagram.Nodes.Add(pb2);

			pb3 = new ShapeNode(diagram);
			pb3.Bounds = new RectangleF(70, 70, 25, 18);
			pb3.Text = "node 2";
			pb3.AnchorPattern = apat2;
			diagram.Nodes.Add(pb3);

			pb4 = new ShapeNode(diagram);
			pb4.Bounds = new RectangleF(80, 100, 25, 18);
			pb4.Shape = Shapes.Ellipse;
			pb4.Text = "End";
			pb4.AnchorPattern = apat1;
			diagram.Nodes.Add(pb4);

			decb1 = new ShapeNode(diagram);
			decb1.Bounds = new RectangleF(20, 35, 30, 20);
			decb1.Shape = Shapes.Decision;
			decb1.Text = "check 1";
			decb1.AnchorPattern = AnchorPattern.Decision1In3Out;
			diagram.Nodes.Add(decb1);

			decb2 = new ShapeNode(diagram);
			decb2.Bounds = new RectangleF(70, 30, 30, 20);
			decb2.Shape = Shapes.Decision;
			decb2.Text = "check 2";
			decb2.AnchorPattern = AnchorPattern.Decision2In2Out;
			diagram.Nodes.Add(decb2);

			diagram.Links.Add(new DiagramLink(diagram, decb1, decb2));
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			diagram.DefaultShape = Shapes.RoundRect;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			diagram.DefaultShape = Shapes.Decision;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					diagram.LoadFromFile(ofd.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				diagram.SaveToFile(sfd.FileName, true);
			}
		}

		private void diagram_DrawAnchorPoint(object sender, DrawAnchorPointEventArgs e)
		{
			PointF imgPos = e.Location;
			imgPos.Y -= 1.8f;
			e.Graphics.DrawImage(icon.Image, imgPos);
		}

		private void diagram_NodeCreated(object sender, NodeEventArgs e)
		{
			ShapeNode node = e.Node as ShapeNode;
			if (node == null)
				return;

			if (node.Shape == Shapes.Decision)
				node.AnchorPattern = AnchorPattern.Decision1In3Out;
			else
				node.AnchorPattern = apat2;
		}


		private AnchorPattern apat1, apat2;
	}
}