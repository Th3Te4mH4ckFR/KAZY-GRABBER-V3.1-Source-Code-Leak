/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 09/05/2022
 * Time: 17:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KAZY_GRABBER
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("ERROR 404");
		}
	}
}
