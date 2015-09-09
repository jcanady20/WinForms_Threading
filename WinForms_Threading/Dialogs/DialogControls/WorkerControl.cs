using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Threading.Dialogs.DialogControls
{
	public partial class WorkerControl : UserControl, Common.IGenericDialogControl
	{
		private BackgroundWorker m_worker;
		public WorkerControl()
		{
			InitializeComponent();
			m_worker = new BackgroundWorker();
			//	Wire Events for BackGround Worker
			m_worker.DoWork += (s, e) => { };
			m_worker.ProgressChanged += (s, e) => { };
			m_worker.RunWorkerCompleted += (s, e) => { };
			m_worker.WorkerReportsProgress = true;
			m_worker.WorkerSupportsCancellation = true;
        }

		public string Caption
		{
			get
			{
				return "Back Ground Worker Sample";
			}
		}

		public bool EnableTaskButton
		{
			get
			{
				return true;
			}
		}

		public bool IsSizeable
		{
			get
			{
				return true;
			}
		}

		public string TaskButtonText
		{
			get
			{
				return "Start Worker";
			}
		}

		public bool AcceptAction()
		{
			return true;
		}

		public void CloseAction()
		{
			return;
		}

		public void TaskAction()
		{
			m_worker.RunWorkerAsync();

		}
	}
}
