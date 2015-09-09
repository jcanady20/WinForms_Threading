using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_Threading.Dialogs
{
	public partial class GenericDialog : BaseDialog
	{
		private Common.IGenericDialogControl m_dialogControl;

		public GenericDialog()
		{
			InitializeComponent();
		}

		public GenericDialog(Common.IGenericDialogControl dialogControl)
		{
			this.DialogControl = dialogControl;
		}

		public Common.IGenericDialogControl DialogControl
		{
			get
			{
				return m_dialogControl;
			}
			set
			{
				this.m_dialogControl = value;
				LoadControl(value);
			}
		}

		private void LoadControl(Common.IGenericDialogControl control)
		{
			var c = control as Control;
			if(c == null)
			{
				return;
			}
			if(this.pnl_controlContainer.Controls.ContainsKey(c.Name))
			{
				return;
			}

			this.FitToScale(c.Size);
			this.Text = control.Caption;
			this.btn_performTask.Enabled = control.EnableTaskButton;
			this.btn_performTask.Enabled = control.EnableTaskButton;
			if(control.EnableTaskButton)
			{
				this.btn_performTask.Text = control.TaskButtonText;
			}
			if(control.IsSizeable)
			{
				this.FormBorderStyle = FormBorderStyle.Sizable;
			}

			this.pnl_controlContainer.Controls.Add(c);
			c.Dock = DockStyle.Fill;
		}

		private void FitToScale(Size s)
		{
			int h = s.Height - pnl_controlContainer.Size.Height + 50;
			int w = s.Width - pnl_controlContainer.Size.Width;
			this.Height += h;
			this.Width += w;
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogControl.CloseAction(); ;
			this.DialogResult = DialogResult.Cancel;
		}

		private void btn_accept_Click(object sender, EventArgs e)
		{
			if(this.DialogControl.AcceptAction())
			{
				this.DialogResult = DialogResult.OK;
			}
		}

		private void btn_performTask_Click(object sender, EventArgs e)
		{
			this.DialogControl.TaskAction();
		}
	}
}
