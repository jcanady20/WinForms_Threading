using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Threading.Common
{
	public interface IGenericDialogControl
	{
		bool EnableTaskButton { get; }
		string TaskButtonText { get; }
		bool IsSizeable { get; }
		string Caption { get; }
		void TaskAction();
		void CloseAction();
		bool AcceptAction();
	}
}
