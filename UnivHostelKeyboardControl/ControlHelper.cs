using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnivHostelKeyboardControl
{
	public static class ControlHelper
	{
		public static Control FindFocusedComponent(this Control control)
		{
			if (!control.Focused)
			{
				return null;
			}
			if (control.Controls.Count > 0)
			{
				foreach (Control child in control.Controls)
				{
					if (child.Focused)
					{
						return FindFocusedComponent(child);
					}
				}
			}
			return control;
		}
	}
}
