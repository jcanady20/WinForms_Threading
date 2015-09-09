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
			using (var dc = new Dialogs.DialogControls.WorkerControl())
			{
				using (var dialog = new Dialogs.GenericDialog(dc))
				{
					dialog.ShowDialog();
				}
			}
		}

		private void btn_progressTask_Click(object sender, EventArgs e)
		{
			var pt = new ThreadSamples.SimpleWait();
			using (var pd = new Dialogs.ProgressDialog(pt))
			{
				pd.ShowDialog();
			}
		}

		private void btn_blockingTask_Click(object sender, EventArgs e)
		{
			ToggleButtons();
			BlockUI();
			ToggleButtons();
		}

		private void BlockUI()
		{
			for (int i = 0; i < 20; i++)
			{
				System.Threading.Thread.Sleep(1000);
			}
		}

		private void ToggleButtons()
		{
			foreach (var c in pnl_container.Controls)
			{
				var btn = c as Button;
				if (btn == null)
				{
					continue;
				}

				btn.Enabled = !btn.Enabled;
			}
		}
	}
}
