using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyHard
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			telahome1.BringToFront();
			
		}
		private static string _CVar = "";

		public static string CVar
		{
			get { return _CVar; }
			set { _CVar = value; }
		}

		private static string _DVar = "";

		public static string DVar
		{
			get { return _DVar; }
			set { _DVar = value; }
		}


		private static string _RVar = "";

		public static string RVar
		{
			get { return _RVar; }
			set { _RVar = value; }
		}


		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnMINI_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;

		}

		private void BtnHome_Click(object sender, EventArgs e)
		{
			telahome1.BringToFront();
		}

		private void BtnConfig_Click(object sender, EventArgs e)
		{
			telaajustes2.BringToFront();

		}

		private void BtnHelp_Click(object sender, EventArgs e)
		{
			telaajuda1.BringToFront();
		}

		private void BtnInfo_Click(object sender, EventArgs e)
		{
			telainfo1.BringToFront();
		}

		
	}
}
