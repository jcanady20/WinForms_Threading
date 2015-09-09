using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace WinForms_Threading.Dialogs.DialogControls
{
	/// <summary>
	/// http://www.codeproject.com/Articles/99143/BackgroundWorker-Class-Sample-for-Beginners
	/// </summary>
	public partial class WorkerControl : UserControl, Common.IGenericDialogControl
	{
		private TimeSpan m_second = new TimeSpan(0, 0, 1);
		private BackgroundWorker m_worker;
		public WorkerControl()
		{
			InitializeComponent();
			m_worker = new BackgroundWorker();
			//	Wire Events for BackGround Worker
			m_worker.DoWork += (s, e) => {
				for(int i = 0; i < 100; i++)
				{
					Thread.Sleep(m_second);
					m_worker.ReportProgress(i);
					if(m_worker.CancellationPending)
					{
						e.Cancel = true;
						m_worker.ReportProgress(0);
						return;
					}
				}
			};
			m_worker.ProgressChanged += (s, e) => {
				pb_progress.Value = e.ProgressPercentage;
			};
			m_worker.RunWorkerCompleted += (s, e) => {
				if(e.Cancelled)
				{
					//	Report the task was Canceled
				}
			};
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

		private void btn_cancelWorker_Click(object sender, EventArgs e)
		{
			m_worker.IsBusy)
			{
				m_worker.CancelAsync();
			}
		}
	}
}
