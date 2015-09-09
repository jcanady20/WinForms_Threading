using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Threading
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_backgroundWorker_Click(object sender, EventArgs e)
		{

		}

		private void btn_progressTask_Click(object sender, EventArgs e)
		{
			var pt = new ThreadSamples.SimpleWait();
			using (var pd = new Dialogs.ProgressDialog(pt))
			{
				pd.ShowDialog();
			}
		}

	}
}
