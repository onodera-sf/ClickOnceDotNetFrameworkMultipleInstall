using System;
using System.Windows.Forms;

namespace ClickOnceMultipleInstall
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
#if DEBUG
			labelMode.Text = "Debug";
#else
			labelMode.Text = "Release";
#endif
		}
	}
}
