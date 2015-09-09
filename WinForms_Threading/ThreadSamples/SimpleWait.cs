using System;
using System.Threading;
using WinForms_Threading.Common;

namespace WinForms_Threading.ThreadSamples
{
	public class SimpleWait : Common.ITaskOperation
	{
		private readonly string m_taskName = "SimpleWaits";
		private readonly int m_maxCount = 100000;
		private readonly TimeSpan m_oneSecond = new TimeSpan(0, 0, 1);
		private bool m_cancel;
		private Thread m_worker;

		public SimpleWait()
		{	}

		public bool CanStopTask
		{
			get
			{
				return true;
			}
		}

		public bool CanTrackProgress
		{
			get
			{
				return true;
			}
		}

		public event EventHandler<NumberOfTasksEventargs> OnNumberOfTasksChanged;
		public event EventHandler<TaskCompletedEventArgs> OnTaskCompleted;
		public event EventHandler<TaskCompletedEventArgs> OnTaskStepCompleted;
		public event EventHandler<TaskStepStartedEventArgs> OnTaskStarted;

		public void StartTask()
		{
			m_cancel = true;
			if(m_worker == null)
			{
				m_worker = new Thread(new ThreadStart(DoWork));
				m_worker.Start();
			}
		}

		public void StopTask()
		{
			m_cancel = true;
		}

		private void DoWork()
		{
			ReportOnTaskStarted(m_taskName);
			ReportOnNumberOfTasksChanged(m_taskName, m_maxCount);
			var x = 0;
			while(x < m_maxCount)
			{
				if(m_cancel)
				{
					break;
				}
				x += 1;
				Thread.Sleep(m_oneSecond);
			}
			ReportOnTaskCompleted(m_taskName);
		}

		private void ReportOnTaskStepCompleted(string taskStepName)
		{
			var onChange = OnTaskStepCompleted;
			if (onChange != null)
			{
				onChange(this, new TaskCompletedEventArgs(taskStepName, null));
			}
		}

		private void ReportOnNumberOfTasksChanged(string taskName, int numberOfTasks)
		{
			var onChange = OnNumberOfTasksChanged;
			if(onChange != null)
			{
				onChange(this, new NumberOfTasksEventargs(taskName, numberOfTasks))
			}
		}

		private void ReportOnTaskStarted(string taskName)
		{
			var onChange = OnTaskStarted;
			if(onChange != null)
			{
				onChange(this, new TaskStepStartedEventArgs(taskName));
			}
		}

		private void ReportOnTaskCompleted(string taskName)
		{
			var onchanged = OnTaskCompleted;
			if(onchanged != null)
			{
				onchanged(this, new TaskCompletedEventArgs(taskName, null));
			}
		}
    }
}
