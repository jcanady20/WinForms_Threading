using System;

namespace WinForms_Threading.Common
{
	public interface ITaskOperation
	{
		bool CanStopTask { get; }
		bool CanTrackProgress { get; }
		void StartTask();
		void StopTask();

		event EventHandler<NumberOfTasksEventargs> OnNumberOfTasksChanged;
		event EventHandler<TaskStepStartedEventArgs> OnTaskStarted;
		event EventHandler<TaskCompletedEventArgs> OnTaskStepCompleted;
		event EventHandler<TaskCompletedEventArgs> OnTaskCompleted;
	}

	public class TaskOperationEventArgs : EventArgs
	{
		private string m_taskName;
		public TaskOperationEventArgs(string taskName)
		{
			m_taskName = taskName;
		}

		public string TaskName
		{
			get
			{
				return m_taskName;
			}
			set
			{
				m_taskName = value;
			}
		}
	}

	public class NumberOfTasksEventargs : TaskOperationEventArgs
	{
		private int m_numberOfTasks;
		public NumberOfTasksEventargs(string taskName, int numberOfTasks) : base(taskName)
		{
			m_numberOfTasks = numberOfTasks;
		}

		public int NumberOfTasks
		{
			get
			{
				return m_numberOfTasks;
			}
			set
			{
				m_numberOfTasks = value;
			}
		}
	}

	public class TaskStepStartedEventArgs : TaskOperationEventArgs
	{
		public TaskStepStartedEventArgs(string taskName) : base(taskName)
		{ }
	}

	public class TaskCompletedEventArgs : TaskOperationEventArgs
	{
		private Exception m_exception;
		public TaskCompletedEventArgs(string taskName, Exception exception) : base(taskName)
		{
			m_exception = exception;
		}
		public Exception Exception
		{
			get
			{
				return m_exception;
			}
			set
			{
				m_exception = value;
			}
		}

		public bool HasErrors
		{
			get
			{
				return this.m_exception == null;
			}
		}
	}
}
