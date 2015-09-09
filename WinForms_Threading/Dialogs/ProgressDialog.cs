using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Threading.Dialogs
{
	public partial class ProgressDialog : BaseDialog
	{
		private Common.ITaskOperation m_taskObject;

		public ProgressDialog(Common.ITaskOperation taskObject)
		{
			InitializeComponent();

			this.m_taskObject = taskObject;

			this.EnableCancelButton(taskObject.CanStopTask);
			this.EnableProgressBar(taskObject.CanTrackProgress);

		}

		private void BindEventHandlers()
		{
			m_taskObject.OnNumberOfTasksChanged += taskObject_OnNumberOfTasksChanged;
			m_taskObject.OnTaskStarted += taskObject_OnTaskStarted;
			m_taskObject.OnTaskStepCompleted += M_taskObject_OnTaskStepCompleted;
			m_taskObject.OnTaskCompleted += taskObject_OnTaskCompleted;
		}
		
		private void UnBindEventHandlers()
		{
			m_taskObject.OnNumberOfTasksChanged -= taskObject_OnNumberOfTasksChanged;
			m_taskObject.OnTaskStarted -= taskObject_OnTaskStarted;
			m_taskObject.OnTaskStepCompleted -= M_taskObject_OnTaskStepCompleted;
			m_taskObject.OnTaskCompleted -= taskObject_OnTaskCompleted;
		}

		private void M_taskObject_OnTaskStepCompleted(object sender, Common.TaskCompletedEventArgs e)
		{
			throw new NotImplementedException();
		}

		private void taskObject_OnTaskCompleted(object sender, Common.TaskCompletedEventArgs e)
		{
			throw new NotImplementedException();
		}

		private void taskObject_OnTaskStarted(object sender, Common.TaskStepStartedEventArgs e)
		{
			throw new NotImplementedException();
		}

		private void taskObject_OnNumberOfTasksChanged(object sender, Common.NumberOfTasksEventargs e)
		{
			
		}

		private void EnableProgressBar(bool canTrackProgress)
		{
			this.tskbr_Progress.Enabled = canTrackProgress;
			this.tskbr_Progress.Visible = canTrackProgress;
		}

		private void EnableCancelButton(bool canStopTask)
		{
			this.btn_CancelTask.Enabled = canStopTask;
			this.btn_CancelTask.Visible = canStopTask;
		}
		
		private void SetTaskStepLabel(string taskName)
		{
			this.lbl_taskStepName.Text = taskName;
		}

		private void SetProgressBar(int numberofTasks)
		{
			this.tskbr_Progress.Minimum = 0;
			this.tskbr_Progress.Maximum = numberofTasks;
			this.tskbr_Progress.Value = 0;
		}

		private void IncrementProgressBar()
		{
			this.tskbr_Progress.Increment(1);
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			if(m_taskObject != null)
			{
				m_taskObject.StartTask();
			}
		}

		private void btn_CancelTask_Click(object sender, EventArgs e)
		{
			if(m_taskObject != null && m_taskObject.CanStopTask)
			{
				m_taskObject.StopTask();
			}
		}
	}
}
