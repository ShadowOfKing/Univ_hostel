using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnivHostelKeyboardControl
{
	class KeyboardButton : Button
	{
		private void init(string rus, string eng = null, KeyboardButtonType type = KeyboardButtonType.Letter)
		{
			Type = type;
			Rus = rus;
			Eng = eng;
			Text = Rus;
		}
		public KeyboardButton(string rus, KeyboardButtonType type = KeyboardButtonType.Letter)
		{
			init(rus, null, type);
		}
		public KeyboardButton(string rus, string eng, KeyboardButtonType type = KeyboardButtonType.Letter)
		{
			init(rus, eng, type);
		}
		public KeyboardButton(string rus, string eng, KeyboardButtonType type, int x, int y, int width, int height)
		{
			init(rus, eng, type);
			Left = x;
			Top = y;
			Width = width;
			Height = height;
		}
		public KeyboardButtonType Type { get; set; }
		public string Rus { get; set; }
		private string _eng { get; set; }
		public string Eng
		{
			get
			{
				return _eng ?? Rus;
			}
			set
			{
				_eng = value;
			}
		}
		public int Row { get; set; }
		public int Col { get; set; }

	}

}
