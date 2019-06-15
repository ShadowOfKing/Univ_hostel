using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace univ_hostel.Forms
{
	public class BaseForm : Form
	{
		protected Form _baseForm;
		protected BaseForm _parent;
		protected bool correctClose;

		public BaseForm() : base()
		{

		}
		public BaseForm(BaseForm parentForm) : base()
		{
			_parent = parentForm;
			StartPosition = FormStartPosition.Manual;
			Left = parentForm.Left;
			Top = parentForm.Top;
			Width = parentForm.Width;
			Height = parentForm.Height;
			_baseForm = parentForm._baseForm;
		}
		protected void Init(BaseForm parentForm)
		{
			Width = parentForm.Width;
			Height = parentForm.Height;
		}


		public BaseForm(Form baseForm) : base()
		{
			StartPosition = FormStartPosition.Manual;
			_baseForm = baseForm;
		}
		protected void SetSize(int width, int height)
		{
			Width = width;
			Height = height;
		}

		protected void ToHome()
		{
			new Home(this).Show();
			CorrectClose();
		}

		protected void CorrectClose()
		{
			correctClose = true;
			Close();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			if (!correctClose)
			{
				_baseForm.Close();
			}
		}
	}
}
