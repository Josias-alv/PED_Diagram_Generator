//
// Copyright (c) 2012, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows.Forms;


namespace MindFusion.Diagramming.WinForms.Samples.CS.Anchors
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
